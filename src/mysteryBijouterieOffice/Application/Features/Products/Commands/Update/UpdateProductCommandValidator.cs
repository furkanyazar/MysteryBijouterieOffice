﻿using FluentValidation;

namespace Application.Features.Products.Commands.Update;

public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(p => p.Id).NotEmpty();
        RuleFor(p => p.CategoryId).GreaterThan(0).When(p => p.CategoryId != null);
        RuleFor(p => p.Name).NotEmpty().MinimumLength(2);
        RuleFor(p => p.BarcodeNumber).NotEmpty().Length(13).Must(StartsWith).Must(Number);
        RuleFor(p => p.PurchasePrice).NotNull();
        RuleFor(p => p.ModelNumber).NotEmpty().Length(8).Must(StartsWith).Must(Number);
        RuleForEach(p => p.ProductMaterials).SetValidator(new UpdateProductCommandProductMaterialListItemDtoValidator());
    }

    private bool StartsWith(string barcodeNumber) => barcodeNumber.StartsWith("MB-");

    private bool Number(string barcodeNumber)
    {
        string[] barcodeSplit = barcodeNumber.Split('-');
        if (barcodeSplit.Length != 2)
            return false;

        foreach (var barcode in barcodeSplit[1])
            if (!char.IsDigit(barcode))
                return false;

        return true;
    }
}
