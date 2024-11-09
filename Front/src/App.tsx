import { useState } from 'react'
import './App.css'
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import PollComponent from './component/PollComponent'
import HomePage from './pages/HomePage'



function App() {

  return (
    <Router>
      <Routes>
        <Route path='/' element={
          <HomePage/>
        }/>
        
      </Routes>
    </Router>
  )
}

export default App
