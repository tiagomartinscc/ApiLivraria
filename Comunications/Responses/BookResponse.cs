﻿namespace ApiLivraria.Comunications.Responses;

public class BookResponse
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public EnumCategory Category { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }
}
