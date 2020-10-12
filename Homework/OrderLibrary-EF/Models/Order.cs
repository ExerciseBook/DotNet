using System;

namespace OrderLibrary_EF.Models
{
    public class Order
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 商品名称
        /// TODO 讲道理这里应该会是一个更复杂的结构体，但是👴懒得写了
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 客户名称
        /// TODO 讲道理这里是一个类，但是👴懒得写了
        /// </summary>
        public string Custom { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public Decimal Balance { get; set; }

    }
}