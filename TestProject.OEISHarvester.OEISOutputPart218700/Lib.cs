using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A257082
{
public static readonly long[] Value={ 1L,2L,8L,12L,28L,52L,108L,216L,448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257082Inst : IEnumerable<long>
{
public static readonly long[] Value=A257082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257082.Bytes);
public long this[int i]=>Value[i];

public static A257082Inst Instance=new A257082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257083
{
public static readonly long[] Value={ 1L,2L,6L,9L,17L,22L,34L,41L,57L,66L,86L,97L,121L,134L,162L,177L,209L,226L,262L,281L,321L,342L,386L,409L,457L,482L,534L,561L,617L,646L,706L,737L,801L,834L,902L,937L,1009L,1046L,1122L,1161L,1241L,1282L,1366L,1409L,1497L,1542L,1634L,1681L,1777L,1826L,1926L,1977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257083Inst : IEnumerable<long>
{
public static readonly long[] Value=A257083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257083.Bytes);
public long this[int i]=>Value[i];

public static A257083Inst Instance=new A257083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257084
{
public static readonly long[] Value={ 1L,1L,4L,17L,80L,407L,2160L,11859L,66754L,383210L,2234921L,13204685L,78870454L,475453371L,2888991879L,17675743626L,108801199823L,673302178725L,4186513098755L,26142455226568L,163873586066647L,1030820865387599L,6504789754356175L,41166205256238155L,261217480924768212L,1661598566523216015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257084Inst : IEnumerable<long>
{
public static readonly long[] Value=A257084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257084.Bytes);
public long this[int i]=>Value[i];

public static A257084Inst Instance=new A257084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257085
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,10L,11L,12L,15L,16L,20L,21L,25L,32L,34L,35L,40L,45L,46L,50L,51L,55L,56L,60L,65L,66L,100L,101L,102L,105L,106L,110L,111L,112L,115L,116L,120L,121L,125L,142L,145L,146L,150L,152L,155L,156L,160L,162L,200L,201L,204L,205L,206L,210L,211L,215L,216L,225L,231L,235L,245L,246L,250L,251L,252L,254L,255L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257085Inst : IEnumerable<long>
{
public static readonly long[] Value=A257085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257085.Bytes);
public long this[int i]=>Value[i];

public static A257085Inst Instance=new A257085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257086
{
public static readonly long[] Value={ 0L,1L,2L,5L,10L,11L,12L,15L,20L,21L,32L,35L,45L,50L,55L,100L,101L,102L,105L,110L,111L,112L,115L,120L,145L,150L,152L,155L,200L,201L,205L,210L,211L,235L,320L,321L,332L,335L,350L,351L,450L,451L,452L,500L,501L,502L,505L,550L,1000L,1001L,1002L,1005L,1010L,1011L,1012L,1015L,1020L,1021L,1050L,1055L,1100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257086Inst : IEnumerable<long>
{
public static readonly long[] Value=A257086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257086.Bytes);
public long this[int i]=>Value[i];

public static A257086Inst Instance=new A257086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257087
{
public static readonly long[] Value={ 515L,516L,519L,617L,618L,714L,716L,814L,815L,817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257087Inst : IEnumerable<long>
{
public static readonly long[] Value=A257087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257087.Bytes);
public long this[int i]=>Value[i];

public static A257087Inst Instance=new A257087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257088
{
public static readonly long[] Value={ 1L,1L,4L,3L,8L,5L,12L,7L,16L,9L,20L,11L,24L,13L,28L,15L,32L,17L,36L,19L,40L,21L,44L,23L,48L,25L,52L,27L,56L,29L,60L,31L,64L,33L,68L,35L,72L,37L,76L,39L,80L,41L,84L,43L,88L,45L,92L,47L,96L,49L,100L,51L,104L,53L,108L,55L,112L,57L,116L,59L,120L,61L,124L,63L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257088Inst : IEnumerable<long>
{
public static readonly long[] Value=A257088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257088.Bytes);
public long this[int i]=>Value[i];

public static A257088Inst Instance=new A257088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257089
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,4L,2L,2L,1L,3L,1L,2L,2L,5L,1L,3L,1L,3L,2L,2L,1L,5L,2L,2L,4L,3L,1L,3L,1L,6L,2L,2L,2L,4L,1L,2L,2L,5L,1L,3L,1L,3L,3L,2L,1L,6L,2L,3L,2L,3L,1L,5L,2L,5L,2L,2L,1L,4L,1L,2L,3L,8L,2L,3L,1L,3L,2L,3L,1L,6L,1L,2L,3L,3L,2L,3L,1L,6L,5L,2L,1L,4L,2L,2L,2L,5L,1L,4L,2L,3L,2L,2L,2L,7L,1L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257089Inst : IEnumerable<long>
{
public static readonly long[] Value=A257089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257089.Bytes);
public long this[int i]=>Value[i];

public static A257089Inst Instance=new A257089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257090
{
public static readonly long[] Value={ 0L,2L,2L,5L,2L,4L,2L,7L,5L,4L,2L,7L,2L,4L,4L,11L,2L,7L,2L,7L,4L,4L,2L,9L,5L,4L,7L,7L,2L,6L,2L,13L,4L,4L,4L,10L,2L,4L,4L,9L,2L,6L,2L,7L,7L,4L,2L,13L,5L,7L,4L,7L,2L,9L,4L,9L,4L,4L,2L,9L,2L,4L,7L,16L,4L,6L,2L,7L,4L,6L,2L,12L,2L,4L,7L,7L,4L,6L,2L,13L,11L,4L,2L,9L,4L,4L,4L,9L,2L,9L,4L,7L,4L,4L,4L,15L,2L,7L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257090Inst : IEnumerable<long>
{
public static readonly long[] Value=A257090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257090.Bytes);
public long this[int i]=>Value[i];

public static A257090Inst Instance=new A257090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257091
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,3L,1L,2L,2L,4L,1L,3L,1L,3L,2L,2L,1L,4L,2L,2L,3L,3L,1L,3L,1L,6L,2L,2L,2L,4L,1L,2L,2L,4L,1L,3L,1L,3L,3L,2L,1L,5L,2L,3L,2L,3L,1L,4L,2L,4L,2L,2L,1L,4L,1L,2L,3L,7L,2L,3L,1L,3L,2L,3L,1L,5L,1L,2L,3L,3L,2L,3L,1L,5L,4L,2L,1L,4L,2L,2L,2L,4L,1L,4L,2L,3L,2L,2L,2L,7L,1L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257091Inst : IEnumerable<long>
{
public static readonly long[] Value=A257091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257091.Bytes);
public long this[int i]=>Value[i];

public static A257091Inst Instance=new A257091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257092
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,2L,3L,4L,4L,3L,4L,5L,0L,5L,4L,5L,2L,6L,6L,2L,5L,6L,3L,1L,0L,1L,3L,6L,7L,8L,8L,8L,8L,8L,8L,7L,8L,9L,3L,1L,0L,1L,3L,9L,8L,9L,6L,10L,2L,6L,6L,2L,10L,6L,9L,10L,7L,5L,11L,5L,0L,5L,11L,5L,7L,10L,11L,12L,12L,4L,12L,4L,4L,12L,4L,12L,12L,11L,12L,13L,7L,13L,3L,13L,0L,13L,3L,13L,7L,13L,12L,13L,10L,14L,14L,10L,2L,14L,14L,2L,10L,14L,14L,10L,13L,14L,11L,9L,7L,9L,11L,1L,0L,1L,11L,9L,7L,9L,11L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257092Inst : IEnumerable<long>
{
public static readonly long[] Value=A257092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257092.Bytes);
public long this[int i]=>Value[i];

public static A257092Inst Instance=new A257092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257093
{
public static readonly long[] Value={ 0L,5L,28L,82L,180L,355L,560L,868L,1272L,1785L,2420L,3190L,4108L,5187L,6440L,7880L,9520L,11373L,15770L,18340L,21175L,24288L,27692L,31400L,35425L,39780L,44478L,49532L,54955L,60760L,73568L,80597L,88060L,95970L,104340L,113183L,122512L,132340L,142680L,153545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257093Inst : IEnumerable<long>
{
public static readonly long[] Value=A257093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257093.Bytes);
public long this[int i]=>Value[i];

public static A257093Inst Instance=new A257093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257094
{
public static readonly long[] Value={ 1L,1L,3L,3L,0L,0L,3L,0L,9L,6L,3L,1L,9L,3L,4L,6L,3L,4L,7L,4L,7L,8L,3L,3L,9L,1L,1L,1L,2L,0L,8L,6L,4L,7L,5L,0L,0L,9L,3L,5L,9L,8L,9L,9L,0L,0L,9L,0L,0L,0L,2L,0L,4L,5L,8L,5L,7L,2L,9L,3L,0L,6L,2L,4L,8L,6L,5L,5L,9L,9L,7L,6L,3L,6L,0L,5L,8L,5L,2L,8L,5L,0L,5L,0L,5L,7L,3L,7L,5L,4L,2L,7L,2L,6L,0L,5L,7L,5L,9L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257094Inst : IEnumerable<long>
{
public static readonly long[] Value=A257094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257094.Bytes);
public long this[int i]=>Value[i];

public static A257094Inst Instance=new A257094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257095
{
public static readonly long[] Value={ 1L,6L,0L,8L,3L,5L,9L,4L,2L,1L,9L,8L,5L,5L,4L,5L,6L,5L,9L,2L,3L,1L,9L,4L,1L,5L,2L,3L,1L,6L,3L,7L,9L,3L,8L,1L,6L,4L,9L,2L,2L,5L,1L,5L,1L,3L,1L,4L,1L,8L,4L,2L,6L,7L,7L,2L,3L,9L,5L,3L,1L,1L,0L,6L,5L,0L,5L,3L,9L,2L,5L,4L,1L,0L,6L,0L,1L,7L,2L,8L,4L,3L,8L,7L,3L,7L,8L,8L,7L,4L,3L,7L,8L,2L,0L,7L,6L,0L,2L,4L,8L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257095Inst : IEnumerable<long>
{
public static readonly long[] Value=A257095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257095.Bytes);
public long this[int i]=>Value[i];

public static A257095Inst Instance=new A257095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257096
{
public static readonly long[] Value={ 7L,2L,4L,2L,3L,5L,6L,3L,3L,8L,0L,0L,9L,7L,1L,4L,2L,9L,5L,3L,8L,9L,2L,3L,3L,3L,1L,1L,1L,1L,5L,0L,1L,8L,3L,8L,3L,3L,0L,9L,7L,6L,3L,4L,4L,6L,8L,3L,2L,9L,5L,5L,3L,0L,4L,9L,8L,9L,2L,4L,7L,6L,0L,7L,2L,5L,1L,1L,4L,3L,5L,6L,4L,7L,3L,6L,3L,5L,5L,8L,5L,5L,2L,3L,5L,8L,4L,6L,2L,2L,3L,9L,6L,1L,3L,9L,4L,0L,3L,8L,9L,3L,8L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257096Inst : IEnumerable<long>
{
public static readonly long[] Value=A257096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257096.Bytes);
public long this[int i]=>Value[i];

public static A257096Inst Instance=new A257096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257097
{
public static readonly long[] Value={ 9L,1L,0L,0L,7L,6L,2L,7L,2L,8L,9L,6L,6L,4L,4L,9L,9L,4L,5L,9L,3L,5L,6L,4L,3L,3L,4L,7L,1L,4L,6L,3L,0L,2L,0L,7L,5L,4L,2L,2L,9L,2L,7L,9L,7L,5L,4L,1L,4L,8L,8L,0L,8L,1L,3L,6L,5L,2L,5L,9L,0L,4L,5L,9L,6L,5L,8L,1L,4L,1L,1L,1L,3L,2L,3L,7L,4L,6L,6L,2L,8L,2L,4L,3L,5L,9L,8L,0L,0L,8L,5L,1L,7L,9L,5L,2L,2L,1L,2L,8L,1L,6L,3L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257097Inst : IEnumerable<long>
{
public static readonly long[] Value=A257097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257097.Bytes);
public long this[int i]=>Value[i];

public static A257097Inst Instance=new A257097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257098
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-5L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-7L,1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,5L,-1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,-21L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,5L,-5L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,7L,-1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257098Inst : IEnumerable<long>
{
public static readonly long[] Value=A257098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257098.Bytes);
public long this[int i]=>Value[i];

public static A257098Inst Instance=new A257098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257099
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,-1L,1L,-1L,-5L,-1L,1L,-1L,1L,-1L,1L,1L,-10L,-1L,1L,-1L,1L,1L,1L,-1L,5L,-1L,1L,-5L,1L,-1L,-1L,-1L,-22L,1L,1L,1L,1L,-1L,1L,1L,5L,-1L,-1L,-1L,1L,1L,1L,-1L,10L,-1L,1L,1L,1L,-1L,5L,1L,5L,1L,1L,-1L,-1L,-1L,1L,1L,-154L,1L,-1L,-1L,1L,1L,-1L,-1L,5L,-1L,1L,1L,1L,1L,-1L,-1L,10L,-10L,1L,-1L,-1L,1L,1L,1L,5L,-1L,-1L,1L,1L,1L,1L,1L,22L,-1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257099Inst : IEnumerable<long>
{
public static readonly long[] Value=A257099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257099.Bytes);
public long this[int i]=>Value[i];

public static A257099Inst Instance=new A257099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257100
{
public static readonly long[] Value={ 1L,-1L,-1L,-3L,-1L,1L,-1L,-7L,-3L,1L,-1L,3L,-1L,1L,1L,-77L,-1L,3L,-1L,3L,1L,1L,-1L,7L,-3L,1L,-7L,3L,-1L,-1L,-1L,-231L,1L,1L,1L,9L,-1L,1L,1L,7L,-1L,-1L,-1L,3L,3L,1L,-1L,77L,-3L,3L,1L,3L,-1L,7L,1L,7L,1L,1L,-1L,-3L,-1L,1L,3L,-1463L,1L,-1L,-1L,3L,1L,-1L,-1L,21L,-1L,1L,3L,3L,1L,-1L,-1L,77L,-77L,1L,-1L,-3L,1L,1L,1L,7L,-1L,-3L,1L,3L,1L,1L,1L,231L,-1L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257100Inst : IEnumerable<long>
{
public static readonly long[] Value=A257100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257100.Bytes);
public long this[int i]=>Value[i];

public static A257100Inst Instance=new A257100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257101
{
public static readonly long[] Value={ 1L,-1L,-1L,-2L,-1L,1L,-1L,-6L,-2L,1L,-1L,2L,-1L,1L,1L,-21L,-1L,2L,-1L,2L,1L,1L,-1L,6L,-2L,1L,-6L,2L,-1L,-1L,-1L,-399L,1L,1L,1L,4L,-1L,1L,1L,6L,-1L,-1L,-1L,2L,2L,1L,-1L,21L,-2L,2L,1L,2L,-1L,6L,1L,6L,1L,1L,-1L,-2L,-1L,1L,2L,-1596L,1L,-1L,-1L,2L,1L,-1L,-1L,12L,-1L,1L,2L,2L,1L,-1L,-1L,21L,-21L,1L,-1L,-2L,1L,1L,1L,6L,-1L,-2L,1L,2L,1L,1L,1L,399L,-1L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257101Inst : IEnumerable<long>
{
public static readonly long[] Value=A257101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257101.Bytes);
public long this[int i]=>Value[i];

public static A257101Inst Instance=new A257101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257102
{
public static readonly long[] Value={ 1L,0L,2L,7L,3L,4L,0L,4L,2L,6L,8L,8L,8L,9L,0L,7L,5L,1L,8L,5L,0L,6L,6L,4L,7L,8L,3L,6L,9L,1L,7L,1L,3L,9L,7L,0L,1L,0L,2L,3L,3L,2L,8L,1L,5L,5L,2L,0L,4L,9L,1L,3L,1L,5L,0L,2L,0L,0L,5L,2L,9L,0L,1L,8L,3L,9L,9L,4L,4L,3L,9L,7L,1L,4L,6L,1L,9L,6L,2L,9L,3L,6L,6L,3L,8L,0L,4L,8L,3L,2L,2L,3L,9L,0L,0L,4L,3L,2L,5L,2L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257102Inst : IEnumerable<long>
{
public static readonly long[] Value=A257102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257102.Bytes);
public long this[int i]=>Value[i];

public static A257102Inst Instance=new A257102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257103
{
public static readonly long[] Value={ 21L,56L,1862L,2526L,1352797L,2201422L,3206062L,34844422L,42400318L,8586830293L,20967471193L,23194695022L,43790421673L,45041812729L,48438881254L,101060544853L,177839630854L,180939891343L,198419358598L,305550990673L,354694083622L,661663823662L,785220739279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257103Inst : IEnumerable<long>
{
public static readonly long[] Value=A257103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257103.Bytes);
public long this[int i]=>Value[i];

public static A257103Inst Instance=new A257103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257104
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,50L,121L,297L,738L,1854L,4704L,12044L,31097L,80919L,212098L,559718L,1486480L,3971285L,10668975L,28812589L,78192989L,213179869L,583703909L,1604685870L,4428216295L,12263271557L,34074271966L,94972933448L,265486492798L,744177020705L,2091359021671L,5891579293777L,16634993650629L,47069839690554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257104Inst : IEnumerable<long>
{
public static readonly long[] Value=A257104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257104.Bytes);
public long this[int i]=>Value[i];

public static A257104Inst Instance=new A257104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257105
{
public static readonly long[] Value={ 132L,476L,2108L,16748L,27548L,28676L,99524L,100076L,239948L,308228L,344129L,573476L,601676L,822908L,860276L,883268L,1673228L,3274010L,4959476L,7548956L,8916044L,9048428L,9215348L,9643169L,9833588L,10011908L,14773676L,17119436L,18529964L,19459028L,21335948L,21739148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257105Inst : IEnumerable<long>
{
public static readonly long[] Value=A257105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257105.Bytes);
public long this[int i]=>Value[i];

public static A257105Inst Instance=new A257105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257106
{
public static readonly long[] Value={ 1L,3L,6L,2L,10L,6L,42L,6L,30L,2L,22L,6L,2730L,6L,6L,2L,170L,6L,798L,6L,330L,2L,46L,6L,2730L,6L,6L,2L,290L,6L,14322L,6L,510L,2L,2L,6L,1919190L,6L,6L,2L,4510L,6L,1806L,6L,690L,2L,94L,6L,46410L,6L,66L,2L,530L,6L,798L,6L,870L,2L,118L,6L,56786730L,6L,6L,2L,170L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257106Inst : IEnumerable<long>
{
public static readonly long[] Value=A257106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257106.Bytes);
public long this[int i]=>Value[i];

public static A257106Inst Instance=new A257106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257107
{
public static readonly long[] Value={ 16L,65L,88L,209L,11009L,38009L,680609L,2205209L,2860198L,3515609L,4347209L,5365387L,5809361L,10595009L,12006209L,31979009L,83255059L,89019209L,152915402L,169130009L,172147423L,225869899L,244766009L,247590209L,258084209L,325622009L,357777209L,377330609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257107Inst : IEnumerable<long>
{
public static readonly long[] Value=A257107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257107.Bytes);
public long this[int i]=>Value[i];

public static A257107Inst Instance=new A257107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257108
{
public static readonly long[] Value={ 2L,3L,7L,47L,241L,2887L,57119L,217069L,37923937L,211014919L,221167421L,221167421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257108Inst : IEnumerable<long>
{
public static readonly long[] Value=A257108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257108.Bytes);
public long this[int i]=>Value[i];

public static A257108Inst Instance=new A257108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257109
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,2L,2L,1L,0L,2L,1L,0L,1L,2L,2L,1L,1L,0L,1L,0L,0L,3L,2L,1L,0L,2L,0L,0L,1L,0L,3L,1L,1L,1L,1L,0L,1L,2L,0L,1L,0L,3L,2L,1L,0L,3L,4L,0L,1L,2L,2L,1L,0L,0L,3L,2L,0L,3L,2L,1L,1L,3L,0L,1L,1L,0L,3L,1L,2L,3L,5L,0L,1L,3L,0L,1L,2L,4L,4L,1L,0L,4L,1L,0L,1L,3L,4L,1L,1L,0L,3L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257109Inst : IEnumerable<long>
{
public static readonly long[] Value=A257109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257109.Bytes);
public long this[int i]=>Value[i];

public static A257109Inst Instance=new A257109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257110
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,41L,43L,67L,109L,179L,467L,1973L,5167L,8363L,21893L,35423L,92737L,392837L,2692537L,11405773L,48315633L,126491971L,204668311L,331160281L,535828591L,1402817467L,40730022149L,279167724889L,8105479075763L,145446920496281L,26944668049352441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257110Inst : IEnumerable<long>
{
public static readonly long[] Value=A257110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257110.Bytes);
public long this[int i]=>Value[i];

public static A257110Inst Instance=new A257110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257111
{
public static readonly long[] Value={ 1L,1L,2L,-1L,3L,-1L,5L,-2L,4L,4L,2L,-11L,15L,6L,-8L,4L,6L,6L,4L,-6L,8L,4L,-37L,39L,-37L,41L,-39L,1L,44L,-32L,28L,-16L,-23L,45L,-39L,29L,16L,-49L,47L,-41L,47L,-45L,7L,-1L,25L,16L,6L,4L,-6L,8L,4L,8L,4L,-73L,67L,-61L,57L,-53L,65L,4L,-62L,64L,4L,-93L,101L,-6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257111Inst : IEnumerable<long>
{
public static readonly long[] Value=A257111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257111.Bytes);
public long this[int i]=>Value[i];

public static A257111Inst Instance=new A257111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257112
{
public static readonly long[] Value={ 1L,2L,11L,4L,55L,6L,25L,8L,165L,14L,3L,16L,15L,26L,5L,12L,35L,18L,7L,22L,21L,32L,9L,28L,27L,10L,33L,20L,77L,34L,49L,38L,231L,46L,121L,24L,143L,36L,65L,44L,45L,52L,51L,58L,75L,56L,39L,40L,57L,50L,63L,62L,69L,64L,81L,68L,87L,17L,93L,136L,105L,74L,85L,42L,95L,48L,115L,54L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257112Inst : IEnumerable<long>
{
public static readonly long[] Value=A257112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257112.Bytes);
public long this[int i]=>Value[i];

public static A257112Inst Instance=new A257112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257113
{
public static readonly long[] Value={ 2L,3L,5L,10L,20L,40L,80L,160L,320L,640L,1280L,2560L,5120L,10240L,20480L,40960L,81920L,163840L,327680L,655360L,1310720L,2621440L,5242880L,10485760L,20971520L,41943040L,83886080L,167772160L,335544320L,671088640L,1342177280L,2684354560L,5368709120L,10737418240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257113Inst : IEnumerable<long>
{
public static readonly long[] Value=A257113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257113.Bytes);
public long this[int i]=>Value[i];

public static A257113Inst Instance=new A257113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257114
{
public static readonly long[] Value={ 1L,1L,10L,70L,465L,2505L,12652L,57232L,240481L,936785L,3428138L,11817866L,38676949L,120577553L,359800464L,1030830032L,2845200663L,7584911479L,19580001382L,49046743566L,119457712491L,283383330899L,655832583316L,1482829086428L,3279794012205L,7105246435381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257114Inst : IEnumerable<long>
{
public static readonly long[] Value=A257114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257114.Bytes);
public long this[int i]=>Value[i];

public static A257114Inst Instance=new A257114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257115
{
public static readonly long[] Value={ 1L,3L,15L,15L,49L,483L,5049L,6347L,144945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257115Inst : IEnumerable<long>
{
public static readonly long[] Value=A257115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257115.Bytes);
public long this[int i]=>Value[i];

public static A257115Inst Instance=new A257115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257116
{
public static readonly long[] Value={ 3L,17L,487L,947L,947L,38639L,38639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257116Inst : IEnumerable<long>
{
public static readonly long[] Value=A257116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257116.Bytes);
public long this[int i]=>Value[i];

public static A257116Inst Instance=new A257116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257117
{
public static readonly long[] Value={ 37L,109L,193L,229L,277L,313L,349L,389L,397L,401L,449L,457L,509L,613L,661L,673L,701L,757L,761L,769L,797L,853L,929L,937L,997L,1009L,1093L,1109L,1193L,1201L,1213L,1237L,1373L,1429L,1489L,1549L,1597L,1609L,1637L,1669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257117Inst : IEnumerable<long>
{
public static readonly long[] Value=A257117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257117.Bytes);
public long this[int i]=>Value[i];

public static A257117Inst Instance=new A257117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257118
{
public static readonly long[] Value={ 389L,397L,449L,661L,757L,761L,929L,997L,1193L,1201L,1669L,2213L,2269L,2293L,2593L,2609L,2617L,2741L,3037L,3041L,3209L,3217L,3413L,3433L,3449L,3877L,4397L,4801L,5189L,5233L,5237L,5569L,5689L,5717L,6101L,6217L,6389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257118Inst : IEnumerable<long>
{
public static readonly long[] Value=A257118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257118.Bytes);
public long this[int i]=>Value[i];

public static A257118Inst Instance=new A257118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257119
{
public static readonly long[] Value={ 389L,757L,1193L,2593L,2609L,3037L,3209L,3413L,3433L,5233L,6829L,7649L,8669L,8677L,9157L,9241L,10169L,10429L,11173L,11593L,11597L,11617L,11621L,11633L,11657L,12269L,12277L,12409L,12413L,12829L,12841L,15053L,17389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257119Inst : IEnumerable<long>
{
public static readonly long[] Value=A257119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257119.Bytes);
public long this[int i]=>Value[i];

public static A257119Inst Instance=new A257119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257120
{
public static readonly long[] Value={ 1L,4L,3L,5L,7L,11L,29L,13L,10L,15L,122L,19L,200L,31L,24L,18L,299L,22L,824L,16L,33L,124L,945L,41L,26L,202L,21L,37L,3093L,45L,7059L,40L,126L,301L,53L,66L,13527L,826L,204L,42L,28658L,36L,40810L,130L,57L,947L,46657L,64L,80L,44L,303L,208L,57449L,49L,133L,38L,828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257120Inst : IEnumerable<long>
{
public static readonly long[] Value=A257120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257120.Bytes);
public long this[int i]=>Value[i];

public static A257120Inst Instance=new A257120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257121
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,11L,12L,15L,16L,20L,21L,22L,25L,26L,30L,31L,34L,38L,46L,48L,51L,58L,63L,66L,68L,71L,73L,90L,91L,92L,95L,98L,113L,114L,116L,118L,121L,128L,136L,142L,143L,144L,146L,158L,161L,164L,165L,178L,180L,185L,188L,191L,198L,208L,214L,216L,222L,225L,231L,232L,234L,236L,238L,248L,252L,256L,260L,264L,283L,288L,295L,298L,301L,303L,310L,311L,330L,333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257121Inst : IEnumerable<long>
{
public static readonly long[] Value=A257121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257121.Bytes);
public long this[int i]=>Value[i];

public static A257121Inst Instance=new A257121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257122
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,4L,30L,6L,10L,7L,123L,12L,201L,31L,9L,13L,300L,11L,825L,16L,34L,124L,946L,14L,27L,202L,21L,32L,3094L,15L,7060L,18L,127L,301L,54L,20L,13528L,826L,205L,17L,28659L,33L,40811L,125L,25L,947L,46658L,19L,81L,28L,304L,203L,57450L,22L,134L,38L,829L,3095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257122Inst : IEnumerable<long>
{
public static readonly long[] Value=A257122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257122.Bytes);
public long this[int i]=>Value[i];

public static A257122Inst Instance=new A257122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257123
{
public static readonly long[] Value={ 275L,2574L,2725L,2765L,4762L,5725L,6762L,7244L,7262L,23765L,25744L,27244L,27325L,27434L,27465L,27525L,27632L,27665L,47725L,52275L,52376L,52475L,52576L,52675L,57242L,67426L,72266L,72275L,72424L,72426L,72576L,72624L,73325L,73725L,74326L,75725L,233725L,233744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257123Inst : IEnumerable<long>
{
public static readonly long[] Value=A257123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257123.Bytes);
public long this[int i]=>Value[i];

public static A257123Inst Instance=new A257123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257124
{
public static readonly long[] Value={ 11L,5639L,88799L,165701L,284729L,626609L,855719L,1068701L,1146779L,6560999L,7540439L,8573429L,11900501L,15760091L,17843459L,18504371L,19089599L,21036131L,24001709L,25658441L,39431921L,42981929L,43534019L,45002591L,67816361L,69156539L,74266259L,79208399L,80427029L,84104549L,86818211L,87988709L,93625991L,124066079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257124Inst : IEnumerable<long>
{
public static readonly long[] Value=A257124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257124.Bytes);
public long this[int i]=>Value[i];

public static A257124Inst Instance=new A257124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257125
{
public static readonly long[] Value={ 7L,11L,13L,17L,1277L,88789L,113143L,113147L,855709L,74266249L,182403491L,226449521L,252277007L,408936947L,521481197L,626927443L,910935911L,964669609L,1042090781L,1116452627L,1209950867L,1422475909L,1459270271L,1645175087L,2117861719L,2335215973L,2558211559L,2843348351L,2873599429L,2966003057L,3447123283L,3947480417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257125Inst : IEnumerable<long>
{
public static readonly long[] Value=A257125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257125.Bytes);
public long this[int i]=>Value[i];

public static A257125Inst Instance=new A257125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257126
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,3L,3L,2L,4L,3L,5L,5L,5L,4L,4L,2L,4L,3L,5L,5L,5L,4L,6L,5L,5L,6L,8L,6L,6L,5L,5L,2L,4L,3L,5L,5L,5L,4L,6L,5L,5L,6L,8L,6L,6L,5L,7L,5L,5L,6L,8L,6L,6L,7L,9L,6L,8L,9L,9L,7L,7L,6L,6L,2L,4L,3L,5L,5L,5L,4L,6L,5L,5L,6L,8L,6L,6L,5L,7L,5L,5L,6L,8L,6L,6L,7L,9L,6L,8L,9L,9L,7L,7L,6L,8L,5L,5L,6L,8L,6L,6L,7L,9L,6L,8L,9L,9L,7L,7L,8L,10L,6L,8L,9L,9L,7L,9L,10L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257126Inst : IEnumerable<long>
{
public static readonly long[] Value=A257126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257126.Bytes);
public long this[int i]=>Value[i];

public static A257126Inst Instance=new A257126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257127
{
public static readonly long[] Value={ 11L,9853497737L,21956291867L,22741837817L,33081664151L,83122625471L,164444511587L,179590045487L,217999764107L,231255798857L,242360943257L,294920291201L,573459229151L,663903555851L,666413245007L,688697679401L,696391309697L,730121110331L,867132039857L,974275568237L,976136848847L,1002263588297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257127Inst : IEnumerable<long>
{
public static readonly long[] Value=A257127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257127.Bytes);
public long this[int i]=>Value[i];

public static A257127Inst Instance=new A257127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257128
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,20L,12L,30L,13L,23L,40L,14L,24L,34L,50L,15L,25L,35L,45L,60L,16L,26L,36L,46L,56L,70L,17L,27L,37L,47L,57L,67L,80L,18L,28L,38L,48L,58L,68L,78L,90L,19L,29L,39L,49L,59L,69L,79L,89L,102L,103L,203L,123L,104L,204L,124L,304L,134L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257128Inst : IEnumerable<long>
{
public static readonly long[] Value=A257128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257128.Bytes);
public long this[int i]=>Value[i];

public static A257128Inst Instance=new A257128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257129
{
public static readonly long[] Value={ 11L,1418575498573L,2118274828903L,4396774576273L,6368171154193L,6953798916913L,7908189600581L,10527733922591L,12640876669691L,27899359258003L,28138953913303L,34460918582323L,38545620633251L,40362095929003L,42023308245613L,43564522846961L,44058461657443L,60268613366231L,60596839933361L,61062361183903L,71431649320301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257129Inst : IEnumerable<long>
{
public static readonly long[] Value=A257129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257129.Bytes);
public long this[int i]=>Value[i];

public static A257129Inst Instance=new A257129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257130
{
public static readonly long[] Value={ 1L,2L,5L,11L,23L,27L,55L,111L,121L,245L,247L,495L,503L,1007L,2015L,2037L,4077L,8157L,8175L,8179L,16363L,16367L,32735L,65471L,65517L,65519L,131039L,131055L,262111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257130Inst : IEnumerable<long>
{
public static readonly long[] Value=A257130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257130.Bytes);
public long this[int i]=>Value[i];

public static A257130Inst Instance=new A257130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257131
{
public static readonly long[] Value={ 11L,1418575498567L,27899359257997L,34460918582317L,76075560855367L,186460616596327L,218021188549237L,234280497145537L,282854319391717L,345120905374087L,346117552180627L,380284918609481L,437163765888581L,604439135284057L,701889794782061L,727417501795057L,980125031081081L,1041814617748747L,1090754719898917L,1277156391416021L,1487854607298791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257131Inst : IEnumerable<long>
{
public static readonly long[] Value=A257131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257131.Bytes);
public long this[int i]=>Value[i];

public static A257131Inst Instance=new A257131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257132
{
public static readonly BigInteger[] Value={ 1L,1L,1L,10L,325L,25296L,3902353L,1053700208L,456536705625L,297754617160000L,278395601200346641L,BigInteger.Parse("359067467227998071808"),BigInteger.Parse("619296691244751962694109"),BigInteger.Parse("1392196584708720449376704000"),BigInteger.Parse("3992553188360180927537240390625"),BigInteger.Parse("14342182990533795228474771602446336") };
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
public class A257132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257132Inst Instance=new A257132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257133
{
public static readonly BigInteger[] Value={ 1L,1L,1L,10L,475L,64821L,19406296L,10838525440L,10144997182125L,14751443961879625L,BigInteger.Parse("31491407608395366016"),BigInteger.Parse("94486384518726630882816"),BigInteger.Parse("384839939170279634083854175"),BigInteger.Parse("2068398906358519479054060953125"),BigInteger.Parse("14329327322496735822187340743680000") };
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
public class A257133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257133Inst Instance=new A257133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257134
{
public static readonly long[] Value={ 2L,1L,6L,4L,6L,4L,6L,4L,6L,7L,4L,2L,2L,2L,7L,6L,3L,8L,3L,0L,3L,2L,0L,0L,7L,3L,9L,3L,0L,8L,2L,3L,3L,5L,8L,0L,5L,5L,4L,9L,5L,0L,1L,9L,0L,3L,8L,3L,7L,4L,5L,3L,8L,1L,5L,3L,6L,5L,9L,5L,2L,4L,3L,0L,8L,8L,8L,2L,4L,1L,2L,3L,2L,3L,7L,3L,9L,3L,7L,6L,9L,3L,1L,1L,3L,8L,1L,9L,2L,7L,1L,8L,8L,3L,3L,9L,9L,8L,3L,4L,4L,6L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257134Inst : IEnumerable<long>
{
public static readonly long[] Value=A257134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257134.Bytes);
public long this[int i]=>Value[i];

public static A257134Inst Instance=new A257134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257135
{
public static readonly long[] Value={ 11L,13L,10527733922579L,186460616596321L,1707898733581273L,3266590043460823L,4289907938811613L,4422879865247923L,5693002600430263L,7582919852522851L,7697168877290909L,7933248530182091L,10071192314217869L,10907318641689703L,11987120084474369L,15991086371740199L,20475715985020181L,21817283854511261L,21817283854511263L,22443709342850669L,28561589689237439L,31979851757518501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257135Inst : IEnumerable<long>
{
public static readonly long[] Value=A257135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257135.Bytes);
public long this[int i]=>Value[i];

public static A257135Inst Instance=new A257135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257136
{
public static readonly long[] Value={ 2L,0L,3L,4L,6L,8L,6L,1L,2L,3L,9L,6L,8L,8L,9L,8L,2L,7L,9L,4L,2L,9L,0L,3L,5L,8L,5L,9L,5L,8L,1L,8L,4L,1L,0L,5L,5L,8L,0L,3L,6L,3L,4L,9L,8L,0L,0L,6L,5L,7L,0L,7L,1L,2L,3L,6L,8L,4L,8L,1L,7L,3L,2L,8L,0L,0L,8L,6L,6L,4L,3L,6L,5L,8L,0L,3L,9L,1L,5L,7L,9L,5L,7L,6L,5L,5L,4L,7L,9L,5L,5L,8L,7L,7L,0L,7L,0L,3L,4L,1L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257136Inst : IEnumerable<long>
{
public static readonly long[] Value=A257136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257136.Bytes);
public long this[int i]=>Value[i];

public static A257136Inst Instance=new A257136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257137
{
public static readonly long[] Value={ 13L,4289907938811613L,5693002600430263L,21817283854511263L,48290946353555023L,51165618791484133L,53094081535451893L,70219878257874463L,98633358468021313L,99142644093930373L,104814760374339133L,166784569423739203L,167841416726358493L,184601252515266523L,263331429949004353L,272039012072134243L,339094624362619243L,363319822006646623L,363760043662280383L,437335541550793003L,455289126169953193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257137Inst : IEnumerable<long>
{
public static readonly long[] Value=A257137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257137.Bytes);
public long this[int i]=>Value[i];

public static A257137Inst Instance=new A257137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257138
{
public static readonly long[] Value={ 1707898733581273L,3266590043460823L,4422879865247923L,10907318641689703L,32472302129057023L,52590359764282573L,60229684381540753L,67893346321234513L,93179596929433093L,115458868925574253L,140563537593599353L,142977538681261363L,148877505784397623L,166362638531783773L,232442516762530153L,236585787518684683L,255933372890105143L,317294052871840123L,325853825645632363L,337188071215909993L,344447962857168403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257138Inst : IEnumerable<long>
{
public static readonly long[] Value=A257138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257138.Bytes);
public long this[int i]=>Value[i];

public static A257138Inst Instance=new A257138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257139
{
public static readonly long[] Value={ 11L,7933248530182091L,20475715985020181L,21817283854511261L,33502273017038711L,40257009922154141L,49242777550551701L,49600456951571411L,75093141517810301L,84653373093824651L,119308586807395871L,129037438367672951L,129706953139869221L,151242381725881331L,158947009165390331L,161216594737343261L,167317340088093311L,176587730173540571L,178444395317213141L,197053322268438521L,301854920123441801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257139Inst : IEnumerable<long>
{
public static readonly long[] Value=A257139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257139.Bytes);
public long this[int i]=>Value[i];

public static A257139Inst Instance=new A257139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257140
{
public static readonly long[] Value={ 7697168877290909L,10071192314217869L,11987120084474369L,28561589689237439L,62321320746357689L,73698766709402669L,75046774774314359L,79287805466244209L,98551408299919409L,136720189890477209L,225735856757596019L,234065221633327919L,302834818301440259L,360345440708336099L,385443070970192069L,387494664213890249L,466256026285842809L,539043082132918379L,570108181108560929L,610147978081735109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257140Inst : IEnumerable<long>
{
public static readonly long[] Value=A257140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257140.Bytes);
public long this[int i]=>Value[i];

public static A257140Inst Instance=new A257140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257141
{
public static readonly long[] Value={ 10527733922579L,15991086371740199L,22443709342850669L,69759046409087909L,94415460183744419L,164873121596539229L,197053322268438509L,212971209388223159L,215768926871613989L,248170682800139819L,270109976153617319L,326374793491266239L,341896216415143109L,341987213500572359L,362035072661912369L,401062754451879239L,441180406661470349L,450928996714672349L,503035098004929209L,533306698691196149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257141Inst : IEnumerable<long>
{
public static readonly long[] Value=A257141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257141.Bytes);
public long this[int i]=>Value[i];

public static A257141Inst Instance=new A257141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257142
{
public static readonly long[] Value={ 1L,3L,1L,8L,7L,1L,21L,34L,12L,1L,55L,141L,89L,18L,1L,144L,534L,522L,186L,25L,1L,377L,1905L,2651L,1445L,340L,33L,1L,987L,6512L,12198L,9370L,3350L,568L,42L,1L,2584L,21557L,52211L,53533L,26804L,6881L,889L,52L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257142Inst : IEnumerable<long>
{
public static readonly long[] Value=A257142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257142.Bytes);
public long this[int i]=>Value[i];

public static A257142Inst Instance=new A257142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257143
{
public static readonly long[] Value={ 1L,1L,3L,3L,6L,5L,9L,7L,12L,9L,15L,11L,18L,13L,21L,15L,24L,17L,27L,19L,30L,21L,33L,23L,36L,25L,39L,27L,42L,29L,45L,31L,48L,33L,51L,35L,54L,37L,57L,39L,60L,41L,63L,43L,66L,45L,69L,47L,72L,49L,75L,51L,78L,53L,81L,55L,84L,57L,87L,59L,90L,61L,93L,63L,96L,65L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257143Inst : IEnumerable<long>
{
public static readonly long[] Value=A257143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257143.Bytes);
public long this[int i]=>Value[i];

public static A257143Inst Instance=new A257143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257144
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,23L,24L,25L,27L,28L,29L,31L,32L,33L,35L,37L,40L,41L,43L,44L,45L,47L,49L,51L,53L,59L,60L,61L,63L,64L,65L,67L,69L,71L,73L,76L,77L,79L,81L,83L,85L,87L,88L,89L,91L,92L,95L,96L,97L,99L,101L,103L,104L,107L,108L,109L,112L,113L,115L,117L,119L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257144Inst : IEnumerable<long>
{
public static readonly long[] Value=A257144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257144.Bytes);
public long this[int i]=>Value[i];

public static A257144Inst Instance=new A257144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257145
{
public static readonly long[] Value={ 1L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L,-1L,-2L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257145Inst : IEnumerable<long>
{
public static readonly long[] Value=A257145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257145.Bytes);
public long this[int i]=>Value[i];

public static A257145Inst Instance=new A257145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257146
{
public static readonly long[] Value={ 60L,168L,1092L,2448L,5616L,6072L,25308L,29120L,32736L,39732L,51888L,74412L,150348L,194472L,285852L,546312L,612468L,1285608L,1934868L,2097024L,2165292L,2588772L,3594432L,3822588L,5848428L,6324552L,7174332L,8487168L,9095592L,10626828L,11332452L,12576732L,14467068L,15331992L,15927348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257146Inst : IEnumerable<long>
{
public static readonly long[] Value=A257146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257146.Bytes);
public long this[int i]=>Value[i];

public static A257146Inst Instance=new A257146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257147
{
public static readonly BigInteger[] Value={ 512L,16677L,732482L,51899365L,6713096472L,1618913713517L,695152560346535L,535333746001462703L,BigInteger.Parse("743423728273958126735"),BigInteger.Parse("1857204484036444866135303") };
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
public class A257147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257147Inst Instance=new A257147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257148
{
public static readonly long[] Value={ 2848L,16677L,101227L,594229L,3374539L,19028310L,106805258L,596053900L,3313202232L,18364278500L,101563966487L,560710638830L,3091513270239L,17027829457467L,93715212546183L,515462743205034L,2833901320808390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257148Inst : IEnumerable<long>
{
public static readonly long[] Value=A257148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257148.Bytes);
public long this[int i]=>Value[i];

public static A257148Inst Instance=new A257148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257149
{
public static readonly long[] Value={ 13504L,96680L,732482L,5449304L,39971674L,295114929L,2183417807L,16144616160L,119387730698L,882890101723L,6529665253371L,48291188396559L,357147674505523L,2641358506805251L,19534786074176850L,144473821838374989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257149Inst : IEnumerable<long>
{
public static readonly long[] Value=A257149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257149.Bytes);
public long this[int i]=>Value[i];

public static A257149Inst Instance=new A257149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257150
{
public static readonly long[] Value={ 62579L,541896L,5352986L,51899365L,502447661L,4926932828L,48470017991L,476479552209L,4684128407465L,46057781886842L,452929851448653L,4454002827485202L,43799245669010846L,430714186067308001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257150Inst : IEnumerable<long>
{
public static readonly long[] Value=A257150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257150.Bytes);
public long this[int i]=>Value[i];

public static A257150Inst Instance=new A257150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257151
{
public static readonly BigInteger[] Value={ 281213L,3009795L,40203005L,519390250L,6713096472L,88719570970L,1174259463543L,15502395045146L,204801698824497L,2706286932253121L,35758534656330823L,472477641818527221L,6242951311695452623L,BigInteger.Parse("82489518239639943631") };
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
public class A257151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257151.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257151Inst Instance=new A257151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257152
{
public static readonly BigInteger[] Value={ 1223367L,16759085L,303570406L,5227360394L,90781754582L,1618913713517L,28823946919854L,511817645366610L,9098220838706972L,161738430206897088L,2874855048099514923L,BigInteger.Parse("51101505829388775443"),BigInteger.Parse("908353565368209584649") };
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
public class A257152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257152Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257152.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257152.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257152Inst Instance=new A257152Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257153
{
public static readonly BigInteger[] Value={ 5203324L,92984383L,2272933686L,52041832046L,1213048046486L,29091719386474L,695152560346535L,16568848511790291L,395391962219835822L,9435041896611595444UL,BigInteger.Parse("225118886779181550215"),BigInteger.Parse("5371507180540875937110") };
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
public class A257153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257153.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257153Inst Instance=new A257153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257154
{
public static readonly long[] Value={ 512L,2848L,2848L,13504L,16677L,13504L,62579L,96680L,101227L,62579L,281213L,541896L,732482L,594229L,281213L,1223367L,3009795L,5352986L,5449304L,3374539L,1223367L,5203324L,16759085L,40203005L,51899365L,39971674L,19028310L,5203324L,21804750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257154Inst : IEnumerable<long>
{
public static readonly long[] Value=A257154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257154.Bytes);
public long this[int i]=>Value[i];

public static A257154Inst Instance=new A257154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257155
{
public static readonly long[] Value={ 2848L,16677L,96680L,541896L,3009795L,16759085L,92984383L,514055240L,2836802122L,15636201632L,86098173638L,473735553644L,2605181351054L,14320528333213L,78693423907691L,432325674225100L,2374652982306556L,13041444890192024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257155Inst : IEnumerable<long>
{
public static readonly long[] Value=A257155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257155.Bytes);
public long this[int i]=>Value[i];

public static A257155Inst Instance=new A257155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257156
{
public static readonly long[] Value={ 13504L,101227L,732482L,5352986L,40203005L,303570406L,2272933686L,16956110702L,126194739903L,937418918510L,6952450459180L,51515862833060L,381469904772233L,2823533969222054L,20892921311894352L,154570404973505912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257156Inst : IEnumerable<long>
{
public static readonly long[] Value=A257156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257156.Bytes);
public long this[int i]=>Value[i];

public static A257156Inst Instance=new A257156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257157
{
public static readonly long[] Value={ 62579L,594229L,5449304L,51899365L,519390250L,5227360394L,52041832046L,516365741514L,5111362313284L,50479024933580L,497753506268003L,4903583803546401L,48276454711270360L,475089725283264360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257157Inst : IEnumerable<long>
{
public static readonly long[] Value=A257157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257157.Bytes);
public long this[int i]=>Value[i];

public static A257157Inst Instance=new A257157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257158
{
public static readonly BigInteger[] Value={ 281213L,3374539L,39971674L,502447661L,6713096472L,90781754582L,1213048046486L,16153376651627L,214690187413026L,2847359969938939L,37708680279482593L,498983589987786874L,6599313193857816398L,BigInteger.Parse("87248623452324857708") };
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
public class A257158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257158Inst Instance=new A257158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257159
{
public static readonly BigInteger[] Value={ 1223367L,19028310L,295114929L,4926932828L,88719570970L,1618913713517L,29091719386474L,521342065918683L,9324568484584043L,166378440386504667L,2964299175474200382L,BigInteger.Parse("52771371147498273044"),BigInteger.Parse("938923629079031853253") };
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
public class A257159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257159Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257159.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257159.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257159Inst Instance=new A257159Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257160
{
public static readonly BigInteger[] Value={ 5203324L,106805258L,2183417807L,48470017991L,1174259463543L,28823946919854L,695152560346535L,16726973938599393L,401676352270542846L,9621272846082303604UL,BigInteger.Parse("230118043327974181813"),BigInteger.Parse("5499355230460178033140") };
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
public class A257160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257160Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257160.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257160Inst Instance=new A257160Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257161
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,4L,1L,2L,2L,5L,1L,4L,7L,6L,11L,3L,1L,2L,10L,7L,2L,7L,1L,11L,9L,8L,2L,4L,21L,7L,1L,2L,4L,9L,6L,21L,2L,3L,1L,27L,11L,10L,3L,5L,17L,6L,23L,16L,1L,2L,8L,11L,2L,15L,2L,6L,2L,27L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257161Inst : IEnumerable<long>
{
public static readonly long[] Value=A257161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257161.Bytes);
public long this[int i]=>Value[i];

public static A257161Inst Instance=new A257161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257162
{
public static readonly long[] Value={ 8L,12L,18L,13L,21L,15L,16L,18L,21L,18L,13L,27L,20L,18L,19L,26L,22L,19L,30L,21L,22L,25L,31L,25L,20L,34L,23L,31L,21L,35L,24L,33L,28L,30L,30L,32L,34L,27L,33L,28L,35L,33L,38L,30L,31L,32L,37L,30L,34L,39L,42L,35L,32L,31L,39L,33L,40L,38L,41L,36L,41L,36L,37L,32L,41L,43L,34L,42L,43L,42L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257162Inst : IEnumerable<long>
{
public static readonly long[] Value=A257162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257162.Bytes);
public long this[int i]=>Value[i];

public static A257162Inst Instance=new A257162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257163
{
public static readonly long[] Value={ 2L,5L,29L,149L,509L,677L,1877L,3677L,8429L,9749L,11909L,13469L,17789L,22709L,27077L,28229L,45389L,46877L,53069L,70229L,72077L,81677L,100469L,102677L,114077L,128549L,141269L,154589L,180077L,192029L,195077L,207509L,223589L,230189L,261077L,312989L,340709L,352949L,395309L,399677L,426389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257163Inst : IEnumerable<long>
{
public static readonly long[] Value=A257163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257163.Bytes);
public long this[int i]=>Value[i];

public static A257163Inst Instance=new A257163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257164
{
public static readonly long[] Value={ 0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257164Inst : IEnumerable<long>
{
public static readonly long[] Value=A257164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257164.Bytes);
public long this[int i]=>Value[i];

public static A257164Inst Instance=new A257164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257165
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,22L,44L,88L,176L,183L,186L,204L,224L,248L,296L,305L,310L,320L,352L,387L,425L,450L,495L,544L,598L,657L,714L,728L,756L,812L,824L,906L,996L,1092L,1184L,1195L,1214L,1235L,1258L,1316L,1329L,1358L,1493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257165Inst : IEnumerable<long>
{
public static readonly long[] Value=A257165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257165.Bytes);
public long this[int i]=>Value[i];

public static A257165Inst Instance=new A257165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257166
{
public static readonly ulong[] Value={ 11L,21817283854511261L,79287805466244209L,841262446570150721L,1006587882969594041L,2682372491413700201L,2714623996387988519L,5009128141636113611L,5012524663381750349L,6120794469172998449L,6195991854028811669L,6232932509314786109L,6808488664768715759L,7126352574372296381L,7993822923596334941L,10756418345074847279UL,11319107721272355839UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257166Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A257166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257166.Bytes);
public ulong this[int i]=>Value[i];

public static A257166Inst Instance=new A257166Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257167
{
public static readonly BigInteger[] Value={ 11L,21817283854511261L,841262446570150721L,1006587882969594041L,2682372491413700201L,5009128141636113611L,7126352574372296381L,7993822923596334941L,12870536149631655611UL,15762479629138737611UL,BigInteger.Parse("22811391659969177381"),BigInteger.Parse("25593071201116914611"),BigInteger.Parse("25908823282383706781"),BigInteger.Parse("42408988436795325461"),BigInteger.Parse("44360646117391789301"),BigInteger.Parse("54533311498517797061"),BigInteger.Parse("54872625531142644341"),BigInteger.Parse("55603189618237916771"),BigInteger.Parse("60815831883653681951") };
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
public class A257167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257167Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257167.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257167Inst Instance=new A257167Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257168
{
public static readonly BigInteger[] Value={ 79287805466244209L,2714623996387988519L,5012524663381750349L,6120794469172998449L,6195991854028811669L,6232932509314786109L,6808488664768715759L,10756418345074847279UL,11319107721272355839UL,12635619305675250719UL,14028155447337025829UL,14094050870111867489UL,14603617704434643719UL,14777669568340323479UL,15420967329931107779UL,16222575536498135639UL,16624441191356313149UL,17367037621075657349UL,BigInteger.Parse("19289576760019250519") };
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
public class A257168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257168Inst Instance=new A257168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257169
{
public static readonly BigInteger[] Value={ 11L,17L,1158722981124148367L,1240068005144831867L,2243290806352501637L,3172206835341609797L,8402171449067476007L,9422138120166964847UL,14094050870111867483UL,16222575536498135633UL,16485850001899818467UL,16679857156627718057UL,17905159760365247387UL,BigInteger.Parse("26082001869529405727"),BigInteger.Parse("27367669288651556693"),BigInteger.Parse("28025081332808782877"),BigInteger.Parse("30304192466683200797"),BigInteger.Parse("34827058725936837287"),BigInteger.Parse("36351118555624575707"),BigInteger.Parse("44333554877816671757") };
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
public class A257169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257169Inst Instance=new A257169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257170
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257170Inst : IEnumerable<long>
{
public static readonly long[] Value=A257170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257170.Bytes);
public long this[int i]=>Value[i];

public static A257170Inst Instance=new A257170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257171
{
public static readonly long[] Value={ 1L,5L,9L,13L,27L,36L,62L,78L,120L,145L,207L,243L,329L,378L,492L,556L,702L,783L,965L,1065L,1287L,1408L,1674L,1818L,2132L,2301L,2667L,2863L,3285L,3510L,3992L,4248L,4794L,5083L,5697L,6021L,6707L,7068L,7830L,8230L,9072L,9513L,10439L,10923L,11937L,12466L,13572L,14148L,15350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257171Inst : IEnumerable<long>
{
public static readonly long[] Value=A257171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257171.Bytes);
public long this[int i]=>Value[i];

public static A257171Inst Instance=new A257171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257172
{
public static readonly long[] Value={ 11424L,13248L,14112L,16128L,16632L,17136L,18144L,41328L,91728L,101112L,102144L,102816L,104832L,106272L,111012L,111375L,112288L,112896L,114048L,114240L,114912L,116160L,116928L,123120L,132480L,140112L,141120L,161280L,166320L,171171L,171360L,181440L,203112L,204288L,204336L,220416L,231012L,233772L,239616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257172Inst : IEnumerable<long>
{
public static readonly long[] Value=A257172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257172.Bytes);
public long this[int i]=>Value[i];

public static A257172Inst Instance=new A257172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257173
{
public static readonly long[] Value={ 0L,1L,2L,3L,69L,5L,9L,7L,40L,171L,365L,11L,805L,13L,217L,49L,637L,17L,1519L,19L,671L,125L,403L,23L,143L,2891L,1199L,1351L,917L,29L,559L,31L,799L,1099L,323L,14443L,949L,37L,803L,5027L,679L,41L,2167L,43L,1837L,6253L,341L,47L,253L,2327L,169L,4697L,2021L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257173Inst : IEnumerable<long>
{
public static readonly long[] Value=A257173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257173.Bytes);
public long this[int i]=>Value[i];

public static A257173Inst Instance=new A257173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257174
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,5L,8L,7L,8L,12L,10L,11L,16L,13L,14L,20L,16L,17L,24L,19L,20L,28L,22L,23L,32L,25L,26L,36L,28L,29L,40L,31L,32L,44L,34L,35L,48L,37L,38L,52L,40L,41L,56L,43L,44L,60L,46L,47L,64L,49L,50L,68L,52L,53L,72L,55L,56L,76L,58L,59L,80L,61L,62L,84L,64L,65L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257174Inst : IEnumerable<long>
{
public static readonly long[] Value=A257174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257174.Bytes);
public long this[int i]=>Value[i];

public static A257174Inst Instance=new A257174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257175
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,5L,5L,6L,7L,7L,8L,9L,10L,10L,11L,12L,12L,13L,14L,14L,15L,16L,17L,17L,18L,19L,19L,20L,21L,22L,22L,23L,24L,24L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,32L,33L,34L,34L,35L,36L,36L,37L,38L,39L,39L,40L,41L,41L,42L,43L,43L,44L,45L,46L,46L,47L,48L,48L,49L,50L,51L,51L,52L,53L,53L,54L,55L,56L,56L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257175Inst : IEnumerable<long>
{
public static readonly long[] Value=A257175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257175.Bytes);
public long this[int i]=>Value[i];

public static A257175Inst Instance=new A257175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257176
{
public static readonly long[] Value={ 1L,1L,9L,9L,0L,5L,8L,7L,1L,0L,0L,0L,2L,8L,2L,3L,6L,2L,9L,7L,1L,9L,3L,2L,9L,4L,3L,0L,9L,6L,6L,2L,5L,8L,3L,0L,5L,2L,2L,2L,9L,0L,6L,5L,1L,6L,7L,7L,0L,9L,5L,8L,5L,2L,0L,0L,2L,2L,2L,4L,3L,4L,6L,2L,2L,4L,3L,6L,8L,6L,9L,8L,3L,7L,6L,3L,0L,4L,3L,0L,9L,0L,2L,0L,0L,4L,9L,4L,4L,0L,0L,9L,7L,2L,1L,1L,8L,7L,7L,4L,5L,4L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257176Inst : IEnumerable<long>
{
public static readonly long[] Value=A257176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257176.Bytes);
public long this[int i]=>Value[i];

public static A257176Inst Instance=new A257176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257177
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,2L,2L,3L,3L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,6L,5L,5L,6L,6L,6L,7L,5L,7L,5L,7L,5L,10L,6L,8L,8L,9L,6L,11L,5L,11L,7L,11L,7L,13L,7L,13L,9L,13L,9L,15L,7L,16L,8L,15L,8L,17L,7L,16L,10L,17L,9L,20L,8L,21L,11L,20L,8L,21L,7L,22L,11L,22L,11L,23L,10L,28L,12L,24L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257177Inst : IEnumerable<long>
{
public static readonly long[] Value=A257177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257177.Bytes);
public long this[int i]=>Value[i];

public static A257177Inst Instance=new A257177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257178
{
public static readonly long[] Value={ 1L,3L,10L,33L,110L,369L,1247L,4245L,14558L,50295L,175029L,613467L,2165100L,7692345L,27504600L,98941185L,357952580L,1301960925L,4759282415L,17478557925L,64468072820L,238736987535L,887359113700L,3309489922743L,12381998910700L,46460457776739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257178Inst : IEnumerable<long>
{
public static readonly long[] Value=A257178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257178.Bytes);
public long this[int i]=>Value[i];

public static A257178Inst Instance=new A257178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257179
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257179Inst : IEnumerable<long>
{
public static readonly long[] Value=A257179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257179.Bytes);
public long this[int i]=>Value[i];

public static A257179Inst Instance=new A257179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257180
{
public static readonly long[] Value={ 1L,3L,3L,9L,24L,9L,27L,141L,141L,27L,81L,726L,1410L,726L,81L,243L,3471L,11406L,11406L,3471L,243L,729L,15828L,81327L,136872L,81327L,15828L,729L,2187L,69873L,533259L,1390521L,1390521L,533259L,69873L,2187L,6561L,301362L,3295152L,12609198L,19467294L,12609198L,3295152L,301362L,6561L,19683L,1277619L,19489380L,105311556L,237144642L,237144642L,105311556L,19489380L,1277619L,19683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257180Inst : IEnumerable<long>
{
public static readonly long[] Value=A257180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257180.Bytes);
public long this[int i]=>Value[i];

public static A257180Inst Instance=new A257180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257181
{
public static readonly long[] Value={ 1L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L,-1L,2L,-1L,0L,0L,1L,-2L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257181Inst : IEnumerable<long>
{
public static readonly long[] Value=A257181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257181.Bytes);
public long this[int i]=>Value[i];

public static A257181Inst Instance=new A257181Inst();

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