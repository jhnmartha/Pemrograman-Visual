### Deskripsi
Weather adalah sebuah sistem yang dibuat menggunakan Visual Studio dengan .NET C#. Aplikasi ini menggunakan WinForms serta API cuaca untuk mendapatkan data penting untuk ditampilkan. Aplikasi ini memiliki opsi bagi pengguna untuk masuk (login) dan mendaftar sebagai pengguna baru. Semua informasi pengguna disimpan dalam database MySQL. Aplikasi Weather dibuat dengan tiga form WINFORM:
- USER Form
  Form ini adalah form utama yang muncul saat aplikasi dijalankan. Form ini memungkinkan pengguna untuk memasukkan username dan password mereka. Selain itu, terdapat opsi untuk mendaftar pengguna baru di sistem.
- REGISTER Form
  Form ini muncul setelah pengguna mengklik opsi signup di form pengguna. Form ini berisi kolom-kolom detail untuk pengguna memasukkan data mereka, yang akan disimpan setelah tombol "Create Account" diklik.
- WEATHER Form
  Form ini muncul setelah pengguna memasukkan username dan password yang benar. Form cuaca ini menampilkan detail ramalan cuaca, termasuk informasi cuaca saat ini dan cuaca mingguan. Selain itu, informasi astronomi juga ditampilkan. Opsi terakhir adalah untuk mengekspor detail cuaca ke dalam file Excel.
  #### Instalasi
  Install Visual Studio di PC Anda, kemudian jalankan file "weatherTrail.sln" yang terdapat dalam folder "WeatherTrail".
  #### Database
  - Jalankan server database lokal seperti WAMP, XAMPP, dll.
  - Buat database dengan nama "users" dan impor file SQL yang disediakan ke dalam database tersebut.
  - Hubungkan database tersebut dari Visual Studio ke server Anda.
  #### API
  Kunci API yang digunakan sudah tersedia. Namun, jika kunci API tersebut tidak aktif, Anda dapat membuat kunci API Anda sendiri melalui host dan menggantinya.
