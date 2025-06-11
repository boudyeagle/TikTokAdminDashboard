<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />
  <title>TikTok Live Viewer Count</title>
  <style>
    body {
      font-family: Arial, sans-serif;
      background-color: #f2f2f2;
      text-align: center;
      padding-top: 50px;
      color: #003366;
      direction: ltr;
    }
    .counter {
      font-size: 4em;
      font-weight: bold;
      margin: 20px 0;
      color: #1DA1F2;
    }
    .label {
      font-size: 1.5em;
    }
    /* إضافي: ستايل حق النماذج */
    input[type="text"], input[type="number"] {
      width: 250px;
      padding: 8px;
      margin: 10px 0;
      font-size: 1em;
    }
    #result {
      margin-top: 30px;
      font-size: 1.5em;
      color: darkblue;
      font-weight: bold;
    }
    h1, h2 {
      color: #004080;
    }
    section {
      margin: 40px auto;
      max-width: 600px;
      background: white;
      padding: 20px;
      border-radius: 10px;
      box-shadow: 0 0 8px rgba(0,0,0,0.1);
    }
    p {
      font-size: 1.1em;
      color: #333;
      text-align: left;
    }
  </style>
</head>
<body>

  <section>
    <h1>TikTok Live Viewers</h1>
    <div class="counter" id="viewerCount">1,500</div>
    <div class="label">Viewers Watching Now</div>
  </section>

  <section>
    <h2>Fake Viewer Counter Controller</h2>
    <input type="text" id="username" placeholder="Enter TikTok Username" />
    <input type="number" id="viewers" placeholder="Number of Viewers" value="1500" min="1" max="9999999" />
    <button id="sendBtn">Send Viewers</button>
    <div id="result">Press "Send Viewers" to update count.</div>
  </section>

  <section>
    <h2>Terms of Service</h2>
    <p>This dashboard is for managing TikTok data. By using this app, you agree to our terms.</p>
  </section>

  <section>
    <h2>Privacy Policy</h2>
    <p>We respect your privacy. This app does not collect or store personal information from TikTok users.</p>
  </section>

  <script>
    const viewerCountEl = document.getElementById('viewerCount');
    const usernameInput = document.getElementById('username');
    const viewersInput = document.getElementById('viewers');
    const sendBtn = document.getElementById('sendBtn');
    const resultEl = document.getElementById('result');

    sendBtn.addEventListener('click', () => {
      const username = usernameInput.value.trim();
      const viewers = parseInt(viewersInput.value);

      if (!username) {
        alert('Please enter a TikTok username.');
        return;
      }
      if (!viewers || viewers < 1) {
        alert('Please enter a valid number of viewers.');
        return;
      }

      viewerCountEl.textContent = viewers.toLocaleString();
      resultEl.textContent = `@${username} is now watching with ${viewers.toLocaleString()} viewers!`;
    });

    // Optional: press Enter key to trigger send button
    [usernameInput, viewersInput].forEach(input => {
      input.addEventListener('keydown', e => {
        if (e.key === 'Enter') {
          sendBtn.click();
        }
      });
    });
  </script>

</body>
</html>
