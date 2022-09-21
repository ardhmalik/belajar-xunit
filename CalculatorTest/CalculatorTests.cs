using Calculator;

namespace CalculatorTest
{
    public class CalculatorTests
    {
        [Fact]
        public void Kurang_Harus_Mengembalikan_HasilPengurangan()
        {
            // Arrange
            int angka1 = 50;
            int angka2 = 30;
            int hasilYangDiinginkan = 20;

            // Act
            int hasilPengurangan = BelajarMenghitung.Kurang(angka1, angka2);

            // Assert
            Assert.Equal(hasilYangDiinginkan, hasilPengurangan);
        }

        [Theory]
        [InlineData(10, 20, 30)]
        [InlineData(25, 20, 45)]
        public void Tambah_Harus_Mengembalikan_HasilPenambahan(int angka1, int angka2, int ekspektasi)
        {
            // Assert
            Assert.Equal(ekspektasi, BelajarMenghitung.Tambah(angka1, angka2));
        }
    }
}