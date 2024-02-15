using DeliveryWinForms.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryWinForms.Services;

/// <summary>
/// Отгрузка CRUD
/// </summary>
public class ShipmentService
{
    /// <summary>
    /// Контекст подключения
    /// </summary>
    private readonly ModelContext _context;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    public ShipmentService(ModelContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Создание отгрузки
    /// </summary>
    /// <param name="newShipment"></param>
    /// <returns></returns>
    public Shipment Create(Shipment newShipment)
    {
        _context.Shipments.Add(newShipment);
        _context.SaveChanges();

        return newShipment;
    }

    /// <summary>
    /// Получить все отгрузки
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Shipment> GetAll()
    {
        return _context.Shipments
            .AsNoTracking()
            .ToList();
    }

    /// <summary>
    /// Получить отгрузку
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Shipment? GetById(int id)
    {
        return _context.Shipments
            .AsNoTracking()
            .SingleOrDefault(p => p.OrderId == id);
    }

    /// <summary>
    /// Обновить отгрузку
    /// </summary>
    /// <param name="id"></param>
    /// <param name="newShipment"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public void UpdateOrder(int id, Shipment newShipment)
    {
        var shipmentToUpdate = _context.Shipments.Find(id);

        if (shipmentToUpdate is null)
        {
            throw new InvalidOperationException("Отгрузка не найдена.");
        }

        _context.Shipments.Update(newShipment);
        _context.SaveChanges();
    }

    /// <summary>
    /// Удалить отгрузку
    /// </summary>
    /// <param name="id"></param>
    public void DeleteById(int id)
    {
        var shipmentToDelete = _context.Shipments.Find(id);

        if (shipmentToDelete is not null)
        {
            _context.Shipments.Remove(shipmentToDelete);
            _context.SaveChanges();
        }
    }
}
