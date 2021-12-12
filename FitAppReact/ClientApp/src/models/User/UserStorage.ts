import { ProfileStorage } from '../ProfileStorage';

export interface UserStorage {
    access_token: string,
    expires_at: number,
    id_token: string,
    profile: ProfileStorage,
    scope: string,
    session_state: string,
    token_type: string
};