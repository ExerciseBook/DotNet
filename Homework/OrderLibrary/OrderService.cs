using System;
using System.Collections;
using System.Collections.Generic;
using UI.Helpers;

namespace OrderLibrary
{
    public class OrderService
    {
        /// <summary>
        /// 互斥锁
        /// TODO 讲道理这里应该要用数据库事务实现的，我又懒了。
        /// </summary>
        private static MutexFlag _mutex = new MutexFlag();

        /// <summary>
        /// 订单信息
        /// TODO 讲道理这里应该要丢数据库的，我又懒了。
        /// </summary>
        private static List<Order> _orders = new List<Order>();

        /// <summary>
        /// 
        /// </summary>
        private static long OrderIdSequence;

        public static long GetNext()
        {
            if (!_mutex.Occupied())
            {
                // TODO 讲道理这里应该自定义一个异常类的，但是我又懒得写了
                throw new Exception();
            }
            _mutex.ReleaseOccupation();
            return OrderIdSequence++;
        }
        
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="NewOrder"></param>
        public void Add(Order NewOrder)
        {
            if (!_mutex.Occupied())
            {
                // TODO 讲道理这里应该自定义一个异常类的，但是我又懒得写了
                throw new Exception();
            }

            _orders.Add(NewOrder);

            _mutex.ReleaseOccupation();

        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <returns></returns>
        public OrderQueryBuilder Retrieve()
        {
            // TODO 思考
            return new OrderQueryBuilder(_orders);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Item"></param>
        public void Delete(Order Item)
        {
            if (!_mutex.Occupied())
            {
                // TODO 讲道理这里应该自定义一个异常类的，但是我又懒得写了
                throw new Exception();
            }

            _orders.Remove(Item);

            _mutex.ReleaseOccupation();

        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ItemID"></param>
        public void Delete(long ItemID)
        {
            if (!_mutex.Occupied())
            {
                // TODO 讲道理这里应该自定义一个异常类的，但是我又懒得写了
                throw new Exception();
            }

            foreach (var i in (IEnumerable) Retrieve().Where("Id", "" + ItemID).Get())
            {
                try
                {
                    Delete((Order)i);
                }
                catch (Exception e)
                {
                    _mutex.ReleaseOccupation();
                    throw;
                }
            }

            _mutex.ReleaseOccupation();

        }
    }
}
