using System.Windows.Input;
using MvvmSample.BasePages;
using MvvmSample.Commands;
using MvvmSample.Models;

namespace MvvmSample.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        #region メンバ変数

        private int _currentNumber;

        #endregion

        #region プロパティ


       
        
       

        public ICommand CountUpCommand { get; }
       // public ICommand CountDownCommand { get; }

        public int CurrentNumber
        {
            get { return _currentNumber; }
            set
            {
                this._currentNumber = value;
                this.OnPropertyChanged(nameof(CurrentNumber));
            }
        }
        #endregion

        #region コンストラクタ

        public MainViewModel()
        {
            CountUpCommand = new CountUpCommand(Increment);
            //CountUpCommand = new CountUpCommand(Decrement);
        }

        #endregion

        #region メソッド

        private void Increment()
        {
            CurrentNumber = Model.Incriment(CurrentNumber);
        }

        private void Decrement()
        {
            CurrentNumber = Model.Decrement(CurrentNumber);
        }


        #endregion
    }
}