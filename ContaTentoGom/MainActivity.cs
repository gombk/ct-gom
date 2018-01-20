using Android.App;
using Android.Widget;
using Android.OS;

namespace ContaTentoGom
{
    [Activity(Label = "Conta-Tento | Truco", MainLauncher = true)]

    public class MainActivity : Activity
    {
        Button buttonAddT1;
        Button buttonAddT2;
        Button buttonSubT1;
        Button buttonSubT2;
        Button buttonReset;
        Button buttonTruco;
        TextView textViewT1;
        TextView textViewT2;
        TextView textView19;
        bool estilo = true;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            textView19 = FindViewById<TextView>(Resource.Id.textView19);
            textViewT1 = FindViewById<TextView>(Resource.Id.textViewT1);
            textViewT2 = FindViewById<TextView>(Resource.Id.textViewT2);
            buttonAddT1 = FindViewById<Button>(Resource.Id.buttonAddT1);
            buttonAddT2 = FindViewById<Button>(Resource.Id.buttonAddT2);
            buttonSubT1 = FindViewById<Button>(Resource.Id.buttonSubT1);
            buttonSubT2 = FindViewById<Button>(Resource.Id.buttonSubT2);
            buttonReset = FindViewById<Button>(Resource.Id.buttonReset);
            buttonTruco = FindViewById<Button>(Resource.Id.buttonTruco);

            buttonAddT1.Click += ButtonAddT1_Click;
            buttonAddT2.Click += ButtonAddT2_Click;
            buttonSubT1.Click += ButtonSubT1_Click;
            buttonSubT2.Click += ButtonSubT2_Click;
            buttonReset.Click += ButtonReset_Click;
            buttonTruco.Click += ButtonTruco_Click;
            textView19.Click += Textview19_Click;
        }

        void vencedor1()
        {
            //Faz um alertbox para anunciar o vencedor
            string text = "Fim de jogo, seu time venceu!";
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Vencedor");
            alert.SetMessage("Seu time venceu!");

            alert.SetPositiveButton("OK, começar outro jogo", (senderAlert, args) => {
                Toast.MakeText(this, text, ToastLength.Short).Show();
                textViewT1.Text = "0";
                textViewT2.Text = "0";
            });

            alert.SetNegativeButton("Cancelar, quero jogar mais!", (senderAlert, args) => {
                Toast.MakeText(this, "Jogo continua!", ToastLength.Short).Show();
            });

            Dialog d = alert.Create();
            d.Show();
        }

        void vencedor2()
        {
            //Faz um alertbox para anunciar o vencedor
            string text = "Fim de jogo, seu oponente venceu!";
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Vencedor");
            alert.SetMessage("Seu oponente venceu!");

            alert.SetPositiveButton("OK, começar outro jogo", (senderAlert, args) => {
                Toast.MakeText(this, text, ToastLength.Short).Show();
                textViewT1.Text = "0";
                textViewT2.Text = "0";
            });

            alert.SetNegativeButton("Cancelar, quero jogar mais!", (senderAlert, args) => {
                Toast.MakeText(this, "Jogo continua!", ToastLength.Short).Show();
            });

            Dialog d = alert.Create();
            d.Show();
        }

       private void Textview19_Click(object sender, System.EventArgs e)
        {
            quinze quinze1 = new quinze();
            doze doze1 = new doze();

            string text = "Desenvolvido por Lucas Zenaro (2017) para aprendizado Android, tendo em mente a mão de 15 pontos. Caso queira trocar para a mão de 12 pontos só escolher a opção abaixo!";
            string doze = "Mão de 12";
            string padrao = "Mão de 15";

            AlertDialog.Builder modo = new AlertDialog.Builder(this);
            modo.SetTitle("Escolher o modo");
            modo.SetMessage("Escolha o estilo de jogo que mais se adequa as suas necessidades");

            modo.SetPositiveButton(padrao, (senderAlert, args) =>
            {
                estilo = true;
            });

            modo.SetNegativeButton(doze, (senderAlert, args) =>
            {
                estilo = !estilo;
            });

            Dialog m = modo.Create();

            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Sobre/Opções");
            alert.SetMessage(text);

            alert.SetPositiveButton("Trocar modo", (senderAlert, args) => {
                m.Show();
            });

            alert.SetNeutralButton("Fechar", (senderAlert, args) => {
                Toast.MakeText(this, "Bom jogo!", ToastLength.Short).Show();
            });

            Dialog d = alert.Create();
            d.Show();
        }

