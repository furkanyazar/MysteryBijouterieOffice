﻿using FluentValidation;

namespace Application.Features.Products.Commands.Create;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.CategoryId).NotEmpty();
        RuleFor(p => p.Name).NotEmpty().MinimumLength(2);
        RuleFor(p => p.BarcodeNumber).Length(13).Must(StartsWith).Must(Number).When(p => !string.IsNullOrEmpty(p.BarcodeNumber));
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