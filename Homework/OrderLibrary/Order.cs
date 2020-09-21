using System;

namespace OrderLibrary
{
    public class Order
    {
        /// <summary>
        /// 订单号
        /// </summary>
        long Id { get; }

        /// <summary>
        /// 商品名称
        /// TODO 讲道理这里应该会是一个更复杂的结构体，但是👴懒得写了
        /// </summary>
        public string ItemName;

        /// <summary>
        /// 客户名称
        /// TODO 讲道理这里是一个类，但是👴懒得写了
        /// </summary>
        public string Custom;

        /// <summary>
        /// 金额
        /// </summary>
        public Decimal Balance;

        public Order(String itemName, String custom, Decimal balance)
        {
            this.Id = OrderService.GetNext();
            this.ItemName = itemName;
            this.Custom = custom;
            this.Balance = balance;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Order)) return false;
            return this.Id == ((Order) obj).Id;
        }

    }
}