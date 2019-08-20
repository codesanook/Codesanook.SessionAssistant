import * as React from 'react';
import { useState, useEffect } from 'react';
import PushMessage from './PushMessage';

const PushMessageAdmin: React.FunctionComponent = () => {
    const [existingMessage, setExistingMessage] = useState('');
    const [newMessage, setNewMessage] = useState('');

    const hub = $.connection.pushMessageHub;

    useEffect(() => {
        // Create a function that the hub can call back
        hub.client.addNewMessage = newMessage => {
            console.log(newMessage);
            //`${previousMessage}\n ${newMessage}`
            setExistingMessage(previousMessage => [previousMessage, newMessage].join('\n'));
            setNewMessage('');
        };

        $.connection.hub.start().done(() => {
            console.log('connected');
        });
    }, []);//run only once

    const sendMessage = (e: React.MouseEvent<HTMLButtonElement>) => {
        hub.server.send(newMessage);
    };

    const handleTextChange = (e: React.ChangeEvent<HTMLTextAreaElement>) => {
        const value = e.currentTarget.value;
        setNewMessage(value);
    };

    return (
        <div>
            <PushMessage message={existingMessage} isReadOnly={true} />
            <textarea value={newMessage} onChange={handleTextChange} />
            <div>
                <button onClick={sendMessage}>send</button>
            </div>
        </div>
    );
};

export default PushMessageAdmin;