        private void ButtonAddT1_Click(object sender, System.EventArgs e)
        {
            if (estilo == true)
            {
                int addT1 = 0;
                addT1 = int.Parse(textViewT1.Text);

                int t1Final = 0;
                t1Final = addT1 + 1;

                textViewT1.Text = t1Final.ToString();

                if (addT1 == 14)
                {
                    vencedor1();
                }
                else if (addT1 == 13)
                {
                    Toast.MakeText(this, "Mão de 14!", ToastLength.Long).Show();
                }
            }
            else if (estilo == false)
            {
                int addT1 = 0;
                addT1 = int.Parse(textViewT1.Text);

                int t1Final = 0;
                t1Final = addT1 + 1;

                textViewT1.Text = t1Final.ToString();

                if (addT1 == 11)
                {
                    vencedor1();
                }
                else if (addT1 == 10)
                {
                    Toast.MakeText(this, "Mão de 11!", ToastLength.Long).Show();
                }
            }
        }

        private void ButtonAddT2_Click(object sender, System.EventArgs e)
        {
            if (estilo == true)
            {
                int addT2 = 0;
                addT2 = int.Parse(textViewT2.Text);

                int t2Final = 0;
                t2Final = addT2 + 1;

                textViewT2.Text = t2Final.ToString();

                if (addT2 == 14)
                {
                    vencedor2();
                }
                else if (addT2 == 13)
                {
                    Toast.MakeText(this, "Mão de 14!", ToastLength.Long).Show();
                }
            }
            else if (estilo == false)
            {
                int addT2 = 0;
                addT2 = int.Parse(textViewT2.Text);

                int t2Final = 0;
                t2Final = addT2 + 1;

                textViewT2.Text = t2Final.ToString();

                if (addT2 == 11)
                {
                    vencedor2();
                }
                else if (addT2 == 10)
                {
                    Toast.MakeText(this, "Mão de 11!", ToastLength.Long).Show();
                }
            }
        }

        private void ButtonSubT1_Click(object sender, System.EventArgs e)
        {
            int subT1 = 0;
            subT1 = int.Parse(textViewT1.Text);

            int t1Final = 0;
            t1Final = subT1 - 1;

            textViewT1.Text = t1Final.ToString();

            if (subT1 <= 0)
            {
                textViewT1.Text = "0";
            }
        }

        private void ButtonSubT2_Click(object sender, System.EventArgs e)
        {
            int subT2 = 0;
            subT2 = int.Parse(textViewT2.Text);

            int t2Final = 0;
            t2Final = subT2 - 1;

            textViewT2.Text = t2Final.ToString();

            if (subT2 <= 0)
            {
                textViewT2.Text = "0";
            }
        }

        private void ButtonReset_Click(object sender, System.EventArgs e)
        {
            textViewT1.Text = "0";
            textViewT2.Text = "0";
        }

        void correu()
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Correu!");
            alert.SetMessage("Escolha pra quem vai o ponto");

