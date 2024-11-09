import { Link } from 'react-router-dom';
import './PollComponent.css'
import { useEffect, useState } from 'react';
import { Poll } from '../interfaces/Poll';
import { getAllPolls } from '../Services/PollService';

const PollComponent: React.FC = ()  => {

    const [polls, setPolls] = useState<Poll[]>([]);
    const [open, setOpen] = useState(false);

    useEffect(() => {
        const fetchPolls = async () => {
            const response = await getAllPolls();
            setPolls(response)
        };
        fetchPolls();

        
    }, []);
    const handleClickOpen = () => {
        setOpen(true);
      };
    
    const handleClickClose = () => {
        setOpen(false);
    };
    return (
        <div className='container'>

            <div className='data'> 
                <p className='list'>
                    Polls List
                </p>
                <button onClick={handleClickOpen} >
                    New Poll
                </button>
                <dialog
                    open={open}
                    onClose={handleClickClose}
                >
                    <div></div>
                </dialog>
                
            </div>
            <div className='options'>
                <ul className='box'>
                    {polls.map((polls) => (
                        <div className='contOpt'>
                            <p className='name'>{polls.name}</p>
                            <div>
                                {polls.options.map((option) =>
                                <div className='data'>
                                    <p> {option.name} </p>
                                    <p> {option.votes}</p>

                                </div>
                                )}
                            </div>
                        
                        </div>
                        
                    ))}
                </ul>
            </div>
            <div className='percentage'>

            </div>

        </div>
    )
}
export default PollComponent;