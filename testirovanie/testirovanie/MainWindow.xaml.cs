using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testirovanie
{

    public partial class MainWindow : Window
    {
        // наачальный параметры
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int qNum = 0;
        int i;
        int score;
        int numersquest = 1;
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }
        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            //создаем кнопочку для правильного ответа
            Button senderButton = sender as Button;
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {

                qNum++;
            }
            // увеличиваем счетчик вопровса и кидаем следующий вопрос
            numersquest++;
            scoreText.Content = "Очков:" + score + "/" + questionNumbers.Count;
            numer.Content = numersquest.ToString();
            NextQuestion();
        }
        //функция для вопросов
        private void NextQuestion()
        {
            // иф для проверки на заверщение игры
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                int finalscore = score;
                int youmark = 0;
                if (finalscore <= 3)
                {
                    youmark = 2;
                }
                else if (finalscore >= 4 && finalscore <= 6)
                {
                    youmark = 3;
                }
                else if (finalscore >= 7 && finalscore <= 9)
                {
                    youmark = 4;
                }
                else if (finalscore == 10)
                {
                    youmark = 5;
                }
                MessageBoxResult result = MessageBox.Show($"Ваша оценка {youmark}", "Результат: ", MessageBoxButton.OK);
                if (result == MessageBoxResult.OK)
                {
                    this.Close();
                }
            }

            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.WhiteSmoke;
            }
            // "вопросник"
            switch (i)
            {
                case 1:
                    textQuestion.Text = "Что такое HTML?";
                    answer1.Content = "Открытый протокол передачи\nгипертекста";
                    answer2.Content = "Гипертекстовый язык\n разметки Correct";//специально отмечаем правильный вопрос
                    answer3.Content = "Язык программирования\n для создания веб-страниц";
                    answer4.Content = " Операционная система";
                    answer2.Tag = "1"; //правильный ответ

                    break;
                case 2:
                    textQuestion.Text = "Какая структура данных используется для хранения элементов в виде \"первым пришел, последним вышел\"?";
                    answer1.Content = "Стек Correct";
                    answer2.Content = "Очередь";
                    answer3.Content = "Массив";
                    answer4.Content = "Списо";
                    answer1.Tag = "1";

                    break;
                case 3:
                    textQuestion.Text = "Что такое SQL?";
                    answer1.Content = " Язык программирования";
                    answer2.Content = "Графический интерфейс";
                    answer3.Content = "Язык структурированных \nзапросов Correct";
                    answer4.Content = "Технология беспроводной \nсвязи";
                    answer3.Tag = "1";

                    break;
                case 4:
                    textQuestion.Text = "Какой тип атаки направлен на получение конфиденциальной информации, такой как пароли или данные кредитных карт?";
                    answer1.Content = "Атака по отказу в\n обслуживании (DDoS)\r\n";
                    answer2.Content = "SQL-инъекция";
                    answer3.Content = "ARP-отравление";
                    answer4.Content = "Фишинг Correct";
                    answer4.Tag = "1";

                    break;
                case 5:
                    textQuestion.Text = "Что такое алгоритм?";
                    answer1.Content = "Метод решения задачи или\n выполнения операции Correct";
                    answer2.Content = "Вид компьютерного\n вируса";
                    answer3.Content = "Функция в языке\n программирования";
                    answer4.Content = "Программа для создания\n веб-страниц";
                    answer1.Tag = "1";

                    break;
                case 6:
                    textQuestion.Text = "Какая операционная система является открытой и основанной на ядре Linux?";
                    answer1.Content = "Windows";
                    answer2.Content = " macOS";
                    answer3.Content = "Ubuntu Correct";
                    answer4.Content = "Android";
                    answer3.Tag = "1";
                    break;
                case 7:
                    textQuestion.Text = "Что такое IDE в контексте разработки программного обеспечения?";
                    answer1.Content = " Интерфейс для взаимодействия\n с базой данных";
                    answer2.Content = "Интегрированная среда разработки\n Correct";
                    answer3.Content = "Инструмент для обработки\n изображений";
                    answer4.Content = "Спецификация для разработки\n интернет-приложений";
                    answer2.Tag = "1";

                    break;
                case 8:
                    textQuestion.Text = "Какой протокол используется для безопасной передачи данных по сети?";
                    answer1.Content = "HTTP";
                    answer2.Content = " FTP";
                    answer3.Content = "Telnet";
                    answer4.Content = "SSH Correct";
                    answer4.Tag = "1";

                    break;
                case 9:
                    textQuestion.Text = "Что такое облачные вычисления (cloud computing)?";
                    answer1.Content = "Тип атаки на компьютерные сети";
                    answer2.Content = "Модель распределенной базы данных";
                    answer3.Content = "Способ организации вычислений, при котором ресурсы\n предоставляются через интернетCorrect";
                    answer4.Content = " Вид программного обеспечения для анализа данных";
                    answer3.Tag = "1";

                    break;
                case 10:
                    textQuestion.Text = "Какой язык программирования часто используется для создания динамических веб-сайтов?";
                    answer1.Content = "Python Correct";
                    answer2.Content = " Swift";
                    answer3.Content = "C++";
                    answer4.Content = "Java";
                    answer1.Tag = "1";

                    break;
            }
        }
        //функия старкта игры
        private void StartGame()
        {
            //случайные вопрсы
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;

            numersquest = 0;

        }
    }
}
