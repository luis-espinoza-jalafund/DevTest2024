import PollComponent from '../component/PollComponent'
import './HomePage.css'

function HomePage() {
    return (
        <div className='container'>
            <header>
                <p>Online Polls</p>
                
            </header>

            <PollComponent></PollComponent>
        </div>
    )
} export default HomePage;