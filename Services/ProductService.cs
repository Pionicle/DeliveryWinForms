﻿using DeliveryWinForms.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryWinForms.Services;

/// <summary>
/// Товар CRUD
/// </summary>
public class ProductService
{
    /// <summary>
    /// Контекст подключения
    /// </summary>
    private readonly ModelContext _context;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    public ProductService(ModelContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Создание товара
    /// </summary>
    /// <param name="newProduct"></param>
    /// <returns></returns>
    public Product Create(Product newProduct)
    {
        _context.Products.Add(newProduct);
        _context.SaveChanges();

        return newProduct;
    }

    /// <summary>
    /// Получить все товары
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Product> GetAll()
    {
        return _context.Products
            .AsNoTracking()
            .ToList();
    }

    /// <summary>
    /// Получить товар
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Product? GetById(int id)
    {
        return _context.Products
            .AsNoTracking()
            .SingleOrDefault(p => p.ProductId == id);
    }

    /// <summary>
    /// Обновить товар
    /// </summary>
    /// <param name="id"></param>
    /// <param name="newProduct"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public void UpdateName(int id, Product newProduct)
    {
        var productToUpdate = _context.Products.Find(id);

        if (productToUpdate is null)
        {
            throw new InvalidOperationException("Товар не найден.");
        }

        _context.Products.Update(newProduct);

        _context.SaveChanges();
    }

    /// <summary>
    /// Удалить товар
    /// </summary>
    /// <param name="id"></param>
    public void DeleteById(int id)
    {
        var productToDelete = _context.Products.Find(id);

        if (productToDelete is not null)
        {
            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
        }
    }
}
