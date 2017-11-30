using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A023164
{
public static readonly long[] Value={ 1L,2L,8L,68L,92L,188L,212L,332L,428L,452L,548L,668L,692L,788L,908L,932L,1028L,1052L,1172L,1268L,1292L,1388L,1412L,1508L,1532L,1772L,1868L,2012L,2074L,2156L,2228L,2252L,2314L,2348L,2372L,2468L,2588L,2612L,2708L,2732L,2972L,3092L,3188L,3308L,3428L,3452L,3548L };
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
public class A023164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023164Inst : IEnumerable<long>
{
public static readonly long[] Value=A023164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023164.Bytes);
public long this[int i]=>Value[i];

public static A023164Inst Instance=new A023164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023165
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,15L,16L,35L,40L,64L,65L,85L,115L,160L,185L,215L,235L,265L,335L,365L,415L,485L,496L,515L,535L,565L,615L,635L,685L,785L,815L,835L,865L,965L,985L,1115L,1135L,1165L,1285L,1315L,1385L,1415L,1465L,1535L,1565L,1585L,1685L,1735L,1765L,1835L,1865L,1915L,1985L };
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
public class A023165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023165Inst : IEnumerable<long>
{
public static readonly long[] Value=A023165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023165.Bytes);
public long this[int i]=>Value[i];

