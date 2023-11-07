﻿using Core.Persistence.Repositories;

namespace Domain.Entities;

public class CategoryPartner : Entity<int>
{
    public int CategoryId { get; set; }
    public int PartnerId { get; set; }
    public decimal CommissionRate { get; set; }

    public virtual Category Category { get; set; } = null!;
    public virtual Partner Partner { get; set; } = null!;

    public CategoryPartner() { }

    public CategoryPartner(int categoryId, int partnerId, decimal commissionRate)
    {
        CategoryId = categoryId;
        PartnerId = partnerId;
        CommissionRate = commissionRate;
    }

    public CategoryPartner(int id, int categoryId, int partnerId, decimal commissionRate)
        : base(id)
    {
        CategoryId = categoryId;
        PartnerId = partnerId;
        CommissionRate = commissionRate;
    }
}
