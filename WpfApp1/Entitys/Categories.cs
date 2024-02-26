using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entitys
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
/*
  <StackPanel Orientation="Horizontal" Background="Red">
            <StackPanel>
                <Label Content="Антивор" FontSize="32"  FontWeight="Bold" HorizontalAlignment="Center" Margin="10,10,0,10"/>
            </StackPanel>
            <DockPanel Margin="400 0 0 0">
                <Button Content="Вернуться в магазин" BorderBrush="Transparent" Background="Transparent" FontSize="24" Height="35" VerticalAlignment="Center" Name="back" Click="back_Click"/>
            </DockPanel>
        </StackPanel>

        <StackPanel Orientation="Horizontal" Margin="20 20 0 0">
            <StackPanel>
                <Image Width="200" Height="200"/>
            </StackPanel>
            <StackPanel Margin="20 0 0 0">
                <TextBlock Text="Название товара"/>
            </StackPanel>
            <StackPanel Margin="20 0 0 0">
                <TextBox Width="200"/>
            </StackPanel>
        </StackPanel>
 */