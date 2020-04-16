﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Dao;

namespace TruYumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItemDaoCollectionTest menuItemDaoCollectionTest = new MenuItemDaoCollectionTest();
            menuItemDaoCollectionTest.TestGetMenuItemListAdmin();
            menuItemDaoCollectionTest.TestGetMenuItemListCustomer();
            menuItemDaoCollectionTest.TestModifyMenuItem();

            CartDaoCollectionTest cartDaoCollectionTest = new CartDaoCollectionTest();
            cartDaoCollectionTest.TestAddCartItem();
            cartDaoCollectionTest.TestRemoveCartItem();

            MenuItemDaoSqlTest menuItemDaoSqlTest = new MenuItemDaoSqlTest();
            menuItemDaoSqlTest.TestGetMenuItemListAdmin();
            menuItemDaoSqlTest.TestGetMenuItemListCustomer();
            menuItemDaoSqlTest.TestEditMenuItem();
            menuItemDaoSqlTest.TestGetMenuItem();

            CartDaoSqlTest cartDaoSqlTest = new CartDaoSqlTest();
            cartDaoSqlTest.TestAddMenuItem();
            cartDaoSqlTest.TestGetMenuItems();
            cartDaoSqlTest.TestRemoveMenuItem();

            Console.ReadKey();
        }
    }
}
