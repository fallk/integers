using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A227857
{
public static readonly long[] Value={ 5L,7L,29L,15L,36L,3L,95L,11L,1L,5L,2L,19L,2L,0L,1L,0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,0L,1L,1L,1L,1L,3L,0L,2L,0L,2L,0L,2L,0L,0L,0L,4L,1L,4L,1L,4L,0L,1L,0L,0L,0L,12L,0L,5L,0L,2L,0L,6L,0L,0L,0L,12L,0L,1L,0L,1L,0L,12L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227857Inst : IEnumerable<long>
{
public static readonly long[] Value=A227857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227857.Bytes);
public long this[int i]=>Value[i];

public static A227857Inst Instance=new A227857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227858
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,66L,77L,88L,99L,101L,111L,121L,131L,141L,151L,161L,171L,181L,191L,202L,212L,222L,232L,242L,252L,262L,272L,282L,292L,303L,313L,323L,333L,343L,353L,363L,373L,383L,393L,404L,414L,424L,434L,444L,454L,464L,474L,484L,494L,505L,515L,525L,535L,545L,555L,565L,575L,585L,595L,606L,616L,626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227858Inst : IEnumerable<long>
{
public static readonly long[] Value=A227858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227858.Bytes);
public long this[int i]=>Value[i];

public static A227858Inst Instance=new A227858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227859
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,3L,2L,4L,5L,3L,6L,7L,4L,8L,5L,9L,1L,6L,1L,7L,0L,0L,8L,2L,3L,9L,2L,4L,3L,5L,6L,7L,4L,8L,9L,5L,1L,6L,1L,7L,0L,0L,8L,2L,9L,3L,2L,4L,5L,3L,6L,7L,4L,8L,5L,9L,1L,6L,1L,7L,0L,0L,8L,2L,3L,9L,2L,4L,3L,5L,6L,7L,4L,8L,9L,5L,1L,6L,1L,7L,0L,0L,8L,2L,9L,3L,2L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227859Inst : IEnumerable<long>
{
public static readonly long[] Value=A227859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227859.Bytes);
public long this[int i]=>Value[i];

public static A227859Inst Instance=new A227859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227860
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,3L,2L,0L,0L,3L,1L,2L,1L,3L,2L,0L,0L,3L,1L,2L,1L,3L,2L,0L,0L,3L,1L,2L,1L,3L,2L,0L,0L,3L,1L,2L,1L,3L,2L,0L,0L,3L,1L,2L,1L,3L,2L,0L,0L,3L,1L,2L,1L,3L,2L,0L,0L,3L,1L,2L,1L,3L,2L,0L,0L,3L,1L,2L,1L,3L,2L,0L,0L,3L,1L,2L,1L,3L,2L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227860Inst : IEnumerable<long>
{
public static readonly long[] Value=A227860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227860.Bytes);
public long this[int i]=>Value[i];

public static A227860Inst Instance=new A227860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227861
{
public static readonly long[] Value={ 2L,3L,3L,4L,4L,5L,4L,5L,6L,5L,6L,5L,7L,6L,7L,6L,8L,7L,6L,8L,7L,9L,8L,7L,9L,8L,7L,10L,9L,8L,10L,9L,8L,11L,10L,9L,8L,11L,10L,9L,12L,11L,10L,9L,12L,11L,10L,13L,9L,12L,11L,10L,13L,12L,11L,14L,10L,13L,12L,11L,14L,10L,13L,12L,15L,11L,14L,13L,12L,15L,11L,14L,13L,16L,12L,15L,11L,14L,13L,16L,12L,15L,14L,17L,13L,16L,12L,15L,14L,17L,13L,16L,12L,15L,18L,14L,17L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227861Inst : IEnumerable<long>
{
public static readonly long[] Value=A227861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227861.Bytes);
public long this[int i]=>Value[i];

public static A227861Inst Instance=new A227861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227862
{
public static readonly long[] Value={ 1L,1L,2L,4L,3L,1L,1L,5L,8L,9L,24L,23L,18L,10L,1L,1L,25L,48L,66L,76L,77L,294L,293L,268L,220L,154L,78L,1L,1L,295L,588L,856L,1076L,1230L,1308L,1309L,6664L,6663L,6368L,5780L,4924L,3848L,2618L,1310L,1L,1L,6665L,13328L,19696L,25476L,30400L,34248L,36866L,38176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227862Inst : IEnumerable<long>
{
public static readonly long[] Value=A227862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227862.Bytes);
public long this[int i]=>Value[i];

public static A227862Inst Instance=new A227862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227863
{
public static readonly long[] Value={ 1L,49L,121L,169L,241L,289L,361L,409L,481L,529L,601L,649L,721L,769L,841L,889L,961L,1009L,1081L,1129L,1201L,1249L,1321L,1369L,1441L,1489L,1561L,1609L,1681L,1729L,1801L,1849L,1921L,1969L,2041L,2089L,2161L,2209L,2281L,2329L,2401L,2449L,2521L,2569L,2641L,2689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227863Inst : IEnumerable<long>
{
public static readonly long[] Value=A227863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227863.Bytes);
public long this[int i]=>Value[i];

public static A227863Inst Instance=new A227863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227864
{
public static readonly long[] Value={ 0L,0L,3L,2L,0L,2L,2L,2L,4L,6L,2L,2L,2L,2L,2L,3L,8L,2L,3L,3L,2L,3L,2L,2L,2L,2L,2L,9L,2L,2L,6L,2L,4L,3L,2L,3L,12L,2L,6L,3L,2L,2L,6L,2L,2L,3L,2L,2L,2L,3L,2L,9L,2L,2L,3L,2L,2L,3L,2L,4L,12L,2L,2L,3L,12L,3L,6L,2L,2L,3L,10L,2L,6L,2L,2L,3L,10L,2L,26L,3L,2L,27L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227864Inst : IEnumerable<long>
{
public static readonly long[] Value=A227864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227864.Bytes);
public long this[int i]=>Value[i];

public static A227864Inst Instance=new A227864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227865
{
public static readonly long[] Value={ 0L,11001L,900L,7L,3L,61L,901L,903L,63L,65L,41L,905L,43L,67L,31L,907L,33L,68L,35L,45L,47L,37L,38L,300L,77L,301L,908L,303L,78L,305L,48L,307L,308L,317L,318L,320L,321L,917L,323L,600L,601L,918L,325L,80L,603L,605L,81L,920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227865Inst : IEnumerable<long>
{
public static readonly long[] Value=A227865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227865.Bytes);
public long this[int i]=>Value[i];

public static A227865Inst Instance=new A227865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227866
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,64L,3125L,288L,823543L,147456L,4251528L,460800L,285311670611L,111974400L,302875106592253L,3251404800L,13436928000L,106542032486400L,BigInteger.Parse("827240261886336764177"),1053455155200000L,BigInteger.Parse("1978419655660313589123979"),102395841085440000L };
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
public class A227866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227866Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227866.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227866.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227866Inst Instance=new A227866Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227867
{
public static readonly long[] Value={ 1L,8L,14L,32L,32L,112L,58L,32L,110L,256L,134L,448L,184L,464L,448L,32L,308L,880L,382L,1024L,812L,1072L,554L,448L,752L,1472L,974L,1856L,872L,3584L,994L,32L,1876L,2464L,1856L,3520L,1408L,3056L,2576L,1024L,1724L,6496L,1894L,4288L,3520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227867Inst : IEnumerable<long>
{
public static readonly long[] Value=A227867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227867.Bytes);
public long this[int i]=>Value[i];

public static A227867Inst Instance=new A227867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227868
{
public static readonly long[] Value={ 143L,187L,203L,217L,247L,323L,413L,427L,473L,517L,533L,623L,637L,667L,697L,713L,803L,817L,833L,847L,893L,923L,1027L,1043L,1057L,1073L,1133L,1147L,1177L,1207L,1253L,1267L,1313L,1343L,1357L,1387L,1403L,1417L,1463L,1477L,1507L,1537L,1643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227868Inst : IEnumerable<long>
{
public static readonly long[] Value=A227868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227868.Bytes);
public long this[int i]=>Value[i];

public static A227868Inst Instance=new A227868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227869
{
public static readonly long[] Value={ 187L,217L,247L,427L,517L,637L,667L,697L,817L,847L,1027L,1057L,1147L,1177L,1207L,1267L,1357L,1387L,1417L,1477L,1507L,1537L,1687L,1717L,1807L,1837L,1897L,1927L,1957L,2047L,2077L,2107L,2167L,2197L,2227L,2257L,2317L,2407L,2497L,2527L,2587L,2737L,2827L,2947L,2977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227869Inst : IEnumerable<long>
{
public static readonly long[] Value=A227869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227869.Bytes);
public long this[int i]=>Value[i];

public static A227869Inst Instance=new A227869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227870
{
public static readonly long[] Value={ 10L,12L,14L,16L,18L,21L,23L,25L,27L,29L,30L,32L,34L,36L,38L,41L,43L,45L,47L,49L,50L,52L,54L,56L,58L,61L,63L,65L,67L,69L,70L,72L,74L,76L,78L,81L,83L,85L,87L,89L,90L,92L,94L,96L,98L,1001L,1003L,1005L,1007L,1009L,1010L,1012L,1014L,1016L,1018L,1021L,1023L,1025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227870Inst : IEnumerable<long>
{
public static readonly long[] Value=A227870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227870.Bytes);
public long this[int i]=>Value[i];

public static A227870Inst Instance=new A227870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227871
{
public static readonly long[] Value={ 1L,5L,16L,17L,22L,29L,37L,23L,52L,44L,67L,65L,73L,68L,52L,80L,85L,83L,100L,122L,106L,116L,130L,137L,118L,140L,124L,152L,166L,173L,136L,158L,178L,179L,202L,128L,199L,176L,187L,206L,220L,227L,244L,230L,232L,224L,256L,272L,253L,275L,268L,278L,301L,272L,298L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227871Inst : IEnumerable<long>
{
public static readonly long[] Value=A227871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227871.Bytes);
public long this[int i]=>Value[i];

public static A227871Inst Instance=new A227871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227872
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,2L,4L,1L,2L,2L,3L,2L,4L,1L,5L,1L,2L,2L,3L,3L,4L,1L,4L,2L,4L,1L,6L,1L,2L,2L,6L,2L,2L,3L,3L,2L,4L,2L,4L,2L,6L,1L,6L,1L,2L,2L,5L,3L,4L,1L,6L,1L,2L,3L,8L,2L,2L,2L,3L,2L,4L,3L,7L,2L,4L,2L,3L,2L,6L,1L,4L,2L,4L,2L,6L,3L,4L,2L,5L,2L,4L,1L,9L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227872Inst : IEnumerable<long>
{
public static readonly long[] Value=A227872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227872.Bytes);
public long this[int i]=>Value[i];

public static A227872Inst Instance=new A227872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227873
{
public static readonly long[] Value={ 1L,3L,1L,7L,1L,3L,8L,15L,1L,3L,12L,7L,14L,24L,1L,31L,1L,3L,20L,7L,29L,36L,1L,15L,26L,42L,1L,56L,1L,3L,32L,63L,12L,3L,43L,7L,38L,60L,14L,15L,42L,87L,1L,84L,1L,3L,48L,31L,57L,78L,1L,98L,1L,3L,67L,120L,20L,3L,60L,7L,62L,96L,29L,127L,14L,36L,68L,7L,70L,129L,1L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227873Inst : IEnumerable<long>
{
public static readonly long[] Value=A227873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227873.Bytes);
public long this[int i]=>Value[i];

public static A227873Inst Instance=new A227873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227874
{
public static readonly long[] Value={ 6L,10L,20L,22L,32L,45L,46L,50L,58L,68L,76L,82L,92L,106L,117L,124L,152L,166L,170L,174L,178L,212L,226L,236L,261L,262L,272L,325L,333L,338L,346L,358L,382L,405L,412L,424L,435L,436L,452L,464L,466L,474L,477L,478L,495L,502L,506L,512L,530L,555L,562L,567L,574L,578L,586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227874Inst : IEnumerable<long>
{
public static readonly long[] Value=A227874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227874.Bytes);
public long this[int i]=>Value[i];

public static A227874Inst Instance=new A227874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227875
{
public static readonly long[] Value={ 0L,1L,8L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227875Inst : IEnumerable<long>
{
public static readonly long[] Value=A227875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227875.Bytes);
public long this[int i]=>Value[i];

public static A227875Inst Instance=new A227875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227876
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,2L,4L,6L,8L,10L,12L,14L,16L,18L,4L,4L,4L,6L,8L,10L,12L,14L,16L,18L,6L,6L,6L,6L,8L,10L,12L,14L,16L,18L,8L,8L,8L,8L,8L,10L,12L,14L,16L,18L,10L,10L,10L,10L,10L,10L,12L,14L,16L,18L,12L,12L,12L,12L,12L,12L,12L,14L,16L,18L,14L,14L,14L,14L,14L,14L,14L,14L,16L,18L,16L,16L,16L,16L,16L,16L,16L,16L,16L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,3L,4L,7L,10L,13L,16L,19L,22L,25L,28L,4L,3L,6L,9L,12L,15L,18L,21L,24L,27L,7L,6L,7L,8L,11L,14L,17L,20L,23L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227876Inst : IEnumerable<long>
{
public static readonly long[] Value=A227876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227876.Bytes);
public long this[int i]=>Value[i];

public static A227876Inst Instance=new A227876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227877
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,2L,2L,3L,3L,7L,3L,6L,3L,3L,2L,3L,7L,6L,7L,5L,4L,5L,10L,2L,10L,4L,5L,2L,2L,9L,5L,9L,2L,4L,3L,4L,5L,7L,5L,11L,12L,5L,8L,11L,12L,5L,11L,3L,7L,11L,4L,10L,6L,2L,9L,11L,8L,7L,9L,8L,9L,4L,3L,4L,10L,6L,9L,15L,9L,17L,3L,3L,8L,12L,10L,5L,1L,7L,9L,16L,8L,17L,6L,8L,16L,6L,8L,8L,10L,1L,6L,4L,8L,5L,23L,11L,2L,9L,6L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227877Inst : IEnumerable<long>
{
public static readonly long[] Value=A227877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227877.Bytes);
public long this[int i]=>Value[i];

public static A227877Inst Instance=new A227877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227878
{
public static readonly long[] Value={ 3L,19L,41L,43L,71L,83L,101L,109L,151L,167L,199L,227L,229L,257L,281L,283L,311L,313L,349L,383L,401L,443L,461L,463L,487L,503L,571L,601L,617L,641L,643L,677L,727L,757L,829L,857L,859L,881L,883L,911L,937L,941L,971L,1033L,1063L,1091L,1093L,1123L,1187L,1217L,1231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227878Inst : IEnumerable<long>
{
public static readonly long[] Value=A227878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227878.Bytes);
public long this[int i]=>Value[i];

public static A227878Inst Instance=new A227878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227879
{
public static readonly long[] Value={ 70L,280L,360L,480L,630L,1120L,1312L,1440L,1750L,1768L,1920L,2132L,2520L,3240L,3430L,4320L,4480L,5248L,5670L,5760L,7000L,7038L,7072L,7680L,7800L,8470L,8528L,9000L,9240L,10080L,11808L,11830L,12000L,12960L,13720L,13950L,14744L,15750L,15912L,17280L,17640L,17920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227879Inst : IEnumerable<long>
{
public static readonly long[] Value=A227879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227879.Bytes);
public long this[int i]=>Value[i];

public static A227879Inst Instance=new A227879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227880
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,29L,31L,61L,89L,127L,149L,233L,401L,509L,773L,1021L,1597L,4093L,8191L,16381L,28657L,31489L,128257L,131071L,514229L,524287L,1048573L,4194301L,5976577L,16777213L,433494437L,536870909L,2147483647L,2971215073L,4293722117L,5350220959L,13435170943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227880Inst : IEnumerable<long>
{
public static readonly long[] Value=A227880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227880.Bytes);
public long this[int i]=>Value[i];

public static A227880Inst Instance=new A227880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227881
{
public static readonly long[] Value={ 1L,8L,19L,17L,19L,35L,37L,35L,55L,71L,55L,62L,64L,80L,91L,80L,109L,98L,91L,98L,82L,116L,136L,143L,109L,152L,163L,152L,145L,152L,172L,170L,172L,170L,208L,215L,199L,197L,226L,233L,217L,206L,271L,224L,244L,242L,253L,287L,244L,305L,271L,269L,298L,305L,325L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227881Inst : IEnumerable<long>
{
public static readonly long[] Value=A227881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227881.Bytes);
public long this[int i]=>Value[i];

public static A227881Inst Instance=new A227881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227882
{
public static readonly long[] Value={ 1L,3L,19L,0L,87L,117L,0L,30L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227882Inst : IEnumerable<long>
{
public static readonly long[] Value=A227882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227882.Bytes);
public long this[int i]=>Value[i];

public static A227882Inst Instance=new A227882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227883
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,5L,50L,328L,2154L,16751L,144840L,1314149L,12735722L,134159743L,1519210786L,18272249418L,233231701166L,3159471128588L,45243728569842L,682183513506619L,10807962134238068L,179606706777512992L,3123700853586733882L,BigInteger.Parse("56737351453843424893") };
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
public class A227883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227883.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227883Inst Instance=new A227883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227884
{
public static readonly long[] Value={ 1L,1L,2L,6L,19L,5L,70L,50L,331L,328L,61L,1863L,2154L,1023L,11637L,16751L,10547L,1385L,81110L,144840L,102030L,34900L,635550L,1314149L,1109973L,518607L,50521L,5495339L,12735722L,13046040L,6858598L,1781101L,51590494L,134159743L,157195762L,97348436L,36004400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227884Inst : IEnumerable<long>
{
public static readonly long[] Value=A227884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227884.Bytes);
public long this[int i]=>Value[i];

public static A227884Inst Instance=new A227884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227885
{
public static readonly long[] Value={ 2L,3L,7L,11L,29L,31L,47L,71L,113L,127L,131L,191L,199L,223L,239L,241L,367L,439L,443L,521L,863L,983L,1013L,1499L,1871L,2003L,2207L,3571L,6553L,8087L,8191L,9349L,16369L,32647L,32707L,36319L,63487L,65407L,65519L,122401L,126719L,131071L,196331L,260111L,524287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227885Inst : IEnumerable<long>
{
public static readonly long[] Value=A227885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227885.Bytes);
public long this[int i]=>Value[i];

public static A227885Inst Instance=new A227885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227886
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,6L,-24L,-820L,27144L,-1291488L,59107938L,-3469468244L,-551251146312L,110380085358300L,-14603070221993568L,1245952635117666628L,BigInteger.Parse("29007906387788967008"),BigInteger.Parse("-20843885535528328473491"),BigInteger.Parse("-180339645015007436197752"),BigInteger.Parse("127321605693530805940344950"),BigInteger.Parse("281613877399819446654643101264") };
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
public class A227886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227886Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227886.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227886.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227886Inst Instance=new A227886Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227887
{
public static readonly BigInteger[] Value={ 1L,1L,17L,1585L,485729L,372281761L,601378506737L,1820943071778385L,9489456505643743169UL,BigInteger.Parse("79759396929125826861121"),BigInteger.Parse("1027412704023984825792488657"),BigInteger.Parse("19464301715272748317827942755185"),BigInteger.Parse("524230105465412991467916306841439009"),BigInteger.Parse("19509134827116013764271741468197795034081") };
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
public class A227887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227887Inst Instance=new A227887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227888
{
public static readonly long[] Value={ 3L,1L,19L,3L,19L,273L,93L,113L,87L,35L,31L,143L,31L,15L,315L,779L,207L,347L,91L,327L,291L,351L,195L,39L,1911L,971L,1083L,435L,1345L,593L,183L,1295L,291L,2553L,735L,1113L,31L,131L,61L,209L,379L,567L,2331L,1907L,4429L,23L,453L,1517L,2281L,2187L,1441L,4847L,1975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227888Inst : IEnumerable<long>
{
public static readonly long[] Value=A227888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227888.Bytes);
public long this[int i]=>Value[i];

public static A227888Inst Instance=new A227888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227889
{
public static readonly long[] Value={ 6L,11346L,1721418L,7449858L,11215266L,14101830L,28118346L,31755786L,37118418L,48517386L,69016314L,78075906L,258216018L,409092018L,410775306L,443414418L,453980706L,471867666L,525843960L,582427266L,758573106L,800349666L,805060626L,874923018L,1042069218L,1458081714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227889Inst : IEnumerable<long>
{
public static readonly long[] Value=A227889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227889.Bytes);
public long this[int i]=>Value[i];

public static A227889Inst Instance=new A227889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227890
{
public static readonly long[] Value={ 3L,7L,163L,353L,5021L,12739L,32719L,49681L,52391L,78901L,113501L,252913L,361091L,452807L,551917L,993841L,1559797L,1956979L,2193127L,3463037L,4067983L,5003837L,5138953L,6115363L,6723271L,7251857L,7447043L,7578607L,8426989L,9479801L,11295847L,12186593L,12439237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227890Inst : IEnumerable<long>
{
public static readonly long[] Value=A227890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227890.Bytes);
public long this[int i]=>Value[i];

public static A227890Inst Instance=new A227890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227891
{
public static readonly long[] Value={ 1L,9L,25L,289L,441L,529L,625L,841L,1849L,2809L,3249L,5041L,6889L,7225L,7569L,7921L,10201L,12769L,15129L,15625L,19321L,21025L,22201L,26569L,31329L,38809L,46225L,48841L,53361L,55225L,66049L,69169L,72361L,76729L,78961L,83521L,85849L,93025L,96721L,100489L,103041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227891Inst : IEnumerable<long>
{
public static readonly long[] Value=A227891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227891.Bytes);
public long this[int i]=>Value[i];

public static A227891Inst Instance=new A227891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227892
{
public static readonly long[] Value={ 191L,1129211L,3218123L,7129217L,7718177L,125292521L,146181641L,171292171L,197292791L,198292891L,316141613L,325383523L,359292953L,767292767L,773181377L,777494777L,929292929L,946141649L,983181389L,992181299L,11222922211L,11584948511L,11942924911L,11991819911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227892Inst : IEnumerable<long>
{
public static readonly long[] Value=A227892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227892.Bytes);
public long this[int i]=>Value[i];

public static A227892Inst Instance=new A227892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227893
{
public static readonly long[] Value={ 1123529253211L,1261129211621L,9989629269899L,136671292176631L,138354292453831L,141495292594141L,143255292552341L,143445292544341L,144413292314441L,158232292232851L,165882292288561L,176838292838671L,184623292326481L,188291292192881L,322632292236223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227893Inst : IEnumerable<long>
{
public static readonly long[] Value=A227893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227893.Bytes);
public long this[int i]=>Value[i];

public static A227893Inst Instance=new A227893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227894
{
public static readonly long[] Value={ 16831813861L,3026159516203L,303551090155303L,310917383719013L,324260616062423L,705345191543507L,906794646497609L,979863191368979L,10245455355454201L,10504462826440501L,10591066266019501L,10899190809199801L,10940832823804901L,11140913931904111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227894Inst : IEnumerable<long>
{
public static readonly long[] Value=A227894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227894.Bytes);
public long this[int i]=>Value[i];

public static A227894Inst Instance=new A227894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227895
{
public static readonly long[] Value={ 12L,24L,60L,120L,168L,240L,420L,660L,720L,840L,1092L,1320L,1680L,2448L,2520L,2640L,3360L,3420L,3960L,5280L,5460L,6072L,6240L,6840L,9360L,10920L,12240L,14280L,15600L,15960L,16320L,17160L,18480L,21840L,22440L,24480L,26520L,27720L,31920L,35880L,38760L,43680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227895Inst : IEnumerable<long>
{
public static readonly long[] Value=A227895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227895.Bytes);
public long this[int i]=>Value[i];

public static A227895Inst Instance=new A227895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227896
{
public static readonly long[] Value={ 1L,4L,8L,8L,4L,5L,1L,5L,4L,8L,4L,5L,1L,1L,5L,8L,8L,5L,1L,1L,5L,4L,8L,4L,5L,1L,5L,4L,8L,8L,4L,1L,1L,4L,8L,8L,4L,5L,1L,5L,4L,8L,4L,5L,1L,1L,5L,8L,8L,5L,1L,1L,5L,4L,8L,4L,5L,1L,5L,4L,8L,8L,4L,1L,1L,4L,8L,8L,4L,5L,1L,5L,4L,8L,4L,5L,1L,1L,5L,8L,8L,5L,1L,1L,5L,4L,8L,4L,5L,1L,5L,4L,8L,8L,4L,1L,1L,4L,8L,8L,4L,5L,1L,5L,4L,8L,4L,5L,1L,1L,5L,8L,8L,5L,1L,1L,5L,4L,8L,4L,5L,1L,5L,4L,8L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227896Inst : IEnumerable<long>
{
public static readonly long[] Value=A227896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227896.Bytes);
public long this[int i]=>Value[i];

public static A227896Inst Instance=new A227896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227897
{
public static readonly long[] Value={ 4L,5L,13L,14L,19L,22L,23L,24L,31L,32L,40L,41L,49L,50L,58L,59L,63L,67L,68L,71L,76L,77L,85L,86L,94L,95L,102L,103L,104L,112L,113L,121L,122L,130L,131L,139L,140L,148L,149L,157L,158L,166L,167L,175L,176L,184L,185L,193L,194L,202L,203L,211L,212L,218L,220L,221L,223L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227897Inst : IEnumerable<long>
{
public static readonly long[] Value=A227897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227897.Bytes);
public long this[int i]=>Value[i];

public static A227897Inst Instance=new A227897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227898
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,3L,1L,4L,3L,2L,2L,3L,3L,3L,3L,3L,4L,4L,2L,2L,3L,3L,3L,2L,2L,5L,5L,2L,5L,4L,2L,4L,5L,2L,7L,5L,3L,4L,5L,3L,3L,4L,4L,3L,5L,4L,9L,9L,2L,5L,3L,4L,8L,6L,2L,5L,8L,3L,4L,7L,3L,10L,5L,2L,7L,4L,5L,10L,6L,4L,6L,6L,2L,6L,8L,3L,6L,5L,3L,6L,6L,5L,9L,4L,5L,7L,5L,4L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227898Inst : IEnumerable<long>
{
public static readonly long[] Value=A227898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227898.Bytes);
public long this[int i]=>Value[i];

public static A227898Inst Instance=new A227898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227899
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,2L,1L,2L,2L,1L,3L,2L,1L,2L,2L,1L,2L,3L,2L,3L,3L,2L,3L,2L,3L,1L,1L,3L,2L,4L,2L,3L,3L,3L,4L,1L,2L,6L,2L,4L,2L,3L,5L,4L,2L,3L,4L,4L,4L,4L,2L,1L,2L,4L,2L,4L,2L,6L,7L,5L,3L,3L,9L,2L,3L,3L,2L,4L,4L,3L,1L,2L,8L,3L,6L,2L,2L,8L,4L,7L,2L,2L,5L,2L,3L,3L,2L,8L,3L,3L,1L,4L,7L,5L,9L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227899Inst : IEnumerable<long>
{
public static readonly long[] Value=A227899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227899.Bytes);
public long this[int i]=>Value[i];

public static A227899Inst Instance=new A227899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227900
{
public static readonly long[] Value={ 1L,-9L,27L,-12L,-90L,132L,81L,-180L,-153L,185L,252L,-324L,162L,396L,-555L,-1264L,936L,1377L,-220L,1080L,-1188L,-2268L,-3303L,2640L,4975L,792L,2430L,-972L,-6930L,-11880L,6752L,5616L,6804L,4576L,-1665L,1836L,-18954L,1980L,-2376L,3700L,-198L,10692L,567L,-3024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227900Inst : IEnumerable<long>
{
public static readonly long[] Value=A227900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227900.Bytes);
public long this[int i]=>Value[i];

public static A227900Inst Instance=new A227900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227901
{
public static readonly long[] Value={ 1L,-3L,0L,5L,0L,-9L,20L,0L,-45L,0L,36L,-18L,0L,135L,0L,-104L,-153L,0L,-60L,0L,252L,367L,0L,-450L,0L,-270L,108L,0L,660L,0L,-624L,-756L,0L,405L,0L,2106L,-220L,0L,-900L,0L,-1188L,-63L,0L,-765L,0L,-1589L,3792L,0L,925L,0L,216L,-878L,0L,1260L,0L,660L,-6930L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227901Inst : IEnumerable<long>
{
public static readonly long[] Value=A227901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227901.Bytes);
public long this[int i]=>Value[i];

public static A227901Inst Instance=new A227901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227902
{
public static readonly long[] Value={ 1L,2L,4L,6L,15L,20L,24L,28L,40L,42L,45L,66L,72L,77L,88L,91L,104L,110L,126L,140L,153L,156L,170L,187L,190L,204L,209L,210L,220L,228L,231L,238L,240L,266L,276L,299L,304L,308L,312L,315L,322L,325L,330L,345L,368L,378L,414L,420L,429L,435L,440L,442L,450L,459L,460L,464L,468L,476L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227902Inst : IEnumerable<long>
{
public static readonly long[] Value=A227902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227902.Bytes);
public long this[int i]=>Value[i];

public static A227902Inst Instance=new A227902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227903
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,5L,2L,1L,4L,2L,2L,1L,2L,3L,3L,1L,3L,2L,3L,4L,2L,2L,2L,1L,2L,3L,3L,1L,3L,1L,5L,2L,5L,5L,4L,4L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,4L,1L,5L,5L,6L,6L,3L,2L,3L,2L,5L,4L,2L,2L,2L,1L,2L,2L,5L,6L,4L,5L,2L,4L,3L,13L,2L,4L,5L,5L,2L,10L,4L,3L,14L,3L,11L,8L,4L,2L,4L,1L,7L,6L,3L,2L,3L,2L,2L,1L,2L,2L,3L,2L,2L,1L,2L,6L,4L,3L,8L,3L,4L,2L,3L,1L,11L,9L,6L,4L,7L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227903Inst : IEnumerable<long>
{
public static readonly long[] Value=A227903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227903.Bytes);
public long this[int i]=>Value[i];

public static A227903Inst Instance=new A227903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227904
{
public static readonly long[] Value={ 1L,2L,39L,78L,100L,126L,434L,501L,1313L,54111L,359466L,523219L,6601441L,8034674L,54092207L,64149290L,158882288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227904Inst : IEnumerable<long>
{
public static readonly long[] Value=A227904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227904.Bytes);
public long this[int i]=>Value[i];

public static A227904Inst Instance=new A227904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227905
{
public static readonly long[] Value={ 741751L,1024651L,5481451L,31150351L,109437751L,139952671L,178482151L,284301751L,383425351L,395044651L,407282851L,417027451L,498706651L,582799951L,612816751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227905Inst : IEnumerable<long>
{
public static readonly long[] Value=A227905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227905.Bytes);
public long this[int i]=>Value[i];

public static A227905Inst Instance=new A227905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227906
{
public static readonly long[] Value={ 2L,4L,4L,9L,6L,13L,8L,17L,10L,21L,12L,25L,14L,29L,16L,33L,18L,37L,20L,41L,22L,45L,24L,49L,26L,53L,28L,57L,30L,61L,32L,65L,34L,69L,36L,73L,38L,77L,40L,81L,42L,85L,44L,89L,46L,93L,48L,97L,50L,101L,52L,105L,54L,109L,56L,113L,58L,117L,60L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227906Inst : IEnumerable<long>
{
public static readonly long[] Value=A227906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227906.Bytes);
public long this[int i]=>Value[i];

public static A227906Inst Instance=new A227906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227907
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,19L,37L,67L,71L,79L,137L,191L,229L,277L,283L,317L,347L,359L,397L,409L,431L,457L,461L,479L,499L,577L,691L,739L,743L,757L,787L,811L,829L,839L,967L,1009L,1061L,1087L,1091L,1109L,1153L,1193L,1279L,1327L,1373L,1429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227907Inst : IEnumerable<long>
{
public static readonly long[] Value=A227907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227907.Bytes);
public long this[int i]=>Value[i];

public static A227907Inst Instance=new A227907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227908
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,2L,3L,2L,2L,0L,2L,6L,1L,3L,5L,2L,3L,2L,1L,2L,2L,5L,4L,3L,2L,3L,8L,1L,4L,3L,3L,2L,5L,1L,2L,4L,5L,3L,4L,4L,2L,6L,1L,4L,5L,3L,3L,6L,2L,6L,5L,4L,5L,7L,3L,1L,9L,2L,3L,6L,1L,2L,5L,4L,7L,2L,7L,6L,6L,2L,4L,10L,3L,3L,6L,1L,7L,9L,5L,4L,5L,4L,3L,5L,3L,5L,8L,4L,4L,5L,2L,11L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227908Inst : IEnumerable<long>
{
public static readonly long[] Value=A227908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227908.Bytes);
public long this[int i]=>Value[i];

public static A227908Inst Instance=new A227908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227909
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,3L,3L,1L,2L,5L,2L,3L,2L,3L,3L,5L,3L,1L,5L,4L,5L,4L,3L,4L,7L,4L,4L,2L,1L,4L,9L,2L,4L,11L,4L,2L,6L,2L,6L,11L,6L,4L,3L,3L,5L,6L,4L,3L,6L,2L,4L,10L,3L,10L,12L,7L,1L,6L,6L,5L,11L,4L,5L,6L,4L,3L,11L,2L,10L,13L,4L,6L,5L,2L,14L,13L,2L,2L,5L,5L,9L,15L,5L,3L,7L,8L,5L,3L,5L,7L,15L,3L,1L,8L,5L,7L,11L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227909Inst : IEnumerable<long>
{
public static readonly long[] Value=A227909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227909.Bytes);
public long this[int i]=>Value[i];

public static A227909Inst Instance=new A227909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227910
{
public static readonly long[] Value={ 1L,2L,4L,8L,13L,24L,40L,71L,119L,216L,372L,678L,1215L,2240L,4102L,7674L,14299L,27000L,50952L,96896L,184397L,352684L,675174L,1296843L,2493711L,4806062L,9272764L,17920843L,34669585L,67159032L,130216106L,252745349L,490984469L,954637538L,1857545280L,3617214660L,7048675939L,13744694906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227910Inst : IEnumerable<long>
{
public static readonly long[] Value=A227910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227910.Bytes);
public long this[int i]=>Value[i];

public static A227910Inst Instance=new A227910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227911
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,2L,2L,3L,2L,2L,4L,4L,4L,5L,4L,4L,5L,5L,6L,7L,6L,6L,7L,7L,6L,7L,7L,7L,9L,9L,9L,10L,9L,9L,10L,10L,10L,11L,10L,10L,12L,12L,13L,14L,13L,13L,14L,14L,13L,14L,14L,14L,15L,15L,15L,16L,15L,15L,17L,17L,17L,18L,17L,17L,18L,18L,19L,20L,19L,19L,20L,20L,20L,21L,21L,21L,22L,22L,22L,23L,22L,22L,24L,24L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227911Inst : IEnumerable<long>
{
public static readonly long[] Value=A227911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227911.Bytes);
public long this[int i]=>Value[i];

public static A227911Inst Instance=new A227911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227912
{
public static readonly long[] Value={ 0L,0L,2L,3L,9L,4L,14L,14L,19L,28L,24L,29L,41L,51L,54L,49L,67L,74L,89L,87L,99L,110L,120L,125L,142L,154L,169L,178L,180L,211L,197L,223L,262L,261L,285L,270L,299L,323L,342L,371L,359L,374L,422L,434L,477L,454L,478L,493L,538L,566L,555L,628L,606L,663L,666L,676L,716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227912Inst : IEnumerable<long>
{
public static readonly long[] Value=A227912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227912.Bytes);
public long this[int i]=>Value[i];

public static A227912Inst Instance=new A227912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227913
{
public static readonly long[] Value={ 0L,0L,2L,3L,5L,4L,10L,14L,15L,20L,20L,29L,37L,43L,38L,49L,63L,66L,85L,71L,83L,102L,116L,125L,118L,146L,153L,162L,176L,179L,193L,223L,246L,253L,233L,254L,295L,315L,326L,339L,355L,342L,418L,418L,405L,446L,474L,493L,506L,518L,539L,612L,602L,631L,598L,644L,700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227913Inst : IEnumerable<long>
{
public static readonly long[] Value=A227913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227913.Bytes);
public long this[int i]=>Value[i];

public static A227913Inst Instance=new A227913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227914
{
public static readonly BigInteger[] Value={ 1L,6L,25L,116L,722L,5956L,59243L,667500L,8296060L,112406158L,1648441865L,26016230581L,439698829588L,7923291500266L,151636272041063L,3071397457222772L,65637064987470128L,1475783903907314842L,BigInteger.Parse("34822081020977308581"),BigInteger.Parse("860290584362463964031"),BigInteger.Parse("22206678791494395506940"),BigInteger.Parse("597775158911764084886982"),BigInteger.Parse("16751152450234618859184419"),BigInteger.Parse("487867395080603697285978385"),BigInteger.Parse("14745549219503008426659528806") };
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
public class A227914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227914Inst Instance=new A227914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227915
{
public static readonly long[] Value={ 4102L,12295L,20487L,28680L,36871L,45064L,53256L,61449L,69639L,77832L,86024L,94217L,102408L,110601L,118793L,126986L,135175L,143368L,151560L,159753L,167944L,176137L,184329L,192522L,200712L,208905L,217097L,225290L,233481L,241674L,249866L,258059L,266247L,274440L,282632L,290825L,299016L,307209L,315401L,323594L,331784L,339977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227915Inst : IEnumerable<long>
{
public static readonly long[] Value=A227915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227915.Bytes);
public long this[int i]=>Value[i];

public static A227915Inst Instance=new A227915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227916
{
public static readonly long[] Value={ 13L,17L,23L,37L,43L,47L,53L,67L,73L,83L,97L,103L,107L,113L,131L,137L,167L,173L,179L,197L,211L,223L,229L,241L,271L,283L,307L,311L,313L,317L,331L,337L,347L,353L,359L,367L,373L,379L,383L,389L,397L,419L,431L,443L,461L,467L,479L,503L,523L,541L,547L,571L,607L,613L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227916Inst : IEnumerable<long>
{
public static readonly long[] Value=A227916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227916.Bytes);
public long this[int i]=>Value[i];

public static A227916Inst Instance=new A227916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227917
{
public static readonly BigInteger[] Value={ 1L,4L,26L,232L,2624L,35888L,575280L,10569984L,218911872L,5044346112L,127980834816L,3544627393536L,106408500206592L,3441351475359744L,119279906031888384L,4410902376303722496L,BigInteger.Parse("173335758665503997952"),BigInteger.Parse("7213199863532804702208"),BigInteger.Parse("316878056718379090771968") };
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
public class A227917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227917Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227917.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227917.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227917Inst Instance=new A227917Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227918
{
public static readonly BigInteger[] Value={ 1L,0L,5L,22L,137L,956L,7653L,68874L,688745L,7576192L,90914309L,1181886014L,16546404201L,248196063012L,3971137008197L,67509329139346L,1215167924508233L,23088190565656424L,461763811313128485L,9697040037575698182UL,BigInteger.Parse("213334880826665360009"),BigInteger.Parse("4906702259013303280204"),BigInteger.Parse("117760854216319278724901") };
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
public class A227918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227918.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227918Inst Instance=new A227918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227919
{
public static readonly long[] Value={ 23L,29L,31L,37L,53L,59L,71L,73L,79L,113L,131L,137L,139L,173L,179L,191L,193L,197L,199L,233L,239L,293L,311L,313L,317L,373L,379L,419L,431L,433L,439L,479L,593L,599L,613L,617L,619L,673L,677L,719L,733L,739L,797L,839L,971L,977L,1013L,1019L,1031L,1033L,1039L,1091L,1093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227919Inst : IEnumerable<long>
{
public static readonly long[] Value=A227919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227919.Bytes);
public long this[int i]=>Value[i];

public static A227919Inst Instance=new A227919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227920
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,3L,1L,3L,1L,2L,4L,1L,3L,1L,3L,4L,1L,4L,2L,5L,4L,1L,4L,4L,3L,5L,1L,3L,2L,3L,8L,2L,6L,4L,4L,7L,2L,6L,5L,3L,8L,2L,6L,6L,3L,10L,2L,8L,4L,4L,10L,2L,9L,4L,4L,6L,1L,7L,4L,4L,8L,5L,3L,6L,4L,7L,1L,3L,5L,2L,10L,3L,7L,5L,3L,11L,3L,9L,4L,5L,6L,1L,7L,5L,5L,9L,4L,6L,4L,6L,9L,2L,5L,4L,3L,5L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227920Inst : IEnumerable<long>
{
public static readonly long[] Value=A227920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227920.Bytes);
public long this[int i]=>Value[i];

public static A227920Inst Instance=new A227920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227921
{
public static readonly long[] Value={ 1L,7L,11L,13L,19L,31L,37L,41L,47L,49L,59L,61L,67L,73L,79L,91L,97L,103L,107L,109L,121L,127L,131L,133L,137L,143L,151L,157L,167L,173L,179L,181L,191L,193L,199L,211L,217L,223L,227L,229L,233L,239L,241L,247L,251L,259L,271L,283L,307L,313L,331L,341L,361L,367L,379L,397L,403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227921Inst : IEnumerable<long>
{
public static readonly long[] Value=A227921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227921.Bytes);
public long this[int i]=>Value[i];

public static A227921Inst Instance=new A227921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227922
{
public static readonly long[] Value={ 5L,7L,25L,55L,75L,325L,555L,755L,775L,2525L,2575L,3225L,3325L,5325L,5555L,7525L,7555L,7575L,7775L,25775L,32225L,33225L,33325L,53225L,53325L,55555L,75325L,75555L,75775L,77525L,77575L,77775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227922Inst : IEnumerable<long>
{
public static readonly long[] Value=A227922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227922.Bytes);
public long this[int i]=>Value[i];

public static A227922Inst Instance=new A227922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227923
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,1L,4L,2L,4L,4L,2L,5L,3L,4L,4L,2L,5L,4L,4L,5L,1L,3L,3L,5L,8L,4L,7L,4L,3L,7L,2L,7L,6L,5L,8L,3L,6L,6L,4L,10L,4L,8L,5L,4L,10L,3L,9L,4L,4L,6L,1L,8L,5L,5L,8L,4L,4L,6L,3L,7L,1L,3L,5L,4L,10L,5L,7L,6L,3L,11L,3L,9L,5L,5L,6L,2L,7L,5L,5L,9L,4L,6L,4L,5L,9L,2L,6L,3L,4L,5L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227923Inst : IEnumerable<long>
{
public static readonly long[] Value=A227923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227923.Bytes);
public long this[int i]=>Value[i];

public static A227923Inst Instance=new A227923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227924
{
public static readonly long[] Value={ 2L,4L,2L,18L,0L,2L,64L,4L,0L,2L,238L,12L,0L,0L,2L,890L,28L,4L,0L,0L,2L,3348L,70L,12L,0L,0L,0L,2L,12662L,182L,20L,4L,0L,0L,0L,2L,48102L,466L,38L,12L,0L,0L,0L,0L,2L,183460L,1186L,84L,20L,4L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227924Inst : IEnumerable<long>
{
public static readonly long[] Value=A227924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227924.Bytes);
public long this[int i]=>Value[i];

public static A227924Inst Instance=new A227924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227925
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,3L,4L,2L,1L,2L,5L,4L,2L,1L,4L,8L,7L,4L,2L,1L,2L,8L,10L,7L,4L,2L,1L,4L,13L,14L,12L,7L,4L,2L,1L,3L,12L,19L,16L,12L,7L,4L,2L,1L,4L,17L,26L,25L,18L,12L,7L,4L,2L,1L,2L,16L,29L,32L,27L,18L,12L,7L,4L,2L,1L,6L,24L,41L,45L,38L,29L,18L,12L,7L,4L,2L,1L,2L,19L,44L,55L,51L,40L,29L,18L,12L,7L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227925Inst : IEnumerable<long>
{
public static readonly long[] Value=A227925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227925.Bytes);
public long this[int i]=>Value[i];

public static A227925Inst Instance=new A227925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227926
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,1L,3L,8L,4L,1L,2L,16L,10L,4L,1L,4L,22L,22L,10L,4L,1L,2L,36L,40L,24L,10L,4L,1L,4L,47L,66L,46L,24L,10L,4L,1L,3L,60L,110L,84L,48L,24L,10L,4L,1L,4L,83L,158L,144L,90L,48L,24L,10L,4L,1L,2L,100L,233L,232L,162L,92L,48L,24L,10L,4L,1L,6L,116L,327L,357L,266L,168L,92L,48L,24L,10L,4L,1L,2L,148L,444L,544L,435L,284L,170L,92L,48L,24L,10L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227926Inst : IEnumerable<long>
{
public static readonly long[] Value=A227926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227926.Bytes);
public long this[int i]=>Value[i];

public static A227926Inst Instance=new A227926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227927
{
public static readonly long[] Value={ 1L,2L,36L,144L,576L,3600L,14400L,921600L,1040400L,4161600L,8643600L,34574400L,266342400L,700131600L,2800526400L,179233689600L,202338032400L,809352129600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227927Inst : IEnumerable<long>
{
public static readonly long[] Value=A227927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227927.Bytes);
public long this[int i]=>Value[i];

public static A227927Inst Instance=new A227927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227928
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,8L,16L,27L,32L,81L,64L,128L,243L,256L,512L,729L,1024L,2187L,2048L,4096L,6561L,8192L,19683L,16384L,32768L,59049L,65536L,131072L,177147L,262144L,531441L,524288L,1048576L,1594323L,2097152L,4782969L,4194304L,8388608L,14348907L,16777216L,43046721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227928Inst : IEnumerable<long>
{
public static readonly long[] Value=A227928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227928.Bytes);
public long this[int i]=>Value[i];

public static A227928Inst Instance=new A227928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227929
{
public static readonly long[] Value={ 3L,6L,9L,5L,7L,5L,3L,6L,1L,1L,6L,8L,6L,3L,6L,0L,6L,6L,8L,0L,9L,5L,0L,0L,1L,9L,7L,6L,1L,6L,2L,7L,2L,9L,8L,9L,1L,0L,5L,8L,0L,0L,8L,6L,6L,7L,3L,0L,9L,7L,7L,4L,5L,7L,8L,5L,4L,0L,4L,9L,2L,7L,6L,9L,9L,1L,0L,5L,1L,8L,5L,6L,3L,1L,9L,8L,6L,9L,1L,2L,8L,9L,6L,6L,6L,0L,5L,7L,4L,9L,4L,6L,3L,0L,4L,5L,7L,6L,6L,0L,2L,5L,7L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227929Inst : IEnumerable<long>
{
public static readonly long[] Value=A227929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227929.Bytes);
public long this[int i]=>Value[i];

public static A227929Inst Instance=new A227929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227930
{
public static readonly long[] Value={ 11L,19L,47L,59L,67L,79L,107L,131L,179L,191L,211L,227L,239L,251L,271L,283L,307L,331L,367L,379L,419L,431L,443L,463L,491L,499L,563L,587L,659L,719L,787L,827L,859L,883L,911L,947L,971L,1019L,1039L,1051L,1087L,1123L,1163L,1171L,1187L,1231L,1259L,1279L,1291L,1327L,1423L,1451L,1459L,1471L,1483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227930Inst : IEnumerable<long>
{
public static readonly long[] Value=A227930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227930.Bytes);
public long this[int i]=>Value[i];

public static A227930Inst Instance=new A227930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227931
{
public static readonly long[] Value={ 5521819L,33014273L,36183593L,39874273L,47143739L,82934191L,83640653L,86225437L,89121073L,99551093L,104663773L,108616619L,109514719L,117611519L,131616409L,142348637L,151942291L,168056137L,168066791L,172096037L,196415237L,197604227L,203519819L,204983507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227931Inst : IEnumerable<long>
{
public static readonly long[] Value=A227931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227931.Bytes);
public long this[int i]=>Value[i];

public static A227931Inst Instance=new A227931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227932
{
public static readonly long[] Value={ 77L,147L,154L,169L,175L,209L,231L,245L,275L,287L,294L,308L,325L,329L,338L,343L,350L,399L,407L,413L,418L,427L,441L,455L,462L,469L,483L,490L,525L,533L,550L,553L,567L,574L,588L,605L,609L,616L,649L,650L,658L,676L,679L,686L,700L,703L,715L,735L,759L,763L,777L,798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227932Inst : IEnumerable<long>
{
public static readonly long[] Value=A227932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227932.Bytes);
public long this[int i]=>Value[i];

public static A227932Inst Instance=new A227932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227933
{
public static readonly long[] Value={ 354963229L,448024483L,467739719L,475313609L,525523709L,771943583L,790277219L,881160173L,901572019L,925569683L,1051470419L,1085896727L,1110999817L,1285560163L,1331768783L,1455016319L,1472310383L,1519074619L,1628600381L,1815368519L,1914032047L,1990306673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227933Inst : IEnumerable<long>
{
public static readonly long[] Value=A227933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227933.Bytes);
public long this[int i]=>Value[i];

public static A227933Inst Instance=new A227933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227934
{
public static readonly BigInteger[] Value={ 1L,1L,2L,18L,219L,4395L,129280L,4970984L,257765641L,16781325293L,1348125117404L,132465548869248L,15490711962965785L,2134540479514352751L,BigInteger.Parse("343307151209151099650"),BigInteger.Parse("63606662918084631874716"),BigInteger.Parse("13470938654397531939066909"),BigInteger.Parse("3238387688528230753569245297"),BigInteger.Parse("876825599524773154743990986391") };
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
public class A227934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227934.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227934Inst Instance=new A227934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227935
{
public static readonly BigInteger[] Value={ 1L,1L,2L,34L,773L,36656L,3001377L,333647780L,58561139773L,13838291852092L,4280413527001849L,1779704699369214238L,BigInteger.Parse("931039792575220097699"),BigInteger.Parse("604786686422678514970170"),BigInteger.Parse("489307443863919174036440087"),BigInteger.Parse("478922652139578822529676247092"),BigInteger.Parse("560120417434857039499787289137249") };
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
public class A227935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227935Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227935.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227935.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227935Inst Instance=new A227935Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227936
{
public static readonly long[] Value={ 21L,28L,36L,55L,78L,136L,171L,190L,231L,378L,435L,595L,1035L,1275L,1378L,2278L,2415L,2775L,4095L,5778L,5995L,7875L,8778L,10878L,11175L,11935L,14535L,14878L,21115L,26335L,27495L,31375L,31878L,36315L,37675L,42195L,47895L,52975L,55278L,60378L,66795L,68635L,75078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227936Inst : IEnumerable<long>
{
public static readonly long[] Value=A227936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227936.Bytes);
public long this[int i]=>Value[i];

public static A227936Inst Instance=new A227936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227937
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1L,3L,10L,25L,105L,385L,1540L,7245L,32725L,164395L,870870L,4689685L,27152125L,161786625L,997196200L,6443061625L,42702885225L,292938721075L,2078239413250L,15119319039825L,113390111659825L,873538909468225L,6894294734827500L,55855506234653125L,463151808682688125L,3927996120260086875L,BigInteger.Parse("34081631999814148750"),BigInteger.Parse("301951521812713898125"),BigInteger.Parse("2731127272307562253125"),BigInteger.Parse("25208456056107710010625"),BigInteger.Parse("237164027532948085570000") };
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
public class A227937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227937Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227937.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227937Inst Instance=new A227937Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227938
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,9L,10L,11L,15L,16L,17L,18L,19L,20L,21L,24L,25L,28L,31L,32L,33L,34L,35L,41L,42L,44L,45L,46L,47L,49L,51L,53L,55L,58L,61L,62L,63L,64L,65L,66L,72L,74L,75L,76L,77L,78L,79L,80L,84L,86L,87L,88L,89L,90L,91L,92L,93L,94L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227938Inst : IEnumerable<long>
{
public static readonly long[] Value=A227938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227938.Bytes);
public long this[int i]=>Value[i];

public static A227938Inst Instance=new A227938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227939
{
public static readonly long[] Value={ 1L,3L,4L,9L,11L,12L,16L,19L,25L,27L,33L,36L,43L,44L,48L,49L,51L,57L,59L,64L,67L,73L,75L,76L,81L,83L,89L,99L,100L,107L,108L,121L,123L,129L,131L,132L,139L,144L,147L,163L,169L,171L,172L,176L,177L,179L,187L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227939Inst : IEnumerable<long>
{
public static readonly long[] Value=A227939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227939.Bytes);
public long this[int i]=>Value[i];

public static A227939Inst Instance=new A227939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227940
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,12L,20L,42L,84L,171L,327L,654L,1288L,2533L,4942L,9566L,18481L,35449L,67649L,128372L,242451L,455393L,851352L,1583854L,2932250L,5403874L,9913868L,18107914L,32932025L,59643292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227940Inst : IEnumerable<long>
{
public static readonly long[] Value=A227940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227940.Bytes);
public long this[int i]=>Value[i];

public static A227940Inst Instance=new A227940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227941
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,19L,55L,125L,245L,434L,4060L,21186L,81212L,254813L,692678L,1688555L,3776432L,60101767L,511650887L,3089821383L,14824989723L,60057570858L,213302293918L,681247718668L,1992449334436L,5409214694961L,132273848506202L,1692162553490943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227941Inst : IEnumerable<long>
{
public static readonly long[] Value=A227941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227941.Bytes);
public long this[int i]=>Value[i];

public static A227941Inst Instance=new A227941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227942
{
public static readonly long[] Value={ 393L,2105L,2147L,3155L,5255L,5357L,25829L,26231L,28241L,29447L,33913L,35719L,39331L,56513L,58517L,59519L,79113L,210653L,212261L,214271L,215879L,216683L,219497L,314147L,315953L,317759L,318361L,320167L,321973L,323779L,326789L,329197L,520541L,523547L,529559L,530561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227942Inst : IEnumerable<long>
{
public static readonly long[] Value=A227942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227942.Bytes);
public long this[int i]=>Value[i];

public static A227942Inst Instance=new A227942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227943
{
public static readonly long[] Value={ 9L,10L,14L,15L,25L,35L,58L,62L,82L,94L,39L,57L,93L,65L,85L,95L,91L,106L,122L,142L,158L,166L,194L,141L,159L,177L,183L,201L,219L,237L,267L,291L,205L,235L,295L,305L,335L,365L,395L,415L,445L,203L,259L,329L,371L,413L,497L,143L,319L,341L,473L,583L,671L,869L,913L,979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227943Inst : IEnumerable<long>
{
public static readonly long[] Value=A227943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227943.Bytes);
public long this[int i]=>Value[i];

public static A227943Inst Instance=new A227943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227944
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,2L,1L,1L,1L,2L,3L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,1L,2L,1L,2L,1L,2L,2L,3L,3L,2L,1L,2L,2L,3L,2L,2L,3L,4L,1L,3L,2L,1L,2L,3L,3L,2L,2L,3L,3L,4L,1L,2L,2L,3L,1L,2L,2L,3L,1L,3L,2L,3L,2L,3L,3L,2L,3L,2L,2L,3L,1L,4L,2L,3L,2L,1L,3L,3L,2L,3L,2L,3L,3L,2L,4L,3L,1L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227944Inst : IEnumerable<long>
{
public static readonly long[] Value=A227944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227944.Bytes);
public long this[int i]=>Value[i];

public static A227944Inst Instance=new A227944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227945
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227945Inst : IEnumerable<long>
{
public static readonly long[] Value=A227945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227945.Bytes);
public long this[int i]=>Value[i];

public static A227945Inst Instance=new A227945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227946
{
public static readonly long[] Value={ 1L,2L,7L,19L,47L,163L,487L,1307L,2879L,19683L,39367L,177147L,531441L,1594323L,4782969L,14348907L,43046721L,86093443L,258280327L,688747547L,3486784401L,10460353203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227946Inst : IEnumerable<long>
{
public static readonly long[] Value=A227946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227946.Bytes);
public long this[int i]=>Value[i];

public static A227946Inst Instance=new A227946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227947
{
public static readonly long[] Value={ 4L,6L,8L,9L,333L,646L,656L,979L,1001L,3553L,10801L,11111L,18581L,31713L,34943L,48484L,57375L,95259L,99099L,158851L,262262L,569965L,1173711L,1216121L,1399931L,1439341L,1502051L,1925291L,3203023L,3436343L,3659563L,3662663L,3803083L,3888883L,5185815L,5352535L,5893985L,5990995L,6902096L,9341439L,9452549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227947Inst : IEnumerable<long>
{
public static readonly long[] Value=A227947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227947.Bytes);
public long this[int i]=>Value[i];

public static A227947Inst Instance=new A227947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227948
{
public static readonly long[] Value={ 21L,23L,27L,29L,81L,83L,253L,293L,299L,343L,347L,349L,431L,437L,439L,471L,473L,477L,529L,623L,653L,659L,677L,743L,893L,1123L,1219L,1253L,1257L,1297L,1423L,1489L,1521L,1523L,1529L,1587L,1589L,1657L,1763L,1853L,1867L,1927L,2151L,2167L,2239L,2277L,2279L,2321L,2327L,2329L,2377L,2413L,2443L,2459L,2467L,2497L,2543L,2569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227948Inst : IEnumerable<long>
{
public static readonly long[] Value=A227948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227948.Bytes);
public long this[int i]=>Value[i];

public static A227948Inst Instance=new A227948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227949
{
public static readonly BigInteger[] Value={ 109L,10099L,10987L,1000999L,100999897L,10000099999L,1000000999999L,1000999998997L,100000009999999L,10000999999989997L,1000000000999999999L,BigInteger.Parse("100999897969594939291"),BigInteger.Parse("1000999998997996995994993"),BigInteger.Parse("100000000000009999999999999"),BigInteger.Parse("10000000000000000000000000099999999999999999999999999") };
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
public class A227949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227949.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227949Inst Instance=new A227949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227950
{
public static readonly long[] Value={ 3L,5L,5L,7L,9L,11L,13L,13L,15L,17L,19L,21L,25L,27L,53L,81L,85L,183L,191L,307L,377L,409L,475L,541L,565L,885L,1065L,1399L,1489L,2653L,4523L,4565L,5773L,7777L,14281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227950Inst : IEnumerable<long>
{
public static readonly long[] Value=A227950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227950.Bytes);
public long this[int i]=>Value[i];

public static A227950Inst Instance=new A227950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227951
{
public static readonly long[] Value={ 2L,2L,4L,2L,4L,2L,2L,4L,2L,4L,2L,10L,8L,2L,2L,40L,2L,14L,38L,2L,2L,2L,158L,20L,2L,52L,38L,2L,4L,60L,34L,652L,2L,8L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227951Inst : IEnumerable<long>
{
public static readonly long[] Value=A227951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227951.Bytes);
public long this[int i]=>Value[i];

public static A227951Inst Instance=new A227951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228448
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,2L,6L,18L,61L,225L,901L,3905L,18226L,91134L,486048L,2754274L,16525645L,104662422L,697749481L,4884246371L,35817806721L,274603184861L,2196825478892L,18306878990770L,158659617920008L,1427936561280078L,13327407905280733L,128831609751047086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228448Inst : IEnumerable<long>
{
public static readonly long[] Value=A228448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228448.Bytes);
public long this[int i]=>Value[i];

public static A228448Inst Instance=new A228448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228449
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,3L,9L,28L,92L,324L,1217L,4871L,20703L,93166L,442542L,2212711L,11616735L,63892044L,367379253L,2204275523L,13776722023L,89548693155L,604453678799L,4231175751597L,30676024199079L,230070181493096L,1783043906571497L,14264351252571976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228449Inst : IEnumerable<long>
{
public static readonly long[] Value=A228449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228449.Bytes);
public long this[int i]=>Value[i];

public static A228449Inst Instance=new A228449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228450
{
public static readonly long[] Value={ 3L,9L,10L,44L,110L,136L,592L,884L,2144L,8384L,18632L,32896L,116624L,391612L,527872L,1090912L,2102272L,8394752L,15370304L,73995392L,536920064L,815634435L,2147516416L,34360131584L,217898810368L,546409576448L,549759483904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228450Inst : IEnumerable<long>
{
public static readonly long[] Value=A228450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228450.Bytes);
public long this[int i]=>Value[i];

public static A228450Inst Instance=new A228450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228451
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,6L,4L,11L,1L,10L,6L,17L,4L,17L,11L,26L,1L,18L,10L,29L,6L,27L,17L,40L,4L,29L,17L,44L,11L,40L,26L,57L,1L,34L,18L,53L,10L,47L,29L,68L,6L,47L,27L,70L,17L,62L,40L,87L,4L,53L,29L,80L,17L,70L,44L,99L,11L,68L,40L,99L,26L,87L,57L,120L,1L,66L,34L,101L,18L,87L,53L,124L,10L,83L,47L,122L,29L,106L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228451Inst : IEnumerable<long>
{
public static readonly long[] Value=A228451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228451.Bytes);
public long this[int i]=>Value[i];

public static A228451Inst Instance=new A228451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228452
{
public static readonly long[] Value={ 3L,53L,19L,3L,19L,593L,313L,113L,1699L,1163L,31L,4217L,31L,47L,7993L,1013L,631L,347L,3793L,3923L,397L,353L,2551L,83L,2719L,971L,3709L,6827L,6361L,593L,2053L,16073L,2719L,2753L,4441L,8663L,31L,131L,61L,5867L,379L,587L,9631L,1907L,8581L,23L,15739L,4049L,2281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228452Inst : IEnumerable<long>
{
public static readonly long[] Value=A228452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228452.Bytes);
public long this[int i]=>Value[i];

public static A228452Inst Instance=new A228452Inst();

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