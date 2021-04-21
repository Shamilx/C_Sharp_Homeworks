using System;
using System.Collections.Generic;

namespace Market
{
    enum ClientType
    {
        BEGINNER,
        NORMAL,
        IMPORTANT,
    }

    enum PayType
    {
        CASH,
        CREDIT,
    }

    struct Article
    {
        double product_price;
        string product_code;
        string product_name;
        
        Article(double price,string code,string name)
        {
            product_price = price;
            product_code = code;
            product_name = name;
        }

    }

    struct Client
    {
        string client_code;
        int number_of_orders;
        int total_orders;
        
        ClientType Importance;

        Client(string code)
        {
            client_code = code;
            number_of_orders = 0;
            total_orders = 0;
            Importance = ClientType.BEGINNER;
        }
    }

    struct Request
    {
        string order_code;
        string client_order_date;
        double ordered_price;
        PayType PayWith;
        List<Article> ordered_products;

    }
}