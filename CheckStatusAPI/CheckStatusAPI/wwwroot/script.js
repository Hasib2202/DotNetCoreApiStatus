// Function to handle GET request
async function getUserStatus() {
    const msisdn = document.getElementById('msisdn').value;

    if (!msisdn) {
        alert('Please enter an MSISDN.');
        return;
    }

    const url = `http://localhost:5018/CheckStatus?msisdn=${msisdn}`;

    try {
        const response = await fetch(url);
        const data = await response.json();
        displayResponse(data);
    } catch (error) {
        console.error('Error:', error);
        displayResponse({ status: '0', message: 'An error occurred while fetching data.' });
    }
}

// Function to handle POST request
async function postUserStatus() {
    const msisdn = document.getElementById('post-msisdn').value;

    if (!msisdn) {
        alert('Please enter an MSISDN.');
        return;
    }

    const url = 'http://localhost:5018/CheckStatus';
    const payload = {
        msisdn: msisdn
    };

    try {
        const response = await fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(payload)
        });
        const data = await response.json();
        displayResponse(data);
    } catch (error) {
        console.error('Error:', error);
        displayResponse({ status: '0', message: 'An error occurred while fetching data.' });
    }
}

// Function to display API response
function displayResponse(data) {
    const responseElement = document.getElementById('api-response');
    responseElement.textContent = JSON.stringify(data, null, 2);
}