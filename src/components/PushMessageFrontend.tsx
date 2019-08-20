import * as React from 'react';
import { useState, useEffect } from 'react';
import PushMessage from './PushMessage';

const PushMessageFrontend: React.FunctionComponent = () => {
    const [existingMessage, setExistingMessage] = useState('');
    const hub = $.connection.pushMessageHub;

    // Create a function that the hub can call back
    hub.client.addNewMessage = (newMessage) => {
        setExistingMessage(previousMessage => [previousMessage, newMessage].join('\n'));
    };

    useEffect(() => {
        $.connection.hub.start().done(() => {
            console.log('frontend connected');
        });
    }, []);

    return (
        <PushMessage message={existingMessage} isReadOnly={true} />
    );
};

export default PushMessageFrontend;

