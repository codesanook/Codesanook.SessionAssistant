import * as React from 'react';

interface PushMessageProps {
    message: string;
    isReadOnly?: boolean;
}

//ES6 object destructuring syntax
const PushMessage: React.FunctionComponent<PushMessageProps> = ({ isReadOnly = false, ...props }) => {
    return (
        <div>
            <div>
                <textarea value={props.message} readOnly={isReadOnly}>
                </textarea>
            </div>
        </div>
    );
};

export default PushMessage;