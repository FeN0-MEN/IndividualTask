using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IndividualTask
{
    

    public partial class Form1 : Form
    {
        private int houseWidth;  // ширина дома
        private int houseHeight; // высота дома
        private int roofHeight;  // высота крыши
        private string roofType; // тип крыши: "Треугольник", "Трапеция", "Прямоугольник"
        private Color houseColor = Color.Black;  // Цвет основания дома
        private Color roofColor = Color.Black;    // Цвет крыши


        // Списки дверей и окон
        private List<Door> doors = new List<Door>();
        private List<Window> windows = new List<Window>();
        private DashStyle currentLineStyleHouse = DashStyle.Solid;
        private DashStyle currentLineStyleRoof = DashStyle.Solid;

        private Random random; // Добавление рандома для случайного появления окон и дверей
        private bool isDragging = false; // Флаг для перемещения окон
        private Window selectedWindow; // Выбор окна
        private DashStyle currentLineStyleWindow = DashStyle.Solid;

        private bool isDoorDragging = false; // Флаг для перемещения дверей
        private Door selectedDoor; // Выбор двери
        private DashStyle currentLineStyleDoor = DashStyle.Solid;

        private ColorDialog colorDialog = new ColorDialog();
        private ColorDialog doorColorDialog = new ColorDialog();

        public Form1()
        {
            // Регистрация обработчиков событий 
            InitializeComponent(); 
            FillComboBox();
            FillComboBoxElements(comboBoxLineStyleFoundation);
            FillComboBoxElements(comboBoxLineStyleRoof);
            FillComboBoxElements(comboBoxLineStyleDoor);
            FillComboBoxElements(comboBoxLineStyleWindow);
            buttonChooseHouseColor.Click += buttonChooseHouseColor_Click;
            buttonChooseRoofColor.Click += buttonChooseRoofColor_Click;
            // Для вызова Paint при изменении размера формы.
            this.ResizeRedraw = true;

            // Инициализации объекта random
            random = new Random();
            pictureBox.MouseClick += pictureBox_MouseClick; // Регистрация обработчика события MouseClick
            AddDoor.Click += AddDoor_Click; // Обработчик события Click для кнопки добавления двери
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxLineStyleDoor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получите выбранный тип линии из ComboBox
            string selectedLineStyle = comboBoxLineStyleDoor.SelectedItem.ToString();

            // Установите текущий тип линии в зависимости от выбранного значения
            switch (selectedLineStyle)
            {
                case "Прямая":
                    currentLineStyleDoor = DashStyle.Solid;
                    break;
                case "Пунктир":
                    currentLineStyleDoor = DashStyle.Dash;
                    break;
                case "Точка-тире":
                    currentLineStyleDoor = DashStyle.DashDot;
                    break;
            }

            pictureBox.Invalidate(); // Перерисовка PictureBox
        }

        private void comboBoxLineStyleWindow_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получите выбранный тип линии из ComboBox
            string selectedLineStyle = comboBoxLineStyleWindow.SelectedItem.ToString();

            // Установите текущий тип линии в зависимости от выбранного значения
            switch (selectedLineStyle)
            {
                case "Прямая":
                    currentLineStyleWindow = DashStyle.Solid;
                    break;
                case "Пунктир":
                    currentLineStyleWindow = DashStyle.Dash;
                    break;
                case "Точка-тире":
                    currentLineStyleWindow = DashStyle.DashDot;
                    break;
            }

            pictureBox.Invalidate(); // Перерисовка PictureBox
        }

        private void comboBoxLineStyleFoundation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получите выбранный тип линии из ComboBox
            string selectedLineStyle = comboBoxLineStyleFoundation.SelectedItem.ToString();

            // Установите текущий тип линии в зависимости от выбранного значения
            switch (selectedLineStyle)
            {
                case "Прямая":
                    currentLineStyleHouse = DashStyle.Solid;
                    break;
                case "Пунктир":
                    currentLineStyleHouse = DashStyle.Dash;
                    break;
                case "Точка-тире":
                    currentLineStyleHouse = DashStyle.DashDot;
                    break;
            }

            pictureBox.Invalidate(); // Перерисовка PictureBox
        }

        private void comboBoxLineStyleRoof_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получите выбранный тип линии из ComboBox
            string selectedLineStyle = comboBoxLineStyleRoof.SelectedItem.ToString();

            // Установите текущий тип линии в зависимости от выбранного значения
            switch (selectedLineStyle)
            {
                case "Прямая":
                    currentLineStyleRoof = DashStyle.Solid;
                    break;
                case "Пунктир":
                    currentLineStyleRoof = DashStyle.Dash;
                    break;
                case "Точка-тире":
                    currentLineStyleRoof = DashStyle.DashDot;
                    break;
            }

            pictureBox.Invalidate(); // Перерисовка PictureBox
        }

        private void FillComboBoxElements(ComboBox comboBox)
        {
            // Список для ComboBox
            comboBox.Items.Add("Прямая");
            comboBox.Items.Add("Пунктир");
            comboBox.Items.Add("Точка-тире");

            // Выбер значение по умолчанию
            comboBox.SelectedIndex = 0;
        }

        private void FillComboBox()
        {
            // Список для ComboBox
            comboBoxRoofType.Items.Add("Треугольник");
            comboBoxRoofType.Items.Add("Трапеция");
            comboBoxRoofType.Items.Add("Прямоугольник");

            // Выбор значения по умолчанию
            comboBoxRoofType.SelectedIndex = 0;
        }
        private void comboBoxRoofType_SelectedIndexChanged(object sender, EventArgs e)
        {
            roofType = comboBoxRoofType.SelectedItem.ToString(); // Фиксация выбора
        }

        private void buttonChooseHouseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                houseColor = colorDialog.Color;
                pictureBox.Invalidate(); // Перерисовка PictureBox
            }
        }

        private void buttonChooseRoofColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                roofColor = colorDialog.Color;
                pictureBox.Invalidate(); // Перерисовка PictureBox
            }
        }

        private bool IsHouseOutOfBoundaries(int houseLeftX, int houseTopY, int houseWidth, int houseHeight, int roofTopX, int roofTopY, int roofHeight)
        {
            // Проверка выхода границ дома за пределы PictureBox
            if (houseLeftX < 0 || houseTopY < 0 || houseLeftX + houseWidth > pictureBox.Width || houseTopY + houseHeight > pictureBox.Height)
            {
                MessageBox.Show("Границы дома выходят за пределы полотна. Пожалуйста, введите другие параметры.");
                return true; // Возврат true, чтобы указать, что дом не может быть нарисован
            }

            // Расчет координат вершин крыши
            int roofLeftX = roofTopX - roofHeight / 2;
            int roofRightX = roofTopX + houseWidth + roofHeight / 2;

            // Проверка выхода границ крыши за пределы PictureBox
            if (roofLeftX < 0 || roofTopY < 0 || roofRightX > pictureBox.Width)
            {
                MessageBox.Show("Границы крыши выходят за пределы полотна. Пожалуйста, введите другие параметры.");
                return true; // Возврат true, чтобы указать, что дом не может быть нарисован
            }

            return false; // Возврат false, если все проверки прошли успешно
        }

        // Метод для рисования дома
        private void DrawHouse(Graphics g)
        {
            int houseLeftX = 450;
            int houseTopY = 250;
            
            // Расчет координат вершин крыши
            int roofTopX = 450;
            int roofTopY = 250;
            int roofLeftX = roofTopX - roofHeight / 2;
            int roofRightX = roofTopX + houseWidth + roofHeight / 2;

            int Top = roofTopY - roofHeight;

            if (IsHouseOutOfBoundaries(houseLeftX, houseTopY, houseWidth, houseHeight, roofTopX, Top, roofHeight))
            {
                return;
            }
            else
            {
                Pen housePen = new Pen(houseColor)
                {
                    DashStyle = currentLineStyleHouse
                };
                // Рисование прямоугольника (дома)

                g.DrawRectangle(housePen, 450, 250, houseWidth, houseHeight);

                Pen roofPen = new Pen(roofColor)
                {
                    DashStyle = currentLineStyleRoof
                };

                // Рисование крыши в зависимости от выбранного типа
                switch (roofType)
                {
                    case "Треугольник":
                        g.DrawLine(roofPen, roofTopX, roofTopY, roofTopX + houseWidth / 2, roofTopY - roofHeight);
                        g.DrawLine(roofPen, roofTopX + houseWidth / 2, roofTopY - roofHeight, roofTopX + houseWidth, roofTopY);
                        g.DrawLine(roofPen, roofTopX, roofTopY, roofTopX + houseWidth, roofTopY); // Исправленная линия, чтобы треугольник касался верхней границы дома
                        break; ;

                    case "Трапеция":
                        g.DrawLine(roofPen, roofLeftX, roofTopY, roofTopX + houseWidth / 4, roofTopY - roofHeight);
                        g.DrawLine(roofPen, roofTopX + houseWidth / 4, roofTopY - roofHeight, roofTopX + houseWidth * 3 / 4, roofTopY - roofHeight);
                        g.DrawLine(roofPen, roofTopX + houseWidth * 3 / 4, roofTopY - roofHeight, roofRightX, roofTopY);
                        g.DrawLine(roofPen, roofLeftX, roofTopY, roofRightX, roofTopY);
                        break;

                    case "Прямоугольник":
                        int roofTopCenterX = roofTopX + houseWidth / 2;
                        int roofWidth = houseWidth + roofHeight * 2;
                        g.DrawRectangle(roofPen, roofTopCenterX - roofWidth / 2, roofTopY - roofHeight, roofWidth, roofHeight);
                        break;

                    default:
                        break;
                }
            }
            
        }

        private void DrawClick(object sender, EventArgs e)
        {
            // Получение значений из TextBox
            if (int.TryParse(WidthFoundationTextBox.Text, out houseWidth) &&
                int.TryParse(HeightFoundationTextBox.Text, out houseHeight) &&
                int.TryParse(WidthRoofTextBox.Text, out roofHeight))
            {
                // Перерисовка PictureBox
                pictureBox.Invalidate();
            }
            else
            {
                // Обработка ошибки при парсинге значений из TextBox
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для параметров дома.");
            }
        }

        private void AddWindow_Click(object sender, EventArgs e)
        {
            int count, width, height;

            if (int.TryParse(textBoxCountWindows.Text, out count) &&
                int.TryParse(textBoxWidthWindow.Text, out width) &&
                int.TryParse(textBoxHeightWindow.Text, out height))
            {
                // Проверка, что размер окна не превышает половину размеров основания дома
                if (width <= houseWidth / 2 && height <= houseHeight / 2)
                {
                    // Открываем ColorDialog
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        Color selectedColor = colorDialog.Color;

                        for (int i = 0; i < count; i++)
                        {
                            Window window = new Window
                            {
                                X = random.Next(pictureBox.Width - width),
                                Y = random.Next(pictureBox.Height - height),
                                Width = width,
                                Height = height,
                                LineColor = selectedColor // Устанавливаем выбранный цвет
                            };

                            windows.Add(window);
                        }

                        pictureBox.Invalidate(); // Перерисовка PictureBox
                    }
                }
                else
                {
                    MessageBox.Show("Размер окна не должен превышать половину размеров основания дома.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректные числовые значения для параметров окна.");
            }
        }

        private void AddDoor_Click(object sender, EventArgs e)
        {
            int count, width, height;

            if (int.TryParse(textBoxCountDoors.Text, out count) &&
                int.TryParse(textBoxWidthDoor.Text, out width) &&
                int.TryParse(textBoxHeightDoor.Text, out height))
            {
                // Проверка, что размер двери не превышает половину размеров основания дома
                if (width <= houseWidth / 2 && height <= houseHeight)
                {
                    // Открываем ColorDialog
                    if (doorColorDialog.ShowDialog() == DialogResult.OK)
                    {
                        Color selectedColor = doorColorDialog.Color;

                        for (int i = 0; i < count; i++)
                        {
                            Door door = new Door
                            {
                                X = random.Next(pictureBox.Width - width),
                                Y = houseHeight - height, // Размещаем дверь внизу стены дома
                                Width = width,
                                Height = height,
                                LineColor = selectedColor // Устанавливаем выбранный цвет
                            };

                            doors.Add(door);
                        }

                        pictureBox.Invalidate(); // Перерисовка PictureBox
                    }
                }
                else
                {
                    MessageBox.Show("Размер двери не должен превышать половину ширины основания дома и высоту не более чем высота дома.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректные числовые значения для параметров двери.");
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Проверка, было ли нажатие в пределах какого-либо окна или двери
            foreach (var window in windows.ToList())
            {
                Rectangle windowRect = new Rectangle(window.X, window.Y, window.Width, window.Height);

                if (windowRect.Contains(e.Location))
                {
                    isDragging = true;
                    selectedWindow = window;
                    break;
                }
            }

            if (!isDragging)
            {
                foreach (var door in doors.ToList())
                {
                    Rectangle doorRect = new Rectangle(door.X, door.Y, door.Width, door.Height);

                    if (doorRect.Contains(e.Location))
                    {
                        isDoorDragging = true;
                        selectedDoor = door;
                        break;
                    }
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedWindow != null)
            {
                selectedWindow.X = e.X - selectedWindow.Width / 2;
                selectedWindow.Y = e.Y - selectedWindow.Height / 2;
                pictureBox.Invalidate(); // Перерисовка PictureBox
            }
            else if (isDoorDragging && selectedDoor != null)
            {
                selectedDoor.X = e.X - selectedDoor.Width / 2;
                selectedDoor.Y = e.Y - selectedDoor.Height / 2;
                pictureBox.Invalidate(); // Перерисовка PictureBox
            }

            
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            selectedWindow = null;

            isDoorDragging = false;
            selectedDoor = null;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Проверка, было ли нажатие в пределах какого-либо окна или двери
                foreach (var window in windows.ToList())
                {
                    Rectangle windowRect = new Rectangle(window.X, window.Y, window.Width, window.Height);

                    if (windowRect.Contains(e.Location))
                    {
                        windows.Remove(window);
                        pictureBox.Invalidate(); // Перерисовка PictureBox
                        break;
                    }
                }

                foreach (var door in doors.ToList())
                {
                    Rectangle doorRect = new Rectangle(door.X, door.Y, door.Width, door.Height);

                    if (doorRect.Contains(e.Location))
                    {
                        doors.Remove(door);
                        pictureBox.Invalidate(); // Перерисовка PictureBox
                        break;
                    }
                }
            }
        }

        

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Рисование дома
            DrawHouse(g);

            // Рисование окон
            foreach (var window in windows)
            {
                Pen windowPen = new Pen(window.LineColor)
                {
                    DashStyle = currentLineStyleWindow
                };
                g.DrawRectangle(windowPen, window.X, window.Y, window.Width, window.Height);
                g.DrawLine(windowPen, window.X, window.Y + window.Height / 2, window.X + window.Width, window.Y + window.Height / 2);
                g.DrawLine(windowPen, window.X + window.Width / 2, window.Y, window.X + window.Width / 2, window.Y + window.Height);
            }

            // Рисование дверей
            foreach (var door in doors)
            {

                Pen doorPen = new Pen(door.LineColor)
                {
                    DashStyle = currentLineStyleDoor
                };
                g.DrawRectangle(doorPen, door.X, door.Y, door.Width, door.Height);

                // Рисование кругов внутри двери
                int circleSize = Math.Min(door.Width, door.Height) / 5;
                Brush circleBrush = new SolidBrush(door.LineColor);
                g.FillEllipse(circleBrush, door.X + door.Width - circleSize, door.Y + door.Height / 4, circleSize, circleSize);
                g.FillEllipse(circleBrush, door.X + door.Width - circleSize, door.Y + door.Height * 3 / 4 - circleSize, circleSize, circleSize);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Создание нового объекта Graphics для PictureBox
            using (Graphics g = pictureBox.CreateGraphics())
            {
                // Очистка всего холста PictureBox цветом фона (предполагается, что цвет фона - белый)
                g.Clear(Color.White);
            }

            // Очистка списков окон и дверей
            windows.Clear();
            doors.Clear();
        }
    }

    // Класс для создания объектов "Окна"
    public class Window
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color LineColor { get; set; }
        public DashStyle LineStyle { get; set; }
    }

    // Класс для создания объектов "Двери"
    public class Door
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color LineColor { get; set; }
        public DashStyle LineStyle { get; set; }
    }

}
