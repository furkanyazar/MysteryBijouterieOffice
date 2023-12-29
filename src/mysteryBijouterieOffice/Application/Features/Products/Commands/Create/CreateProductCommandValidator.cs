using FluentValidation;

namespace Application.Features.Products.Commands.Create;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.CategoryId).GreaterThan(0).When(p => p.CategoryId != null);
        RuleFor(p => p.Name).NotEmpty().MinimumLength(2);
        RuleFor(p => p.BarcodeNumber).NotEmpty().Length(13).Must(StartsWith).Must(Number);
        RuleFor(p => p.PurchasePrice).NotNull();
        RuleFor(p => p.ModelNumber).NotEmpty().Length(8).Must(StartsWith).Must(Number);
        RuleForEach(p => p.ProductMaterials).SetValidator(new CreateProductCommandProductMaterialListItemDtoValidator());
        RuleFor(p => p.UnitsInStock).NotNull();
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