            alert.SetPositiveButton("Ponto pro meu time", (senderAlert, args) => {
                if (estilo == true)
                {
                    int addT1 = 0;
                    addT1 = int.Parse(textViewT1.Text);

                    int t1Final = 0;
                    t1Final = addT1 + 1;

                    if (t1Final >= 14)
                    {
                        vencedor1();
                    }

                    textViewT1.Text = t1Final.ToString();
                }
                else if (estilo == false)
                {
                    int addT1 = 0;
                    addT1 = int.Parse(textViewT1.Text);

                    int t1Final = 0;
                    t1Final = addT1 + 1;

                    if (t1Final >= 11)
                    {
                        vencedor1();
                    }

                    textViewT1.Text = t1Final.ToString();
                }
            });

            alert.SetNegativeButton("Ponto para o oponente!", (senderAlert, args) => {
                if (estilo == true)
                {
                    int addT2 = 0;
                    addT2 = int.Parse(textViewT2.Text);

                    int t2Final = 0;
                    t2Final = addT2 + 1;

                    if (t2Final >= 14)
                    {
                        vencedor2();
                    }

                    textViewT2.Text = t2Final.ToString();
                }
                else if (estilo == false)
                {
                    int addT2 = 0;
                    addT2 = int.Parse(textViewT2.Text);

                    int t2Final = 0;
                    t2Final = addT2 + 1;

                    if (t2Final >= 11)
                    {
                        vencedor2();
                    }

                    textViewT2.Text = t2Final.ToString();
                }
            });

            Dialog d = alert.Create();
            d.Show();
        }

        private void ButtonTruco_Click(object sender, System.EventArgs e)
        {
            //Faz um alertbox para escolher pra quem vai o ponto do truco ou se passa

            AlertDialog.Builder alert2 = new AlertDialog.Builder(this);
            alert2.SetTitle("Escolha");
            alert2.SetMessage("Escolha para quem vai os três pontos");

            AlertDialog.Builder alert1 = new AlertDialog.Builder(this);
            alert1.SetTitle("TRUCO!");
            alert1.SetMessage("TRUCO! VAI OU CORRE!?");

            alert1.SetPositiveButton("IR!", (senderAlert, args) => {
                Dialog d2 = alert2.Create();
                d2.Show();
            });


            alert1.SetNegativeButton("CORRER!", (senderAlert, args) => {
                correu();
            });

            Dialog d1 = alert1.Create();
            d1.Show();

            //Abre outra alertbox para decidir pra quem vai os pontos
            alert2.SetPositiveButton("3 pontos pra vocês!", (senderAlert, args) => {

                if (estilo == true)
                {
                    int addT1 = 0;
                    addT1 = int.Parse(textViewT1.Text);

                    int t1Final = 0;
                    t1Final = addT1 + 3;

                    if (t1Final >= 14)
                    {
                        vencedor1();
                        textViewT1.Text = "15";
                    }

                    textViewT1.Text = t1Final.ToString();
                }
                else if (estilo == false)
                {
                    int addT1 = 0;
                    addT1 = int.Parse(textViewT1.Text);

                    int t1Final = 0;
                    t1Final = addT1 + 3;

                    if (t1Final >= 11)
                    {
                        vencedor1();
                        textViewT1.Text = "12";
                    }

                    textViewT1.Text = t1Final.ToString();
                }
            });

            alert2.SetNegativeButton("3 pontos pra eles!", (senderAlert, args) => {

                if (estilo == true)
                {
                    int addT2 = 0;
                    addT2 = int.Parse(textViewT2.Text);

                    int t2Final = 0;
                    t2Final = addT2 + 3;

                    if (t2Final >= 14)
                    {
                        vencedor2();
                        textViewT1.Text = "15";
                    }

                    textViewT2.Text = t2Final.ToString();
                }
                else if (estilo == false)
                {
                    int addT2 = 0;
                    addT2 = int.Parse(textViewT2.Text);

                    int t2Final = 0;
                    t2Final = addT2 + 3;

                    if (t2Final >= 11)
                    {
                        vencedor2();
                        textViewT1.Text = "12";
                    }

                    textViewT2.Text = t2Final.ToString();
                }
            });
        }
    }
}

