
function alertt() {
  alert("işlem başarılı");
}

function saveData() {
  // Form elemanlarından verileri al
  var name = document.getElementById("name").value;
  var surname = document.getElementById("surname").value;
  var email = document.getElementById("email").value;

  // Dosya yazma işlemleri
  var file = new File(["Ad: " + name + ", Soyad: " + surname + ", E-posta: " + email], "kayitlar.txt", {type: "text/plain;charset=utf-8"});
  window.saveAs(file);
}
function siparis() {
  // Form verilerini al
  var isim = document.getElementById("isim").value;
  var email = document.getElementById("email").value;
  var telefon = document.getElementById("telefon").value;
  var adres = document.getElementById("adres").value;
  var kartNo = document.getElementById("kartNo").value;
  var kartTarih = document.getElementById("kartTarih").value;
  var guvenlik = document.getElementById("guvenlik").value;
  
  // Verileri e-posta olarak gönder
  var body = "İsim: " + isim + "\n" + "E-posta: " + email + "\n" + "Telefon: " + telefon + "\n" + "Adres: " + adres + "\n" + "Kart Numarası: " + kartNo + "\


emailjs.init("user_xxxxxxxxxxxxxxxxxxxxxxxxxxxx"); // User ID, EmailJS 
  var name = document.getElementById("name").value;
  var email = document.getElementById("email").value;
  var message = document.getElementById("message").value;


  emailjs.send("service_xxxxxxxxxxxxxx", "template_xxxxxxxxxxxxxx", {
    from_name: name,
    from_email: email,
    message_html: message,
  }).then(
    function (response) {
      alert("E-posta başarıyla gönderildi.");
    },
    function (error) {
      alert("E-posta gönderirken bir hata oluştu. Tekrar deneyin.");
    }
  );
}


function submitForm() {
  // Form submit edildiğinde yapılacaklar
  alert("Siparişiniz alındı!");
  setTimeout(function() {
    window.location.href = "index.html";
  }, 2000); // 2 saniye bekle
}


