void Sum(int x, int y, out int result)
{
    result = x + y;
}
 
int number;
 
Sum(10, 15, out number);
 
Console.WriteLine(number);


// void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
// {
//     rectArea = width * height;       // площадь прямоугольника - произведение ширины на высоту
//     rectPerimetr = (width + height) * 2; // периметр прямоугольника - сумма длин всех сторон  
// }
 
// int area;
// int perimetr;
 
// GetRectangleData(10, 20, out area, out perimetr);
 
// Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
// Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60




// void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
// {
//     rectArea = width * height;  
//     rectPerimetr = (width + height) * 2; 
// }
 
// GetRectangleData(10, 20, out int area, out int perimetr);
 
// Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
// Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60