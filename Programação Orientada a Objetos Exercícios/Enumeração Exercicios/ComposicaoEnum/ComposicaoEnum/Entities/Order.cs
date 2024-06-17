using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComposicaoEnum.Entities.Enum;
using System.Collections.Generic;
using System.Globalization;

namespace ComposicaoEnum.Entities
{
    internal class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status{ get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void AddItem (OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem (OrderItem item) 
        {  
            Items.Remove(item); 
        }

        public double TotalOrdem()
        {
            double total = 0.0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotalItem();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + TotalOrdem().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
