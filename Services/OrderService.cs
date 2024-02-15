using DeliveryWinForms.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryWinForms.Services;

/// <summary>
/// Заказ CRUD
/// </summary>
public class OrderService
{
    /// <summary>
    /// Контекст подключения
    /// </summary>
    private readonly ModelContext _context;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    public OrderService(ModelContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Создание заказа
    /// </summary>
    /// <param name="newOrder"></param>
    /// <returns></returns>
    public Order Create(Order newOrder)
    {
        _context.Orders.Add(newOrder);
        _context.SaveChanges();

        return newOrder;
    }

    /// <summary>
    /// Получить все заказы
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Order> GetAll()
    {
        return _context.Orders
            .AsNoTracking()
            .ToList();
    }

    /// <summary>
    /// Получить заказ
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Order? GetById(int id)
    {
        return _context.Orders
            .AsNoTracking()
            .SingleOrDefault(p => p.OrderId == id);
    }

    /// <summary>
    /// Обновить заказ
    /// </summary>
    /// <param name="id"></param>
    /// <param name="newOrder"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public void UpdateOrder(int id, Order newOrder)
    {
        var orderToUpdate = _context.Products.Find(id);

        if (orderToUpdate is null)
        {
            throw new InvalidOperationException("Заказ не найден.");
        }

        _context.Orders.Update(newOrder);
        _context.SaveChanges();
    }

    /// <summary>
    /// Удалить заказ
    /// </summary>
    /// <param name="id"></param>
    public void DeleteById(int id)
    {
        var orderToDelete = _context.Orders.Find(id);

        if (orderToDelete is not null)
        {
            _context.Orders.Remove(orderToDelete);
            _context.SaveChanges();
        }
    }
}
