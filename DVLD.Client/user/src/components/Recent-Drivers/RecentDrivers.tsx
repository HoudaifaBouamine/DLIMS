import './RecentDrivers.css'
import TableComponent from './Table/Table'



export default function DownContent(){
    return (
        
      <div className="down-content">
        <TableComponent title='Recent Drivers' data={testData}/>
      </div>
    )
  }

  const testData = [
    {
      id: 1,
      fullName: 'John Doe',
      startDate: '2022-01-01',
      avatar: 'https://example.com/avatar1.jpg',
    },
    {
      id: 2,
      fullName: 'Jane Doe',
      startDate: '2022-02-15',
      avatar: 'https://example.com/avatar2.jpg',
    },
    {
      id: 3,
      fullName: 'Bob Smith',
      startDate: '2022-03-10',
      avatar: 'https://example.com/avatar3.jpg',
    },
    // Add more sample data as needed
  ];
  
  