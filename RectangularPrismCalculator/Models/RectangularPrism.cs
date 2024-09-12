/*
    Name: Luke Hamann
    Date: 2024-09-12
    Purpose: The RectangularPrism class represents a rectangular prism. The
             Length, Width, and Height properties are used to get and set the
             dimensions of the prism, protected by required and range
             attributes. The Volume, SurfaceArea, and Diagonal properties are
             read-only and calculate their respective values based on the
             dimensions.
*/
using System.ComponentModel.DataAnnotations;

namespace RectangularPrismCalculator.Models
{
    public class RectangularPrism
    {
        [Required(ErrorMessage = "Please enter a length.")]
        [Range(0.1, 1_000_000, ErrorMessage =
            "Length must be between 0.1 and 1,000,000.")]
        public double? Length { get; set; }

        [Required(ErrorMessage = "Please enter a width.")]
        [Range(0.1, 1_000_000, ErrorMessage =
            "Width must be between 0.1 and 1,000,000.")]
        public double? Width { get; set; }

        [Required(ErrorMessage = "Please enter a height.")]
        [Range(0.1, 1_000_000, ErrorMessage =
            "Height must be between 0.1 and 1,000,000.")]
        public double? Height { get; set; }

        public double? Volume
        {
            get
            {
                return Length * Width * Height;
            }
        }

        public double? SurfaceArea
        {
            get
            {
                return 2 * (Length * Width + Length * Height + Width * Height);
            }
        }

        public double? Diagonal
        {
            get
            {
                double l = (Length.HasValue ? Length.Value : 0);
                double w = (Width.HasValue ? Width.Value : 0);
                double h = (Height.HasValue ? Height.Value : 0);

                return Math.Sqrt(Math.Pow(l, 2) + Math.Pow(w, 2) + Math.Pow(h, 2));
            }
        }
    }
}
