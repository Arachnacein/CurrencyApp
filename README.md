<h1 align="center">CurrencyApp</h1><br>

<p align="center">
  CurrencyApp is a simple application that displays the current price of gold and silver in PLN and $.<br>
  Additionally, it displays the exchange rate of the dollar, euro, British pound, and Norwegian krone converted to PLN.<br>
  The gold-silver ratio is helpful when exchanging silver for gold. The app calculates it and shows it.<br><br>
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/345e2dd8-ac75-42a2-81ad-d7da1376a4e2" alt="CurrencyApp screenshot">
</p><br>

<hr><br>

<p style="text-ident:30px;">
  I used in my project goldapi.io API (www.goldapi.io). The query according to the documentation should contain the type of the method (GET), the url to the resource we want to receive and the header 'x-access-token', which is our secret api key. As on the picture below.
</p>

<p align="center">
    <img src="https://github.com/user-attachments/assets/b04a7cde-09ef-4347-9cca-188bb9e14c61"><br><br>
</p

<p style="text-ident:30px;">
    In response we get JSON as below. Instead of creating a model according to it I used <dynamic> option specifying ["price"] because only this property was needed .
</p>
      
<p align="center">
    <img src="https://github.com/user-attachments/assets/7397027e-f7e0-4823-b82e-e4b9b4f5f34c">
</p>

<hr>
