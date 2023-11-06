using FluentValidation;

namespace Application.Features.Products.Commands.Update;

public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(p => p.Id).NotEmpty();
        RuleFor(p => p.Name).NotEmpty().MinimumLength(2);
        RuleFor(p => p.BarcodeNumber).Length(13).Must(StartsWith).Must(Number);
        RuleFor(p => p.UnitPrice).NotNull();
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
