using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A083636
{
public static readonly long[] Value={ 24658601L,24658602L,82144203L,287248607L,1096547723L,1136093224L,1136093225L,1199887625L,1253506894L,1284344221L,1284344222L,1343455078L,1347842020L,1387894932L,1387894933L,1439845247L,1577148578L };
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
public class A083636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083636Inst : IEnumerable<long>
{
public static readonly long[] Value=A083636.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083636.Bytes);
public long this[int i]=>Value[i];

public static A083636Inst Instance=new A083636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083587
{
public static readonly long[] Value={ 1L,4L,10L,28L,84L,260L,812L,2532L,7852L,24196L,74124L,225956L,686060L,2076612L,6270796L,18902500L,56904108L,171138308L,514332428L,1544963364L,4639084396L,13926166084L,41797372620L,125431963748L,376379777324L,1129315492740L };
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
public class A083587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083587Inst : IEnumerable<long>
{
public static readonly long[] Value=A083587.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083587.Bytes);
public long this[int i]=>Value[i];

public static A083587Inst Instance=new A083587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083586
{
public static readonly long[] Value={ 0L,1L,5L,22L,96L,419L,1819L,7824L,33302L,140317L,585873L,2427146L,9989068L,40886295L,166600967L,676368388L,2737758594L,11055063953L,44553867901L,179280877950L,720513441080L,2892804682891L,11605214879475L,46528078138232L };
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
public class A083586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083586Inst : IEnumerable<long>
{
public static readonly long[] Value=A083586.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083586.Bytes);
public long this[int i]=>Value[i];

public static A083586Inst Instance=new A083586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083585
{
public static readonly long[] Value={ 1L,10L,60L,320L,1640L,8280L,41560L,208120L,1041240L,5207480L,26039960L,130204920L,651034840L,3255194680L,16276014360L,81380153720L,406900932440L,2034504989880L,10172525604760L,50862629334520L,254313149294040L };
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
public class A083585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083585Inst : IEnumerable<long>
{
public static readonly long[] Value=A083585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083585.Bytes);
public long this[int i]=>Value[i];

public static A083585Inst Instance=new A083585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083584
{
public static readonly long[] Value={ 1L,9L,41L,169L,681L,2729L,10921L,43689L,174761L,699049L,2796201L,11184809L,44739241L,178956969L,715827881L,2863311529L,11453246121L,45812984489L,183251937961L,733007751849L,2932031007401L,11728124029609L,46912496118441L };
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
public class A083584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083584Inst : IEnumerable<long>
{
public static readonly long[] Value=A083584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083584.Bytes);
public long this[int i]=>Value[i];

public static A083584Inst Instance=new A083584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083583
{
public static readonly long[] Value={ 1L,8L,24L,72L,216L,648L,1944L,5832L,17496L,52488L,157464L,472392L,1417176L,4251528L,12754584L,38263752L,114791256L,344373768L,1033121304L,3099363912L,9298091736L,27894275208L,83682825624L,251048476872L,753145430616L,2259436291848L };
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
public class A083583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083583Inst : IEnumerable<long>
{
public static readonly long[] Value=A083583.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083583.Bytes);
public long this[int i]=>Value[i];

public static A083583Inst Instance=new A083583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083582
{
public static readonly long[] Value={ 1L,7L,9L,23L,41L,87L,169L,343L,681L,1367L,2729L,5463L,10921L,21847L,43689L,87383L,174761L,349527L,699049L,1398103L,2796201L,5592407L,11184809L,22369623L,44739241L,89478487L,178956969L,357913943L,715827881L,1431655767L,2863311529L };
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
public class A083582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083582Inst : IEnumerable<long>
{
public static readonly long[] Value=A083582.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083582.Bytes);
public long this[int i]=>Value[i];

public static A083582Inst Instance=new A083582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083581
{
public static readonly long[] Value={ 1L,6L,-4L,16L,-24L,56L,-104L,216L,-424L,856L,-1704L,3416L,-6824L,13656L,-27304L,54616L,-109224L,218456L,-436904L,873816L,-1747624L,3495256L,-6990504L,13981016L,-27962024L,55924056L,-111848104L,223696216L,-447392424L,894784856L,-1789569704L,3579139416L,-7158278824L };
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
public class A083581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083581Inst : IEnumerable<long>
{
public static readonly long[] Value=A083581.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083581.Bytes);
public long this[int i]=>Value[i];

public static A083581Inst Instance=new A083581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083580
{
public static readonly long[] Value={ 0L,1L,3L,10L,34L,114L,374L,1202L,3798L,11842L,36550L,111954L,340982L,1034210L,3127206L,9434866L,28419286L,85503618L,257035142L,772219538L,2319017910L,6962034466L,20896589158L,62711787570L,188181500054L,564640969154L };
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
public class A083580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083580Inst : IEnumerable<long>
{
public static readonly long[] Value=A083580.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083580.Bytes);
public long this[int i]=>Value[i];

public static A083580Inst Instance=new A083580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083579
{
public static readonly long[] Value={ 0L,1L,1L,4L,8L,19L,39L,82L,166L,337L,677L,1360L,2724L,5455L,10915L,21838L,43682L,87373L,174753L,349516L,699040L,1398091L,2796191L,5592394L,11184798L,22369609L,44739229L,89478472L,178956956L,357913927L,715827867L,1431655750L,2863311514L };
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
public class A083579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083579Inst : IEnumerable<long>
{
public static readonly long[] Value=A083579.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083579.Bytes);
public long this[int i]=>Value[i];

public static A083579Inst Instance=new A083579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083578
{
public static readonly long[] Value={ 1L,1L,26L,76L,776L,3376L,25376L,131776L,872576L,4907776L,30757376L,179301376L,1096779776L,6496792576L,39316299776L,234555621376L,1412702437376L,8454739787776L,50814338072576L,304542431051776L,1828628975845376L };
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
public class A083578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083578Inst : IEnumerable<long>
{
public static readonly long[] Value=A083578.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083578.Bytes);
public long this[int i]=>Value[i];

public static A083578Inst Instance=new A083578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083577
{
public static readonly long[] Value={ 13L,37L,73L,181L,337L,433L,541L,661L,937L,1093L,2053L,2281L,2521L,3037L,3313L,5581L,5953L,6337L,6733L,7561L,7993L,8893L,10333L,10837L,11353L,12421L,12973L,13537L,15913L,18481L,20533L,21961L,25741L,27337L,32413L,33301L,36037L,36973L,42841L };
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
public class A083577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083577Inst : IEnumerable<long>
{
public static readonly long[] Value=A083577.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083577.Bytes);
public long this[int i]=>Value[i];

public static A083577Inst Instance=new A083577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083576
{
public static readonly long[] Value={ 13L,181L,1093L,10333L,100621L,1040833L,10085473L,100000837L,1000705861L,10003758337L,100012479337L,1000001026513L,10000000794181L,100000078156441L,1000000776555301L,10000014919168441L,100000008716411701L };
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
public class A083576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083576Inst : IEnumerable<long>
{
public static readonly long[] Value=A083576.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083576.Bytes);
public long this[int i]=>Value[i];

public static A083576Inst Instance=new A083576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083575
{
public static readonly long[] Value={ 6L,11L,21L,41L,81L,161L,321L,641L,1281L,2561L,5121L,10241L,20481L,40961L,81921L,163841L,327681L,655361L,1310721L,2621441L,5242881L,10485761L,20971521L,41943041L,83886081L,167772161L,335544321L,671088641L,1342177281L,2684354561L,5368709121L,10737418241L };
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
public class A083575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083575Inst : IEnumerable<long>
{
public static readonly long[] Value=A083575.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083575.Bytes);
public long this[int i]=>Value[i];

public static A083575Inst Instance=new A083575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083574
{
public static readonly long[] Value={ 3L,3L,3L,5L,3L,7L,5L,5L,3L,3L,3L,3L,11L,5L,7L,3L,13L,3L,3L,5L,7L,7L,3L,17L,5L,11L,3L,19L,3L,3L,7L,5L,13L,3L,23L,3L,5L,5L,7L,11L,3L,3L,3L,3L,29L,7L,13L,3L,31L,5L,19L,3L,3L,11L };
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
public class A083574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083574Inst : IEnumerable<long>
{
public static readonly long[] Value=A083574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083574.Bytes);
public long this[int i]=>Value[i];

public static A083574Inst Instance=new A083574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083573
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,6L,0L,10L,0L,8L,0L,16L,0L,10L,0L,35L,0L,28L,0L,22L,10L,14L,0L,54L,0L,16L,19L,28L,0L,28L,0L,158L,0L,20L,0L,78L,0L,22L,16L,76L,0L,36L,0L,40L,0L,26L,0L,236L,0L,64L,0L,46L,0L,212L,14L,98L,22L,32L,0L,80L,0L,34L,36L,937L,0L,52L,0L,58L,0L,52L,0L,272L };
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
public class A083573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083573Inst : IEnumerable<long>
{
public static readonly long[] Value=A083573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083573.Bytes);
public long this[int i]=>Value[i];

public static A083573Inst Instance=new A083573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083572
{
public static readonly BigInteger[] Value={ 0L,1L,2296L,40833L,22847280L,395417121L,219458276136L,3797122504033L,2107246056196960L,36460001965365441L,BigInteger.Parse("20233777167801893976"),BigInteger.Parse("350088938217540957633"),BigInteger.Parse("194284726332034400465040"),BigInteger.Parse("3361553948612830233684961") };
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
public class A083572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083572Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083572.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083572.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083572Inst Instance=new A083572Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083539
{
public static readonly long[] Value={ 3L,12L,28L,42L,72L,96L,120L,195L,234L,216L,336L,392L,336L,576L,744L,558L,702L,780L,840L,1344L,1152L,864L,1440L,1860L,1302L,1680L,2240L,1680L,2160L,2304L,2016L,3024L,2592L,2592L,4368L,3458L,2280L,3360L,5040L,3780L,4032L,4224L,3696L,6552L,5616L,3456L,5952L };
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
public class A083539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083539Inst : IEnumerable<long>
{
public static readonly long[] Value=A083539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083539.Bytes);
public long this[int i]=>Value[i];

public static A083539Inst Instance=new A083539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083538
{
public static readonly long[] Value={ 3L,12L,28L,42L,2L,6L,120L,195L,234L,6L,21L,2L,84L,1L,744L,558L,78L,780L,210L,336L,72L,6L,10L,1860L,1302L,420L,35L,420L,60L,36L,2016L,336L,72L,72L,4368L,3458L,570L,210L,1260L,105L,112L,264L,231L,182L,156L,6L,372L,7068L,589L,744L,1764L,1323L,180L,15L,15L,6L,72L,6L,70L };
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
public class A083538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083538Inst : IEnumerable<long>
{
public static readonly long[] Value=A083538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083538.Bytes);
public long this[int i]=>Value[i];

public static A083538Inst Instance=new A083538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083537
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,1L,1L,3L,0L,1L,2L,2L,0L,2L,1L,4L,1L,1L,3L,2L,0L,3L,1L,3L,2L,1L,2L,3L,0L,2L,2L,5L,1L,2L,4L,2L,1L,4L,1L,3L,3L,1L,2L,4L,0L,2L,3L,4L,1L,3L,3L,2L,2L,3L,1L,4L,2L,1L,3L,3L,0L,3L,2L,6L,2L,2L,5L,3L,1L,5L,2L,3L,4L,2L,2L,5L,1L,2L,4L,4L,1L,4L,3L,2L,3L,3L,1L,5L,2L,1L,4L,3L };
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
public class A083537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083537Inst : IEnumerable<long>
{
public static readonly long[] Value=A083537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083537.Bytes);
public long this[int i]=>Value[i];

public static A083537Inst Instance=new A083537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083536
{
public static readonly long[] Value={ 16L,8L,16L,2L,6L,28L,14L,16L,6L,8L,4L,12L,8L,16L,2L,14L,16L,4L,12L,4L,10L,12L,16L,6L,2L,6L,16L,2L,6L,12L,16L,14L,4L,2L,16L,4L,6L,14L,8L,10L,8L,24L,30L,4L,4L,8L,8L,28L,2L,12L,2L,2L,10L,8L,8L,4L,14L,4L,12L,30L,8L,16L,2L,14L,14L,6L,2L,10L,8L,16L,2L,6L,2L,14L,26L,6L,8L,8L,14L,10L,16L,8L,8L,22L,2L,28L };
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
public class A083536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083536Inst : IEnumerable<long>
{
public static readonly long[] Value=A083536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083536.Bytes);
public long this[int i]=>Value[i];

public static A083536Inst Instance=new A083536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083535
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,4L,6L,6L,6L,6L,8L,8L,11L,11L,11L,11L,14L,14L,17L,17L,17L,17L,20L,20L,20L,20L,20L,20L,23L,23L,27L,27L,27L,27L,27L,27L,30L,30L,30L,30L,34L,34L,38L,38L,38L,38L,41L,41L,41L,41L,41L,41L,45L,45L,45L,45L,45L,45L,50L,50L,54L,54L,54L,54L,54L,54L,58L,58L,58L,58L,62L,62L,66L,66L,66L,66L };
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
public class A083535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083535Inst : IEnumerable<long>
{
public static readonly long[] Value=A083535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083535.Bytes);
public long this[int i]=>Value[i];

public static A083535Inst Instance=new A083535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083534
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L };
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
public class A083534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083534Inst : IEnumerable<long>
{
public static readonly long[] Value=A083534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083534.Bytes);
public long this[int i]=>Value[i];

public static A083534Inst Instance=new A083534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083533
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,4L,2L,2L,2L,2L,4L,2L,2L,4L,4L,2L,2L,2L,2L,4L,2L,2L,2L,2L,4L,2L,4L,2L,6L,2L,2L,2L,4L,4L,4L,4L,2L,2L,2L,2L,2L,2L,4L,4L,6L,2L,2L,2L,4L,2L,2L,4L,4L,2L,6L,4L,2L,2L,2L,2L,4L,4L,2L,2L,4L,6L,2L,4L,2L,2L,4L,4L,2L,2L,4L,4L,2L,2L,2L,2L,4L,6L,2L,10L,2L,4L,4L,2L,2L,4L,2L,2L,4L,4L,2L,6L,4L,2L,2L,4L,6L,4L,2L,4L };
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
public class A083533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083533Inst : IEnumerable<long>
{
public static readonly long[] Value=A083533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083533.Bytes);
public long this[int i]=>Value[i];

public static A083533Inst Instance=new A083533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083532
{
public static readonly long[] Value={ 3L,4L,1L,1L,5L,1L,2L,2L,1L,1L,2L,1L,1L,2L,4L,1L,1L,2L,4L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,3L,1L,2L,3L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,3L,2L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,3L,1L,2L,4L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,1L,2L,1L };
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
public class A083532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083532Inst : IEnumerable<long>
{
public static readonly long[] Value=A083532.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083532.Bytes);
public long this[int i]=>Value[i];

public static A083532Inst Instance=new A083532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083531
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,4L,1L,1L,1L,3L,2L,4L,4L,2L,1L,1L,4L,2L,1L,1L,2L,2L,4L,6L,2L,1L,3L,2L,1L,5L,4L,2L,4L,2L,4L,6L,1L,2L,3L,2L,4L,2L,4L,2L,2L,2L,6L,1L,3L,2L,1L,1L,4L,1L,5L,2L,4L,6L,2L,4L,2L,2L,2L,2L,4L,3L,3L,2L,4L,2L,1L,3L,6L,2L,1L,3L,2L,4L,6L,2L,4L,1L,5L,2L,4L,2L,4L,6L,2L,6L,4L,3L,1L,2L,2L,4L,2L,4L,2L,6L,2L,2L,2L,4L,6L };
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
public class A083531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083531Inst : IEnumerable<long>
{
public static readonly long[] Value=A083531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083531.Bytes);
public long this[int i]=>Value[i];

public static A083531Inst Instance=new A083531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083530
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,7L,1L,1L,9L,7L,1L,7L,21L,13L,1L,7L,1L,7L,1L,7L,5L,7L,1L,7L,49L,1L,49L,7L,49L,7L,1L,13L,49L,63L,1L,7L,49L,31L,1L,7L,49L,7L,25L,37L,49L,7L,1L,49L,49L,37L,9L,7L,1L,43L,49L,1L,49L,7L,1L,7L,49L,91L,1L,37L,37L,7L,89L,67L,49L,7L,1L,7L,49L,43L,121L,105L,25L,7L,1L,1L,49L,7L,49L,147L,49L };
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
public class A083530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083530Inst : IEnumerable<long>
{
public static readonly long[] Value=A083530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083530.Bytes);
public long this[int i]=>Value[i];

public static A083530Inst Instance=new A083530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083529
{
public static readonly long[] Value={ 2L,1L,8L,1L,5L,1L,5L,1L,26L,25L,5L,1L,5L,25L,35L,1L,5L,1L,5L,25L,62L,25L,5L,1L,50L,25L,80L,37L,5L,55L,5L,1L,26L,25L,80L,1L,5L,25L,8L,25L,5L,1L,5L,97L,80L,25L,5L,1L,68L,25L,125L,1L,5L,1L,155L,25L,125L,25L,5L,145L,5L,25L,188L,1L,5L,181L,5L,13L,125L,205L,5L,1L,5L,25L,125L,169L,80L,181L,5L };
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
public class A083529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083529Inst : IEnumerable<long>
{
public static readonly long[] Value=A083529.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083529.Bytes);
public long this[int i]=>Value[i];

public static A083529Inst Instance=new A083529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083528
{
public static readonly long[] Value={ 1L,1L,5L,1L,5L,1L,5L,1L,17L,5L,5L,1L,5L,25L,5L,1L,5L,1L,5L,25L,41L,25L,5L,1L,25L,25L,53L,9L,5L,25L,5L,1L,59L,25L,45L,1L,5L,25L,47L,65L,5L,1L,5L,9L,35L,25L,5L,1L,19L,25L,23L,1L,5L,1L,45L,81L,11L,25L,5L,25L,5L,25L,125L,1L,5L,49L,5L,81L,125L,65L,5L,1L,5L,25L,125L,17L,3L,25L,5L,65L,161L,25L,5L,1L,65L };
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
public class A083528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083528Inst : IEnumerable<long>
{
public static readonly long[] Value=A083528.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083528.Bytes);
public long this[int i]=>Value[i];

public static A083528Inst Instance=new A083528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083527
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,5L,0L,0L,43L,57L,0L,0L,239L,430L,0L,0L,2904L,5419L,0L,0L,27813L,50213L,0L,0L,348082L,649300L,0L,0L,3913496L,7287183L,0L,0L,50030553L,93696497L,0L,0L,611793542L,1161079907L,0L,0L,8009933135L,15176652567L,0L,0L };
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
public class A083527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083527Inst : IEnumerable<long>
{
public static readonly long[] Value=A083527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083527.Bytes);
public long this[int i]=>Value[i];

public static A083527Inst Instance=new A083527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083526
{
public static readonly long[] Value={ 1469L,9641L,13273L,14339L,15613L,15769L,15899L,16913L,31651L,31961L,34193L,37231L,39143L,39299L,93341L,96751L,99293L,99851L,115373L,124639L,135713L,143039L,157469L,159913L,317531L,319951L,341093L,373511L,390143L,392899L,930341L,936421L,964751L };
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
public class A083526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083526Inst : IEnumerable<long>
{
public static readonly long[] Value=A083526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083526.Bytes);
public long this[int i]=>Value[i];

public static A083526Inst Instance=new A083526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083525
{
public static readonly long[] Value={ 1L,3L,6L,24L,29L,174L,181L,1448L,13032L,130320L,130331L,1563972L,1563985L,21895790L,328436850L,5254989600L,5254989617L,94589813106L,94589813125L,1891796262500L,39727721512500L,874009873275000L,874009873275023L,20976236958600552L };
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
public class A083525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083525Inst : IEnumerable<long>
{
public static readonly long[] Value=A083525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083525.Bytes);
public long this[int i]=>Value[i];

public static A083525Inst Instance=new A083525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083524
{
public static readonly long[] Value={ 1L,2L,6L,10L,50L,56L,392L,400L,409L,419L,4609L,4621L,60073L,60087L,60102L,60118L,1022006L,1022024L,19418456L,19418476L,19418497L,19418519L,446625937L,446625961L,446625986L,446626012L,446626039L,446626067L,12952155943L };
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
public class A083524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083524Inst : IEnumerable<long>
{
public static readonly long[] Value=A083524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083524.Bytes);
public long this[int i]=>Value[i];

public static A083524Inst Instance=new A083524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083507
{
public static readonly long[] Value={ 6L,6L,8L,12L,24L,6L,8L,10L,12L,15L,20L,24L,30L,40L,60L,6L,8L,10L,12L,15L,18L,20L,24L,30L,36L,40L,48L,60L,72L,90L,120L,6L,8L,10L,12L,14L,15L,18L,20L,21L,24L,28L,30L,35L,36L,40L,42L,48L,56L,60L,70L,72L,84L,90L,105L,120L,126L,140L,168L,210L,6L,8L,10L,12L,14L,15L,16L,18L,20L,21L,24L,28L };
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
public class A083507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083507Inst : IEnumerable<long>
{
public static readonly long[] Value=A083507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083507.Bytes);
public long this[int i]=>Value[i];

public static A083507Inst Instance=new A083507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083506
{
public static readonly long[] Value={ 2L,2L,3L,6L,2L,3L,4L,6L,8L,12L,2L,3L,4L,5L,6L,8L,10L,12L,15L,20L,2L,3L,4L,5L,6L,8L,10L,12L,15L,18L,20L,24L,30L,2L,3L,4L,5L,6L,7L,8L,10L,12L,14L,15L,18L,20L,21L,24L,28L,30L,35L,42L,2L,3L,4L,5L,6L,7L,8L,10L,12L,14L,15L,16L,18L,20L,21L,24L,28L,30L,32L,35L,40L,42L,48L,56L,2L,3L,4L,5L,6L,7L,8L,9L };
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
public class A083506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083506Inst : IEnumerable<long>
{
public static readonly long[] Value=A083506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083506.Bytes);
public long this[int i]=>Value[i];

public static A083506Inst Instance=new A083506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083505
{
public static readonly long[] Value={ 1L,3L,6L,10L,14L };
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
public class A083505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083505Inst : IEnumerable<long>
{
public static readonly long[] Value=A083505.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083505.Bytes);
public long this[int i]=>Value[i];

public static A083505Inst Instance=new A083505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083504
{
public static readonly long[] Value={ 4L,8L,24L,12L,40L,80L,16L,56L,120L,200L,20L,72L,160L,280L,420L,24L,88L,200L,360L,560L,784L,28L,104L,240L,440L,700L,1008L,1344L,32L,120L,280L,520L,840L,1232L,1680L,2160L,36L,136L,320L,600L,980L,1456L,2016L,2640L,3300L,40L,152L,360L,680L,1120L,1680L,2352L,3120L };
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
public class A083504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083504Inst : IEnumerable<long>
{
public static readonly long[] Value=A083504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083504.Bytes);
public long this[int i]=>Value[i];

public static A083504Inst Instance=new A083504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083503
{
public static readonly long[] Value={ 3L,3L,4L,3L,6L,5L,8L,3L,4L,9L,12L,5L,14L,13L,16L,3L,18L,5L,20L,3L,4L,21L,24L,5L,6L,25L,4L,13L,30L,11L,32L,3L,34L,33L,36L,5L,38L,37L,16L,3L,42L,5L,44L,21L,16L,45L,48L,5L,8L,9L,52L,5L,54L,5L,16L,13L,7L,57L,60L,7L,62L,61L,4L,3L,66L,23L,68L,13L,70L,29L,72L,5L,74L,73L,16L,37L,78L,17L,80L,3L,4L };
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
public class A083503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083503Inst : IEnumerable<long>
{
public static readonly long[] Value=A083503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083503.Bytes);
public long this[int i]=>Value[i];

public static A083503Inst Instance=new A083503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083502
{
public static readonly BigInteger[] Value={ 1L,2L,18L,16L,1550L,2598L,299586L,812L,29118L,348678430L,67546215506L,20345040L,61054982557998L,281241170407078L,76861433640456450L,2690404L,BigInteger.Parse("128583032925805678334"),211927625850L,BigInteger.Parse("275941052631578947368402"),174339200L };
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
public class A083502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083502.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083502Inst Instance=new A083502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083501
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,4L,9L,7L,11L,12L,13L,9L,9L,16L,17L,18L,7L,11L,21L,16L,23L,24L,25L,26L,9L,10L,25L,30L,31L,25L,33L,34L,35L,11L,13L,26L,39L,16L,41L,42L,25L,36L,45L,16L,47L,48L,49L,18L,51L,52L,29L,54L,19L,56L,25L,49L,59L,60L,61L,47L,25L,16L,65L,61L,67L,29L,69L,70L,51L,72L,25L,64L,47L };
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
public class A083501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083501Inst : IEnumerable<long>
{
public static readonly long[] Value=A083501.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083501.Bytes);
public long this[int i]=>Value[i];

public static A083501Inst Instance=new A083501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083500
{
public static readonly long[] Value={ 6L,11L,18L,27L,38L,51L,2L,83L,29L,123L,146L,171L,43L,38L,258L,291L,326L,1L,51L,443L,174L,531L,578L,627L,678L,2L,10L,530L,902L,963L,473L,1091L,1158L,1227L,3L,25L,438L,1523L,66L,1683L,1766L,330L,1042L,2027L,46L,2211L,2306L,2403L,70L,2603L,2706L,417L,2918L,73L };
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
public class A083500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083500Inst : IEnumerable<long>
{
public static readonly long[] Value=A083500.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083500.Bytes);
public long this[int i]=>Value[i];

public static A083500Inst Instance=new A083500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083499
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,4L,5L,2L,3L,3L,2L,3L,4L,5L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,4L,2L,2L,3L,2L,3L,2L,2L,4L,6L,2L,5L,2L,3L,2L,3L,2L,2L,3L,2L,6L,3L,4L,3L,4L,3L,5L,3L,4L,3L,4L,2L,4L,3L,8L,4L,6L,3L,4L,5L,3L,2L,6L,5L,2L,4L,2L,3L,4L,8L,3L,2L,3L,7L,4L,2L,3L,2L,3L,2L,4L,2L,4L,2L,5L,3L,2L,5L,2L,4L,2L,23L,3L,11L,2L,5L,2L,3L,4L,5L,2L,5L,2L,3L,2L,3L,2L,3L,6L,2L,5L,2L,5L,2L,3L,4L,7L,2L,3L,2L,6L,7L };
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
public class A083499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083499Inst : IEnumerable<long>
{
public static readonly long[] Value=A083499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083499.Bytes);
public long this[int i]=>Value[i];

public static A083499Inst Instance=new A083499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083498
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,24L,35L,16L,27L,30L,22L,36L,52L,70L,45L,32L,51L,36L,57L,40L,63L,44L,69L,48L,50L,78L,54L,112L,58L,60L,93L,64L,99L,68L,70L,144L,222L,76L,195L,80L,123L,84L,129L,88L,90L,138L,94L,288L,147L,200L,153L,208L,159L,270L,165L,224L,171L,232L,118L,240L,183L,496L,252L,384L };
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
public class A083498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083498Inst : IEnumerable<long>
{
public static readonly long[] Value=A083498.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083498.Bytes);
public long this[int i]=>Value[i];

public static A083498Inst Instance=new A083498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083497
{
public static readonly long[] Value={ 9L,18L,27L,36L,45L,63L,72L,81L,90L,117L,225L,306L,414L,522L,603L,711L,828L,900L,1116L,2007L,3114L,5022L,6111L,7002L,8118L,9000L,11115L,20007L,31113L,40005L,61119L,70002L,81135L,90000L,111114L,200007L,311139L,400005L,611118L,700002L,811116L,900000L };
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
public class A083497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083497Inst : IEnumerable<long>
{
public static readonly long[] Value=A083497.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083497.Bytes);
public long this[int i]=>Value[i];

public static A083497Inst Instance=new A083497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083496
{
public static readonly long[] Value={ 8L,16L,24L,56L,72L,80L,96L,104L,232L,400L,512L,600L,712L,800L,912L,3000L,4112L,5000L,6112L,7000L,8112L,9000L,11112L,30000L,41112L,50000L,61112L,70000L,81112L,90000L,111112L,300000L,411112L,500000L,611112L,700000L,811112L,900000L,1111112L };
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
public class A083496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083496Inst : IEnumerable<long>
{
public static readonly long[] Value=A083496.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083496.Bytes);
public long this[int i]=>Value[i];

public static A083496Inst Instance=new A083496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083495
{
public static readonly long[] Value={ 7L,14L,28L,35L,42L,56L,70L,84L,91L,203L,441L,525L,609L,714L,805L,917L,2002L,3115L,4004L,5117L,6006L,7112L,8008L,9114L,20006L,31115L,40026L,51135L,60004L,71113L,80024L,91119L,200004L,311115L,400008L,511112L,600033L,711144L,800002L,911113L,2000005L };
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
public class A083495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083495Inst : IEnumerable<long>
{
public static readonly long[] Value=A083495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083495.Bytes);
public long this[int i]=>Value[i];

public static A083495Inst Instance=new A083495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083494
{
public static readonly long[] Value={ 6L,12L,30L,42L,60L,72L,84L,90L,114L,222L,300L,414L,522L,600L,714L,822L,900L,1116L,2004L,3138L,4002L,5118L,6000L,7122L,8004L,9126L,30000L,41112L,50058L,61116L,70002L,81114L,90000L,111114L,200022L,311118L,400002L,511116L,700002L,811116L,900000L,1111116L };
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
public class A083494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083494Inst : IEnumerable<long>
{
public static readonly long[] Value=A083494.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083494.Bytes);
public long this[int i]=>Value[i];

public static A083494Inst Instance=new A083494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083493
{
public static readonly long[] Value={ 5L,10L,25L,30L,45L,60L,75L,80L,95L,100L,225L,300L,415L,600L,715L,800L,915L,2000L,3115L,4000L,5115L,6000L,7115L,8000L,9115L,20000L,31115L,40000L,51115L,60000L,71115L,80000L,91115L,200000L,311115L,400000L,511115L,600000L,711115L,800000L,911115L };
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
public class A083493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083493Inst : IEnumerable<long>
{
public static readonly long[] Value=A083493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083493.Bytes);
public long this[int i]=>Value[i];

public static A083493Inst Instance=new A083493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083492
{
public static readonly long[] Value={ 4L,8L,12L,36L,40L,52L,60L,72L,80L,92L,100L,224L,300L,412L,500L,612L,700L,812L,900L,1112L,3000L,4112L,5000L,6112L,7000L,8112L,9000L,11112L,30000L,41112L,50000L,61112L,70000L,81112L,90000L,111112L,300000L,411112L,500000L,611112L,700000L,811112L,900000L };
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
public class A083492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083492Inst : IEnumerable<long>
{
public static readonly long[] Value=A083492.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083492.Bytes);
public long this[int i]=>Value[i];

public static A083492Inst Instance=new A083492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083379
{
public static readonly long[] Value={ 1L,2L,7L,20L,62L,193L,608L,1918L,6061L,19160L,60582L,191568L,605782L,1915640L,6057776L,19156359L,60577716L,191563545L,605777108L,1915635402L };
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
public class A083379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083379Inst : IEnumerable<long>
{
public static readonly long[] Value=A083379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083379.Bytes);
public long this[int i]=>Value[i];

public static A083379Inst Instance=new A083379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083378
{
public static readonly long[] Value={ 1L,2L,5L,12L,27L,58L,125L,271L,584L,1259L,2714L,5848L,12599L,27144L,58480L,125992L,271441L,584803L,1259921L,2714417L,5848035L,12599210L,27144176L,58480354L,125992104L,271441761L,584803547L,1259921049L,2714417616L,5848035476L };
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
public class A083378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083378Inst : IEnumerable<long>
{
public static readonly long[] Value=A083378.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083378.Bytes);
public long this[int i]=>Value[i];

public static A083378Inst Instance=new A083378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083377
{
public static readonly long[] Value={ 1L,4L,14L,44L,141L,447L,1414L,4472L,14142L,44721L,141421L,447213L,1414213L,4472135L,14142135L,44721359L,141421356L,447213595L,1414213562L,4472135954L,14142135623L,44721359549L,141421356237L,447213595499L,1414213562373L,4472135954999L };
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
public class A083377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083377Inst : IEnumerable<long>
{
public static readonly long[] Value=A083377.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083377.Bytes);
public long this[int i]=>Value[i];

public static A083377Inst Instance=new A083377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083376
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,9L,18L,23L,27L,63L,105L,164L,189L,214L,1467L };
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
public class A083376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083376Inst : IEnumerable<long>
{
public static readonly long[] Value=A083376.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083376.Bytes);
public long this[int i]=>Value[i];

public static A083376Inst Instance=new A083376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083375
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
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
public class A083375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083375Inst : IEnumerable<long>
{
public static readonly long[] Value=A083375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083375.Bytes);
public long this[int i]=>Value[i];

public static A083375Inst Instance=new A083375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083374
{
public static readonly long[] Value={ 0L,6L,36L,120L,300L,630L,1176L,2016L,3240L,4950L,7260L,10296L,14196L,19110L,25200L,32640L,41616L,52326L,64980L,79800L,97020L,116886L,139656L,165600L,195000L,228150L,265356L,306936L,353220L,404550L,461280L,523776L,592416L,667590L,749700L,839160L,936396L };
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
public class A083374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083374Inst : IEnumerable<long>
{
public static readonly long[] Value=A083374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083374.Bytes);
public long this[int i]=>Value[i];

public static A083374Inst Instance=new A083374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083373
{
public static readonly long[] Value={ 6L,37L,1212L,1530L,5055L,37680L,98918163L,149308749L,250094358L };
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
public class A083373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083373Inst : IEnumerable<long>
{
public static readonly long[] Value=A083373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083373.Bytes);
public long this[int i]=>Value[i];

public static A083373Inst Instance=new A083373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083372
{
public static readonly long[] Value={ 15L,21L,55L,33L,39L,85L,51L,57L,115L,69L,203L,145L,87L,93L,259L,185L,111L,205L,123L,129L,235L,141L,371L,265L,159L,413L,295L,177L,183L,469L,335L,201L,355L,213L,219L,553L,395L,237L,415L,249L,623L,445L,267L,1313L,679L,485L,291L,505L,303L,309L,535L,321L,327L,565L };
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
public class A083372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083372Inst : IEnumerable<long>
{
public static readonly long[] Value=A083372.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083372.Bytes);
public long this[int i]=>Value[i];

public static A083372Inst Instance=new A083372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083371
{
public static readonly long[] Value={ 89L,113L,139L,181L,199L,211L,241L,283L,293L,317L,337L,359L,389L,401L,409L,421L,449L,467L,479L,491L,509L,523L,547L,577L,619L,631L,661L,683L,691L,701L,709L,719L,743L,761L,773L,787L,797L,811L,829L,839L,863L,887L,911L,919L,929L,953L,983L,997L,1021L,1039L,1051L,1069L };
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
public class A083371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083371Inst : IEnumerable<long>
{
public static readonly long[] Value=A083371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083371.Bytes);
public long this[int i]=>Value[i];

public static A083371Inst Instance=new A083371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083370
{
public static readonly long[] Value={ 23L,31L,47L,53L,61L,73L,83L,89L,113L,131L,139L,151L,157L,167L,173L,181L,199L,211L,233L,241L,251L,257L,263L,271L,283L,293L,317L,331L,337L,353L,359L,367L,373L,383L,389L,401L,409L,421L,433L,443L,449L,467L,479L,491L };
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
public class A083370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083370Inst : IEnumerable<long>
{
public static readonly long[] Value=A083370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083370.Bytes);
public long this[int i]=>Value[i];

public static A083370Inst Instance=new A083370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083369
{
public static readonly long[] Value={ 1L,2L,3L,7L,43L,139L,50207L,340999L,2365347734339L,4680225641471129L,1368845206580129L };
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
public class A083369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083369Inst : IEnumerable<long>
{
public static readonly long[] Value=A083369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083369.Bytes);
public long this[int i]=>Value[i];

public static A083369Inst Instance=new A083369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083368
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,1L,3L,2L,1L,5L,2L,1L,4L,1L,3L,2L,1L,6L,1L,3L,2L,1L,5L,2L,1L,4L,1L,3L,2L,1L,7L,2L,1L,4L,1L,3L,2L,1L,6L,1L,3L,2L,1L,5L,2L,1L,4L,1L,3L,2L,1L,8L,1L,3L,2L,1L,5L,2L,1L,4L,1L,3L,2L,1L,7L,2L,1L,4L,1L,3L,2L,1L,6L,1L,3L,2L,1L,5L,2L,1L,4L,1L,3L,2L,1L,9L,2L,1L,4L,1L,3L,2L,1L,6L,1L,3L,2L,1L,5L,2L };
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
public class A083368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083368Inst : IEnumerable<long>
{
public static readonly long[] Value=A083368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083368.Bytes);
public long this[int i]=>Value[i];

public static A083368Inst Instance=new A083368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083367
{
public static readonly long[] Value={ 1L,60L,1959L,149587L,277947L,1449933L,2222863L,2396214L,24918486L,25354845L,48878262L,1673533845L,24753647943L };
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
public class A083367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083367Inst : IEnumerable<long>
{
public static readonly long[] Value=A083367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083367.Bytes);
public long this[int i]=>Value[i];

public static A083367Inst Instance=new A083367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083366
{
public static readonly long[] Value={ 1L,3L,5L,9L,23L,65L,95L,129L,161L,341L,439L,771L,819L,1031L,1099L,1443L,1923L,5793L };
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
public class A083366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083366Inst : IEnumerable<long>
{
public static readonly long[] Value=A083366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083366.Bytes);
public long this[int i]=>Value[i];

public static A083366Inst Instance=new A083366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083365
{
public static readonly long[] Value={ 1L,-1L,2L,-3L,4L,-6L,9L,-12L,16L,-22L,29L,-38L,50L,-64L,82L,-105L,132L,-166L,208L,-258L,320L,-395L,484L,-592L,722L,-876L,1060L,-1280L,1539L,-1846L,2210L,-2636L,3138L,-3728L,4416L,-5222L,6163L,-7256L,8528L,-10006L,11716L,-13696L,15986L,-18624L,21666L,-25169L,29190L,-33808L,39104L };
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
public class A083365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083365Inst : IEnumerable<long>
{
public static readonly long[] Value=A083365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083365.Bytes);
public long this[int i]=>Value[i];

public static A083365Inst Instance=new A083365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083364
{
public static readonly long[] Value={ 1L,5L,17L,32L,71L,105L,187L,248L,389L,485L,701L,840L,1147L,1337L,1751L,2000L,2537L,2853L,3529L,3920L,4751L,5225L,6227L,6792L,7981L,8645L,10037L,10808L,12419L,13305L,15151L,16160L,18257L,19397L,21761L,23040L,25687L,27113L,30059L,31640L,34901L,36645L };
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
public class A083364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083364Inst : IEnumerable<long>
{
public static readonly long[] Value=A083364.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083364.Bytes);
public long this[int i]=>Value[i];

public static A083364Inst Instance=new A083364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083299
{
public static readonly long[] Value={ 1L,4L,32L,160L,1088L,6016L,38144L,220672L,1356800L,8009728L,48582656L,289398784L,1744781312L,10435133440L,62745018368L,375933239296L,2257746919424L,13537891581952L,81261709230080L,487432816427008L,2925146654375936L };
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
public class A083299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083299Inst : IEnumerable<long>
{
public static readonly long[] Value=A083299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083299.Bytes);
public long this[int i]=>Value[i];

public static A083299Inst Instance=new A083299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083298
{
public static readonly long[] Value={ 1L,3L,25L,75L,625L,1875L,15625L,46875L,390625L,1171875L,9765625L,29296875L };
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
public class A083298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083298Inst : IEnumerable<long>
{
public static readonly long[] Value=A083298.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083298.Bytes);
public long this[int i]=>Value[i];

public static A083298Inst Instance=new A083298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083297
{
public static readonly long[] Value={ 1L,2L,20L,8L,464L,-736L,12608L,-42880L,388352L,-1805824L,12932096L,-69203968L,448778240L,-2558451712L,15887581184L,-93178003456L,567657955328L,-3371587993600L,20366966915072L,-121652045676544L,732111297314816L,-4383871690866688L,26338414517288960L };
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
public class A083297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083297Inst : IEnumerable<long>
{
public static readonly long[] Value=A083297.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083297.Bytes);
public long this[int i]=>Value[i];

public static A083297Inst Instance=new A083297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083296
{
public static readonly long[] Value={ 1L,1L,17L,-47L,545L,-3167L,24113L,-162959L,1158209L,-8054975L,56542289L,-395323631L,2768682593L,-19376526623L,135648440945L,-949500822863L,6646620551297L,-46525999485311L,325683029518481L,-2279778107265455L,15958456048949921L,-111709164448374239L };
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
public class A083296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083296Inst : IEnumerable<long>
{
public static readonly long[] Value=A083296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083296.Bytes);
public long this[int i]=>Value[i];

public static A083296Inst Instance=new A083296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083295
{
public static readonly long[] Value={ 1L,0L,16L,-96L,832L,-6528L,52480L,-419328L,3355648L,-26843136L,214749184L,-1717985280L,13743898624L,-109951156224L,879609315328L,-7036874391552L,56294995394560L,-450359962632192L,3602879702106112L,-28823037614751744L,230584300922208256L };
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
public class A083295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083295Inst : IEnumerable<long>
{
public static readonly long[] Value=A083295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083295.Bytes);
public long this[int i]=>Value[i];

public static A083295Inst Instance=new A083295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083294
{
public static readonly long[] Value={ 1L,-1L,17L,-145L,1313L,-11809L,106289L,-956593L,8609345L,-77484097L,697356881L,-6276211921L,56485907297L,-508373165665L,4575358490993L,-41178226418929L,370604037770369L,-3335436339933313L,30018927059399825L,-270170343534598417L,2431533091811385761L };
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
public class A083294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083294Inst : IEnumerable<long>
{
public static readonly long[] Value=A083294.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083294.Bytes);
public long this[int i]=>Value[i];

public static A083294Inst Instance=new A083294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083293
{
public static readonly long[] Value={ 2L,1L,1L,4L,3L,8L,2L,5L,15L,10L,5L,10L,19L,4L,20L,23L,17L,3L,5L,12L,0L,33L,23L,22L,35L,3L,20L,12L,15L,22L,51L,9L,29L,19L,7L,17L,56L,37L,31L,76L,24L,47L,30L,59L,59L,66L,34L,18L,12L,5L,10L,69L,62L,21L,65L,55L,37L,102L,79L,36L,91L,47L,2L,123L,46L,117L,10L,49L,28L,4L,57L,31L,38L,22L,99L };
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
public class A083293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083293Inst : IEnumerable<long>
{
public static readonly long[] Value=A083293.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083293.Bytes);
public long this[int i]=>Value[i];

public static A083293Inst Instance=new A083293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083292
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,40L,43L,46L,49L,52L,55L,58L,61L,64L,67L,90L,94L,98L,102L,106L,110L,114L,118L,122L,126L,160L,165L,170L,175L,180L,185L,190L,195L,200L,205L,250L,256L,262L,268L,274L,280L,286L,292L,298L,304L,360L,367L,374L };
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
public class A083292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083292Inst : IEnumerable<long>
{
public static readonly long[] Value=A083292.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083292.Bytes);
public long this[int i]=>Value[i];

public static A083292Inst Instance=new A083292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083291
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,3L,4L,5L,6L,7L,8L,9L,10L,11L };
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
public class A083291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083291Inst : IEnumerable<long>
{
public static readonly long[] Value=A083291.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083291.Bytes);
public long this[int i]=>Value[i];

public static A083291Inst Instance=new A083291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083290
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,3L,2L,3L,2L,7L,2L,9L,3L,4L,5L,16L,3L,20L,4L,8L,7L,31L,5L,22L,9L,18L,9L,54L,4L };
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
public class A083290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083290Inst : IEnumerable<long>
{
public static readonly long[] Value=A083290.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083290.Bytes);
public long this[int i]=>Value[i];

public static A083290Inst Instance=new A083290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083289
{
public static readonly long[] Value={ 3L,0L,21L,3L,201L,13L,18081L,43L,140049L,81L,600009L,147L,6000009L,73L,380000361L,3L,1400000049L,831L,14000000049L,49L,380000000361L,987L,600000000009L,691L,78000000001521L,183L,740000000001369L,4153L,6200000000000961L,279L };
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
public class A083289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083289Inst : IEnumerable<long>
{
public static readonly long[] Value=A083289.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083289.Bytes);
public long this[int i]=>Value[i];

public static A083289Inst Instance=new A083289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083288
{
public static readonly long[] Value={ 1L,2L,9L,15L,18L,21L,40L,42L,60L,104L,120L,288L,312L,756L,1023L,1170L,2160L,2520L,3024L,4092L,6048L,6552L,8184L,17850L,18720L,29127L,30690L,40768L,58254L,79794L,147312L };
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
public class A083288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083288Inst : IEnumerable<long>
{
public static readonly long[] Value=A083288.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083288.Bytes);
public long this[int i]=>Value[i];

public static A083288Inst Instance=new A083288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083287
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,5L,10L,19L,1L,4L,4L,4L,3L,10L,1L,42L,2L,23L,33L,1L,4L,7L,1L,12L,1L,1L,2L,9L,2L,11L,3L,4L,1L,1L,3L,2L,4L,25L,3L,1L,16L,5L,10L,1L,1L,1L,3L,1L,1L,1L,3L,2L,2L,1L,1L,1L,2L,3L,2L,1L,3L,4L,3L,1L,1L,117L,2L,1L,12L,4L,1L,4L,3L,3L,15L,1L,5L,16L,7L,2L,7L,21L,1L,3L,1L,2L,2L,2L,1L,1L,1L,1L };
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
public class A083287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083287Inst : IEnumerable<long>
{
public static readonly long[] Value=A083287.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083287.Bytes);
public long this[int i]=>Value[i];

public static A083287Inst Instance=new A083287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083286
{
public static readonly long[] Value={ 1L,6L,2L,2L,2L,7L,0L,5L,0L,2L,8L,8L,4L,7L,6L,7L,3L,1L,5L,9L,5L,6L,9L,5L,0L,9L,8L,2L,8L,9L,9L,3L,2L,4L,1L,1L,3L,0L,6L,6L,1L,0L,5L,5L,6L,2L,3L,1L,3L,0L,3L,7L,4L,3L,2L,1L,8L,5L,4L,4L,3L,3L,8L,7L,3L,7L,8L,4L,3L,3L,9L,9L,9L,7L,2L,7L,4L,8L,4L,4L,7L,6L,3L,8L,3L,6L,1L,6L,5L,3L,9L,8L,3L,3L,2L,3L,3L,4L,1L,1L,0L,0L };
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
public class A083286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083286Inst : IEnumerable<long>
{
public static readonly long[] Value=A083286.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083286.Bytes);
public long this[int i]=>Value[i];

public static A083286Inst Instance=new A083286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083285
{
public static readonly long[] Value={ 6L,10L,21L,319L,403L,529L,667L,799L,1003L,1513L,1537L,2623L,2809L,4183L,16459L,23707L,24613L,31309L,34117L,35179L,35653L,37399L,37669L,39913L,40723L,43357L,46243L,46513L,49183L,50689L,53293L,55417L,55747L,56257L,59287L,60547L,61069L,61093L };
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
public class A083285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083285Inst : IEnumerable<long>
{
public static readonly long[] Value=A083285.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083285.Bytes);
public long this[int i]=>Value[i];

public static A083285Inst Instance=new A083285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083284
{
public static readonly long[] Value={ 4L,527L,779L,869L,899L,1079L,1157L,1271L,1679L,4187L,6497L,6887L,24287L,24881L,25019L,29591L,35237L,37127L,37769L,38807L,39269L,39911L,41309L,43361L,44831L,45347L,46001L,46127L,47261L,48509L,48929L,51809L,52907L,54389L,55481L,55751L,55961L };
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
public class A083284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083284Inst : IEnumerable<long>
{
public static readonly long[] Value=A083284.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083284.Bytes);
public long this[int i]=>Value[i];

public static A083284Inst Instance=new A083284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083251
{
public static readonly long[] Value={ 2L,48L,72L,80L,112L,176L,208L,272L,304L,368L,464L,496L,592L,656L,688L,752L,848L,944L,976L,1072L,1136L,1168L,1264L,1328L,1424L,1552L,1616L,1648L,1712L,1744L,1808L,2032L,2096L,2192L,2224L,2384L,2416L,2512L,2608L,2672L,2768L,2864L,2896L };
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
public class A083251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083251Inst : IEnumerable<long>
{
public static readonly long[] Value=A083251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083251.Bytes);
public long this[int i]=>Value[i];

public static A083251Inst Instance=new A083251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083250
{
public static readonly long[] Value={ 3L,825L,1755L,4641L,5313L,56865L,58395L,140049L };
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
public class A083250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083250Inst : IEnumerable<long>
{
public static readonly long[] Value=A083250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083250.Bytes);
public long this[int i]=>Value[i];

public static A083250Inst Instance=new A083250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083249
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,16L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L };
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
public class A083249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083249Inst : IEnumerable<long>
{
public static readonly long[] Value=A083249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083249.Bytes);
public long this[int i]=>Value[i];

public static A083249Inst Instance=new A083249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083248
{
public static readonly long[] Value={ 36L,40L,42L,48L,50L,54L,56L,60L,66L,70L,72L,78L,80L,84L,88L,90L,96L,98L,100L,102L,104L,105L,108L,110L,112L,114L,120L,126L,130L,132L,136L,138L,140L,144L,150L,152L,154L,156L,160L,162L,168L,170L,174L,176L,180L,182L,184L,186L,190L,192L,196L,198L,200L,204L,208L,210L };
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
public class A083248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083248Inst : IEnumerable<long>
{
public static readonly long[] Value=A083248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083248.Bytes);
public long this[int i]=>Value[i];

public static A083248Inst Instance=new A083248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083247
{
public static readonly long[] Value={ 14L,20L,21L,22L,26L,27L,28L,32L,33L,34L,35L,38L,39L,44L,45L,46L,49L,51L,52L,55L,57L,58L,62L,63L,64L,65L,68L,69L,74L,75L,76L,77L,81L,82L,85L,86L,87L,91L,92L,93L,94L,95L,99L,106L,111L,115L,116L,117L,118L,119L,121L,122L,123L,124L,125L,128L,129L,133L,134L,135L,141L,142L };
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
public class A083247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083247Inst : IEnumerable<long>
{
public static readonly long[] Value=A083247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083247.Bytes);
public long this[int i]=>Value[i];

public static A083247Inst Instance=new A083247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083246
{
public static readonly long[] Value={ 1L,3L,8L,10L,15L,18L,24L,25L,30L,50L,61455L };
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
public class A083246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083246Inst : IEnumerable<long>
{
public static readonly long[] Value=A083246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083246.Bytes);
public long this[int i]=>Value[i];

public static A083246Inst Instance=new A083246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083245
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,4L,7L,6L,7L,4L,11L,6L,13L,4L,7L,8L,17L,4L,19L,6L,9L,4L,23L,6L,19L,4L,15L,6L,29L,0L,31L,10L,13L,4L,19L,4L,37L,4L,15L,6L,41L,-4L,43L,6L,13L,4L,47L,2L,39L,0L,19L,6L,53L,-4L,31L,6L,21L,4L,59L,-6L,61L,4L,19L,12L,37L,-12L,67L,6L,25L,-8L,71L,-2L,73L,4L,15L,6L,49L,-16L,79L,2L,35L,4L,83L,-14L,49L,4L,31L,6L,89L,-20L,59L,6L,33L,4L,55L,-10L,97L,-4L };
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
public class A083245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083245Inst : IEnumerable<long>
{
public static readonly long[] Value=A083245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083245.Bytes);
public long this[int i]=>Value[i];

public static A083245Inst Instance=new A083245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083244
{
public static readonly long[] Value={ 42L,54L,60L,66L,70L,72L,78L,84L,90L,96L,98L,100L,102L,108L,110L,114L,120L,126L,130L,132L,138L,140L,144L,150L,154L,156L,160L,162L,168L,170L,174L,180L,182L,186L,190L,192L,196L,198L,200L,204L,210L,216L,220L,222L,224L,228L,230L,234L,238L,240L,242L,246L,250L,252L };
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
public class A083244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083244Inst : IEnumerable<long>
{
public static readonly long[] Value=A083244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083244.Bytes);
public long this[int i]=>Value[i];

public static A083244Inst Instance=new A083244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083243
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,67L,68L,69L,71L,73L,74L,75L,76L,77L,79L };
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
public class A083243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083243Inst : IEnumerable<long>
{
public static readonly long[] Value=A083243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083243.Bytes);
public long this[int i]=>Value[i];

public static A083243Inst Instance=new A083243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083242
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,5L,3L,7L,4L,9L,9L,9L,10L,13L,11L,13L,16L,19L,13L,19L,20L,21L,19L,23L,26L,29L,23L,25L,30L,31L,27L,39L,34L,37L,29L,49L,36L,43L,35L,53L,42L,49L,37L,63L,44L,53L,39L,75L };
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
public class A083242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083242Inst : IEnumerable<long>
{
public static readonly long[] Value=A083242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083242.Bytes);
public long this[int i]=>Value[i];

public static A083242Inst Instance=new A083242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083241
{
public static readonly long[] Value={ 0L,0L,0L,5L,2L,4L,2L,9L,4L,8L,8L,11L,10L,12L,10L,15L,16L,18L,12L,21L,20L,20L,18L,25L,26L,28L,22L,27L,30L,30L,26L,41L,34L,36L,28L,51L,36L,42L,34L,55L,42L,48L,36L,65L,44L,52L,38L,77L,56L,56L,40L,81L,62L,58L,50L,87L,68L,64L,52L,93L,72L,66L };
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
public class A083241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083241Inst : IEnumerable<long>
{
public static readonly long[] Value=A083241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083241.Bytes);
public long this[int i]=>Value[i];

public static A083241Inst Instance=new A083241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083240
{
public static readonly long[] Value={ 37L,47L,163L,167L,647L,881L,1151L,1627L,3271L,5179L,5659L,11597L,13799L,18503L,31259L,43331L,44201L,76441L,163883L,277231L,391067L,402487L,630493L,643703L,809407L,985679L,1170311L,1326989L,1365799L,2113973L,2260631L,2273101L,2392939L,2662133L,2750431L };
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
public class A083240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083240Inst : IEnumerable<long>
{
public static readonly long[] Value=A083240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083240.Bytes);
public long this[int i]=>Value[i];

public static A083240Inst Instance=new A083240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083239
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,-1L,7L,-3L,9L,-5L,15L,-11L,23L,-17L,25L,-17L,33L,-27L,45L,-37L,49L,-39L,61L,-53L,73L,-61L,79L,-67L,95L,-87L,117L,-101L,121L,-105L,129L,-117L,153L,-135L,159L,-143L,183L,-171L,213L,-193L,217L,-195L,241L,-225L,267L,-247L,279L,-255L,307L,-289L,329L,-305L,341L,-313L,371L,-355L,415L,-385L,421L,-389L,437L,-417L };
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
public class A083239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083239Inst : IEnumerable<long>
{
public static readonly long[] Value=A083239.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083239.Bytes);
public long this[int i]=>Value[i];

public static A083239Inst Instance=new A083239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083238
{
public static readonly long[] Value={ 0L,3L,1L,6L,0L,12L,-4L,19L,-6L,24L,-12L,40L,-26L,50L,-26L,57L,-39L,78L,-58L,100L,-68L,104L,-80L,140L,-109L,151L,-111L,167L,-137L,209L,-177L,240L,-192L,246L,-198L,289L,-251L,311L,-255L,345L,-303L,399L,-355L,439L,-361L,433L,-385L,509L,-452L,545L,-473L,571L,-517L,637L,-565L,685L,-605L,695L,-635L,803L,-741L,837L,-733L,860L };
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
public class A083238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083238Inst : IEnumerable<long>
{
public static readonly long[] Value=A083238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083238.Bytes);
public long this[int i]=>Value[i];

public static A083238Inst Instance=new A083238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083237
{
public static readonly long[] Value={ -3L,6L,-1L,8L,3L,10L,7L,12L,11L,18L,13L,24L,17L,26L,21L,32L,27L,34L,33L,38L,35L,44L,39L,50L,47L,54L,49L,58L,51L,62L,65L,66L,71L,68L,81L,70L,87L,76L,91L,82L,97L,84L,107L,86L,111L,88L,123L,100L,127L,102L,131L,108L,133L,118L,139L,124L,145L,126L,151L,130L,153L,140L,167L,144L,169L,148L,183L,154L,193L,156L,197L,162L,205L,168L,211L,172L };
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
public class A083237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083237Inst : IEnumerable<long>
{
public static readonly long[] Value=A083237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083237.Bytes);
public long this[int i]=>Value[i];

public static A083237Inst Instance=new A083237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083236
{
public static readonly long[] Value={ 0L,3L,2L,5L,6L,7L,10L,9L,14L,15L,16L,21L,20L,23L,24L,29L,30L,31L,36L,35L,38L,41L,42L,47L,50L,51L,52L,55L,54L,59L,68L,63L,74L,65L,84L,67L,90L,73L,94L,79L,100L,81L,110L,83L,114L,85L,126L,97L,130L,99L,134L,105L,136L,115L,142L,121L,148L,123L,154L,127L,156L,137L,170L,141L,172L,145L };
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
public class A083236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083236Inst : IEnumerable<long>
{
public static readonly long[] Value=A083236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083236.Bytes);
public long this[int i]=>Value[i];

public static A083236Inst Instance=new A083236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083219
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,4L,5L,4L,5L,6L,7L,6L,7L,8L,9L,8L,9L,10L,11L,10L,11L,12L,13L,12L,13L,14L,15L,14L,15L,16L,17L,16L,17L,18L,19L,18L,19L,20L,21L,20L,21L,22L,23L,22L,23L,24L,25L,24L,25L,26L,27L,26L,27L,28L,29L,28L,29L,30L,31L,30L,31L,32L,33L,32L,33L,34L,35L,34L,35L,36L,37L,36L,37L,38L };
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
public class A083219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083219Inst : IEnumerable<long>
{
public static readonly long[] Value=A083219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083219.Bytes);
public long this[int i]=>Value[i];

public static A083219Inst Instance=new A083219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083218
{
public static readonly long[] Value={ 1L,2L,0L,4L,2L,6L,1L,0L,0L,10L,2L,12L,1L,2L,0L,16L,2L,18L,1L,0L,0L,22L,2L,0L,1L,2L,0L,28L,2L,30L,1L,0L,0L,4L,2L,36L,1L,2L,0L,40L,2L,42L,1L,0L,0L,46L,2L,0L,1L,2L,0L,52L,2L,0L,1L,0L,0L,58L,2L,60L,1L,2L,0L,4L,2L,66L,1L,0L,0L,70L,2L,72L,1L,2L,0L,4L,2L,78L,1L,0L,0L,82L,2L,0L,1L,2L,0L,88L,2L,2L,1L,0L,0L,4L,2L,96L };
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
public class A083218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083218Inst : IEnumerable<long>
{
public static readonly long[] Value=A083218.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083218.Bytes);
public long this[int i]=>Value[i];

public static A083218Inst Instance=new A083218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083217
{
public static readonly long[] Value={ 1L,3L,17L,83L,417L,2083L,10417L,52083L,260417L,1302083L,6510417L,32552083L,162760417L,813802083L,4069010417L,20345052083L,101725260417L,508626302083L,2543131510417L,12715657552083L,63578287760417L,317891438802083L };
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
public class A083217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083217Inst : IEnumerable<long>
{
public static readonly long[] Value=A083217.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083217.Bytes);
public long this[int i]=>Value[i];

public static A083217Inst Instance=new A083217Inst();

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