public static A023165Inst Instance=new A023165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023166
{
public static readonly long[] Value={ 1L,7L,18L,42L,138L,162L,258L,282L,378L,402L,498L,594L,618L,642L,714L,762L,978L,1002L,1242L,1338L,1362L,1578L,1674L,1698L,1842L,1938L,2082L,2202L,2298L,2658L,2778L,2802L,2922L,3018L,3138L,3282L,3378L,3522L,3642L,3858L,3882L,4098L,4362L,4458L,4554L,4674L,4698L };
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
public class A023166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023166Inst : IEnumerable<long>
{
public static readonly long[] Value=A023166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023166.Bytes);
public long this[int i]=>Value[i];

public static A023166Inst Instance=new A023166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023167
{
public static readonly long[] Value={ 1L,2L,3L,4L,49L,161L,182L,511L,721L,959L,1169L,1631L,1841L,2191L,3199L,3409L,3521L,4319L,4529L,5089L,5201L,5761L,5999L,6209L,6559L,6671L,6769L,6881L,7231L,7441L,7679L,8351L,8561L,9121L,9569L,10031L,10129L,10801L,11249L,11599L,12271L,12481L,12929L,13391L };
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
public class A023167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023167Inst : IEnumerable<long>
{
public static readonly long[] Value=A023167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023167.Bytes);
public long this[int i]=>Value[i];

public static A023167Inst Instance=new A023167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023168
{
public static readonly long[] Value={ 1L,2L,4L,11L,16L,22L,112L,136L,184L,376L,424L,664L,682L,856L,904L,1096L,1288L,1336L,1384L,1576L,1816L,1864L,2056L,2104L,2344L,2536L,2584L,2776L,2824L,3016L,3064L,3472L,3544L,3736L,4024L,4402L,4456L,4504L,4696L,4744L,4936L,5176L,5224L,5332L,5416L,5464L,5944L };
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
public class A023168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023168Inst : IEnumerable<long>
{
public static readonly long[] Value=A023168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023168.Bytes);
public long this[int i]=>Value[i];

public static A023168Inst Instance=new A023168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023169
{
public static readonly long[] Value={ 1L,3L,6L,27L,78L,117L,294L,333L,387L,459L,477L,603L,747L,963L,1413L,1467L,1557L,1773L,2043L,2493L,2547L,2637L,2763L,2853L,3123L,3357L,3573L,3987L,4203L,4707L,4923L,5013L,5067L,5283L,5517L,5787L,5877L,6093L,6147L,6597L,6813L,6957L,7083L,7173L,7443L,7677L };
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
public class A023169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023169Inst : IEnumerable<long>
{
public static readonly long[] Value=A023169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023169.Bytes);
public long this[int i]=>Value[i];

public static A023169Inst Instance=new A023169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023170
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,20L,70L,110L,116L,130L,170L,230L,285L,322L,370L,430L,470L,494L,530L,555L,620L,670L,730L,770L,830L,970L,1030L,1070L,1130L,1270L,1334L,1370L,1570L,1630L,1670L,1730L,1930L,1970L,2230L,2270L,2330L,2530L,2570L,2630L,2770L,2830L,2870L,2930L,3070L };
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
public class A023170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023170Inst : IEnumerable<long>
{
public static readonly long[] Value=A023170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023170.Bytes);
public long this[int i]=>Value[i];

public static A023170Inst Instance=new A023170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023171
{
public static readonly long[] Value={ 1L,2L,4L,172L,748L,1958L,6307L,22313L,106012L,530308L,1051529L,1225708L,7188127L,14309369L,24168763L,30752921L,31373381L,34217107L,38527661L,40448867L,56051179L,81926788L,83917901L,87871781L,99922929L,122614387L };
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
public class A023171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023171Inst : IEnumerable<long>
{
public static readonly long[] Value=A023171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023171.Bytes);
public long this[int i]=>Value[i];

public static A023171Inst Instance=new A023171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023172
{
public static readonly long[] Value={ 1L,5L,12L,24L,25L,36L,48L,60L,72L,96L,108L,120L,125L,144L,168L,180L,192L,216L,240L,288L,300L,324L,336L,360L,384L,432L,480L,504L,540L,552L,576L,600L,612L,625L,648L,660L,672L,684L,720L,768L,840L,864L,900L,960L,972L,1008L,1080L,1104L,1152L,1176L,1200L,1224L,1296L,1320L };
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
public class A023172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023172Inst : IEnumerable<long>
{
public static readonly long[] Value=A023172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023172.Bytes);
public long this[int i]=>Value[i];

public static A023172Inst Instance=new A023172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023173
{
public static readonly long[] Value={ 1L,2L,11L,19L,22L,29L,31L,38L,41L,58L,59L,61L,62L,71L,79L,82L,89L,101L,109L,118L,122L,131L,139L,142L,149L,151L,158L,178L,179L,181L,191L,199L,202L,211L,218L,229L,239L,241L,251L,262L,269L,271L,278L,281L,298L,302L,311L,323L,331L,349L,358L,359L,362L,379L,382L,389L,398L,401L };
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
public class A023173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023173Inst : IEnumerable<long>
{
public static readonly long[] Value=A023173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023173.Bytes);
public long this[int i]=>Value[i];

public static A023173Inst Instance=new A023173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023174
{
public static readonly long[] Value={ 1L,3L,6L,77L,93L,123L,143L,213L,237L,267L,453L,483L,573L,597L,627L,717L,723L,813L,843L,933L,1077L,1203L,1227L,1293L,1317L,1347L,1437L,1517L,1563L,1707L,1763L,1797L,1803L,1893L,1923L,2157L,2253L,2283L,2307L,2427L,2517L,2643L,2691L,2733L,2757L,2787L,2973L,3021L };
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
public class A023174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023174Inst : IEnumerable<long>
{
public static readonly long[] Value=A023174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023174.Bytes);
public long this[int i]=>Value[i];

public static A023174Inst Instance=new A023174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023175
{
public static readonly long[] Value={ 1L,2L,4L,76L,124L,196L,244L,316L,374L,436L,556L,604L,724L,796L,844L,916L,964L,1084L,1324L,1396L,1516L,1636L,1684L,1756L,1768L,1804L,1996L,2164L,2284L,2404L,2476L,2524L,2644L,2764L,2836L,2956L,3004L,3076L,3244L,3316L,3436L,3676L,3964L,4036L,4084L,4156L,4204L };
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
public class A023175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023175Inst : IEnumerable<long>
{
public static readonly long[] Value=A023175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023175.Bytes);
public long this[int i]=>Value[i];

public static A023175Inst Instance=new A023175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023176
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,10L,20L,21L,32L,55L,80L,95L,104L,145L,155L,165L,205L,247L,295L,305L,320L,355L,395L,437L,445L,505L,545L,605L,655L,667L,695L,745L,755L,895L,905L,955L,987L,995L,1055L,1145L,1195L,1205L,1255L,1345L,1355L,1405L,1435L,1555L,1615L,1655L,1705L,1745L,1795L };
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
public class A023176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023176Inst : IEnumerable<long>
{
public static readonly long[] Value=A023176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023176.Bytes);
public long this[int i]=>Value[i];

public static A023176Inst Instance=new A023176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023177
{
public static readonly long[] Value={ 1L,3L,6L,54L,174L,246L,366L,534L,606L,654L,894L,966L,1086L,1374L,1446L,1614L,1686L,2046L,2094L,2214L,2334L,2406L,2454L,2526L,2694L,2766L,3054L,3126L,3246L,3414L,3606L,3846L,3966L,4206L,4254L,4566L,4614L,4854L,4926L,4974L,5286L,5382L,5406L,5574L,5646L,6054L };
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
public class A023177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023177Inst : IEnumerable<long>
{
public static readonly long[] Value=A023177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023177.Bytes);
public long this[int i]=>Value[i];

public static A023177Inst Instance=new A023177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023178
{
public static readonly long[] Value={ 1L,2L,7L,8L,14L,33L,187L,217L,553L,713L,1147L,1337L,1353L,1673L,1687L,1897L,1911L,1927L,2233L,2807L,3017L,3143L,3233L,3353L,3503L,4087L,4263L,4487L,5033L,5257L,5383L,6167L,6377L,6503L,6937L,7063L,7273L,8057L,8407L,8617L,8743L,8953L,9527L,9863L,10073L,10297L };
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
public class A023178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023178Inst : IEnumerable<long>
{
public static readonly long[] Value=A023178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023178.Bytes);
public long this[int i]=>Value[i];

public static A023178Inst Instance=new A023178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023179
{
public static readonly long[] Value={ 1L,2L,8L,56L,152L,248L,488L,632L,638L,872L,1112L,1178L,1208L,1448L,1592L,1688L,1832L,1928L,2168L,2648L,2792L,3032L,3272L,3368L,3512L,3536L,3608L,3992L,4148L,4328L,4568L,4628L,4808L,4952L,5048L,5288L,5528L,5672L,5912L,6008L,6152L,6488L,6632L,6872L,7352L };
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
public class A023179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023179Inst : IEnumerable<long>
{
public static readonly long[] Value=A023179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023179.Bytes);
public long this[int i]=>Value[i];

public static A023179Inst Instance=new A023179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023180
{
public static readonly long[] Value={ 1L,7L,9L,11L,42L,153L,231L,279L,329L,369L,513L,639L,711L,759L,801L,1073L,1359L,1449L,1719L,1791L,1881L,2151L,2169L,2439L,2529L,2799L,2889L,3231L,3249L,3591L,3609L,3681L,3879L,3951L,3953L,4041L,4311L,4551L,4689L,5049L,5121L,5159L,5289L,5391L,5409L,5679L,5769L };
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
public class A023180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023180Inst : IEnumerable<long>
{
public static readonly long[] Value=A023180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023180.Bytes);
public long this[int i]=>Value[i];

public static A023180Inst Instance=new A023180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023181
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,10L,14L,15L,105L,110L,119L,190L,220L,290L,310L,410L,590L,610L,710L,790L,874L,890L,1010L,1090L,1310L,1390L,1490L,1510L,1790L,1810L,1910L,1990L,2110L,2170L,2290L,2390L,2410L,2510L,2690L,2710L,2726L,2810L,2860L,3110L,3310L,3490L,3590L,3790L,3890L };
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
public class A023181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023181Inst : IEnumerable<long>
{
public static readonly long[] Value=A023181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023181.Bytes);
public long this[int i]=>Value[i];

public static A023181Inst Instance=new A023181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023182
{
public static readonly long[] Value={ 1L,2L,3L,11L,21L,22L,92L,121L,133L,209L,319L,341L,451L,493L,649L,671L,781L,869L,979L,1111L,1131L,1199L,1419L,1441L,1529L,1639L,1661L,1969L,1991L,2101L,2189L,2321L,2519L,2629L,2651L,2761L,2773L,2959L,2981L,3091L,3421L,3641L,3839L,3949L,4169L,4279L,4411L,4499L };
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
public class A023182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023182Inst : IEnumerable<long>
{
public static readonly long[] Value=A023182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023182.Bytes);
public long this[int i]=>Value[i];

public static A023182Inst Instance=new A023182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023183
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,5L,21L,14L,6L,11L,15L,22L,216L,7L,111L,130L,168L,37L,27L,112L,60L,8L,117L,64L,198L,25L,99L,136L,204L,29L,105L,88L,174L,13L,9L,70L,222L,43L,93L,172L,30L,41L,63L,124L,12L,55L,21L,154L,186L,49L,75L,148L,36L,67L,129L,10L,162L,23L,87L,118L,180L,61L,57L,166L,72L,20L };
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
public class A023183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023183Inst : IEnumerable<long>
{
public static readonly long[] Value=A023183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023183.Bytes);
public long this[int i]=>Value[i];

public static A023183Inst Instance=new A023183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023184
{
public static readonly BigInteger[] Value={ 0L,1L,2L,3L,34L,5L,10946L,377L,8L,89L,610L,17711L,BigInteger.Parse("619220451666590135228675387863297874269396512"),13L,BigInteger.Parse("70492524767089125814114"),BigInteger.Parse("659034621587630041982498215"),BigInteger.Parse("57602132235424755886206198685365216"),24157817L,196418L,BigInteger.Parse("114059301025943970552219"),1548008755920L };
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
public class A023184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A023184.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A023184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A023184Inst Instance=new A023184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023185
{
public static readonly long[] Value={ 73225L,196729L,543049L,706225L,730249L,3560089L,3584425L,6434041L,8392849L,14561209L,15686089L,40742425L,43508881L,69339625L,73878025L,85753369L,88450609L,90723169L,146947321L,148031689L,180998425L,216698161L,235198825L,273080809L };
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
public class A023185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023185Inst : IEnumerable<long>
{
public static readonly long[] Value=A023185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023185.Bytes);
public long this[int i]=>Value[i];

public static A023185Inst Instance=new A023185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023186
{
public static readonly long[] Value={ 2L,5L,23L,53L,211L,1847L,2179L,3967L,16033L,24281L,38501L,58831L,203713L,206699L,413353L,1272749L,2198981L,5102953L,10938023L,12623189L,72546283L,142414669L,162821917L,163710121L,325737821L,1131241763L,1791752797L,3173306951L,4841337887L,6021542119L,6807940367L,7174208683L,8835528511L,11179888193L,15318488291L,26329105043L,31587561361L,45241670743L };
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
public class A023186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023186Inst : IEnumerable<long>
{
public static readonly long[] Value=A023186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023186.Bytes);
public long this[int i]=>Value[i];

public static A023186Inst Instance=new A023186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023187
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,14L,18L,20L,24L,30L,40L,42L,44L,48L,54L,62L,72L,76L,96L,98L,108L,116L,124L,136L,156L,160L,162L,168L,174L,176L,178L,180L,186L,194L,210L,214L,222L,242L,244L,246L,250L,258L,268L,284L,300L,324L,328L,340L,348L,352L,390L,396L,420L,432L,452L,480L };
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
public class A023187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023187Inst : IEnumerable<long>
{
public static readonly long[] Value=A023187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023187.Bytes);
public long this[int i]=>Value[i];

public static A023187Inst Instance=new A023187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023188
{
public static readonly long[] Value={ 2L,5L,23L,53L,409L,293L,211L,1847L,3137L,2179L,3967L,23719L,16033L,40387L,44417L,24281L,158699L,220973L,172933L,321509L,38501L,58831L,203713L,268343L,206699L,829399L,824339L,413353L,2280767L,2305549L,3253631L,1272749L,2401807L,2844833L,3021241L };
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
public class A023188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023188Inst : IEnumerable<long>
{
public static readonly long[] Value=A023188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023188.Bytes);
public long this[int i]=>Value[i];

public static A023188Inst Instance=new A023188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023189
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,4L,14L,13L,16L,48L,55L,50L,173L,148L,147L,665L,580L,559L,1920L,1447L,1975L,6240L,4228L,5689L,15764L,17562L,14332L,46207L,39071L,35317L,172311L,134752L,110758L,381384L,299971L,479935L,1154568L,733900L,1027967L,2581763L,2636545L,2333308L };
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
public class A023189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023189Inst : IEnumerable<long>
{
public static readonly long[] Value=A023189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023189.Bytes);
public long this[int i]=>Value[i];

public static A023189Inst Instance=new A023189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023190
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,5L,5L,6L,6L,7L,6L,7L,8L,8L,9L,10L,10L,11L,10L,11L,12L,12L,12L,13L,14L,13L,14L,15L,15L,16L,16L,16L,17L,17L,18L,18L,18L,19L,19L,20L,20L };
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
public class A023190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023190Inst : IEnumerable<long>
{
public static readonly long[] Value=A023190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023190.Bytes);
public long this[int i]=>Value[i];

public static A023190Inst Instance=new A023190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023191
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,2L,1L,4L,2L,10L,14L,3L,2L,4L,2L,1L,2L,11L,2L,2L,6L,9L,6L,2L,12L,14L,4L,2L,2L,10L,2L,4L,8L,2L,12L,8L,4L,12L,2L,2L };
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
public class A023191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023191Inst : IEnumerable<long>
{
public static readonly long[] Value=A023191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023191.Bytes);
public long this[int i]=>Value[i];

public static A023191Inst Instance=new A023191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023192
{
public static readonly long[] Value={ 2L,3L,5L,7L,10L,13L,19L,25L,35L,45L,59L,73L,101L,129L,170L,211L,268L,325L,430L,535L,695L,855L,1065L,1275L,1658L,2041L,2572L,3103L,3781L,4459L,5802L,7145L,9068L,10991L,13473L,15955L,20357L,24759L,30608L,36457L,44281L,52105L,66169L,80233L,98525L,116817L };
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
public class A023192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023192Inst : IEnumerable<long>
{
public static readonly long[] Value=A023192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023192.Bytes);
public long this[int i]=>Value[i];

public static A023192Inst Instance=new A023192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023193
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L };
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
public class A023193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023193Inst : IEnumerable<long>
{
public static readonly long[] Value=A023193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023193.Bytes);
public long this[int i]=>Value[i];

public static A023193Inst Instance=new A023193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023194
{
public static readonly long[] Value={ 2L,4L,9L,16L,25L,64L,289L,729L,1681L,2401L,3481L,4096L,5041L,7921L,10201L,15625L,17161L,27889L,28561L,29929L,65536L,83521L,85849L,146689L,262144L,279841L,458329L,491401L,531441L,552049L,579121L,597529L,683929L,703921L,707281L,734449L,829921L,1190281L };
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
public class A023194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023194Inst : IEnumerable<long>
{
public static readonly long[] Value=A023194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023194.Bytes);
public long this[int i]=>Value[i];

public static A023194Inst Instance=new A023194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023195
{
public static readonly long[] Value={ 3L,7L,13L,31L,127L,307L,1093L,1723L,2801L,3541L,5113L,8011L,8191L,10303L,17293L,19531L,28057L,30103L,30941L,86143L,88741L,131071L,147073L,292561L,459007L,492103L,524287L,552793L,579883L,598303L,684757L,704761L,732541L,735307L,797161L,830833L,1191373L };
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
public class A023195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023195Inst : IEnumerable<long>
{
public static readonly long[] Value=A023195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023195.Bytes);
public long this[int i]=>Value[i];

public static A023195Inst Instance=new A023195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023196
{
public static readonly long[] Value={ 6L,12L,18L,20L,24L,28L,30L,36L,40L,42L,48L,54L,56L,60L,66L,70L,72L,78L,80L,84L,88L,90L,96L,100L,102L,104L,108L,112L,114L,120L,126L,132L,138L,140L,144L,150L,156L,160L,162L,168L,174L,176L,180L,186L,192L,196L,198L,200L,204L,208L,210L,216L,220L,222L,224L,228L,234L,240L,246L,252L };
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
public class A023196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023196Inst : IEnumerable<long>
{
public static readonly long[] Value=A023196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023196.Bytes);
public long this[int i]=>Value[i];

public static A023196Inst Instance=new A023196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023197
{
public static readonly long[] Value={ 120L,180L,240L,360L,420L,480L,504L,540L,600L,660L,672L,720L,780L,840L,900L,960L,1008L,1080L,1200L,1260L,1320L,1344L,1440L,1512L,1560L,1584L,1620L,1680L,1800L,1848L,1872L,1890L,1920L,1980L,2016L,2040L,2100L,2160L,2184L,2280L,2340L,2352L,2376L,2400L,2520L };
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
public class A023197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023197Inst : IEnumerable<long>
{
public static readonly long[] Value=A023197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023197.Bytes);
public long this[int i]=>Value[i];

public static A023197Inst Instance=new A023197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023198
{
public static readonly long[] Value={ 27720L,30240L,32760L,50400L,55440L,60480L,65520L,75600L,83160L,85680L,90720L,95760L,98280L,100800L,105840L,110880L,115920L,120120L,120960L,128520L,131040L,138600L,141120L,143640L,151200L,163800L,166320L,171360L,176400L,180180L,181440L,184800L };
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
public class A023198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023198Inst : IEnumerable<long>
{
public static readonly long[] Value=A023198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023198.Bytes);
public long this[int i]=>Value[i];

public static A023198Inst Instance=new A023198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023199
{
public static readonly BigInteger[] Value={ 1L,6L,120L,27720L,122522400L,130429015516800L,BigInteger.Parse("1970992304700453905270400"),BigInteger.Parse("1897544233056092162003806758651798777216000"),BigInteger.Parse("4368924363354820808981210203132513655327781713900627249499856876120704000") };
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
public class A023199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023199Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A023199.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A023199.Bytes);
public BigInteger this[int i]=>Value[i];

public static A023199Inst Instance=new A023199Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023200
{
public static readonly long[] Value={ 3L,7L,13L,19L,37L,43L,67L,79L,97L,103L,109L,127L,163L,193L,223L,229L,277L,307L,313L,349L,379L,397L,439L,457L,463L,487L,499L,613L,643L,673L,739L,757L,769L,823L,853L,859L,877L,883L,907L,937L,967L,1009L,1087L,1093L,1213L,1279L,1297L,1303L,1423L,1429L,1447L,1483L };
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
public class A023200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023200Inst : IEnumerable<long>
{
public static readonly long[] Value=A023200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023200.Bytes);
public long this[int i]=>Value[i];

public static A023200Inst Instance=new A023200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023201
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,23L,31L,37L,41L,47L,53L,61L,67L,73L,83L,97L,101L,103L,107L,131L,151L,157L,167L,173L,191L,193L,223L,227L,233L,251L,257L,263L,271L,277L,307L,311L,331L,347L,353L,367L,373L,383L,433L,443L,457L,461L,503L,541L,557L,563L,571L,587L,593L,601L,607L,613L,641L,647L };
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
public class A023201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023201Inst : IEnumerable<long>
{
public static readonly long[] Value=A023201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023201.Bytes);
public long this[int i]=>Value[i];

public static A023201Inst Instance=new A023201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023202
{
public static readonly long[] Value={ 3L,5L,11L,23L,29L,53L,59L,71L,89L,101L,131L,149L,173L,191L,233L,263L,269L,359L,389L,401L,431L,449L,479L,491L,563L,569L,593L,599L,653L,683L,701L,719L,743L,761L,821L,911L,929L,983L,1013L,1031L,1061L,1109L,1163L,1193L,1223L,1229L,1283L,1289L,1319L,1373L,1439L };
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
public class A023202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023202Inst : IEnumerable<long>
{
public static readonly long[] Value=A023202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023202.Bytes);
public long this[int i]=>Value[i];

public static A023202Inst Instance=new A023202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023203
{
public static readonly long[] Value={ 3L,7L,13L,19L,31L,37L,43L,61L,73L,79L,97L,103L,127L,139L,157L,163L,181L,223L,229L,241L,271L,283L,307L,337L,349L,373L,379L,409L,421L,433L,439L,457L,499L,547L,577L,607L,631L,643L,673L,691L,709L,733L,751L,787L,811L,829L,853L,877L,919L,937L,967L,1009L,1021L,1039L,1051L };
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
public class A023203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023203Inst : IEnumerable<long>
{
public static readonly long[] Value=A023203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023203.Bytes);
public long this[int i]=>Value[i];

public static A023203Inst Instance=new A023203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023204
{
public static readonly long[] Value={ 2L,5L,7L,13L,17L,19L,29L,43L,47L,53L,67L,73L,89L,97L,113L,127L,137L,139L,157L,167L,173L,193L,197L,199L,223L,227L,229L,269L,277L,283L,307L,337L,349L,353L,379L,383L,397L,409L,439L,463L,467L,487L,503L,509L,523L,547L,557L,563L,599L,607L,613L,617L,643L,647L,659L,739L,743L,773L };
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
public class A023204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023204Inst : IEnumerable<long>
{
public static readonly long[] Value=A023204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023204.Bytes);
public long this[int i]=>Value[i];

public static A023204Inst Instance=new A023204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023205
{
public static readonly long[] Value={ 3L,7L,13L,19L,31L,37L,61L,67L,73L,79L,97L,103L,109L,139L,151L,163L,181L,229L,241L,271L,283L,307L,313L,367L,373L,409L,439L,457L,523L,541L,613L,643L,661L,709L,727L,733L,739L,769L,787L,811L,829L,859L,877L,937L,991L,997L,1039L,1063L,1069L,1087L,1117L,1123L,1153L,1171L };
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
public class A023205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023205Inst : IEnumerable<long>
{
public static readonly long[] Value=A023205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023205.Bytes);
public long this[int i]=>Value[i];

public static A023205Inst Instance=new A023205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023206
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,23L,41L,47L,53L,71L,83L,113L,131L,137L,173L,191L,197L,227L,251L,257L,281L,293L,317L,347L,383L,401L,461L,467L,503L,521L,587L,593L,641L,647L,677L,683L,701L,743L,773L,797L,857L,863L,941L,947L,953L,971L,983L,1031L,1061L,1103L,1151L,1163L,1187L,1193L,1217L };
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
public class A023206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023206Inst : IEnumerable<long>
{
public static readonly long[] Value=A023206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023206.Bytes);
public long this[int i]=>Value[i];

public static A023206Inst Instance=new A023206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023207
{
public static readonly long[] Value={ 2L,5L,7L,11L,17L,19L,29L,31L,37L,47L,59L,61L,71L,79L,101L,107L,109L,127L,131L,137L,149L,151L,179L,211L,227L,229L,239L,241L,257L,269L,277L,281L,311L,317L,337L,359L,367L,389L,401L,409L,439L,449L,479L,487L,491L,521L,541L,547L,557L,571L,577L,607L,641L,647L,659L,709L,719L,739L };
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
public class A023207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023207Inst : IEnumerable<long>
{
public static readonly long[] Value=A023207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023207.Bytes);
public long this[int i]=>Value[i];

public static A023207Inst Instance=new A023207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023208
{
public static readonly long[] Value={ 3L,5L,7L,13L,17L,19L,23L,29L,37L,43L,59L,79L,83L,89L,97L,103L,127L,139L,149L,163L,167L,173L,197L,199L,227L,233L,239L,257L,269L,293L,313L,317L,337L,349L,353L,367L,383L,397L,409L,419L,433L,439L,457L,479L,499L,503L,523L,569L,577L,607L,643L,659L,709L,757L,769L,797L,859L,863L };
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
public class A023208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023208Inst : IEnumerable<long>
{
public static readonly long[] Value=A023208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023208.Bytes);
public long this[int i]=>Value[i];

public static A023208Inst Instance=new A023208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023209
{
public static readonly long[] Value={ 3L,5L,11L,13L,19L,23L,31L,41L,53L,59L,73L,79L,89L,101L,103L,109L,131L,139L,151L,173L,179L,181L,191L,199L,223L,229L,241L,251L,269L,283L,293L,311L,331L,349L,353L,373L,383L,389L,409L,431L,433L,439L,509L,521L,541L,563L,593L,599L,619L,643L,661L,683L,709L,719L,733L,739L,761L };
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
public class A023209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023209Inst : IEnumerable<long>
{
public static readonly long[] Value=A023209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023209.Bytes);
public long this[int i]=>Value[i];

public static A023209Inst Instance=new A023209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023210
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,31L,41L,43L,47L,53L,61L,73L,83L,101L,103L,113L,127L,131L,137L,151L,157L,167L,193L,197L,211L,223L,251L,263L,271L,277L,283L,293L,307L,311L,313L,337L,347L,367L,431L,433L,467L,491L,521L,563L,571L,593L,601L,613L,631L,641L,647L,673L,677L,691L,701L,733L,743L };
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
public class A023210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023210Inst : IEnumerable<long>
{
public static readonly long[] Value=A023210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023210.Bytes);
public long this[int i]=>Value[i];

public static A023210Inst Instance=new A023210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023211
{
public static readonly long[] Value={ 3L,7L,11L,17L,19L,23L,29L,31L,43L,47L,61L,67L,71L,73L,89L,101L,107L,109L,113L,137L,149L,151L,163L,179L,197L,199L,211L,227L,233L,239L,241L,271L,281L,283L,337L,347L,353L,359L,373L,397L,401L,409L,431L,439L,457L,463L,479L,487L,491L,523L,563L,571L,577L,593L,607L,617L,619L,641L };
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
public class A023211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023211Inst : IEnumerable<long>
{
public static readonly long[] Value=A023211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023211.Bytes);
public long this[int i]=>Value[i];

public static A023211Inst Instance=new A023211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023212
{
public static readonly long[] Value={ 3L,7L,13L,37L,43L,67L,73L,79L,97L,127L,139L,163L,193L,199L,277L,307L,373L,409L,433L,487L,499L,577L,619L,673L,709L,727L,739L,853L,883L,919L,997L,1033L,1039L,1063L,1087L,1093L,1123L,1129L,1297L,1327L,1423L,1429L,1453L,1543L,1549L,1567L,1579L,1597L,1663L,1753L };
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
public class A023212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023212Inst : IEnumerable<long>
{
public static readonly long[] Value=A023212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023212.Bytes);
public long this[int i]=>Value[i];

public static A023212Inst Instance=new A023212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023213
{
public static readonly long[] Value={ 2L,5L,7L,11L,17L,19L,31L,37L,41L,47L,59L,67L,89L,107L,109L,149L,151L,157L,179L,181L,227L,229L,241L,257L,271L,307L,331L,349L,359L,367L,389L,401L,439L,457L,461L,467L,487L,499L,509L,521L,571L,577L,587L,599L,647L,661L,677L,691L,719L,769L,797L,829L,839L,877L,881L,907L,929L,941L };
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
public class A023213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023213Inst : IEnumerable<long>
{
public static readonly long[] Value=A023213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023213.Bytes);
public long this[int i]=>Value[i];

public static A023213Inst Instance=new A023213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023214
{
public static readonly long[] Value={ 2L,3L,17L,23L,47L,59L,83L,101L,107L,113L,149L,167L,191L,233L,251L,257L,281L,311L,401L,443L,449L,467L,503L,521L,569L,593L,617L,647L,653L,677L,761L,827L,839L,857L,863L,881L,941L,947L,971L,1013L,1031L,1049L,1109L,1163L,1181L,1277L,1301L,1307L,1319L,1361L,1409L,1433L };
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
public class A023214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023214Inst : IEnumerable<long>
{
public static readonly long[] Value=A023214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023214.Bytes);
public long this[int i]=>Value[i];

public static A023214Inst Instance=new A023214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023215
{
public static readonly long[] Value={ 3L,13L,19L,31L,43L,61L,103L,109L,139L,163L,241L,271L,313L,373L,379L,499L,523L,601L,613L,631L,643L,673L,709L,733L,739L,751L,769L,811L,823L,829L,883L,1021L,1033L,1051L,1063L,1069L,1129L,1171L,1231L,1249L,1291L,1381L,1459L,1483L,1531L,1549L,1579L,1621L,1663L };
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
public class A023215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023215Inst : IEnumerable<long>
{
public static readonly long[] Value=A023215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023215.Bytes);
public long this[int i]=>Value[i];

public static A023215Inst Instance=new A023215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023216
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,23L,37L,41L,43L,47L,67L,71L,97L,103L,113L,137L,151L,163L,167L,173L,181L,191L,197L,211L,233L,251L,263L,271L,277L,293L,307L,317L,397L,401L,421L,431L,433L,463L,467L,491L,557L,571L,587L,593L,607L,617L,653L,683L,727L,757L,811L,823L,863L,877L,881L,883L,887L,907L };
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
public class A023216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023216Inst : IEnumerable<long>
{
public static readonly long[] Value=A023216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023216.Bytes);
public long this[int i]=>Value[i];

public static A023216Inst Instance=new A023216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023217
{
public static readonly long[] Value={ 3L,7L,13L,19L,31L,61L,67L,73L,79L,97L,109L,151L,157L,181L,193L,199L,223L,313L,331L,349L,373L,397L,457L,487L,523L,541L,571L,577L,607L,613L,643L,661L,691L,709L,727L,739L,769L,811L,859L,919L,991L,997L,1021L,1033L,1039L,1069L,1087L,1129L,1171L,1201L,1213L,1249L,1279L,1321L };
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
public class A023217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023217Inst : IEnumerable<long>
{
public static readonly long[] Value=A023217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023217.Bytes);
public long this[int i]=>Value[i];

public static A023217Inst Instance=new A023217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023218
{
public static readonly long[] Value={ 3L,5L,11L,17L,29L,47L,53L,71L,83L,89L,101L,113L,131L,167L,251L,257L,263L,281L,311L,389L,419L,461L,467L,479L,491L,509L,521L,557L,563L,587L,593L,599L,617L,641L,659L,677L,743L,797L,809L,827L,857L,881L,929L,977L,983L,1019L,1061L,1103L,1187L,1217L,1259L,1277L,1289L,1319L };
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
public class A023218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023218Inst : IEnumerable<long>
{
public static readonly long[] Value=A023218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023218.Bytes);
public long this[int i]=>Value[i];

public static A023218Inst Instance=new A023218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023219
{
public static readonly long[] Value={ 5L,7L,11L,13L,19L,29L,37L,41L,47L,53L,61L,79L,83L,97L,103L,107L,113L,127L,131L,137L,139L,149L,151L,163L,181L,193L,197L,211L,229L,233L,239L,257L,263L,271L,293L,313L,347L,359L,373L,379L,389L,401L,421L,431L,443L,449L,461L,467L,487L,503L,509L,523L,541L,547L,557L,569L,571L,593L };
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
public class A023219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023219Inst : IEnumerable<long>
{
public static readonly long[] Value=A023219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023219.Bytes);
public long this[int i]=>Value[i];

public static A023219Inst Instance=new A023219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023220
{
public static readonly long[] Value={ 3L,7L,13L,19L,31L,37L,43L,61L,73L,103L,127L,163L,211L,223L,229L,241L,283L,307L,331L,337L,349L,373L,397L,409L,421L,439L,457L,499L,541L,631L,661L,673L,691L,727L,733L,757L,769L,787L,829L,853L,883L,919L,997L,1021L,1063L,1087L,1123L,1129L,1213L,1231L,1447L,1543L,1549L };
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
public class A023220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023220Inst : IEnumerable<long>
{
public static readonly long[] Value=A023220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023220.Bytes);
public long this[int i]=>Value[i];

public static A023220Inst Instance=new A023220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023221
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,17L,29L,31L,37L,41L,43L,59L,71L,73L,79L,83L,97L,107L,109L,113L,137L,139L,151L,157L,163L,181L,191L,193L,197L,227L,239L,241L,251L,263L,269L,277L,307L,311L,317L,337L,347L,349L,367L,373L,389L,401L,409L,421L,431L,443L,449L,479L,487L,499L,503L,541L,557L,577L,587L };
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
public class A023221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023221Inst : IEnumerable<long>
{
public static readonly long[] Value=A023221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023221.Bytes);
public long this[int i]=>Value[i];

public static A023221Inst Instance=new A023221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023222
{
public static readonly long[] Value={ 2L,5L,11L,17L,29L,31L,37L,61L,67L,71L,89L,101L,109L,127L,137L,167L,181L,191L,199L,229L,241L,257L,269L,277L,281L,311L,331L,337L,347L,359L,379L,389L,397L,419L,431L,457L,491L,499L,509L,541L,571L,577L,587L,601L,617L,631L,641L,647L,691L,709L,739L,751L,757L,769L,787L,797L,809L };
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
public class A023222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023222Inst : IEnumerable<long>
{
public static readonly long[] Value=A023222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023222.Bytes);
public long this[int i]=>Value[i];

public static A023222Inst Instance=new A023222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023223
{
public static readonly long[] Value={ 3L,5L,11L,23L,47L,53L,71L,101L,107L,131L,167L,173L,197L,251L,257L,293L,311L,317L,353L,383L,431L,461L,467L,563L,587L,593L,683L,701L,773L,797L,821L,827L,863L,887L,911L,953L,977L,983L,1031L,1091L,1097L,1103L,1151L,1181L,1187L,1193L,1217L,1223L,1277L,1301L,1307L,1373L };
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
public class A023223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023223Inst : IEnumerable<long>
{
public static readonly long[] Value=A023223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023223.Bytes);
public long this[int i]=>Value[i];

public static A023223Inst Instance=new A023223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023224
{
public static readonly long[] Value={ 7L,19L,37L,61L,79L,97L,139L,151L,157L,211L,229L,271L,307L,349L,379L,457L,487L,547L,571L,601L,607L,619L,631L,709L,751L,757L,769L,829L,877L,907L,937L,997L,1021L,1069L,1117L,1129L,1237L,1249L,1291L,1327L,1429L,1447L,1471L,1489L,1549L,1567L,1579L,1621L,1627L,1699L };
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
public class A023224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023224Inst : IEnumerable<long>
{
public static readonly long[] Value=A023224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023224.Bytes);
public long this[int i]=>Value[i];

public static A023224Inst Instance=new A023224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023225
{
public static readonly long[] Value={ 5L,11L,13L,19L,23L,31L,41L,43L,59L,61L,71L,83L,103L,109L,113L,149L,151L,173L,179L,199L,211L,223L,229L,233L,241L,263L,269L,281L,283L,353L,373L,379L,383L,389L,419L,421L,431L,433L,439L,479L,499L,503L,541L,563L,569L,571L,593L,613L,619L,631L,641L,643L,683L,709L,719L,739L,761L };
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
public class A023225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023225Inst : IEnumerable<long>
{
public static readonly long[] Value=A023225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023225.Bytes);
public long this[int i]=>Value[i];

public static A023225Inst Instance=new A023225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023226
{
public static readonly long[] Value={ 3L,5L,17L,29L,47L,53L,59L,89L,107L,137L,149L,227L,347L,359L,383L,389L,443L,479L,503L,509L,557L,593L,599L,617L,659L,683L,743L,773L,839L,857L,887L,947L,953L,1049L,1097L,1187L,1217L,1259L,1307L,1319L,1373L,1409L,1433L,1493L,1499L,1607L,1613L,1637L,1667L,1697L,1709L };
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
public class A023226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023226Inst : IEnumerable<long>
{
public static readonly long[] Value=A023226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023226.Bytes);
public long this[int i]=>Value[i];

public static A023226Inst Instance=new A023226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023227
{
public static readonly long[] Value={ 3L,7L,13L,31L,37L,43L,67L,73L,79L,109L,139L,157L,163L,181L,193L,211L,223L,229L,241L,271L,277L,367L,373L,379L,397L,421L,433L,439L,457L,463L,523L,541L,571L,577L,601L,607L,661L,673L,709L,727L,757L,769L,787L,829L,853L,907L,937L,967L,991L,1039L,1063L,1117L,1153L,1213L };
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
public class A023227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023227Inst : IEnumerable<long>
{
public static readonly long[] Value=A023227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023227.Bytes);
public long this[int i]=>Value[i];

public static A023227Inst Instance=new A023227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023228
{
public static readonly long[] Value={ 2L,5L,11L,17L,29L,71L,101L,107L,131L,137L,149L,179L,239L,269L,347L,401L,431L,449L,479L,491L,509L,557L,599L,617L,659L,677L,761L,809L,821L,857L,929L,941L,947L,977L,1151L,1187L,1229L,1289L,1307L,1361L,1367L,1409L,1487L,1559L,1571L,1601L,1619L,1667L,1697L,1811L,1871L };
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
public class A023228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023228Inst : IEnumerable<long>
{
public static readonly long[] Value=A023228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023228.Bytes);
public long this[int i]=>Value[i];

public static A023228Inst Instance=new A023228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023229
{
public static readonly long[] Value={ 2L,5L,7L,13L,17L,31L,41L,43L,47L,61L,71L,73L,101L,103L,107L,113L,127L,131L,157L,163L,181L,191L,197L,223L,233L,241L,251L,281L,283L,293L,307L,317L,337L,367L,383L,421L,433L,443L,457L,461L,467L,491L,503L,563L,631L,643L,647L,653L,673L,677L,691L,733L,751L,761L,787L,797L,811L };
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
public class A023229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023229Inst : IEnumerable<long>
{
public static readonly long[] Value=A023229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023229.Bytes);
public long this[int i]=>Value[i];

public static A023229Inst Instance=new A023229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023230
{
public static readonly long[] Value={ 3L,7L,13L,19L,43L,67L,103L,109L,127L,139L,151L,181L,193L,199L,211L,223L,241L,277L,283L,349L,379L,397L,421L,433L,439L,463L,577L,601L,607L,613L,619L,727L,733L,787L,829L,853L,883L,967L,991L,1033L,1039L,1117L,1201L,1237L,1291L,1303L,1399L,1429L,1459L,1531L,1567L,1579L };
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
public class A023230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023230Inst : IEnumerable<long>
{
public static readonly long[] Value=A023230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023230.Bytes);
public long this[int i]=>Value[i];

public static A023230Inst Instance=new A023230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023231
{
public static readonly long[] Value={ 2L,3L,5L,23L,29L,47L,53L,59L,89L,107L,113L,137L,179L,197L,227L,233L,257L,263L,293L,317L,359L,389L,419L,509L,557L,587L,593L,599L,617L,653L,659L,683L,839L,857L,863L,887L,947L,977L,1013L,1097L,1103L,1163L,1193L,1217L,1223L,1229L,1259L,1277L,1283L,1307L,1319L,1409L };
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
public class A023231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023231Inst : IEnumerable<long>
{
public static readonly long[] Value=A023231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023231.Bytes);
public long this[int i]=>Value[i];

public static A023231Inst Instance=new A023231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023232
{
public static readonly long[] Value={ 11L,13L,23L,29L,31L,41L,43L,53L,71L,73L,79L,83L,109L,149L,151L,193L,199L,211L,233L,251L,263L,269L,283L,331L,349L,353L,379L,389L,401L,419L,431L,461L,499L,521L,541L,563L,569L,599L,601L,643L,653L,659L,661L,673L,743L,809L,821L,853L,881L,911L,941L,983L,991L,1009L,1019L,1033L };
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
public class A023232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023232Inst : IEnumerable<long>
{
public static readonly long[] Value=A023232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023232.Bytes);
public long this[int i]=>Value[i];

public static A023232Inst Instance=new A023232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023233
{
public static readonly long[] Value={ 3L,5L,11L,19L,29L,31L,43L,53L,71L,73L,101L,103L,109L,113L,131L,151L,173L,179L,191L,211L,229L,233L,239L,269L,271L,281L,283L,311L,313L,373L,379L,383L,431L,443L,491L,499L,509L,521L,541L,599L,613L,619L,653L,691L,701L,719L,733L,739L,743L,751L,773L,809L,883L,919L,929L,971L,983L };
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
public class A023233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023233Inst : IEnumerable<long>
{
public static readonly long[] Value=A023233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023233.Bytes);
public long this[int i]=>Value[i];

public static A023233Inst Instance=new A023233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023234
{
public static readonly long[] Value={ 3L,7L,11L,17L,23L,31L,37L,41L,67L,71L,73L,83L,97L,107L,113L,137L,163L,191L,193L,197L,223L,263L,283L,307L,311L,317L,337L,353L,367L,373L,401L,421L,461L,491L,577L,601L,613L,617L,631L,643L,647L,653L,661L,683L,727L,743L,751L,773L,797L,821L,823L,853L,857L,881L,883L,907L,947L };
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
public class A023234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023234Inst : IEnumerable<long>
{
public static readonly long[] Value=A023234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023234.Bytes);
public long this[int i]=>Value[i];

public static A023234Inst Instance=new A023234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023235
{
public static readonly long[] Value={ 5L,7L,11L,19L,29L,47L,61L,71L,79L,89L,97L,107L,127L,131L,139L,151L,167L,179L,181L,211L,229L,251L,271L,317L,337L,397L,401L,419L,421L,449L,461L,467L,487L,541L,547L,557L,571L,599L,601L,607L,659L,677L,701L,709L,727L,739L,761L,811L,827L,839L,877L,881L,907L,929L,971L,1051L };
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
public class A023235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023235Inst : IEnumerable<long>
{
public static readonly long[] Value=A023235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023235.Bytes);
public long this[int i]=>Value[i];

public static A023235Inst Instance=new A023235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023236
{
public static readonly long[] Value={ 3L,7L,11L,13L,17L,19L,29L,41L,43L,47L,53L,59L,67L,83L,89L,97L,101L,103L,109L,127L,157L,173L,179L,193L,197L,199L,223L,227L,239L,241L,251L,263L,277L,281L,283L,293L,353L,367L,383L,389L,397L,409L,431L,433L,449L,461L,463L,509L,547L,557L,563L,593L,601L,613L,617L,619L,631L,641L };
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
public class A023236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023236Inst : IEnumerable<long>
{
public static readonly long[] Value=A023236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023236.Bytes);
public long this[int i]=>Value[i];

public static A023236Inst Instance=new A023236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023237
{
public static readonly long[] Value={ 3L,7L,13L,19L,31L,43L,97L,103L,109L,151L,157L,181L,193L,211L,241L,271L,337L,349L,367L,409L,421L,439L,487L,523L,547L,571L,601L,613L,631L,691L,733L,769L,811L,823L,829L,883L,937L,1009L,1021L,1033L,1039L,1063L,1069L,1117L,1201L,1249L,1279L,1291L,1459L,1483L,1489L };
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
public class A023237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023237Inst : IEnumerable<long>
{
public static readonly long[] Value=A023237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023237.Bytes);
public long this[int i]=>Value[i];

public static A023237Inst Instance=new A023237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023238
{
public static readonly long[] Value={ 2L,5L,7L,11L,17L,19L,23L,29L,31L,37L,43L,59L,61L,67L,73L,101L,103L,109L,137L,149L,173L,191L,193L,197L,199L,211L,227L,229L,233L,239L,263L,269L,271L,283L,331L,337L,353L,359L,367L,373L,379L,383L,401L,409L,449L,467L,479L,499L,523L,541L,557L,569L,607L,613L,617L,647L,673L,683L };
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
public class A023238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023238Inst : IEnumerable<long>
{
public static readonly long[] Value=A023238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023238.Bytes);
public long this[int i]=>Value[i];

public static A023238Inst Instance=new A023238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023239
{
public static readonly long[] Value={ 3L,13L,19L,31L,61L,67L,79L,97L,109L,127L,163L,199L,223L,229L,241L,277L,283L,313L,367L,379L,421L,433L,439L,463L,487L,523L,541L,547L,571L,619L,631L,673L,691L,751L,757L,787L,811L,823L,829L,853L,859L,883L,937L,967L,1033L,1093L,1117L,1171L,1237L,1249L,1291L,1303L,1321L };
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
public class A023239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023239Inst : IEnumerable<long>
{
public static readonly long[] Value=A023239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023239.Bytes);
public long this[int i]=>Value[i];

public static A023239Inst Instance=new A023239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023240
{
public static readonly long[] Value={ 2L,5L,7L,13L,17L,19L,23L,37L,41L,43L,47L,59L,61L,71L,73L,83L,101L,103L,127L,131L,139L,149L,157L,197L,199L,223L,233L,239L,257L,269L,271L,281L,293L,307L,311L,331L,349L,353L,373L,401L,409L,421L,433L,463L,467L,479L,491L,499L,503L,509L,541L,547L,563L,577L,587L,593L,607L,619L };
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
public class A023240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023240Inst : IEnumerable<long>
{
public static readonly long[] Value=A023240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023240.Bytes);
public long this[int i]=>Value[i];

public static A023240Inst Instance=new A023240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023241
{
public static readonly long[] Value={ 5L,7L,11L,17L,31L,41L,47L,61L,67L,97L,101L,151L,167L,227L,251L,257L,271L,347L,367L,557L,587L,601L,607L,641L,647L,727L,941L,971L,1091L,1097L,1117L,1181L,1217L,1277L,1291L,1361L,1427L,1447L,1481L,1487L,1601L,1607L,1657L,1741L,1747L,1777L,1861L,1867L,1901L,1987L };
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
public class A023241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023241Inst : IEnumerable<long>
{
public static readonly long[] Value=A023241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023241.Bytes);
public long this[int i]=>Value[i];

public static A023241Inst Instance=new A023241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023242
{
public static readonly long[] Value={ 2L,5L,7L,13L,43L,47L,67L,97L,113L,137L,167L,173L,197L,277L,307L,397L,463L,467L,557L,607L,617L,887L,1063L,1153L,1217L,1237L,1307L,1373L,1427L,1453L,1523L,1553L,1567L,1663L,1693L,2027L,2113L,2143L,2203L,2617L,2647L,2707L,2777L,2857L,2927L,3343L,3613L,3767L };
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
public class A023242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023242Inst : IEnumerable<long>
{
public static readonly long[] Value=A023242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023242.Bytes);
public long this[int i]=>Value[i];

public static A023242Inst Instance=new A023242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023243
{
public static readonly long[] Value={ 7L,13L,31L,37L,67L,73L,79L,139L,151L,181L,367L,541L,613L,661L,709L,739L,787L,811L,829L,997L,1087L,1117L,1123L,1249L,1327L,1669L,1753L,1801L,1861L,1999L,2011L,2113L,2179L,2239L,2293L,2473L,2557L,2659L,2713L,2719L,3037L,3181L,3187L,3271L,3301L,3517L,3727L,3793L };
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
public class A023243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023243Inst : IEnumerable<long>
{
public static readonly long[] Value=A023243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023243.Bytes);
public long this[int i]=>Value[i];

public static A023243Inst Instance=new A023243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023244
{
public static readonly long[] Value={ 2L,5L,17L,23L,53L,83L,137L,197L,227L,257L,293L,317L,347L,383L,467L,593L,647L,677L,683L,797L,857L,953L,1163L,1193L,1217L,1607L,1877L,1907L,1913L,1997L,2063L,2207L,2237L,2843L,2903L,3023L,3257L,3323L,3557L,3947L,4133L,4253L,4517L,4583L,4643L,4967L,5087L,5387L };
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
public class A023244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023244Inst : IEnumerable<long>
{
public static readonly long[] Value=A023244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023244.Bytes);
public long this[int i]=>Value[i];

public static A023244Inst Instance=new A023244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023389
{
public static readonly long[] Value={ 7L,9L,11L,13L,15L,19L,23L,29L,37L,47L,59L,93L,137L,211L,343L,729L,1513L,3133L,8077L,21435L,70255L,243939L,1085583L,5931677L,43738095L,406863821L,4668281037L,71095945599L,1434858502437L,47306783952687L,2415226651498341L,204771657238889285L };
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
public class A023389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023389Inst : IEnumerable<long>
{
public static readonly long[] Value=A023389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023389.Bytes);
public long this[int i]=>Value[i];

public static A023389Inst Instance=new A023389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023390
{
public static readonly BigInteger[] Value={ 7L,10L,13L,16L,22L,31L,43L,61L,115L,223L,436L,1162L,3250L,12322L,50632L,300421L,2360602L,26031136L,434155345L,13521155011L,656031631000L,65253034566544L,16513243012141246L,13066154302600036600UL,BigInteger.Parse("32251566130104220405204") };
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
public class A023390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023390Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A023390.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A023390.Bytes);
public BigInteger this[int i]=>Value[i];

public static A023390Inst Instance=new A023390Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023391
{
public static readonly long[] Value={ 8L,9L,10L,11L,12L,13L,14L,15L,16L,18L,20L,22L,24L,27L,30L,33L,37L,41L,46L,51L,57L,64L,81L,100L,121L,145L,181L,221L,275L,345L,433L,541L,761L,1036L,1471L,2014L,2787L,3927L,5533L,8537L,13555L,21441L,34102L,60891L,103386L,185033L,329032L,651411L,1286139L,2551404L };
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
public class A023391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023391Inst : IEnumerable<long>
{
public static readonly long[] Value=A023391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023391.Bytes);
public long this[int i]=>Value[i];

public static A023391Inst Instance=new A023391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023392
{
public static readonly long[] Value={ 9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,20L,22L,24L,26L,28L,31L,34L,37L,41L,45L,50L,55L,61L,67L,74L,82L,101L,122L,145L,171L,210L,253L,311L,375L,456L,556L,677L,832L,1124L,1478L,2022L,2686L,3614L,4855L,6584L,10025L,14668L,22107L,33283L,50581L,76341L,125643L,211313L };
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
public class A023392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023392Inst : IEnumerable<long>
{
public static readonly long[] Value=A023392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023392.Bytes);
public long this[int i]=>Value[i];

public static A023392Inst Instance=new A023392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023393
{
public static readonly long[] Value={ 0L,1L,2L,7L,11L,19L,27L,38L,50L,64L,80L,98L,118L };
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
public class A023393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023393Inst : IEnumerable<long>
{
public static readonly long[] Value=A023393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023393.Bytes);
public long this[int i]=>Value[i];

public static A023393Inst Instance=new A023393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023394
{
public static readonly long[] Value={ 3L,5L,17L,257L,641L,65537L,114689L,274177L,319489L,974849L,2424833L,6700417L,13631489L,26017793L,45592577L,63766529L,167772161L,825753601L,1214251009L,6487031809L,70525124609L,190274191361L,646730219521L,2710954639361L,2748779069441L,4485296422913L,6597069766657L };
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
public class A023394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023394Inst : IEnumerable<long>
{
public static readonly long[] Value=A023394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023394.Bytes);
public long this[int i]=>Value[i];

public static A023394Inst Instance=new A023394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023395
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,12L,6L,11L,11L,9L,5L,18L,12L,10L,12L,23L,16L,15L,10L,19L,12L,19L,13L,36L,21L,38L,32L,25L,17L,39L,6L,26L,27L,30L,30L,8L,12L,15L,29L,38L,7L,25L,27L,36L,42L,25L,13L,13L,55L };
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
public class A023395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023395Inst : IEnumerable<long>
{
public static readonly long[] Value=A023395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023395.Bytes);
public long this[int i]=>Value[i];

public static A023395Inst Instance=new A023395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023396
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,1L,2L,2L,2L,1L,2L,1L,1L,2L,2L,2L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L };
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
public class A023396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023396Inst : IEnumerable<long>
{
public static readonly long[] Value=A023396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023396.Bytes);
public long this[int i]=>Value[i];

public static A023396Inst Instance=new A023396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023397
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,3L,3L,2L,3L,3L,3L,3L,3L,3L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,3L,3L,2L,2L,2L,2L,3L,3L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,3L,2L,3L,3L,3L,2L,2L,3L,3L,3L,2L,3L,3L,3L,2L,2L,2L,2L,2L,3L,2L,2L,3L,3L,3L,2L,3L,2L,3L,3L,2L,3L,2L,3L,3L,2L,2L,2L,2L,2L,3L,2L };
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
public class A023397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023397Inst : IEnumerable<long>
{
public static readonly long[] Value=A023397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023397.Bytes);
public long this[int i]=>Value[i];

public static A023397Inst Instance=new A023397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023398
{
public static readonly long[] Value={ 2L,5L,5L,5L,5L,2L,5L,5L,2L,2L,2L,2L,5L,5L,2L,2L,2L,2L,2L,5L,5L,5L,5L,2L,5L,5L,5L,2L,2L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,2L,5L,5L,2L,5L,2L,5L,2L,2L,5L,2L,2L,2L,2L,5L,5L,5L,5L,5L,2L,2L,5L,5L,2L,5L,2L,5L,5L,5L,2L,5L,2L,2L,2L,5L,2L,2L,2L,5L,5L,2L,2L,2L,5L,2L,5L,2L,5L,5L,2L,2L,5L,5L,2L,5L,2L,2L,5L,2L,2L,2L,2L,5L,2L,5L,5L,2L,5L,2L };
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
public class A023398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023398Inst : IEnumerable<long>
{
public static readonly long[] Value=A023398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023398.Bytes);
public long this[int i]=>Value[i];

public static A023398Inst Instance=new A023398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023399
{
public static readonly long[] Value={ 2L,7L,2L,2L,2L,2L,7L,2L,7L,2L,7L,7L,7L,7L,2L,2L,7L,2L,7L,2L,7L,7L,2L,7L,7L,2L,7L,2L,7L,7L,2L,2L,2L,2L,7L,2L,7L,2L,7L,2L,2L,2L,7L,7L,7L,7L,2L,2L,7L,7L,7L,2L,7L,2L,2L,7L,7L,7L,7L,2L,7L,7L,2L,7L,7L,2L,7L,7L,7L,7L,7L,2L,2L,7L,2L,7L,7L,7L,7L,7L,2L,2L,7L,7L,2L,2L,7L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,2L,7L,2L,7L,7L,2L,7L };
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
public class A023399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023399Inst : IEnumerable<long>
{
public static readonly long[] Value=A023399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023399.Bytes);
public long this[int i]=>Value[i];

public static A023399Inst Instance=new A023399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023400
{
public static readonly long[] Value={ 2L,9L,9L,2L,9L,2L,2L,2L,2L,2L,2L,9L,9L,2L,9L,9L,9L,9L,2L,2L,9L,2L,9L,2L,9L,2L,2L,9L,2L,2L,9L,2L,2L,9L,9L,9L,9L,9L,2L,2L,2L,2L,2L,2L,9L,2L,2L,9L,9L,2L,9L,9L,9L,9L,9L,2L,9L,2L,9L,2L,2L,9L,9L,9L,2L,2L,9L,9L,9L,2L,9L,2L,2L,2L,2L,9L,9L,9L,9L,9L,9L,9L,9L,2L,9L,2L,9L,2L,2L,2L,9L,9L,2L,2L,2L,9L,9L,2L,9L,9L,2L,9L,9L,9L,2L,2L,9L,9L };
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
public class A023400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023400Inst : IEnumerable<long>
{
public static readonly long[] Value=A023400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023400.Bytes);
public long this[int i]=>Value[i];

public static A023400Inst Instance=new A023400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023401
{
public static readonly long[] Value={ 4L,4L,1L,4L,1L,4L,1L,4L,4L,1L,1L,4L,4L,4L,4L,1L,4L,4L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,4L,4L,1L,1L,4L,1L,1L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,4L,4L,4L,4L,4L,4L,1L,4L,4L,4L,4L,1L,1L,4L,1L,4L,4L,1L,4L,1L,4L,4L,4L,1L,1L,1L,4L,4L,4L,4L,4L,1L,1L,4L,4L,1L,4L,4L,1L,1L,4L,1L,1L,1L,1L,4L,4L,4L,1L,4L,4L,4L,1L,1L,1L,4L,1L,4L,4L,4L,1L,1L,4L };
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
public class A023401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023401Inst : IEnumerable<long>
{
public static readonly long[] Value=A023401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023401.Bytes);
public long this[int i]=>Value[i];

public static A023401Inst Instance=new A023401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023402
{
public static readonly long[] Value={ 4L,4L,3L,3L,3L,4L,3L,3L,3L,3L,4L,3L,3L,3L,4L,3L,4L,4L,3L,4L,4L,4L,4L,3L,4L,4L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,4L,4L,3L,4L,3L,4L,3L,3L,4L,4L,3L,4L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,4L,4L,4L,3L,4L,4L,4L,4L,4L,3L,3L,3L,3L,4L,3L,4L,3L,4L,4L,3L,3L,4L,4L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,3L,4L,4L };
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
public class A023402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023402Inst : IEnumerable<long>
{
public static readonly long[] Value=A023402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023402.Bytes);
public long this[int i]=>Value[i];

public static A023402Inst Instance=new A023402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023403
{
public static readonly long[] Value={ 4L,4L,5L,4L,4L,4L,4L,5L,4L,5L,4L,5L,5L,5L,5L,4L,4L,5L,4L,5L,4L,5L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,4L,4L,4L,5L,4L,5L,4L,5L,4L,4L,4L,5L,5L,5L,5L,4L,4L,5L,5L,5L,4L,5L,4L,4L,5L,5L,5L,5L,4L,5L,5L,4L,5L,5L,4L,5L,5L,5L,5L,5L,4L,4L,5L,4L,5L,5L,5L,5L,5L,4L,4L,5L,5L,4L,4L,5L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,4L,5L,4L,5L,5L,4L };
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
public class A023403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023403Inst : IEnumerable<long>
{
public static readonly long[] Value=A023403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023403.Bytes);
public long this[int i]=>Value[i];

public static A023403Inst Instance=new A023403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023404
{
public static readonly long[] Value={ 4L,4L,7L,7L,4L,4L,4L,4L,4L,4L,7L,4L,4L,4L,4L,7L,7L,4L,7L,7L,7L,4L,7L,4L,4L,7L,4L,7L,4L,4L,7L,7L,4L,4L,7L,4L,7L,7L,4L,4L,4L,4L,4L,4L,7L,4L,7L,4L,4L,4L,4L,4L,7L,4L,7L,4L,4L,7L,7L,4L,4L,4L,7L,4L,7L,7L,4L,4L,4L,7L,7L,4L,7L,4L,4L,7L,4L,7L,7L,7L,7L,7L,4L,7L,7L,7L,7L,7L,7L,7L,4L,4L,4L,4L,4L,7L,4L,7L,4L,7L,7L,4L,7L,7L,7L,4L,4L,4L };
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
public class A023404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023404Inst : IEnumerable<long>
{
public static readonly long[] Value=A023404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023404.Bytes);
public long this[int i]=>Value[i];

public static A023404Inst Instance=new A023404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023549
{
public static readonly long[] Value={ 2L,9L,21L,43L,80L,142L,244L,411L,683L,1125L,1842L,3004L,4886L,7933L,12865L,20847L,33764L,54666L,88488L,143215L,231767L,375049L,606886L,982008L,1588970L,2571057L,4160109L,6731251L };
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
public class A023549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023549Inst : IEnumerable<long>
{
public static readonly long[] Value=A023549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023549.Bytes);
public long this[int i]=>Value[i];

public static A023549Inst Instance=new A023549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023550
{
public static readonly long[] Value={ 2L,7L,16L,32L,59L,104L,178L,299L,496L,816L,1335L,2176L,3538L,5743L,9312L,15088L,24435L,39560L,64034L,103635L,167712L,271392L,439151L,710592L,1149794L,1860439L,3010288L,4870784L,7881131L,12751976L,20633170L,33385211L,54018448L,87403728L,141422247L,228826048L };
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
public class A023550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023550Inst : IEnumerable<long>
{
public static readonly long[] Value=A023550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023550.Bytes);
public long this[int i]=>Value[i];

public static A023550Inst Instance=new A023550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A023551
{
public static readonly long[] Value={ 9L,24L,46L,76L,115L,164L,224L,296L,381L,480L,594L,724L,871L,1036L,1220L,1424L,1649L,1896L,2166L,2460L,2779L,3124L,3496L,3896L,4325L,4784L,5274L,5796L,6351L,6940L,7564L,8224L,8921L,9656L,10430L,11244L,12099L,12996L,13936L,14920L,15949L };
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
public class A023551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A023551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A023551Inst : IEnumerable<long>
{
public static readonly long[] Value=A023551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A023551.Bytes);
public long this[int i]=>Value[i];

public static A023551Inst Instance=new A023551Inst();

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