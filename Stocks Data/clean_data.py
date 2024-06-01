import pandas as pd

# Verileri oku
data = pd.read_csv(r'C:\Users\mertu\OneDrive\Masaüstü\VS Code Dosyaları\Clean_Data\nasdaq_screener_1712573325260.csv')

# Boş değerleri kaldır
data = data.dropna()

# Sadece 'Symbol' sütununu seç
data = data[['Symbol']]

# Tekrarlayan verileri kaldır
data = data.drop_duplicates()

# Sembolleri tek bir satırda virgülle ayrılmış olarak yaz
symbols_string = ','.join([f'"{symbol}"' for symbol in data['Symbol']])
with open('temizlenmis_veriler.txt', 'w') as file:
    file.write(symbols_string)
