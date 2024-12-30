﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharpEgitimKampi301.BusinessLayer.Abstract;
using CharpEgitimKampi301.DataAccessLayer.Abstract;
using CharpEgitimKampi301.EntityLayer.Concrete;

namespace CharpEgitimKampi301.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TDelete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public List<Order> TGetAll()
        {
            return _orderDal.GetAll();
        }

        public Order TGetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public void TInsert(Order entity)
        {
            _orderDal.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
