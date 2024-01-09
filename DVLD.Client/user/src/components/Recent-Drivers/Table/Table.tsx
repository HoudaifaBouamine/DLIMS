import React from 'react';
import './Table.css'; // Import your CSS file for styling

interface Driver {
  id: number;
  fullName: string;
  startDate: string;
  avatar: string; // Assuming the avatar is an image URL
}

interface TableComponentProps {
  title: string;
  data: Driver[];
}

const TableComponent: React.FC<TableComponentProps> = ({ title, data }: TableComponentProps) => {
  return (
    <div className="table-container">
      <h2 className="table-title">{title}</h2>
      <table className="custom-table">
        <thead>
          <tr>
            <th>Avatar</th>
            <th>ID</th>
            <th>FullName</th>
            <th>StartDate</th>
          </tr>
        </thead>
        <tbody>
          {data.map((driver) => (
            <tr key={driver.id}>
              <td>
                <img src={driver.avatar} className="avatar" />
              </td>
              <td>{driver.id}</td>
              <td>{driver.fullName}</td>
              <td>{driver.startDate}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default TableComponent;
