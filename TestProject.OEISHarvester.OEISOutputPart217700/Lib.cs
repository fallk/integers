using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A256082
{
public static readonly long[] Value={ 70L,78L,150L,266L,282L,294L,310L,334L,350L,355L,371L,397L,413L,540L,554L,582L,630L,686L,723L,798L,813L,1036L,1042L,1068L,1074L,1098L,1116L,1130L,1148L,1158L,1178L,1190L,1210L,1221L,1238L,1253L,1270L,1302L,1305L,1334L,1337L,1347L,1358L,1379L,1390L,1427L,1438L,1459L,1470L,1483L,1515L,1550L,1557L,1582L,1589L,1613L,1630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256082Inst : IEnumerable<long>
{
public static readonly long[] Value=A256082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256082.Bytes);
public long this[int i]=>Value[i];

public static A256082Inst Instance=new A256082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256083
{
public static readonly long[] Value={ 87L,96L,105L,137L,146L,155L,169L,178L,187L,264L,276L,312L,348L,380L,416L,452L,464L,508L,520L,556L,592L,741L,768L,795L,816L,831L,843L,858L,870L,885L,895L,906L,922L,933L,949L,960L,987L,991L,1014L,1018L,1041L,1045L,1055L,1077L,1082L,1104L,1109L,1131L,1141L,1145L,1168L,1172L,1195L,1199L,1226L,1237L,1253L,1264L,1280L,1291L,1301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256083Inst : IEnumerable<long>
{
public static readonly long[] Value=A256083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256083.Bytes);
public long this[int i]=>Value[i];

public static A256083Inst Instance=new A256083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256084
{
public static readonly long[] Value={ 76L,114L,141L,179L,206L,264L,280L,296L,312L,332L,348L,364L,380L,386L,402L,418L,434L,454L,470L,486L,502L,521L,537L,553L,569L,589L,605L,621L,637L,643L,659L,675L,691L,711L,727L,743L,759L,778L,794L,810L,826L,846L,862L,878L,894L,1060L,1096L,1140L,1176L,1221L,1256L,1320L,1329L,1356L,1400L,1410L,1436L,1481L,1490L,1516L,1554L,1580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256084Inst : IEnumerable<long>
{
public static readonly long[] Value=A256084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256084.Bytes);
public long this[int i]=>Value[i];

public static A256084Inst Instance=new A256084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256085
{
public static readonly long[] Value={ 140L,170L,202L,232L,266L,296L,328L,358L,392L,422L,454L,484L,518L,548L,635L,660L,685L,710L,735L,765L,790L,815L,840L,865L,877L,895L,902L,920L,927L,945L,952L,970L,977L,995L,1007L,1032L,1057L,1082L,1107L,1128L,1137L,1153L,1162L,1178L,1187L,1203L,1212L,1228L,1237L,1261L,1270L,1286L,1295L,1311L,1320L,1336L,1345L,1361L,1370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256085Inst : IEnumerable<long>
{
public static readonly long[] Value=A256085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256085.Bytes);
public long this[int i]=>Value[i];

public static A256085Inst Instance=new A256085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256086
{
public static readonly long[] Value={ 234L,276L,318L,326L,368L,410L,451L,493L,535L,543L,585L,627L,668L,710L,752L,760L,802L,844L,885L,927L,969L,977L,1019L,1061L,1102L,1144L,1186L,1308L,1344L,1380L,1416L,1452L,1488L,1530L,1566L,1602L,1638L,1674L,1710L,1730L,1752L,1766L,1788L,1802L,1824L,1838L,1860L,1874L,1896L,1910L,1932L,1952L,1974L,1988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256086Inst : IEnumerable<long>
{
public static readonly long[] Value=A256086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256086.Bytes);
public long this[int i]=>Value[i];

public static A256086Inst Instance=new A256086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256087
{
public static readonly long[] Value={ 364L,420L,476L,492L,532L,548L,604L,640L,660L,708L,728L,764L,820L,836L,876L,892L,948L,984L,1004L,1052L,1072L,1108L,1164L,1180L,1220L,1236L,1292L,1328L,1348L,1396L,1416L,1452L,1508L,1524L,1564L,1580L,1636L,1672L,1692L,1740L,1760L,1796L,1852L,1868L,1908L,1924L,1980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256087Inst : IEnumerable<long>
{
public static readonly long[] Value=A256087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256087.Bytes);
public long this[int i]=>Value[i];

public static A256087Inst Instance=new A256087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256088
{
public static readonly long[] Value={ 536L,608L,680L,706L,752L,778L,824L,850L,899L,922L,971L,994L,1049L,1072L,1121L,1144L,1193L,1219L,1265L,1291L,1337L,1363L,1412L,1435L,1484L,1507L,1562L,1585L,1634L,1657L,1706L,1732L,1778L,1804L,1850L,1876L,1925L,1948L,1997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256088Inst : IEnumerable<long>
{
public static readonly long[] Value=A256088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256088.Bytes);
public long this[int i]=>Value[i];

public static A256088Inst Instance=new A256088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256089
{
public static readonly long[] Value={ 756L,846L,936L,974L,1026L,1064L,1116L,1154L,1206L,1218L,1244L,1308L,1334L,1398L,1424L,1486L,1512L,1576L,1602L,1666L,1692L,1704L,1756L,1794L,1846L,1884L,1936L,1948L,1974L,2038L,2064L,2128L,2154L,2216L,2242L,2306L,2332L,2396L,2422L,2434L,2486L,2524L,2576L,2614L,2666L,2678L,2704L,2768L,2794L,2858L,2884L,2946L,2972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256089Inst : IEnumerable<long>
{
public static readonly long[] Value=A256089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256089.Bytes);
public long this[int i]=>Value[i];

public static A256089Inst Instance=new A256089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256090
{
public static readonly long[] Value={ 6451L,7717L,8513L,8963L,9601L,10501L,10867L,11317L,11411L,12227L,13829L,14561L,15461L,15733L,16183L,16529L,16979L,18517L,19333L,19427L,19699L,20149L,20233L,20327L,22483L,22567L,23027L,23561L,23833L,25717L,26083L,26261L,26711L,27077L,27527L,27799L,27893L,28867L,29411L,29683L,30133L,30677L,30949L,31033L,31849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256090Inst : IEnumerable<long>
{
public static readonly long[] Value=A256090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256090.Bytes);
public long this[int i]=>Value[i];

public static A256090Inst Instance=new A256090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256091
{
public static readonly long[] Value={ 5L,7L,9L,11L,17L,23L,25L,33L,38L,45L,55L,72L,79L,89L,95L,96L,99L,100L,103L,105L,117L,133L,137L,163L,171L,213L,218L,220L,237L,239L,240L,248L,255L,257L,282L,303L,305L,320L,347L,355L,362L,375L,384L,393L,407L,408L,411L,459L,475L,503L,506L,513L,525L,539L,540L,567L,581L,613L,616L,657L,659L,660L,751L,752L,761L,792L,796L,808L,824L,833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256091Inst : IEnumerable<long>
{
public static readonly long[] Value=A256091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256091.Bytes);
public long this[int i]=>Value[i];

public static A256091Inst Instance=new A256091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256092
{
public static readonly long[] Value={ 1L,3L,19L,132L,955L,7068L,53074L,402552L,3075747L,23632620L,182384774L,1412575112L,10972566670L,85442073304L,666717107460L,5211833678832L,40805272682787L,319915465833804L,2511182586525886L,19732752016481000L,155208152657919130L,1221848390114284680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256092Inst : IEnumerable<long>
{
public static readonly long[] Value=A256092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256092.Bytes);
public long this[int i]=>Value[i];

public static A256092Inst Instance=new A256092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256093
{
public static readonly long[] Value={ 1L,3L,5L,20L,101L,572L,3470L,22040L,144669L,973356L,6676186L,46503080L,328034226L,2338460056L,16819478972L,121903180848L,889396747869L,6526715628492L,48141140144546L,356708675726088L,2653863473928870L,19816831149068360L,148466651633265540L,1115659552758534480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256093Inst : IEnumerable<long>
{
public static readonly long[] Value=A256093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256093.Bytes);
public long this[int i]=>Value[i];

public static A256093Inst Instance=new A256093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256094
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,4L,5L,4L,6L,7L,7L,8L,8L,7L,8L,8L,10L,10L,12L,13L,14L,11L,13L,13L,11L,14L,16L,15L,18L,17L,16L,15L,17L,17L,20L,20L,23L,23L,21L,21L,21L,19L,23L,22L,24L,26L,26L,23L,25L,24L,28L,29L,31L,30L,32L,29L,31L,28L,29L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256094Inst : IEnumerable<long>
{
public static readonly long[] Value=A256094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256094.Bytes);
public long this[int i]=>Value[i];

public static A256094Inst Instance=new A256094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256095
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,3L,6L,1L,3L,6L,10L,1L,1L,2L,10L,15L,1L,3L,3L,5L,15L,21L,1L,3L,3L,1L,3L,21L,28L,1L,1L,2L,2L,1L,7L,28L,36L,1L,3L,6L,2L,3L,3L,4L,36L,45L,1L,3L,3L,5L,15L,3L,1L,9L,45L,55L,1L,1L,1L,5L,5L,1L,1L,1L,5L,55L,66L,1L,3L,6L,2L,3L,3L,2L,6L,3L,11L,66L,78L,1L,3L,6L,2L,3L,3L,2L,6L,3L,1L,6L,78L,91L,1L,1L,1L,1L,1L,7L,7L,1L,1L,1L,1L,13L,91L,105L,1L,3L,3L,5L,15L,21L,7L,3L,15L,5L,3L,3L,7L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256095Inst : IEnumerable<long>
{
public static readonly long[] Value=A256095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256095.Bytes);
public long this[int i]=>Value[i];

public static A256095Inst Instance=new A256095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256096
{
public static readonly long[] Value={ 4L,-9L,27L,-81L,243L,-729L,2187L,-6561L,19683L,-59049L,177147L,-531441L,1594323L,-4782969L,14348907L,-43046721L,129140163L,-387420489L,1162261467L,-3486784401L,10460353203L,-31381059609L,94143178827L,-282429536481L,847288609443L,-2541865828329L,7625597484987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256096Inst : IEnumerable<long>
{
public static readonly long[] Value=A256096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256096.Bytes);
public long this[int i]=>Value[i];

public static A256096Inst Instance=new A256096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256097
{
public static readonly long[] Value={ 1L,3L,2L,2L,9L,5L,11L,3L,3L,19L,10L,7L,11L,23L,4L,4L,33L,17L,35L,9L,37L,19L,39L,5L,5L,51L,26L,53L,27L,11L,28L,57L,29L,59L,6L,6L,73L,37L,25L,19L,77L,13L,79L,20L,27L,41L,83L,7L,7L,99L,50L,101L,51L,103L,52L,15L,53L,107L,54L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256097Inst : IEnumerable<long>
{
public static readonly long[] Value=A256097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256097.Bytes);
public long this[int i]=>Value[i];

public static A256097Inst Instance=new A256097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256098
{
public static readonly long[] Value={ 1L,2L,1L,1L,4L,2L,4L,1L,1L,6L,3L,2L,3L,6L,1L,1L,8L,4L,8L,2L,8L,4L,8L,1L,1L,10L,5L,10L,5L,2L,5L,10L,5L,10L,1L,1L,12L,6L,4L,3L,12L,2L,12L,3L,4L,6L,12L,1L,1L,14L,7L,14L,7L,14L,7L,2L,7L,14L,7L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256098Inst : IEnumerable<long>
{
public static readonly long[] Value=A256098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256098.Bytes);
public long this[int i]=>Value[i];

public static A256098Inst Instance=new A256098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256099
{
public static readonly long[] Value={ 1L,5L,4L,3L,6L,8L,9L,0L,1L,2L,6L,9L,2L,0L,7L,6L,3L,6L,1L,5L,7L,0L,8L,5L,5L,9L,7L,1L,8L,0L,1L,7L,4L,7L,9L,8L,6L,5L,2L,5L,2L,0L,3L,2L,9L,7L,6L,5L,0L,9L,8L,3L,9L,3L,5L,2L,4L,0L,8L,0L,4L,0L,3L,7L,8L,3L,1L,1L,6L,8L,6L,7L,3L,9L,2L,7L,9L,7L,3L,8L,6L,6L,4L,8L,5L,1L,5L,7L,9L,1L,4L,5L,7L,6L,0L,5L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256099Inst : IEnumerable<long>
{
public static readonly long[] Value=A256099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256099.Bytes);
public long this[int i]=>Value[i];

public static A256099Inst Instance=new A256099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256100
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,4L,5L,2L,6L,2L,7L,2L,8L,2L,9L,2L,10L,2L,11L,2L,12L,2L,3L,2L,4L,13L,5L,6L,7L,3L,8L,3L,9L,3L,10L,3L,11L,3L,12L,3L,13L,3L,4L,3L,5L,14L,6L,14L,7L,8L,9L,4L,10L,4L,11L,4L,12L,4L,13L,4L,14L,4L,5L,4L,6L,15L,7L,15L,8L,15L,9L,10L,11L,5L,12L,5L,13L,5L,14L,5L,15L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256100Inst : IEnumerable<long>
{
public static readonly long[] Value=A256100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256100.Bytes);
public long this[int i]=>Value[i];

public static A256100Inst Instance=new A256100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256101
{
public static readonly long[] Value={ 301L,721L,1141L,1561L,1981L,2401L,2821L,3241L,3661L,4081L,4501L,4921L,5341L,5761L,6181L,6601L,7021L,7441L,7861L,8281L,8701L,9121L,9541L,9961L,10381L,10801L,11221L,11641L,12061L,12481L,12901L,13321L,13741L,14161L,14581L,15001L,15421L,15841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256101Inst : IEnumerable<long>
{
public static readonly long[] Value=A256101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256101.Bytes);
public long this[int i]=>Value[i];

public static A256101Inst Instance=new A256101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256102
{
public static readonly long[] Value={ 20L,42L,77L,110L,156L,272L,342L,506L,812L,930L,1247L,1332L,1640L,1806L,2162L,2756L,3422L,3660L,4422L,4970L,5256L,6162L,6806L,7832L,9312L,9328L,10100L,10506L,11342L,11772L,12656L,16002L,17030L,18632L,19182L,22052L,22650L,24492L,26406L,27722L,29756L,31862L,32580L,36290L,37056L,38612L,39402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256102Inst : IEnumerable<long>
{
public static readonly long[] Value=A256102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256102.Bytes);
public long this[int i]=>Value[i];

public static A256102Inst Instance=new A256102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256103
{
public static readonly long[] Value={ 5L,7L,11L,11L,13L,17L,19L,23L,29L,31L,43L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,11L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256103Inst : IEnumerable<long>
{
public static readonly long[] Value=A256103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256103.Bytes);
public long this[int i]=>Value[i];

public static A256103Inst Instance=new A256103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256104
{
public static readonly long[] Value={ 20404L,31330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256104Inst : IEnumerable<long>
{
public static readonly long[] Value=A256104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256104.Bytes);
public long this[int i]=>Value[i];

public static A256104Inst Instance=new A256104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256105
{
public static readonly long[] Value={ 1L,2L,10L,36L,166L,556L,2724L,9000L,41542L,153164L,657644L,2325816L,11020508L,38006264L,164662664L,634362320L,2695771462L,9775537676L,43527018396L,156855914904L,687387270260L,2605392165928L,10799896586616L,40214700074800L,178809945153820L,657023566793400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256105Inst : IEnumerable<long>
{
public static readonly long[] Value=A256105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256105.Bytes);
public long this[int i]=>Value[i];

public static A256105Inst Instance=new A256105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256106
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,1L,1L,3L,2L,2L,1L,3L,2L,4L,2L,1L,2L,2L,2L,2L,2L,2L,3L,4L,1L,4L,4L,5L,3L,4L,2L,6L,3L,3L,1L,4L,3L,4L,2L,1L,5L,5L,3L,2L,3L,3L,4L,3L,2L,3L,5L,4L,4L,5L,2L,7L,4L,8L,4L,5L,1L,6L,5L,5L,5L,4L,3L,9L,4L,3L,6L,5L,5L,4L,5L,3L,6L,5L,4L,5L,4L,4L,4L,5L,3L,10L,5L,8L,4L,7L,3L,11L,8L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256106Inst : IEnumerable<long>
{
public static readonly long[] Value=A256106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256106.Bytes);
public long this[int i]=>Value[i];

public static A256106Inst Instance=new A256106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256107
{
public static readonly long[] Value={ 1L,2L,4L,1L,7L,2L,2L,12L,4L,5L,2L,1L,20L,7L,10L,4L,2L,2L,33L,12L,18L,8L,4L,4L,2L,1L,54L,20L,31L,14L,7L,8L,4L,2L,2L,88L,33L,52L,24L,12L,14L,8L,4L,4L,2L,1L,143L,54L,86L,40L,20L,24L,14L,7L,8L,4L,2L,2L,232L,88L,141L,66L,33L,40L,24L,12L,14L,8L,4L,4L,2L,1L,376L,143L,230L,108L,54L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256107Inst : IEnumerable<long>
{
public static readonly long[] Value=A256107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256107.Bytes);
public long this[int i]=>Value[i];

public static A256107Inst Instance=new A256107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256108
{
public static readonly long[] Value={ -1L,0L,3L,6L,11L,12L,13L,14L,15L,16L,18L,19L,21L,23L,25L,29L,33L,38L,40L,41L,43L,47L,48L,53L,57L,58L,60L,63L,64L,68L,71L,72L,76L,77L,80L,81L,85L,87L,91L,93L,94L,95L,103L,104L,106L,107L,108L,114L,115L,116L,119L,120L,122L,126L,129L,131L,134L,141L,144L,147L,148L,149L,155L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256108Inst : IEnumerable<long>
{
public static readonly long[] Value=A256108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256108.Bytes);
public long this[int i]=>Value[i];

public static A256108Inst Instance=new A256108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256109
{
public static readonly long[] Value={ 33L,309L,604L,13394L,17539L,1699933L,3794579L,172330858L,2542542111L,8324296445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256109Inst : IEnumerable<long>
{
public static readonly long[] Value=A256109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256109.Bytes);
public long this[int i]=>Value[i];

public static A256109Inst Instance=new A256109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256110
{
public static readonly long[] Value={ 5L,2L,7L,7L,8L,4L,6L,0L,0L,4L,5L,0L,2L,9L,2L,7L,3L,7L,4L,2L,7L,3L,2L,0L,5L,3L,3L,1L,6L,6L,1L,0L,2L,1L,1L,6L,4L,1L,8L,4L,3L,2L,4L,0L,0L,6L,7L,5L,0L,2L,4L,9L,2L,5L,5L,0L,1L,5L,4L,8L,3L,5L,2L,8L,0L,2L,9L,8L,6L,2L,2L,3L,5L,5L,3L,6L,8L,2L,7L,8L,3L,9L,9L,6L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256110Inst : IEnumerable<long>
{
public static readonly long[] Value=A256110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256110.Bytes);
public long this[int i]=>Value[i];

public static A256110Inst Instance=new A256110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256111
{
public static readonly long[] Value={ 0L,1L,5L,13L,26L,50L,65L,85L,116L,100L,97L,85L,85L,90L,128L,205L,293L,409L,481L,586L,730L,845L,890L,841L,833L,745L,514L,244L,65L,17L,106L,338L,698L,1117L,1225L,1193L,1040L,986L,1037L,1060L,850L,477L,197L,85L,80L,232L,530L,757L,650L,522L,225L,16L,50L,333L,797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256111Inst : IEnumerable<long>
{
public static readonly long[] Value=A256111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256111.Bytes);
public long this[int i]=>Value[i];

public static A256111Inst Instance=new A256111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256112
{
public static readonly long[] Value={ 2L,19L,75L,99L,108L,135L,228L,2102L,8525L,10535L,13685L,13710L,26075L,31835L,44790L,203367L,247215L,477543L,518703L,576495L,620343L,743823L,3850399L,6996535L,6996871L,6996920L,7375543L,8947631L,11128712L,12306056L,78473956L,89789620L,156414388L,222029284L,306600196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256112Inst : IEnumerable<long>
{
public static readonly long[] Value=A256112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256112.Bytes);
public long this[int i]=>Value[i];

public static A256112Inst Instance=new A256112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256113
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,2L,5L,2L,3L,5L,3L,5L,7L,2L,5L,7L,2L,3L,7L,2L,3L,5L,7L,2L,3L,5L,7L,11L,2L,3L,5L,7L,11L,2L,3L,5L,11L,13L,2L,3L,7L,11L,13L,3L,5L,7L,11L,13L,2L,3L,5L,7L,11L,13L,2L,5L,7L,11L,13L,17L,2L,3L,5L,7L,11L,13L,17L,2L,3L,7L,11L,13L,17L,19L,2L,3L,5L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256113Inst : IEnumerable<long>
{
public static readonly long[] Value=A256113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256113.Bytes);
public long this[int i]=>Value[i];

public static A256113Inst Instance=new A256113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256114
{
public static readonly long[] Value={ 1L,2L,3L,101L,102L,103L,104L,105L,201L,202L,203L,205L,301L,302L,303L,305L,401L,402L,403L,405L,501L,502L,503L,504L,505L,506L,507L,508L,509L,601L,602L,603L,605L,609L,661L,701L,702L,703L,705L,708L,709L,801L,802L,803L,805L,901L,902L,903L,905L,906L,983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256114Inst : IEnumerable<long>
{
public static readonly long[] Value=A256114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256114.Bytes);
public long this[int i]=>Value[i];

public static A256114Inst Instance=new A256114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256115
{
public static readonly long[] Value={ 1L,2L,3L,661L,983L,2631L,2893L,9254L,9628L,9642L,11892L,12385L,12893L,13836L,14642L,14661L,16472L,18615L,27519L,29474L,35383L,36213L,36914L,38691L,43386L,46215L,49231L,49342L,56176L,72576L,75384L,76256L,83631L,87291L,92843L,94482L,99146L,99482L,99842L,113865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256115Inst : IEnumerable<long>
{
public static readonly long[] Value=A256115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256115.Bytes);
public long this[int i]=>Value[i];

public static A256115Inst Instance=new A256115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256116
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,0L,1L,9L,10L,0L,1L,34L,112L,84L,0L,1L,125L,930L,1800L,1008L,0L,1L,461L,7018L,26400L,35640L,15840L,0L,1L,1715L,51142L,334152L,816816L,840840L,308880L,0L,1L,6434L,368464L,3944220L,15550080L,27824160L,23063040L,7207200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256116Inst : IEnumerable<long>
{
public static readonly long[] Value=A256116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256116.Bytes);
public long this[int i]=>Value[i];

public static A256116Inst Instance=new A256116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256117
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,0L,1L,9L,5L,0L,1L,34L,56L,14L,0L,1L,125L,465L,300L,42L,0L,1L,461L,3509L,4400L,1485L,132L,0L,1L,1715L,25571L,55692L,34034L,7007L,429L,0L,1L,6434L,184232L,657370L,647920L,231868L,32032L,1430L,0L,1L,24309L,1325609L,7488228L,11187462L,6191808L,1447992L,143208L,4862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256117Inst : IEnumerable<long>
{
public static readonly long[] Value=A256117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256117.Bytes);
public long this[int i]=>Value[i];

public static A256117Inst Instance=new A256117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256118
{
public static readonly long[] Value={ 127463859L,127643859L,149257683L,149257863L,149263587L,149263857L,149563827L,149653827L,157463829L,157643829L,163457829L,163547829L,239461587L,239461857L,239587641L,239641857L,241367859L,241673859L,241769853L,241853967L,251389467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256118Inst : IEnumerable<long>
{
public static readonly long[] Value=A256118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256118.Bytes);
public long this[int i]=>Value[i];

public static A256118Inst Instance=new A256118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256119
{
public static readonly long[] Value={ 0L,0L,0L,3L,3L,0L,5L,0L,3L,7L,3L,11L,0L,11L,7L,0L,11L,5L,3L,7L,5L,19L,0L,11L,17L,3L,0L,5L,13L,3L,23L,5L,17L,7L,19L,0L,29L,11L,3L,13L,0L,19L,7L,3L,29L,5L,11L,7L,13L,23L,43L,0L,17L,13L,3L,29L,5L,0L,7L,19L,3L,59L,5L,23L,7L,43L,31L,41L,11L,29L,0L,31L,37L,3L,17L,5L,19L,0L,43L,53L,3L,11L,5L,13L,7L,59L,29L,17L,11L,19L,13L,79L,0L,23L,17L,3L,19L,5L,41L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256119Inst : IEnumerable<long>
{
public static readonly long[] Value=A256119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256119.Bytes);
public long this[int i]=>Value[i];

public static A256119Inst Instance=new A256119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256120
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,2L,12L,6L,57L,88L,373L,554L,2086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256120Inst : IEnumerable<long>
{
public static readonly long[] Value=A256120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256120.Bytes);
public long this[int i]=>Value[i];

public static A256120Inst Instance=new A256120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256121
{
public static readonly long[] Value={ 2L,3L,5L,8L,13L,17L,23L,30L,39L,54L,66L,74L,88L,107L,145L,166L,191L,209L,238L,261L,312L,343L,380L,408L,468L,507L,568L,616L,703L,769L,795L,886L,918L,1109L,1120L,1217L,1323L,1399L,1466L,1510L,1727L,1808L,1936L,2005L,2094L,2167L,2216L,2361L,2497L,2580L,2899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256121Inst : IEnumerable<long>
{
public static readonly long[] Value=A256121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256121.Bytes);
public long this[int i]=>Value[i];

public static A256121Inst Instance=new A256121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256122
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,2L,2L,2L,1L,2L,1L,2L,2L,3L,1L,2L,1L,2L,2L,3L,1L,2L,3L,2L,3L,2L,1L,3L,1L,4L,2L,3L,2L,2L,1L,2L,2L,3L,1L,4L,1L,2L,2L,3L,1L,2L,5L,2L,2L,2L,1L,6L,3L,2L,3L,4L,1L,3L,1L,2L,2L,3L,2L,3L,1L,6L,2L,3L,1L,2L,1L,3L,2L,4L,2L,4L,1L,2L,5L,3L,1L,3L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256122Inst : IEnumerable<long>
{
public static readonly long[] Value=A256122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256122.Bytes);
public long this[int i]=>Value[i];

public static A256122Inst Instance=new A256122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256123
{
public static readonly long[] Value={ 1854811727L,1988791547L,2498711497L,2866433161L,3337303943L,3514209079L,5078536369L,5856521807L,6057449263L,7402496771L,8158654937L,8426760781L,8829158339L,10337846809L,11487954299L,11867001431L,12967520437L,14336558143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256123Inst : IEnumerable<long>
{
public static readonly long[] Value=A256123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256123.Bytes);
public long this[int i]=>Value[i];

public static A256123Inst Instance=new A256123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256124
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,65L,443L,3626L,34811L,384479L,4806098L,67109281L,1035627571L,17505788792L,321689532755L,6385033369589L,136124555962844L,3102031758758001L,75238874818446123L,1935053096953675800L,BigInteger.Parse("52595740530868430967"),BigInteger.Parse("1506344153813275882667") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256124Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256124.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256124Inst Instance=new A256124Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256125
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,67L,457L,3734L,35741L,392875L,4886114L,67924417L,1044531625L,17609980356L,322993544751L,6402464186243L,136373115537072L,3105809328600351L,75300018326324541L,1936106590359322126L,BigInteger.Parse("52615058519875702993"),BigInteger.Parse("1506721174739412743551") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256125Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256125.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256125Inst Instance=new A256125Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256126
{
public static readonly BigInteger[] Value={ 1L,1L,3L,11L,50L,278L,1860L,14793L,138166L,1494034L,18422609L,255359957L,3929301362L,66412322717L,1222216175058L,24314268876147L,519701698551031L,11874016816562299L,288722141589331161L,7442890569982739838L,BigInteger.Parse("202733505298293899570"),BigInteger.Parse("5817564888930184685708") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256126Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256126.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256126Inst Instance=new A256126Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256127
{
public static readonly long[] Value={ 1L,2L,6L,3L,2L,1L,4L,8L,1L,7L,0L,6L,2L,0L,9L,0L,3L,6L,3L,6L,5L,2L,2L,6L,7L,5L,3L,2L,5L,3L,2L,0L,2L,3L,9L,1L,8L,4L,4L,2L,4L,4L,3L,0L,9L,4L,6L,5L,2L,8L,3L,5L,1L,6L,3L,7L,8L,9L,9L,7L,4L,3L,0L,4L,2L,9L,0L,8L,6L,7L,4L,0L,0L,8L,5L,1L,2L,5L,4L,3L,7L,1L,7L,8L,0L,5L,2L,9L,7L,4L,1L,9L,8L,2L,9L,7L,0L,0L,2L,2L,4L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256127Inst : IEnumerable<long>
{
public static readonly long[] Value=A256127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256127.Bytes);
public long this[int i]=>Value[i];

public static A256127Inst Instance=new A256127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256128
{
public static readonly long[] Value={ 6L,7L,1L,7L,1L,9L,6L,0L,1L,8L,8L,5L,8L,7L,4L,5L,4L,2L,3L,5L,4L,4L,0L,5L,0L,6L,9L,2L,8L,8L,7L,7L,9L,8L,8L,4L,0L,0L,8L,8L,0L,2L,0L,6L,6L,2L,1L,9L,3L,5L,6L,3L,3L,2L,0L,5L,3L,6L,1L,6L,7L,3L,3L,7L,5L,1L,2L,5L,1L,2L,1L,7L,1L,7L,5L,8L,6L,1L,9L,0L,2L,1L,8L,3L,2L,6L,7L,1L,2L,6L,8L,6L,2L,9L,3L,2L,3L,7L,2L,3L,5L,5L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256128Inst : IEnumerable<long>
{
public static readonly long[] Value=A256128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256128.Bytes);
public long this[int i]=>Value[i];

public static A256128Inst Instance=new A256128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256129
{
public static readonly long[] Value={ 0L,6L,2L,8L,1L,6L,4L,7L,9L,8L,0L,6L,0L,3L,8L,9L,9L,7L,9L,4L,0L,1L,5L,8L,4L,3L,0L,0L,9L,3L,7L,6L,0L,1L,4L,3L,7L,3L,5L,1L,8L,2L,3L,2L,8L,6L,9L,2L,4L,3L,3L,6L,4L,0L,7L,0L,6L,4L,1L,2L,0L,8L,6L,4L,5L,3L,0L,6L,1L,7L,8L,9L,4L,3L,1L,2L,6L,6L,6L,5L,3L,3L,7L,9L,5L,9L,3L,5L,6L,0L,0L,0L,6L,3L,3L,7L,8L,6L,4L,6L,7L,7L,3L,1L,1L,5L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256129Inst : IEnumerable<long>
{
public static readonly long[] Value=A256129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256129.Bytes);
public long this[int i]=>Value[i];

public static A256129Inst Instance=new A256129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256130
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,3L,4L,1L,0L,5L,12L,7L,1L,0L,7L,30L,33L,11L,1L,0L,11L,72L,130L,77L,16L,1L,0L,15L,160L,463L,438L,157L,22L,1L,0L,22L,351L,1557L,2216L,1223L,289L,29L,1L,0L,30L,743L,5031L,10422L,8331L,2957L,492L,37L,1L,0L,42L,1561L,15877L,46731L,52078L,26073L,6401L,788L,46L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256130Inst : IEnumerable<long>
{
public static readonly long[] Value=A256130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256130.Bytes);
public long this[int i]=>Value[i];

public static A256130Inst Instance=new A256130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256131
{
public static readonly long[] Value={ 3L,12L,20L,100L,10000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256131Inst : IEnumerable<long>
{
public static readonly long[] Value=A256131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256131.Bytes);
public long this[int i]=>Value[i];

public static A256131Inst Instance=new A256131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256132
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,1L,3L,2L,2L,2L,1L,3L,3L,3L,3L,2L,4L,3L,2L,3L,2L,4L,1L,5L,4L,4L,4L,3L,6L,3L,4L,4L,2L,3L,3L,5L,6L,4L,6L,4L,5L,5L,6L,4L,3L,4L,6L,5L,4L,6L,7L,6L,5L,6L,5L,4L,4L,7L,7L,6L,5L,7L,8L,8L,4L,5L,5L,6L,4L,6L,9L,8L,6L,6L,9L,6L,9L,8L,8L,6L,6L,10L,6L,7L,9L,6L,8L,5L,9L,6L,5L,10L,8L,11L,6L,7L,10L,7L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256132Inst : IEnumerable<long>
{
public static readonly long[] Value=A256132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256132.Bytes);
public long this[int i]=>Value[i];

public static A256132Inst Instance=new A256132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256133
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,9L,11L,13L,14L,15L,18L,20L,21L,22L,23L,24L,29L,30L,32L,34L,35L,36L,37L,39L,41L,47L,48L,49L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,66L,76L,77L,78L,79L,84L,85L,87L,89L,90L,91L,92L,94L,96L,97L,98L,100L,102L,103L,104L,107L,109L,123L,124L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256133Inst : IEnumerable<long>
{
public static readonly long[] Value=A256133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256133.Bytes);
public long this[int i]=>Value[i];

public static A256133Inst Instance=new A256133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256134
{
public static readonly long[] Value={ 1L,1L,1L,-1L,-2L,-2L,1L,3L,4L,4L,5L,5L,5L,-1L,-6L,-7L,-7L,-8L,-8L,-8L,1L,9L,10L,10L,11L,11L,12L,12L,12L,-1L,-13L,-14L,-14L,-14L,1L,15L,16L,16L,16L,-1L,-17L,-18L,-18L,-19L,-19L,-20L,-20L,-20L,1L,21L,22L,22L,23L,23L,24L,24L,24L,-1L,-25L,-26L,-26L,-27L,-27L,-27L,1L,28L,29L,29L,29L,-1L,-30L,-31L,-31L,-31L,1L,32L,33L,33L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256134Inst : IEnumerable<long>
{
public static readonly long[] Value=A256134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256134.Bytes);
public long this[int i]=>Value[i];

public static A256134Inst Instance=new A256134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256135
{
public static readonly long[] Value={ 1L,5L,5L,25L,5L,25L,25L,125L,5L,25L,25L,125L,25L,125L,125L,625L,5L,25L,25L,125L,25L,125L,125L,625L,25L,125L,125L,625L,125L,625L,625L,3125L,5L,25L,25L,125L,25L,125L,125L,625L,25L,125L,125L,625L,125L,625L,625L,3125L,25L,125L,125L,625L,125L,625L,625L,3125L,125L,625L,625L,3125L,625L,3125L,3125L,15625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256135Inst : IEnumerable<long>
{
public static readonly long[] Value=A256135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256135.Bytes);
public long this[int i]=>Value[i];

public static A256135Inst Instance=new A256135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256136
{
public static readonly long[] Value={ 1L,6L,6L,36L,6L,36L,36L,216L,6L,36L,36L,216L,36L,216L,216L,1296L,6L,36L,36L,216L,36L,216L,216L,1296L,36L,216L,216L,1296L,216L,1296L,1296L,7776L,6L,36L,36L,216L,36L,216L,216L,1296L,36L,216L,216L,1296L,216L,1296L,1296L,7776L,36L,216L,216L,1296L,216L,1296L,1296L,7776L,216L,1296L,1296L,7776L,1296L,7776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256136Inst : IEnumerable<long>
{
public static readonly long[] Value=A256136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256136.Bytes);
public long this[int i]=>Value[i];

public static A256136Inst Instance=new A256136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256137
{
public static readonly long[] Value={ 1L,4L,6L,8L,14L,18L,26L,32L,42L,50L,62L,72L,86L,98L,114L,128L,146L,162L,182L,200L,222L,242L,266L,288L,314L,338L,366L,392L,422L,450L,482L,512L,546L,578L,614L,648L,686L,722L,762L,800L,842L,882L,926L,968L,1014L,1058L,1106L,1152L,1202L,1250L,1302L,1352L,1406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256137Inst : IEnumerable<long>
{
public static readonly long[] Value=A256137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256137.Bytes);
public long this[int i]=>Value[i];

public static A256137Inst Instance=new A256137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256138
{
public static readonly long[] Value={ 1L,5L,9L,21L,25L,37L,57L,85L,89L,101L,121L,157L,193L,221L,273L,333L,337L,349L,369L,405L,441L,477L,545L,645L,713L,741L,793L,885L,993L,1069L,1193L,1317L,1321L,1333L,1353L,1389L,1425L,1461L,1529L,1629L,1697L,1733L,1801L,1917L,2065L,2197L,2361L,2589L,2721L,2749L,2801L,2893L,3001L,3109L,3281L,3549L,3785L,3893L,4017L,4237L,4513L,4709L,4985L,5237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256138Inst : IEnumerable<long>
{
public static readonly long[] Value=A256138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256138.Bytes);
public long this[int i]=>Value[i];

public static A256138Inst Instance=new A256138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256139
{
public static readonly long[] Value={ 1L,4L,4L,12L,4L,12L,20L,28L,4L,12L,20L,36L,36L,28L,52L,60L,4L,12L,20L,36L,36L,36L,68L,100L,68L,28L,52L,92L,108L,76L,124L,124L,4L,12L,20L,36L,36L,36L,68L,100L,68L,36L,68L,116L,148L,132L,164L,228L,132L,28L,52L,92L,108L,108L,172L,268L,236L,108L,124L,220L,276L,196L,276L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256139Inst : IEnumerable<long>
{
public static readonly long[] Value=A256139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256139.Bytes);
public long this[int i]=>Value[i];

public static A256139Inst Instance=new A256139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256140
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,2L,1L,0L,1L,4L,3L,4L,1L,0L,1L,5L,4L,9L,2L,1L,0L,1L,6L,5L,16L,3L,4L,1L,0L,1L,7L,6L,25L,4L,9L,4L,1L,0L,1L,8L,7L,36L,5L,16L,9L,8L,1L,0L,1L,9L,8L,49L,6L,25L,16L,27L,2L,1L,0L,1L,10L,9L,64L,7L,36L,25L,64L,3L,4L,1L,0L,1L,11L,10L,81L,8L,49L,36L,125L,4L,9L,4L,1L,0L,1L,12L,11L,100L,9L,64L,49L,216L,5L,16L,9L,8L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256140Inst : IEnumerable<long>
{
public static readonly long[] Value=A256140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256140.Bytes);
public long this[int i]=>Value[i];

public static A256140Inst Instance=new A256140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256141
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,5L,4L,1L,1L,5L,7L,9L,5L,1L,1L,6L,9L,16L,11L,6L,1L,1L,7L,11L,25L,19L,15L,7L,1L,1L,8L,13L,36L,29L,28L,19L,8L,1L,1L,9L,15L,49L,41L,45L,37L,27L,9L,1L,1L,10L,17L,64L,55L,66L,61L,64L,29L,10L,1L,1L,11L,19L,81L,71L,91L,91L,125L,67L,33L,11L,1L,1L,12L,21L,100L,89L,120L,127L,216L,129L,76L,37L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256141Inst : IEnumerable<long>
{
public static readonly long[] Value=A256141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256141.Bytes);
public long this[int i]=>Value[i];

public static A256141Inst Instance=new A256141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256142
{
public static readonly long[] Value={ 1L,3L,12L,55L,225L,927L,3729L,14787L,57888L,224220L,860022L,3270744L,12343899L,46264257L,172305837L,638039136L,2350109736L,8613851832L,31428857611L,114187160631L,413222547846L,1489829356657L,5352683946903L,19167988920930L,68427472477338L,243559693397025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256142Inst : IEnumerable<long>
{
public static readonly long[] Value=A256142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256142.Bytes);
public long this[int i]=>Value[i];

public static A256142Inst Instance=new A256142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256143
{
public static readonly long[] Value={ 1L,0L,2L,1L,4L,2L,3L,6L,5L,3L,4L,4L,5L,7L,6L,6L,6L,4L,5L,5L,6L,8L,6L,7L,7L,8L,7L,7L,7L,6L,8L,5L,8L,7L,6L,8L,6L,8L,7L,10L,8L,10L,9L,9L,8L,9L,9L,10L,8L,9L,8L,8L,9L,7L,9L,9L,7L,6L,8L,7L,9L,8L,7L,11L,9L,8L,7L,9L,8L,10L,10L,11L,8L,10L,10L,9L,9L,10L,10L,11L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256143Inst : IEnumerable<long>
{
public static readonly long[] Value=A256143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256143.Bytes);
public long this[int i]=>Value[i];

public static A256143Inst Instance=new A256143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256144
{
public static readonly long[] Value={ 3L,73L,757L,19L,829L,2467L,37L,1063L,262657L,333667L,1772893L,80749L,1609669L,397L,18973L,541L,21061L,109L,1270657L,991L,34327L,523L,29989L,64008001L,85775383L,127L,297613L,7792003L,2017L,4987L,5167L,308933353L,433L,8209L,444979L,14437L,41203L,729027001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256144Inst : IEnumerable<long>
{
public static readonly long[] Value=A256144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256144.Bytes);
public long this[int i]=>Value[i];

public static A256144Inst Instance=new A256144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256145
{
public static readonly long[] Value={ 2L,17L,41L,257L,313L,1297L,1201L,241L,193L,73L,137L,7321L,89L,233L,14281L,937L,1489L,65537L,41761L,113L,929L,3833L,160001L,97241L,3209L,139921L,331777L,11489L,26881L,6481L,614657L,353641L,3361L,409L,1129L,61681L,97L,6113L,1336337L,750313L,98801L,10529L,50857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256145Inst : IEnumerable<long>
{
public static readonly long[] Value=A256145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256145.Bytes);
public long this[int i]=>Value[i];

public static A256145Inst Instance=new A256145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256146
{
public static readonly long[] Value={ 7L,127L,1093L,43L,19531L,55987L,29L,4733L,337L,547L,239L,4649L,45319L,659L,4943L,5229043L,8108731L,1743463L,113L,25646167L,449L,80207L,701L,70841L,71L,32719L,631L,3319L,16968421L,5336717L,28771L,321272407L,368089L,4422461L,88009573L,93997L,917087137L,122921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256146Inst : IEnumerable<long>
{
public static readonly long[] Value=A256146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256146.Bytes);
public long this[int i]=>Value[i];

public static A256146Inst Instance=new A256146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256147
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,4L,2L,7L,3L,2L,6L,2L,1L,7L,7L,7L,17L,7L,3L,1L,43L,66L,2L,72L,51L,7L,50L,32L,3L,111L,85L,26L,1L,44L,31L,7L,7L,96L,157L,23L,1L,88L,3L,97L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256147Inst : IEnumerable<long>
{
public static readonly long[] Value=A256147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256147.Bytes);
public long this[int i]=>Value[i];

public static A256147Inst Instance=new A256147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256148
{
public static readonly long[] Value={ 3L,7L,13L,31L,43L,19L,73L,37L,157L,61L,211L,241L,307L,127L,421L,463L,79L,601L,757L,271L,67L,331L,151L,1123L,397L,97L,1483L,223L,547L,1723L,139L,631L,283L,109L,103L,181L,2551L,379L,919L,409L,2971L,3307L,163L,3541L,523L,3907L,613L,4423L,4831L,1657L,5113L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256148Inst : IEnumerable<long>
{
public static readonly long[] Value=A256148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256148.Bytes);
public long this[int i]=>Value[i];

public static A256148Inst Instance=new A256148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256149
{
public static readonly long[] Value={ 1L,36L,441L,5625L,6084L,407044L,8444836L,17388900L,35070084L,40729924L,57790404L,80138304L,537822481L,588159504L,659821969L,918999225L,1820387556L,2179862721L,2599062361L,5110963081L,28816420516L,36144473689L,46082779561L,55145598561L,147225690000L,163405126756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256149Inst : IEnumerable<long>
{
public static readonly long[] Value=A256149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256149.Bytes);
public long this[int i]=>Value[i];

public static A256149Inst Instance=new A256149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256150
{
public static readonly long[] Value={ 2L,12L,56L,342L,992L,16256L,17822L,169332L,628056L,1189190L,2720850L,11085570L,35599122L,67100672L,1147210770L,1317435912L,1707135806L,7800334080L,11208986256L,13366943840L,17109032402L,17179738112L,46343540900L,58413331032L,83717924940L,204574837700L,274877382656L,445968192672L,589130699852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256150Inst : IEnumerable<long>
{
public static readonly long[] Value=A256150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256150.Bytes);
public long this[int i]=>Value[i];

public static A256150Inst Instance=new A256150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256151
{
public static readonly long[] Value={ 1L,3L,66L,210L,820L,2346L,4278L,22578L,27966L,32131L,35511L,51681L,53956L,102378L,169653L,173755L,177906L,223446L,241860L,256686L,306153L,310866L,349866L,431056L,434778L,470935L,491536L,512578L,567645L,579426L,688551L,799480L,845650L,893116L,963966L,1031766L,1110795L,1200475L,1613706L,1719585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256151Inst : IEnumerable<long>
{
public static readonly long[] Value=A256151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256151.Bytes);
public long this[int i]=>Value[i];

public static A256151Inst Instance=new A256151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256152
{
public static readonly long[] Value={ 22L,94L,115L,119L,214L,217L,265L,382L,497L,517L,527L,679L,745L,862L,889L,1174L,1177L,1207L,1219L,1393L,1465L,1501L,1649L,1687L,1915L,1942L,2101L,2159L,2201L,2359L,2899L,2902L,2995L,3007L,3143L,3383L,3401L,3427L,3937L,4039L,4054L,4097L,4315L,4529L,4537L,4702L,4741L,5029L,5065L,5398L,5587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256152Inst : IEnumerable<long>
{
public static readonly long[] Value=A256152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256152.Bytes);
public long this[int i]=>Value[i];

public static A256152Inst Instance=new A256152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256153
{
public static readonly long[] Value={ 5L,31L,11L,71L,311L,2801L,151L,61L,41L,271L,3221L,22621L,30941L,3761L,4931L,88741L,2711L,911L,251L,40841L,245411L,292561L,346201L,521L,8641L,4561L,637421L,732541L,837931L,17351L,601L,1801L,39451L,22571L,49831L,101L,4271L,194681L,191L,401L,2625641L,579281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256153Inst : IEnumerable<long>
{
public static readonly long[] Value=A256153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256153.Bytes);
public long this[int i]=>Value[i];

public static A256153Inst Instance=new A256153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256154
{
public static readonly long[] Value={ 3L,5L,7L,33L,311L,57L,37L,313L,53L,511L,319L,59L,73L,355L,711L,79L,331L,519L,97L,3311L,3337L,567L,337L,3113L,353L,571L,3717L,359L,373L,3555L,1329L,379L,3131L,579L,397L,3719L,1341L,5107L,3179L,7711L,779L,3537L,557L,1343L,3191L,5523L,577L,3193L,593L,5717L,3199L,599L,733L,3577L,1167L,739L,3251L,5151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256154Inst : IEnumerable<long>
{
public static readonly long[] Value=A256154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256154.Bytes);
public long this[int i]=>Value[i];

public static A256154Inst Instance=new A256154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256155
{
public static readonly long[] Value={ 1L,8L,5L,6L,3L,1L,4L,6L,5L,6L,3L,6L,1L,0L,1L,1L,4L,7L,2L,7L,4L,7L,5L,3L,5L,4L,2L,3L,2L,2L,6L,9L,2L,8L,4L,0L,4L,8L,4L,2L,5L,8L,8L,5L,9L,4L,7L,2L,2L,9L,0L,7L,0L,6L,8L,2L,0L,1L,0L,2L,5L,3L,9L,0L,7L,5L,4L,7L,6L,3L,7L,5L,6L,4L,7L,4L,6L,5L,1L,0L,0L,1L,9L,7L,1L,5L,7L,0L,7L,2L,9L,6L,0L,4L,2L,1L,5L,1L,9L,3L,0L,3L,9L,4L,5L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256155Inst : IEnumerable<long>
{
public static readonly long[] Value=A256155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256155.Bytes);
public long this[int i]=>Value[i];

public static A256155Inst Instance=new A256155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256156
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,4L,2L,1L,1L,3L,10L,12L,10L,3L,1L,1L,4L,21L,49L,78L,49L,21L,4L,1L,1L,5L,39L,172L,584L,778L,584L,172L,39L,5L,1L,1L,6L,68L,573L,5236L,18033L,46661L,18033L,5236L,573L,68L,6L,1L,1L,7L,112L,1890L,72205L,971573L,149636721L,19498369L,149636721L,971573L,72205L,1890L,112L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256156Inst : IEnumerable<long>
{
public static readonly long[] Value=A256156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256156.Bytes);
public long this[int i]=>Value[i];

public static A256156Inst Instance=new A256156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256157
{
public static readonly long[] Value={ 1L,3L,10L,40L,228L,2380L,94495L,320863387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256157Inst : IEnumerable<long>
{
public static readonly long[] Value=A256157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256157.Bytes);
public long this[int i]=>Value[i];

public static A256157Inst Instance=new A256157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256158
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,6L,3L,1L,1L,7L,29L,41L,29L,7L,1L,1L,15L,135L,477L,784L,477L,135L,15L,1L,1L,31L,642L,5957L,27375L,41695L,27375L,5957L,642L,31L,1L,1L,63L,3199L,87477L,1554077L,7109189L,21937982L,7109189L,1554077L,87477L,3199L,63L,1L,1L,127L,16879L,1604768L,189213842L,3559635761L,733133160992L,86322358307L,733133160992L,3559635761L,189213842L,1604768L,16879L,127L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256158Inst : IEnumerable<long>
{
public static readonly long[] Value=A256158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256158.Bytes);
public long this[int i]=>Value[i];

public static A256158Inst Instance=new A256158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256159
{
public static readonly long[] Value={ 1L,3L,14L,115L,2040L,109707L,39445994L,1560089623047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256159Inst : IEnumerable<long>
{
public static readonly long[] Value=A256159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256159.Bytes);
public long this[int i]=>Value[i];

public static A256159Inst Instance=new A256159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256160
{
public static readonly long[] Value={ 6L,46L,2952L,17992L,19451L,768L,1722783L,36356650L,564665215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256160Inst : IEnumerable<long>
{
public static readonly long[] Value=A256160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256160.Bytes);
public long this[int i]=>Value[i];

public static A256160Inst Instance=new A256160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256161
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,11L,6L,1L,1L,5L,26L,23L,9L,1L,1L,6L,57L,72L,50L,12L,1L,1L,7L,120L,201L,222L,86L,16L,1L,1L,8L,247L,522L,867L,480L,150L,20L,1L,1L,9L,502L,1291L,3123L,2307L,1080L,230L,25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256161Inst : IEnumerable<long>
{
public static readonly long[] Value=A256161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256161.Bytes);
public long this[int i]=>Value[i];

public static A256161Inst Instance=new A256161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256162
{
public static readonly long[] Value={ 1L,8L,9L,98L,99L,998L,999L,9998L,9999L,99998L,99999L,999998L,999999L,9999998L,9999999L,99999998L,99999999L,999999998L,999999999L,9999999998L,9999999999L,99999999998L,99999999999L,999999999998L,999999999999L,9999999999998L,9999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256162Inst : IEnumerable<long>
{
public static readonly long[] Value=A256162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256162.Bytes);
public long this[int i]=>Value[i];

public static A256162Inst Instance=new A256162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256163
{
public static readonly long[] Value={ 1L,7913L,8923L,24943L,34009L,35437L,42533L,52783L,60113L,83437L,100727L,105953L,116437L,120521L,126631L,132211L,133241L,137171L,145589L,164729L,172331L,181645L,183671L,192173L,196633L,199513L,203069L,204013L,215113L,215279L,218503L,220523L,253519L,254329L,254587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256163Inst : IEnumerable<long>
{
public static readonly long[] Value=A256163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256163.Bytes);
public long this[int i]=>Value[i];

public static A256163Inst Instance=new A256163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256164
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,10L,161L,2342L,27216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256164Inst : IEnumerable<long>
{
public static readonly long[] Value=A256164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256164.Bytes);
public long this[int i]=>Value[i];

public static A256164Inst Instance=new A256164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256165
{
public static readonly long[] Value={ 9L,8L,5L,4L,2L,0L,6L,4L,6L,9L,2L,7L,7L,6L,7L,0L,6L,9L,1L,8L,7L,1L,7L,4L,0L,3L,6L,9L,7L,7L,9L,6L,1L,3L,9L,1L,7L,3L,5L,5L,5L,6L,4L,9L,6L,3L,8L,5L,8L,8L,5L,8L,5L,4L,2L,3L,4L,7L,5L,7L,0L,1L,0L,0L,8L,9L,4L,0L,4L,1L,1L,8L,9L,1L,3L,7L,6L,0L,4L,4L,7L,6L,8L,0L,3L,7L,6L,5L,9L,8L,3L,2L,3L,5L,8L,8L,2L,6L,0L,5L,9L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256165Inst : IEnumerable<long>
{
public static readonly long[] Value=A256165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256165.Bytes);
public long this[int i]=>Value[i];

public static A256165Inst Instance=new A256165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256166
{
public static readonly long[] Value={ 1L,2L,8L,8L,0L,2L,2L,5L,2L,4L,6L,9L,8L,0L,7L,7L,4L,5L,7L,3L,7L,0L,6L,1L,0L,4L,4L,0L,2L,1L,9L,7L,1L,7L,2L,9L,5L,9L,2L,5L,3L,7L,7L,5L,6L,5L,1L,1L,2L,8L,6L,0L,5L,5L,0L,4L,9L,9L,9L,8L,7L,0L,2L,2L,5L,3L,3L,9L,6L,1L,2L,6L,2L,6L,7L,5L,6L,9L,8L,8L,3L,6L,2L,1L,6L,0L,7L,3L,8L,1L,6L,4L,1L,7L,6L,1L,3L,8L,6L,6L,1L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256166Inst : IEnumerable<long>
{
public static readonly long[] Value=A256166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256166.Bytes);
public long this[int i]=>Value[i];

public static A256166Inst Instance=new A256166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256167
{
public static readonly long[] Value={ 1L,5L,2L,4L,0L,6L,3L,8L,2L,2L,4L,3L,0L,7L,8L,4L,5L,2L,4L,8L,8L,1L,0L,5L,6L,4L,9L,3L,9L,2L,6L,3L,0L,2L,1L,9L,2L,5L,6L,5L,9L,3L,3L,7L,3L,7L,4L,0L,6L,4L,0L,3L,4L,7L,5L,1L,0L,4L,2L,8L,7L,2L,9L,1L,4L,6L,4L,9L,9L,1L,7L,9L,8L,2L,5L,1L,8L,0L,8L,8L,5L,3L,7L,3L,8L,8L,1L,8L,6L,6L,3L,3L,9L,2L,7L,8L,5L,5L,1L,6L,9L,9L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256167Inst : IEnumerable<long>
{
public static readonly long[] Value=A256167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256167.Bytes);
public long this[int i]=>Value[i];

public static A256167Inst Instance=new A256167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256168
{
public static readonly BigInteger[] Value={ 1L,-2L,1L,-1L,-9L,-59L,-474L,-4560L,-50364L,-625385L,-8622658L,-130751886L,-2163331779L,-38793751015L,-749691306018L,-15535914341831L,-343749787006758L,-8089725377931547L,-201801866906374263L,-5319643146604299835L,BigInteger.Parse("-147774950436327236681") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256168Inst Instance=new A256168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256169
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,8L,17L,38L,91L,212L,509L,1234L,3007L,7408L,18353L,45742L,114643L,288620L,729749L,1852138L,4716951L,12050920L,30876185L,79317990L,204256027L,527171556L,1363428637L,3533070818L,9171798815L,23849951200L,62116162081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256169Inst : IEnumerable<long>
{
public static readonly long[] Value=A256169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256169.Bytes);
public long this[int i]=>Value[i];

public static A256169Inst Instance=new A256169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256170
{
public static readonly long[] Value={ 2L,3L,2L,2L,3L,3L,2L,3L,7L,2L,2L,2L,3L,7L,2L,3L,3L,11L,2L,2L,3L,13L,2L,7L,3L,3L,3L,2L,2L,2L,2L,3L,3L,3L,3L,2L,3L,7L,19L,2L,2L,3L,3L,7L,7L,2L,11L,3L,13L,2L,2L,2L,3L,25L,2L,13L,3L,3L,7L,2L,2L,7L,3L,11L,2L,3L,3L,3L,31L,2L,2L,2L,2L,2L,3L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256170Inst : IEnumerable<long>
{
public static readonly long[] Value=A256170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256170.Bytes);
public long this[int i]=>Value[i];

public static A256170Inst Instance=new A256170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256171
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,0L,1L,2L,1L,2L,3L,0L,1L,3L,1L,2L,3L,1L,1L,1L,1L,3L,3L,1L,2L,1L,2L,3L,1L,2L,4L,2L,1L,3L,2L,2L,3L,2L,1L,2L,2L,2L,3L,3L,2L,1L,2L,2L,3L,5L,2L,2L,2L,2L,3L,4L,2L,2L,4L,1L,3L,2L,1L,4L,3L,2L,2L,5L,2L,4L,3L,0L,4L,2L,1L,3L,6L,3L,3L,3L,1L,5L,2L,3L,5L,2L,2L,3L,3L,1L,5L,3L,1L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256171Inst : IEnumerable<long>
{
public static readonly long[] Value=A256171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256171.Bytes);
public long this[int i]=>Value[i];

public static A256171Inst Instance=new A256171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256172
{
public static readonly long[] Value={ 31L,223L,439L,1399L,2383L,2767L,3343L,3463L,3607L,4567L,6079L,7927L,8167L,8287L,8719L,10159L,10663L,11959L,14503L,15559L,15727L,17383L,18223L,19087L,20743L,21487L,21559L,24007L,25639L,26647L,27103L,27583L,28807L,28879L,29167L,29599L,31183L,32359L,33343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256172Inst : IEnumerable<long>
{
public static readonly long[] Value=A256172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256172.Bytes);
public long this[int i]=>Value[i];

public static A256172Inst Instance=new A256172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256173
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,8L,9L,12L,15L,16L,21L,24L,25L,27L,32L,35L,36L,40L,45L,48L,49L,55L,60L,63L,64L,65L,72L,77L,80L,81L,84L,91L,96L,99L,100L,105L,112L,117L,120L,121L,128L,135L,140L,143L,144L,153L,160L,165L,168L,169L,171L,180L,187L,192L,195L,196L,200L,209L,216L,221L,224L,225L,231L,240L,247L,252L,255L,256L,264L,273L,280L,285L,288L,289L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256173Inst : IEnumerable<long>
{
public static readonly long[] Value=A256173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256173.Bytes);
public long this[int i]=>Value[i];

public static A256173Inst Instance=new A256173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256174
{
public static readonly long[] Value={ 4L,9L,7L,20L,6L,33L,13L,23L,16L,62L,8L,75L,18L,17L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256174Inst : IEnumerable<long>
{
public static readonly long[] Value=A256174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256174.Bytes);
public long this[int i]=>Value[i];

public static A256174Inst Instance=new A256174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256175
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256175Inst : IEnumerable<long>
{
public static readonly long[] Value=A256175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256175.Bytes);
public long this[int i]=>Value[i];

public static A256175Inst Instance=new A256175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256176
{
public static readonly long[] Value={ 67L,89L,7879L,8081L,9091L,9293L,186187L,188189L,276277L,278279L,426427L,428429L,438439L,440441L,450451L,452453L,600601L,602603L,606607L,608609L,798799L,800801L,816817L,818819L,858859L,860861L,936937L,938939L,960961L,962963L,11401141L,11421143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256176Inst : IEnumerable<long>
{
public static readonly long[] Value=A256176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256176.Bytes);
public long this[int i]=>Value[i];

public static A256176Inst Instance=new A256176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256177
{
public static readonly long[] Value={ 13L,23L,43L,73L,83L,113L,163L,173L,193L,223L,233L,263L,283L,293L,313L,373L,383L,433L,443L,463L,523L,563L,593L,613L,643L,673L,683L,733L,743L,773L,823L,863L,883L,983L,1013L,1033L,1063L,1093L,1123L,1163L,1193L,1213L,1223L,1283L,1373L,1423L,1433L,1483L,1493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256177Inst : IEnumerable<long>
{
public static readonly long[] Value=A256177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256177.Bytes);
public long this[int i]=>Value[i];

public static A256177Inst Instance=new A256177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256178
{
public static readonly BigInteger[] Value={ 1L,21L,385L,6930L,124410L,2232594L,40062659L,718896255L,12900072515L,231482415780L,4153783429236L,74536619356836L,1337505365115205L,24000559953034665L,430672573790340805L,7728105768275278134L,BigInteger.Parse("138675231255170368494") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256178Inst Instance=new A256178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256179
{
public static readonly BigInteger[] Value={ 2L,3L,4L,8L,9L,16L,27L,81L,256L,512L,6561L,19683L,65536L,43046721L,134217728L,7625597484987L,BigInteger.Parse("2417851639229258349412352"),BigInteger.Parse("443426488243037769948249630619149892803"),BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639936") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256179Inst Instance=new A256179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256180
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,86L,404L,2121L,12264L,77272L,525941L,3839706L,29891370L,246906569L,2154904856L,19799299506L,190904273049L,1926229186162L,20288311652672L,222568337565537L,2537998989244956L,30029233006187756L,368050599579654557L,4665833729558724030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256180Inst : IEnumerable<long>
{
public static readonly long[] Value=A256180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256180.Bytes);
public long this[int i]=>Value[i];

public static A256180Inst Instance=new A256180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256181
{
public static readonly long[] Value={ 1L,2L,6L,24L,120L,720L,5040L,32256L,169632L,737364L,2731444L,8875868L,25894376L,69053375L,170694383L,395443223L,866147111L,1806459866L,3608498678L,6937282452L,12887902732L,23216767894L,40675018726L,69480583966L,115975600846L,189528370396L,303753983092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256181Inst : IEnumerable<long>
{
public static readonly long[] Value=A256181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256181.Bytes);
public long this[int i]=>Value[i];

public static A256181Inst Instance=new A256181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}