import React, { useEffect, useState } from 'react'

function App() {
  const [weatherData, setWeatherData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(()=> {
    const apiUrl = "http://localhost:5125/weatherforecast";
    
    fetch(apiUrl)
      .then(res => {
        if(!res.ok){
          throw new Error(`HTTP Error!, Status: ${res.status}`)
        }
        return res.json();
      })
      .then(data => {
        setWeatherData(data);
        setLoading(false);
      })
      .catch(err => {
        setError(err);
        setLoading(false);
        console.log("Failed to fetch weather data:", err);
      })
  },[]);

  if (loading) {
    return (
      <div className="flex items-center justify-center min-h-screen bg-gray-100">
        <p className="text-lg text-gray-700">Loading weather data...</p>
      </div>
    );
  }

  if (error) {
    return (
      <div className="flex flex-col items-center justify-center min-h-screen bg-red-100 text-red-800 p-4 rounded-lg shadow-md">
        <h2 className="text-xl font-bold mb-2">Error loading data:</h2>
        <p>{error.message}</p>
        <p className="text-sm mt-2">Please ensure your .NET API is running and CORS is configured correctly.</p>
      </div>
    );
  }

  return (
    <div>
      <h1>Weather Forcast</h1>
      {weatherData.length > 0 ? (
        <div>
          {
            weatherData.map((forcast, index) => (
              <div key={index} className='bg-white bg-opacity-20 backdrop-filter backdrop-blur-lg rounded-xl p-6 shadow-xl transform transition-transform hover:scale-105 duration-300 ease-in-out border border-white border-opacity-30'>
                <h2>{forcast.data}</h2>
                <p>{forcast.temperatureC}°C / {forcast.temperatureF}°F</p>
                <p>{forcast.summary}</p>
              </div>
            ))
          }
        </div>
      )
    :(
      <p>Weather data is not present.</p>
    )}
    </div>
  )
}

export default App