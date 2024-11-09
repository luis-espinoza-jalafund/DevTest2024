import axios from "axios";
import { Poll } from "../interfaces/Poll";
import { Vote } from "../interfaces/Vote";

const API_URL = 'http://localhost:5214/api/v1';

export const getAllPolls = async (): Promise<Poll[]> => {
    const response = await axios.get<Poll[]>(`${API_URL}/polls`);
    return response.data;
};

export const addPoll = async (pollData: Poll): Promise<Poll> => {
    const response = await axios.post<Poll>(`${API_URL}/polls`, pollData);
    return response.data;
}

export const getPollById = async(pollId : Promise<Poll>) => {
    const response = await axios.get<Poll>(`${API_URL}/polls/${pollId}`)
    return response.data;
}

export const vote = async(pollId: number) => {
    const response = await axios.post<Vote>(`${API_URL}/polls/${pollId}/vote`)
    return response.data;
}

