using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.CoinGreckoServices;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Desktop.Forms
{
    public partial class MarketForm : Form
    {
        private static int currentPage;
        private static int totalPages;
        private static ApplicationDbContext dbcontext;
        private static IGenericRepository<CoinEntity> _coinRepository;
        private static ICryptoService _cryptoService;
        public MarketForm()
        {
            dbcontext = new ApplicationDbContext();
            _coinRepository = new GenericRepository<CoinEntity>(dbcontext);
            _cryptoService = new CoinGreckoService(_coinRepository);

            _cryptoService.UpdateData();

            currentPage = 0;
            InitializeComponent();

            AddToFlowLayot(GetCoinsFromDb(currentPage), currenciesFlowLayoutPanel);
            UpdatePageInfo();
            CheckPaginationState();
        }
        private void UpdatePageInfo()
        {
            PageNumberInfoLab.Text = $"{currentPage + 1}/{totalPages}";
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            currentPage++;
            AddToFlowLayot(GetCoinsFromDb(currentPage), currenciesFlowLayoutPanel);
            CheckPaginationState();
            PreviousPageBtn.Enabled = true;
            UpdatePageInfo();
        }

        private void PreviousPageBtn_Click(object sender, EventArgs e)
        {
            currentPage--;
            AddToFlowLayot(GetCoinsFromDb(currentPage), currenciesFlowLayoutPanel);
            CheckPaginationState();
            UpdatePageInfo();
            NextPageBtn.Enabled = true;
        }
        private void CheckPaginationState()
        {
            if (currentPage <= 0)
            {
                PreviousPageBtn.Enabled = false;
            }
            if (currentPage == totalPages - 1)
            {
                NextPageBtn.Enabled = false;
            }
        }
        private static void groupBox_Click(object sender, EventArgs e)
        {
            GroupBox groupBox = (GroupBox)sender;
            Label secondLabel = (Label)groupBox.Controls[1];
            string coinId = secondLabel.Text;
            CoinForm coinForm = new CoinForm(coinId);
            coinForm.Show();
        }

        private static ResponseService<List<CoinEntity>> GetCoinsFromDb(int pageNumber)
        {
            _cryptoService.UpdateData();
            return default;
        }

        private void isDbEmptyChecker()
        {
            if (GetCoinsFromDb(0) == null)
            {
                _cryptoService.UpdateData();
            }
        }

        private async void MarketForm_Load(object sender, EventArgs e)
        {
            var result = await _cryptoService.CoinsIsExists();
            if (!result)
            {
                await _cryptoService.UpdateData();
            }
        }
    }
}
