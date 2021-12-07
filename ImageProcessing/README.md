# Обработка изображений

Работа с изображениями в C# обычно подразумевает использование стандартной библиотеки System.Drawing; в частности, класса Bitmap (наследник класса Image). Этот класс предоставляет возможность обращаться к пикселям изображения через методы GetPixel и SetPixel. Однако обращение к этим методам требует от класса обращения к его внутренней памяти, что замедляет процесс обработки; кроме того, класс становится недоступным до окончания процедуры, из-за чего невозможно распараллелить задачу обработки.

Чтобы избежать проблем, можно обратиться к пикселям изображения напрямую, получив указатель из метода LockBits. Затем, используя быстрое копирование (System.Runtime.InteropServices.Marshal.Copy), перенести данные в обычный массив byte[], каждый элемент которого можно обрабатывать отдельно. В обратную сторону производятся те же операции; указатель на данные сохраняется в класс Bitmap методом UnlockBits.

Пример кода - перевод изображения из цветного (24 бита на пиксель) в чёрно-белое:

```
int width = Source.Width, height = Source.Height;
int depth = Image.GetPixelFormatSize(Source.PixelFormat) / 8;
var pixeldata = Source.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, Source.PixelFormat);
int stride = pixeldata.Stride;

// Копирование данных из источника:
var orig = new byte[height * stride];
Marshal.Copy(pixeldata.Scan0, orig, 0, orig.Length);
Source.UnlockBits(pixeldata);

var res = new byte[height * stride];
for (int j = 0; j < height; j++)
{
	for (int i = 0; i < width; i++) 
	{
		// Y = 0.114 * B + 0.587 * G + 0.299 * R
		byte v = (byte)(0.114 * orig[i * depth + j * stride] + 0.587 * orig[i * depth + j * stride + 1] + 0.299 * orig[i * depth + j * stride + 2]);
		res[i * depth + j * stride] = res[i * depth + j * stride + 1] = res[i * depth + j * stride + 2] = v;
	}
}

// Сохранение данных:
var Result = new Bitmap(width, height, format);
var resultdata = Result.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, format);
Marshal.Copy(res, 0, resultdata.Scan0, res.Length);
Result.UnlockBits(resultdata);
```