using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A088677
{
public static readonly long[] Value={ 65L,730L,793L,4097L,4160L,4825L,15626L,15689L,16354L,19721L,46657L,46720L,47385L,50752L,62281L,117650L,117713L,118378L,121745L,133274L,164305L,262145L,262208L,262873L,266240L,277769L,308800L,379793L,531442L,531505L,532170L,535537L,547066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088677Inst : IEnumerable<long>
{
public static readonly long[] Value=A088677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088677.Bytes);
public long this[int i]=>Value[i];

public static A088677Inst Instance=new A088677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088678
{
public static readonly long[] Value={ 1L,3L,17L,190L,2179L,27678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088678Inst : IEnumerable<long>
{
public static readonly long[] Value=A088678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088678.Bytes);
public long this[int i]=>Value[i];

public static A088678Inst Instance=new A088678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088679
{
public static readonly BigInteger[] Value={ 0L,1L,2L,6L,48L,2880L,9953280L,115579079884800L,BigInteger.Parse("15266884236590834264309760000"),BigInteger.Parse("262212473580148912869121218589990322256745385164800000000") };
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
public class A088679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088679.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088679Inst Instance=new A088679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088680
{
public static readonly long[] Value={ 2L,4L,4L,4L,2L,4L,4L,6L,6L,2L,4L,8L,2L,2L,14L,6L,10L,6L,4L,6L,10L,4L,12L,4L,4L,2L,6L,6L,6L,2L,14L,2L,14L,10L,4L,8L,6L,6L,4L,10L,10L,6L,6L,4L,4L,8L,8L,6L,2L,6L,6L,2L,10L,6L,6L,4L,12L,2L,6L,2L,4L,8L,8L,8L,6L,8L,4L,4L,10L,2L,2L,2L,14L,2L,14L,2L,20L,8L,8L,6L,14L,6L,8L,12L,6L,10L,6L,2L,2L,18L,2L,6L,8L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088680Inst : IEnumerable<long>
{
public static readonly long[] Value=A088680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088680.Bytes);
public long this[int i]=>Value[i];

public static A088680Inst Instance=new A088680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088681
{
public static readonly long[] Value={ 2L,2L,2L,6L,6L,2L,6L,2L,4L,6L,6L,4L,4L,4L,4L,2L,2L,6L,6L,2L,2L,2L,12L,2L,6L,10L,6L,2L,4L,10L,4L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088681Inst : IEnumerable<long>
{
public static readonly long[] Value=A088681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088681.Bytes);
public long this[int i]=>Value[i];

public static A088681Inst Instance=new A088681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088682
{
public static readonly long[] Value={ 4L,6L,10L,10L,10L,8L,8L,14L,6L,18L,8L,8L,10L,12L,6L,16L,10L,16L,8L,6L,18L,18L,12L,14L,10L,12L,12L,8L,14L,6L,12L,10L,20L,16L,8L,12L,12L,14L,6L,8L,10L,18L,14L,12L,12L,24L,12L,6L,18L,18L,6L,12L,12L,20L,12L,18L,8L,8L,12L,24L,6L,14L,28L,18L,12L,16L,8L,22L,6L,8L,6L,8L,12L,28L,6L,14L,8L,12L,6L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088682Inst : IEnumerable<long>
{
public static readonly long[] Value=A088682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088682.Bytes);
public long this[int i]=>Value[i];

public static A088682Inst Instance=new A088682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088683
{
public static readonly long[] Value={ 6L,6L,8L,6L,12L,10L,10L,12L,6L,18L,12L,12L,12L,12L,14L,6L,8L,12L,8L,12L,6L,20L,6L,14L,10L,12L,12L,10L,12L,16L,12L,18L,24L,12L,16L,8L,10L,22L,10L,14L,14L,18L,12L,14L,12L,22L,12L,12L,6L,18L,24L,18L,10L,18L,14L,16L,12L,16L,12L,22L,10L,14L,24L,18L,14L,10L,8L,28L,10L,10L,16L,40L,14L,24L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088683Inst : IEnumerable<long>
{
public static readonly long[] Value=A088683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088683.Bytes);
public long this[int i]=>Value[i];

public static A088683Inst Instance=new A088683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088684
{
public static readonly long[] Value={ 6L,6L,8L,6L,8L,6L,10L,6L,6L,10L,12L,10L,8L,6L,24L,6L,12L,12L,10L,24L,6L,16L,10L,12L,14L,18L,12L,10L,6L,20L,12L,14L,16L,8L,16L,8L,6L,12L,12L,16L,18L,18L,10L,10L,18L,14L,6L,24L,6L,6L,24L,18L,12L,10L,14L,10L,12L,12L,8L,6L,12L,12L,12L,16L,20L,12L,18L,20L,8L,6L,14L,40L,26L,18L,10L,6L,22L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088684Inst : IEnumerable<long>
{
public static readonly long[] Value=A088684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088684.Bytes);
public long this[int i]=>Value[i];

public static A088684Inst Instance=new A088684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088685
{
public static readonly long[] Value={ 0L,4L,5L,6L,7L,9L,10L,13L,15L,19L,21L,25L,31L,33L,39L,43L,45L,49L,55L,61L,63L,69L,73L,75L,81L,85L,91L,99L,103L,105L,109L,111L,115L,129L,133L,139L,141L,151L,153L,159L,165L,169L,175L,181L,183L,193L,195L,199L,201L,213L,225L,229L,231L,235L,241L,243L,253L,259L,265L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088685Inst : IEnumerable<long>
{
public static readonly long[] Value=A088685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088685.Bytes);
public long this[int i]=>Value[i];

public static A088685Inst Instance=new A088685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088686
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,14L,21L,22L,26L,34L,38L,46L,58L,62L,74L,82L,86L,94L,106L,118L,122L,134L,142L,146L,158L,166L,178L,194L,202L,206L,214L,218L,226L,254L,262L,274L,278L,298L,302L,314L,326L,334L,346L,358L,362L,382L,386L,394L,398L,422L,446L,454L,458L,466L,478L,482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088686Inst : IEnumerable<long>
{
public static readonly long[] Value=A088686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088686.Bytes);
public long this[int i]=>Value[i];

public static A088686Inst Instance=new A088686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088687
{
public static readonly long[] Value={ 17L,82L,97L,257L,272L,337L,626L,641L,706L,881L,1297L,1312L,1377L,1552L,1921L,2402L,2417L,2482L,2657L,3026L,3697L,4097L,4112L,4177L,4352L,4721L,5392L,6497L,6562L,6577L,6642L,6817L,7186L,7857L,8962L,10001L,10016L,10081L,10256L,10625L,10657L,11296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088687Inst : IEnumerable<long>
{
public static readonly long[] Value=A088687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088687.Bytes);
public long this[int i]=>Value[i];

public static A088687Inst Instance=new A088687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088688
{
public static readonly long[] Value={ 0L,1L,3L,6L,12L,27L,63L,141L,297L,594L,1146L,2169L,4095L,7827L,15291L,30582L,62256L,127791L,262143L,534129L,1078101L,2156202L,4282878L,8477181L,16777215L,33288711L,66311703L,132623406L,266043972L,534479427L,1073741823L,2154658101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088688Inst : IEnumerable<long>
{
public static readonly long[] Value=A088688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088688.Bytes);
public long this[int i]=>Value[i];

public static A088688Inst Instance=new A088688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088689
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088689Inst : IEnumerable<long>
{
public static readonly long[] Value=A088689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088689.Bytes);
public long this[int i]=>Value[i];

public static A088689Inst Instance=new A088689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088690
{
public static readonly BigInteger[] Value={ 1L,2L,11L,106L,1489L,27696L,643579L,17973488L,586899009L,21953140480L,925890264331L,43480125312768L,2250352192663249L,127280062346049536L,7811329076598534075L,BigInteger.Parse("517016126622623635456"),BigInteger.Parse("36713034605774835974401"),BigInteger.Parse("2784127167066690618458112") };
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
public class A088690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088690Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088690.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088690.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088690Inst Instance=new A088690Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088691
{
public static readonly BigInteger[] Value={ 1L,1L,5L,47L,657L,12245L,285805L,8022555L,263276705L,9892965545L,418911700725L,19738761470375L,1024422336336625L,58067265415960125L,3569400983720767325L,BigInteger.Parse("236508279434832201875"),BigInteger.Parse("16804378746368557826625"),BigInteger.Parse("1274542376742001037932625"),BigInteger.Parse("102780751359763333970849125") };
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
public class A088691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088691Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088691.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088691.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088691Inst Instance=new A088691Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088740
{
public static readonly long[] Value={ 4L,6L,4L,9L,10L,6L,14L,15L,4L,9L,10L,21L,22L,6L,25L,26L,9L,14L,15L,4L,33L,34L,35L,9L,38L,39L,10L,21L,22L,15L,46L,6L,49L,25L,51L,26L,9L,55L,14L,57L,58L,15L,62L,21L,4L,65L,33L,34L,69L,35L,9L,74L,25L,38L,77L,39L,10L,9L,82L,21L,85L,86L,87L,22L,15L,91L,46L,93L,94L,95L,6L,49L,33L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088740Inst : IEnumerable<long>
{
public static readonly long[] Value=A088740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088740.Bytes);
public long this[int i]=>Value[i];

public static A088740Inst Instance=new A088740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088741
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,1L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088741Inst : IEnumerable<long>
{
public static readonly long[] Value=A088741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088741.Bytes);
public long this[int i]=>Value[i];

public static A088741Inst Instance=new A088741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088742
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,1L,3L,3L,1L,1L,2L,1L,4L,1L,3L,3L,1L,1L,2L,1L,3L,1L,1L,3L,4L,1L,2L,1L,4L,1L,3L,3L,1L,1L,2L,1L,3L,1L,1L,3L,3L,1L,1L,2L,1L,4L,1L,3L,4L,1L,2L,1L,3L,1L,1L,3L,4L,1L,2L,1L,4L,1L,3L,3L,1L,1L,2L,1L,3L,1L,1L,3L,3L,1L,1L,2L,1L,4L,1L,3L,3L,1L,1L,2L,1L,3L,1L,1L,3L,4L,1L,2L,1L,4L,1L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088742Inst : IEnumerable<long>
{
public static readonly long[] Value=A088742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088742.Bytes);
public long this[int i]=>Value[i];

public static A088742Inst Instance=new A088742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088743
{
public static readonly long[] Value={ 1L,3L,5L,5L,7L,9L,9L,9L,11L,13L,15L,15L,15L,17L,17L,17L,19L,21L,23L,23L,25L,27L,27L,27L,27L,29L,31L,31L,31L,33L,33L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088743Inst : IEnumerable<long>
{
public static readonly long[] Value=A088743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088743.Bytes);
public long this[int i]=>Value[i];

public static A088743Inst Instance=new A088743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088744
{
public static readonly long[] Value={ 1L,4L,7L,7L,10L,13L,13L,13L,16L,19L,22L,22L,22L,25L,25L,25L,28L,31L,34L,34L,37L,40L,40L,40L,40L,43L,46L,46L,46L,49L,49L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088744Inst : IEnumerable<long>
{
public static readonly long[] Value=A088744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088744.Bytes);
public long this[int i]=>Value[i];

public static A088744Inst Instance=new A088744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088745
{
public static readonly long[] Value={ 1L,3L,4L,8L,2L,6L,11L,7L,9L,15L,24L,16L,5L,12L,17L,26L,18L,13L,14L,25L,35L,48L,36L,22L,10L,23L,27L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088745Inst : IEnumerable<long>
{
public static readonly long[] Value=A088745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088745.Bytes);
public long this[int i]=>Value[i];

public static A088745Inst Instance=new A088745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088746
{
public static readonly long[] Value={ 1L,-10L,205L,-6300L,276363L,-15615642L,861774366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088746Inst : IEnumerable<long>
{
public static readonly long[] Value=A088746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088746.Bytes);
public long this[int i]=>Value[i];

public static A088746Inst Instance=new A088746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088747
{
public static readonly long[] Value={ 2L,3L,11L,37L,109L,349L,1009L,2801L,7759L,21157L,56611L,150107L,394817L,1031141L,2676301L,6908743L,17756213L,45456347L,115973411L,294965017L,748174379L,1893049583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088747Inst : IEnumerable<long>
{
public static readonly long[] Value=A088747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088747.Bytes);
public long this[int i]=>Value[i];

public static A088747Inst Instance=new A088747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088748
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,5L,4L,3L,4L,3L,2L,3L,4L,5L,4L,5L,6L,5L,4L,3L,4L,5L,4L,3L,4L,3L,2L,3L,4L,5L,4L,5L,6L,5L,4L,5L,6L,7L,6L,5L,6L,5L,4L,3L,4L,5L,4L,5L,6L,5L,4L,3L,4L,5L,4L,3L,4L,3L,2L,3L,4L,5L,4L,5L,6L,5L,4L,5L,6L,7L,6L,5L,6L,5L,4L,5L,6L,7L,6L,7L,8L,7L,6L,5L,6L,7L,6L,5L,6L,5L,4L,3L,4L,5L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088748Inst : IEnumerable<long>
{
public static readonly long[] Value=A088748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088748.Bytes);
public long this[int i]=>Value[i];

public static A088748Inst Instance=new A088748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088749
{
public static readonly long[] Value={ -3L,-1L,1L,3L,9L,11L,17L,23L,29L,35L,41L,47L,53L,59L,69L,75L,81L,91L,97L,103L,113L,123L,129L,135L,145L,155L,161L,171L,181L,187L,197L,207L,217L,223L,237L,247L,253L,263L,273L,283L,293L,307L,313L,323L,329L,343L,353L,359L,373L,383L,393L,403L,417L,423L,437L,451L,457L,467L,481L,491L,501L,511L,525L,535L,545L,559L,569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088749Inst : IEnumerable<long>
{
public static readonly long[] Value=A088749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088749.Bytes);
public long this[int i]=>Value[i];

public static A088749Inst Instance=new A088749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088750
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,8L,10L,9L,11L,13L,12L,14L,16L,15L,17L,18L,20L,19L,21L,24L,22L,23L,25L,27L,26L,28L,29L,32L,30L,31L,33L,35L,34L,36L,37L,40L,38L,39L,41L,44L,42L,43L,45L,46L,48L,47L,49L,50L,53L,51L,52L,54L,55L,57L,56L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088750Inst : IEnumerable<long>
{
public static readonly long[] Value=A088750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088750.Bytes);
public long this[int i]=>Value[i];

public static A088750Inst Instance=new A088750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088751
{
public static readonly long[] Value={ 6L,8L,6L,7L,7L,7L,8L,3L,4L,4L,6L,0L,6L,3L,4L,9L,5L,4L,4L,2L,6L,5L,4L,0L,2L,2L,3L,7L,0L,6L,7L,6L,9L,2L,6L,9L,2L,2L,7L,0L,0L,2L,6L,3L,7L,6L,2L,2L,5L,0L,4L,2L,0L,7L,3L,9L,3L,4L,2L,5L,8L,2L,9L,4L,0L,1L,1L,5L,3L,1L,0L,0L,8L,7L,7L,0L,0L,4L,3L,7L,3L,6L,6L,9L,6L,9L,5L,3L,0L,1L,0L,6L,7L,6L,8L,2L,5L,9L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088751Inst : IEnumerable<long>
{
public static readonly long[] Value=A088751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088751.Bytes);
public long this[int i]=>Value[i];

public static A088751Inst Instance=new A088751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088752
{
public static readonly long[] Value={ 1L,4L,3L,4L,4L,5L,6L,6L,6L,7L,7L,8L,9L,9L,8L,9L,9L,10L,11L,12L,11L,12L,13L,14L,14L,15L,14L,15L,15L,16L,17L,18L,18L,19L,18L,19L,20L,21L,20L,21L,21L,22L,23L,24L,23L,24L,25L,26L,26L,27L,26L,27L,28L,29L,29L,30L,29L,30L,30L,31L,32L,33L,33L,34L,33L,34L,35L,36L,35L,36L,36L,37L,38L,39L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088752Inst : IEnumerable<long>
{
public static readonly long[] Value=A088752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088752.Bytes);
public long this[int i]=>Value[i];

public static A088752Inst Instance=new A088752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088753
{
public static readonly long[] Value={ 196L,879L,1997L,7059L,9999L,10553L,10563L,10577L,10583L,10585L,10638L,10663L,10668L,10697L,10715L,10728L,10735L,10746L,10748L,10783L,10785L,10787L,10788L,10877L,10883L,10963L,10965L,10969L,10977L,10983L,10985L,12797L,12898L,13097L,13197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088753Inst : IEnumerable<long>
{
public static readonly long[] Value=A088753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088753.Bytes);
public long this[int i]=>Value[i];

public static A088753Inst Instance=new A088753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088754
{
public static readonly long[] Value={ 1L,2L,14L,107L,103L,851L,6931L,59557L,518971L,4585526L,41368791L,375232730L,3441863700L,31843327587L,295907384843L,2761221438054L,25890141962275L,244138314690159L,2306482418751769L,21874074143081175L,208132164249925671L,1983046852246630734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088754Inst : IEnumerable<long>
{
public static readonly long[] Value=A088754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088754.Bytes);
public long this[int i]=>Value[i];

public static A088754Inst Instance=new A088754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088755
{
public static readonly long[] Value={ 0L,2L,16L,119L,924L,7445L,63129L,547572L,4838319L,4814936L,43167234L,391378851L,3580266494L,32997926272L,306051434210L,2853931339135L,26737370196938L,251515351394258L,2374493400086829L,22488661383368556L,213597279448646179L,2033961812788210675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088755Inst : IEnumerable<long>
{
public static readonly long[] Value=A088755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088755.Bytes);
public long this[int i]=>Value[i];

public static A088755Inst Instance=new A088755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088788
{
public static readonly long[] Value={ 227L,449L,8669L,8849L,66449L,86627L,8886649L,8888449L,8888669L,8888849L,86664427L,888886447L,888888449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088788Inst : IEnumerable<long>
{
public static readonly long[] Value=A088788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088788.Bytes);
public long this[int i]=>Value[i];

public static A088788Inst Instance=new A088788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088789
{
public static readonly BigInteger[] Value={ 0L,1L,1L,3L,14L,90L,738L,7364L,86608L,1173240L,17990600L,308055528L,5826331440L,120629547584L,2713659864832L,65909241461760L,1718947213795328L,47912968352783232L,1421417290991105664L,BigInteger.Parse("44717945211445216640"),BigInteger.Parse("1487040748881346835200"),BigInteger.Parse("52117255681017313721088") };
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
public class A088789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088789Inst Instance=new A088789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088790
{
public static readonly long[] Value={ 2L,3L,19L,31L,7547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088790Inst : IEnumerable<long>
{
public static readonly long[] Value=A088790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088790.Bytes);
public long this[int i]=>Value[i];

public static A088790Inst Instance=new A088790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088791
{
public static readonly long[] Value={ 1L,1L,1L,2L,8L,46L,337L,2976L,30627L,359222L,4725968L,68903766L,1102712316L,19219507328L,362428546833L,7352854216056L,159705991698432L,3697928742242694L,90933523698184947L,2366758931071064064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088791Inst : IEnumerable<long>
{
public static readonly long[] Value=A088791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088791.Bytes);
public long this[int i]=>Value[i];

public static A088791Inst Instance=new A088791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088792
{
public static readonly long[] Value={ 1L,1L,2L,7L,38L,279L,2535L,27106L,330998L,4526827L,68402684L,1130591607L,20282026273L,392427087780L,8146462590683L,180629845193090L,4261044215912232L,106571080784076813L,2817142524095598771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088792Inst : IEnumerable<long>
{
public static readonly long[] Value=A088792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088792.Bytes);
public long this[int i]=>Value[i];

public static A088792Inst Instance=new A088792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088793
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,15L,43L,135L,462L,1708L,6752L,28302L,125036L,579709L,2811084L,14216095L,74788529L,408388370L,2310191935L,13514877249L,81639455600L,508524173808L,3262111727548L,21525758405136L,145957394683691L,1015949479338974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088793Inst : IEnumerable<long>
{
public static readonly long[] Value=A088793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088793.Bytes);
public long this[int i]=>Value[i];

public static A088793Inst Instance=new A088793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088794
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,30L,305L,3905L,59828L,1063728L,21497921L,486476766L,12184618776L,334684804952L,10005219881472L,323438539163521L,11244331792094312L,418375698771595037L,16590419690069321454UL,BigInteger.Parse("698526596162530976512") };
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
public class A088794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088794Inst Instance=new A088794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088795
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,13L,20L,30L,43L,60L,81L,107L,138L,175L,218L,268L,325L,390L,463L,545L,636L,737L,848L,970L,1103L,1248L,1405L,1575L,1758L,1955L,2166L,2392L,2633L,2890L,3163L,3453L,3760L,4085L,4428L,4790L,5171L,5572L,5993L,6435L,6898L,7383L,7890L,8420L,8973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088795Inst : IEnumerable<long>
{
public static readonly long[] Value=A088795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088795.Bytes);
public long this[int i]=>Value[i];

public static A088795Inst Instance=new A088795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088796
{
public static readonly long[] Value={ 2L,5L,11L,19L,29L,37L,47L,71L,89L,97L,107L,127L,139L,179L,281L,317L,331L,337L,379L,397L,461L,499L,509L,571L,617L,659L,677L,691L,709L,839L,877L,887L,907L,1021L,1049L,1051L,1087L,1097L,1229L,1279L,1297L,1307L,1381L,1429L,1447L,1481L,1489L,1499L,1511L,1579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088796Inst : IEnumerable<long>
{
public static readonly long[] Value=A088796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088796.Bytes);
public long this[int i]=>Value[i];

public static A088796Inst Instance=new A088796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088797
{
public static readonly long[] Value={ 3L,7L,67L,667L,6667L,66667L,666667L,2857143L,6666667L,66666667L,666666667L,1052631579L,6666666667L,66666666667L,666666666667L,2857142857143L,6666666666667L,11764705882353L,66666666666667L,666666666666667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088797Inst : IEnumerable<long>
{
public static readonly long[] Value=A088797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088797.Bytes);
public long this[int i]=>Value[i];

public static A088797Inst Instance=new A088797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088798
{
public static readonly BigInteger[] Value={ 3L,19L,57L,3276457L,9829371L,22997937L,24687460011L,24504559526049L,1152870338086169L,3458611014258507L,BigInteger.Parse("19831522709797616449"),BigInteger.Parse("54128285729329681609"),BigInteger.Parse("59494568129392849347"),BigInteger.Parse("61582096835687335289") };
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
public class A088798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088798Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088798.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088798.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088798Inst Instance=new A088798Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088799
{
public static readonly BigInteger[] Value={ 3L,11L,9491L,12258083L,36774249L,2159487563L,2561252691L,2723957777L,6478462689L,8171873331L,333351714587L,146217070005379L,438651210016137L,13919982618156833L,41759947854470499L,BigInteger.Parse("1278907806311980217974478364841") };
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
public class A088799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088799Inst Instance=new A088799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088800
{
public static readonly long[] Value={ 16L,43L,86L,3923L,7846L,1320532L,14869252L,37031789L,74063578L,1770748607L,3541497214L,7082994428L,50541770557L,1040474831558L,1076026363388L,2080949663116L,2746369613531L,3376243036861L,5492739227062L,6529386313577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088800Inst : IEnumerable<long>
{
public static readonly long[] Value=A088800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088800.Bytes);
public long this[int i]=>Value[i];

public static A088800Inst Instance=new A088800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088801
{
public static readonly BigInteger[] Value={ 1L,-3L,-7L,-9L,59L,483L,-2323L,-42801L,923923L,30055311L,-170042041L,-8639161167L,99976667055L,7336972779615L,-42962450319915L,-4309733345367105L,203289825295660035L,BigInteger.Parse("26751125064470578695"),BigInteger.Parse("-158415664732997134045"),BigInteger.Parse("-26488943422458070446915") };
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
public class A088801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088801.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088801Inst Instance=new A088801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088802
{
public static readonly long[] Value={ 1L,4L,32L,128L,2048L,8192L,65536L,262144L,8388608L,33554432L,268435456L,1073741824L,17179869184L,68719476736L,549755813888L,2199023255552L,140737488355328L,562949953421312L,4503599627370496L,18014398509481984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088802Inst : IEnumerable<long>
{
public static readonly long[] Value=A088802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088802.Bytes);
public long this[int i]=>Value[i];

public static A088802Inst Instance=new A088802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088803
{
public static readonly long[] Value={ 1L,3L,7L,11L,17L,25L,33L,41L,53L,65L,77L,93L,109L,123L,143L,163L,181L,203L,227L,249L,277L,303L,329L,357L,389L,417L,451L,485L,517L,555L,593L,629L,669L,711L,749L,795L,839L,883L,931L,981L,1025L,1077L,1131L,1179L,1235L,1293L,1343L,1403L,1465L,1519L,1583L,1649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088803Inst : IEnumerable<long>
{
public static readonly long[] Value=A088803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088803.Bytes);
public long this[int i]=>Value[i];

public static A088803Inst Instance=new A088803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088932
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,20L,26L,36L,46L,60L,74L,94L,114L,140L,166L,201L,236L,280L,324L,380L,436L,504L,572L,656L,740L,840L,940L,1060L,1180L,1320L,1460L,1625L,1790L,1980L,2170L,2390L,2610L,2860L,3110L,3396L,3682L,4004L,4326L,4690L,5054L,5460L,5866L,6321L,6776L,7280L,7784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088932Inst : IEnumerable<long>
{
public static readonly long[] Value=A088932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088932.Bytes);
public long this[int i]=>Value[i];

public static A088932Inst Instance=new A088932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088933
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,4L,3L,13L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088933Inst : IEnumerable<long>
{
public static readonly long[] Value=A088933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088933.Bytes);
public long this[int i]=>Value[i];

public static A088933Inst Instance=new A088933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088934
{
public static readonly long[] Value={ 19L,13L,19L,13L,2L,3L,13L,19L,13L,3L,13L,7L,5L,3L,13L,7L,5L,13L,13L,7L,5L,5L,19L,13L,7L,5L,13L,13L,7L,5L,5L,19L,13L,7L,5L,13L,7L,7L,5L,13L,7L,17L,11L,11L,7L,7L,17L,11L,13L,7L,17L,11L,13L,7L,7L,17L,11L,13L,7L,11L,11L,7L,7L,11L,13L,7L,17L,11L,11L,7L,7L,17L,11L,13L,7L,17L,11L,11L,7L,7L,17L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088934Inst : IEnumerable<long>
{
public static readonly long[] Value=A088934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088934.Bytes);
public long this[int i]=>Value[i];

public static A088934Inst Instance=new A088934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088935
{
public static readonly long[] Value={ 0L,5L,15L,78L,88L,98L,108L,118L,181L,191L,201L,211L,274L,284L,294L,304L,367L,377L,387L,397L,407L,470L,480L,490L,500L,563L,573L,583L,593L,603L,666L,676L,686L,696L,759L,769L,779L,789L,852L,862L,872L,882L,892L,955L,965L,975L,985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088935Inst : IEnumerable<long>
{
public static readonly long[] Value=A088935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088935.Bytes);
public long this[int i]=>Value[i];

public static A088935Inst Instance=new A088935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088936
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,4L,3L,4L,2L,5L,5L,5L,4L,5L,5L,5L,4L,5L,5L,3L,5L,5L,5L,4L,5L,2L,6L,6L,6L,6L,5L,6L,6L,6L,6L,5L,6L,6L,6L,6L,5L,6L,6L,6L,4L,6L,6L,6L,6L,5L,6L,6L,6L,6L,5L,6L,6L,6L,6L,5L,6L,6L,6L,4L,6L,6L,6L,6L,5L,6L,6L,6L,6L,5L,6L,6L,3L,6L,6L,6L,6L,5L,6L,6L,6L,6L,5L,6L,6L,6L,6L,5L,6L,6L,6L,4L,6L,6L,6L,6L,5L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088936Inst : IEnumerable<long>
{
public static readonly long[] Value=A088936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088936.Bytes);
public long this[int i]=>Value[i];

public static A088936Inst Instance=new A088936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088937
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,14L,18L,21L,25L,27L,32L,37L,42L,46L,51L,56L,61L,65L,70L,75L,78L,83L,88L,93L,97L,102L,104L,110L,116L,122L,128L,133L,139L,145L,151L,157L,162L,168L,174L,180L,186L,191L,197L,203L,209L,213L,219L,225L,231L,237L,242L,248L,254L,260L,266L,271L,277L,283L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088937Inst : IEnumerable<long>
{
public static readonly long[] Value=A088937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088937.Bytes);
public long this[int i]=>Value[i];

public static A088937Inst Instance=new A088937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088938
{
public static readonly long[] Value={ 2L,3L,5L,10L,27L,104L,541L,3498L,26615L,231172L,2250129L,24227486L,285705643L,3660694200L,50624828357L,751426146514L,11913622408671L,200919532718828L,3591112295892985L,67803855263483142L,1348467602319393299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088938Inst : IEnumerable<long>
{
public static readonly long[] Value=A088938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088938.Bytes);
public long this[int i]=>Value[i];

public static A088938Inst Instance=new A088938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088939
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,3L,4L,2L,5L,4L,5L,4L,5L,3L,5L,4L,5L,2L,6L,5L,6L,5L,6L,5L,6L,4L,6L,5L,6L,5L,6L,5L,6L,4L,6L,5L,6L,5L,6L,3L,6L,5L,6L,5L,6L,5L,6L,4L,6L,5L,6L,2L,7L,6L,7L,6L,7L,6L,7L,6L,7L,5L,7L,6L,7L,6L,7L,6L,7L,6L,7L,5L,7L,6L,7L,6L,7L,6L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088939Inst : IEnumerable<long>
{
public static readonly long[] Value=A088939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088939.Bytes);
public long this[int i]=>Value[i];

public static A088939Inst Instance=new A088939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088940
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,14L,18L,21L,25L,27L,32L,37L,42L,46L,51L,56L,61L,65L,70L,75L,78L,83L,88L,93L,97L,102L,104L,110L,116L,122L,128L,133L,139L,145L,151L,157L,162L,168L,174L,180L,186L,191L,197L,203L,209L,213L,219L,225L,231L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088940Inst : IEnumerable<long>
{
public static readonly long[] Value=A088940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088940.Bytes);
public long this[int i]=>Value[i];

public static A088940Inst Instance=new A088940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088941
{
public static readonly long[] Value={ 0L,12L,54L,154L,349L,685L,1217L,2009L,3134L,4674L,6720L,9372L,12739L,16939L,22099L,28355L,35852L,44744L,55194L,67374L,81465L,97657L,116149L,137149L,160874L,187550L,217412L,250704L,287679L,328599L,373735L,423367L,477784L,537284L,602174L,672770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088941Inst : IEnumerable<long>
{
public static readonly long[] Value=A088941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088941.Bytes);
public long this[int i]=>Value[i];

public static A088941Inst Instance=new A088941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088942
{
public static readonly long[] Value={ 0L,60L,390L,1450L,4045L,9421L,19361L,36281L,63326L,104466L,164592L,249612L,366547L,523627L,730387L,997763L,1338188L,1765688L,2295978L,2946558L,3736809L,4688089L,5823829L,7169629L,8753354L,10605230L,12757940L,15246720L,18109455L,21386775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088942Inst : IEnumerable<long>
{
public static readonly long[] Value=A088942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088942.Bytes);
public long this[int i]=>Value[i];

public static A088942Inst Instance=new A088942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088943
{
public static readonly long[] Value={ 0L,60L,450L,1790L,5195L,12419L,25999L,49399L,87154L,145014L,230088L,350988L,517973L,743093L,1040333L,1425757L,1917652L,2536672L,3305982L,4251402L,5401551L,6787991L,8445371L,10411571L,12727846L,15438970L,18593380L,22243320L,26444985L,31258665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088943Inst : IEnumerable<long>
{
public static readonly long[] Value=A088943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088943.Bytes);
public long this[int i]=>Value[i];

public static A088943Inst Instance=new A088943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088944
{
public static readonly long[] Value={ 6L,12L,60L,60L,84L,84L,60L,60L,132L,132L,5460L,5460L,12L,12L,1020L,1020L,1596L,1596L,660L,660L,276L,276L,5460L,5460L,12L,12L,60L,60L,28644L,28644L,1020L,1020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088944Inst : IEnumerable<long>
{
public static readonly long[] Value=A088944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088944.Bytes);
public long this[int i]=>Value[i];

public static A088944Inst Instance=new A088944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088945
{
public static readonly long[] Value={ 0L,60L,690L,3630L,13035L,37059L,89839L,193879L,382834L,704694L,1225368L,2032668L,3240693L,4994613L,7475853L,10907677L,15561172L,21761632L,29895342L,40416762L,53856111L,70827351L,92036571L,118290771L,150507046L,189722170L,237102580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088945Inst : IEnumerable<long>
{
public static readonly long[] Value=A088945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088945.Bytes);
public long this[int i]=>Value[i];

public static A088945Inst Instance=new A088945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088946
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,13L,86L,466L,3830L,29633L,289480L,2865826L,32992576L,394893590L,5267005771L,73816682108L,1123682376634L,18021084739737L,309127486471294L,5578794711931042L,106617559112195219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088946Inst : IEnumerable<long>
{
public static readonly long[] Value=A088946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088946.Bytes);
public long this[int i]=>Value[i];

public static A088946Inst Instance=new A088946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088947
{
public static readonly long[] Value={ 1L,2L,5L,7L,10L,13L,25L,27L,31L,37L,151L,277L,385L,451L,902L,6314L,6601L,16627L,24673L,30371L,31451L,32338L,36058L,41173L,44083L,44215L,47322L,52580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088947Inst : IEnumerable<long>
{
public static readonly long[] Value=A088947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088947.Bytes);
public long this[int i]=>Value[i];

public static A088947Inst Instance=new A088947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089028
{
public static readonly long[] Value={ 1L,3L,1L,5L,6L,1L,1L,9L,10L,11L,1L,13L,1L,1L,1L,17L,18L,19L,20L,1L,22L,23L,1L,25L,1L,1L,28L,1L,1L,1L,1L,33L,34L,35L,36L,37L,1L,39L,40L,41L,1L,43L,44L,1L,46L,1L,1L,49L,50L,1L,52L,1L,1L,55L,1L,1L,1L,59L,1L,1L,1L,1L,1L,65L,66L,67L,68L,69L,70L,1L,72L,73L,74L,75L,1L,77L,78L,79L,1L,81L,82L,1L,84L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089028Inst : IEnumerable<long>
{
public static readonly long[] Value=A089028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089028.Bytes);
public long this[int i]=>Value[i];

public static A089028Inst Instance=new A089028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089029
{
public static readonly long[] Value={ 1L,3L,4L,1L,6L,7L,1L,9L,1L,1L,12L,1L,1L,15L,1L,17L,18L,1L,20L,1L,1L,1L,24L,1L,1L,27L,1L,1L,1L,31L,1L,1L,34L,35L,1L,37L,38L,1L,40L,41L,1L,43L,1L,1L,1L,1L,48L,1L,50L,51L,1L,1L,54L,1L,1L,57L,1L,59L,1L,1L,1L,63L,1L,1L,66L,1L,1L,69L,70L,1L,72L,73L,1L,75L,1L,77L,1L,79L,80L,81L,1L,1L,84L,1L,86L,87L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089029Inst : IEnumerable<long>
{
public static readonly long[] Value=A089029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089029.Bytes);
public long this[int i]=>Value[i];

public static A089029Inst Instance=new A089029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089030
{
public static readonly long[] Value={ 1L,13L,37L,61L,73L,85L,85L,97L,109L,145L,157L,169L,193L,229L,241L,265L,277L,289L,325L,325L,337L,349L,373L,397L,409L,433L,457L,481L,493L,493L,505L,505L,541L,577L,577L,601L,625L,661L,673L,685L,697L,697L,709L,733L,757L,769L,793L,793L,829L,853L,865L,865L,877L,901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089030Inst : IEnumerable<long>
{
public static readonly long[] Value=A089030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089030.Bytes);
public long this[int i]=>Value[i];

public static A089030Inst Instance=new A089030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089031
{
public static readonly long[] Value={ 1L,14L,44L,56L,91L,76L,104L,119L,136L,161L,184L,209L,221L,266L,299L,319L,304L,341L,296L,406L,391L,434L,464L,496L,481L,451L,551L,589L,506L,574L,559L,629L,656L,539L,611L,731L,779L,814L,799L,784L,689L,851L,754L,806L,946L,931L,901L,989L,1034L,826L,899L,1081L,1066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089031Inst : IEnumerable<long>
{
public static readonly long[] Value=A089031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089031.Bytes);
public long this[int i]=>Value[i];

public static A089031Inst Instance=new A089031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089032
{
public static readonly long[] Value={ 1L,11L,19L,69L,9L,99L,29L,31L,11L,111L,91L,41L,129L,141L,49L,119L,221L,159L,371L,19L,209L,59L,61L,21L,231L,399L,201L,161L,469L,299L,391L,71L,219L,639L,511L,231L,79L,189L,351L,459L,711L,249L,621L,581L,29L,319L,551L,89L,91L,899L,801L,31L,341L,979L,819L,589L,1001L,899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089032Inst : IEnumerable<long>
{
public static readonly long[] Value=A089032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089032.Bytes);
public long this[int i]=>Value[i];

public static A089032Inst Instance=new A089032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089033
{
public static readonly long[] Value={ 0L,2L,4L,8L,10L,14L,22L,28L,32L,34L,38L,40L,44L,50L,52L,58L,68L,74L,80L,82L,88L,92L,94L,110L,112L,118L,122L,134L,140L,142L,148L,158L,160L,164L,170L,178L,182L,184L,188L,194L,208L,212L,220L,224L,230L,232L,238L,242L,250L,260L,268L,272L,278L,298L,304L,320L,334L,340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089033Inst : IEnumerable<long>
{
public static readonly long[] Value=A089033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089033.Bytes);
public long this[int i]=>Value[i];

public static A089033Inst Instance=new A089033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089034
{
public static readonly long[] Value={ 10L,61L,119L,348L,543L,1166L,2947L,3848L,7809L,11774L,14245L,20332L,32877L,50489L,57691L,83963L,105882L,118326L,162292L,197743L,261426L,368872L,433585L,468962L,546165L,588159L,679364L,1083936L,1227083L,1467814L,1555421L,2053685L,2166190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089034Inst : IEnumerable<long>
{
public static readonly long[] Value=A089034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089034.Bytes);
public long this[int i]=>Value[i];

public static A089034Inst Instance=new A089034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089035
{
public static readonly BigInteger[] Value={ 1L,4L,56L,4096L,666624L,1194590208L,3343877406720L,72057594037927936L,BigInteger.Parse("3701652434038082764800"),BigInteger.Parse("1021880992906173430024372224") };
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
public class A089035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089035.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A089035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089035Inst Instance=new A089035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089036
{
public static readonly BigInteger[] Value={ 1L,12L,729L,758160L,2972290464L,354396766517640L,BigInteger.Parse("92079975413927255040"),BigInteger.Parse("939180873931369976460153600") };
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
public class A089036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089036Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089036.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A089036.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089036Inst Instance=new A089036Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089037
{
public static readonly BigInteger[] Value={ 1L,30L,15500L,453375000L,95367431640625L,BigInteger.Parse("1200572419921875000000"),BigInteger.Parse("216114100769531250000000000000") };
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
public class A089037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089037.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A089037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089037Inst Instance=new A089037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089038
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,9L,12L,13L,16L,18L,19L,21L,24L,27L,28L,31L,33L,34L,37L,39L,42L,46L,48L,49L,51L,52L,54L,61L,63L,66L,67L,72L,73L,76L,79L,81L,84L,87L,88L,93L,94L,96L,97L,103L,109L,111L,112L,114L,117L,118L,123L,126L,129L,132L,133L,136L,138L,139L,144L,151L,153L,154L,156L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089038Inst : IEnumerable<long>
{
public static readonly long[] Value=A089038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089038.Bytes);
public long this[int i]=>Value[i];

public static A089038Inst Instance=new A089038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089039
{
public static readonly BigInteger[] Value={ 1L,2L,6L,60L,960L,24000L,861840L,42104160L,2686763520L,217039253760L,21651071904000L,2614084251609600L,375698806311628800L,BigInteger.Parse("63383303286471168000"),BigInteger.Parse("12403896267489382656000"),BigInteger.Parse("2786994829444848422400000"),BigInteger.Parse("712575504763406361133056000") };
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
public class A089039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089039Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089039.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A089039.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089039Inst Instance=new A089039Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089040
{
public static readonly long[] Value={ 1L,5L,15L,47L,102L,276L,578L,1261L,2465L,5362L,9285L,18900L,33269L,58171L,99328L,181514L,287239L,502116L,775710L,1239710L,1956334L,3210736L,4660786L,7297823L,10997235L,16536803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089040Inst : IEnumerable<long>
{
public static readonly long[] Value=A089040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089040.Bytes);
public long this[int i]=>Value[i];

public static A089040Inst Instance=new A089040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089041
{
public static readonly BigInteger[] Value={ 1L,0L,3L,26L,453L,11844L,439975L,22056222L,1436236809L,117923229512L,11921584264011L,1455483251191650L,211163237294447053L,BigInteger.Parse("35913642489947449356"),BigInteger.Parse("7077505637217289437423"),BigInteger.Parse("1599980633296779087784934"),BigInteger.Parse("411293643476907595937924625"),BigInteger.Parse("119299057697083019137937718672") };
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
public class A089041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089041Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089041.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A089041.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089041Inst Instance=new A089041Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089042
{
public static readonly long[] Value={ 4L,8L,9L,16L,32L,49L,64L,128L,133L,256L,259L,512L,961L,1024L,2048L,2059L,2449L,3713L,4096L,4681L,4867L,6169L,6241L,8192L,8401L,8773L,9353L,10261L,10561L,12307L,12449L,16129L,16384L,16459L,16531L,16771L,18467L,20491L,24649L,24721L,24961L,25217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089042Inst : IEnumerable<long>
{
public static readonly long[] Value=A089042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089042.Bytes);
public long this[int i]=>Value[i];

public static A089042Inst Instance=new A089042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089043
{
public static readonly BigInteger[] Value={ 0L,5L,35L,577L,14399L,518401L,25401599L,1625702401L,131681894399L,13168189440001L,1593350922239999L,229442532802560001L,BigInteger.Parse("38775788043632639999"),BigInteger.Parse("7600054456551997440001"),BigInteger.Parse("1710012252724199423999999"),BigInteger.Parse("437763136697395052544000001"),BigInteger.Parse("126513546505547170185215999999") };
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
public class A089043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089043.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A089043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089043Inst Instance=new A089043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089076
{
public static readonly long[] Value={ -1L,0L,-2L,2L,-4L,4L,-6L,7L,-11L,14L,-20L,26L,-37L,50L,-70L,95L,-132L,181L,-251L,345L,-477L,657L,-908L,1252L,-1729L,2385L,-3293L,4544L,-6273L,8657L,-11950L,16493L,-22766L,31422L,-43372L,59864L,-82630L,114051L,-157423L,217286L,-299916L,413966L,-571389L,788674L,-1088590L,1502555L,-2073944L,2862617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089076Inst : IEnumerable<long>
{
public static readonly long[] Value=A089076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089076.Bytes);
public long this[int i]=>Value[i];

public static A089076Inst Instance=new A089076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089077
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,-1L,0L,-1L,-1L,-2L,-2L,-1L,-2L,0L,-2L,2L,0L,1L,2L,1L,4L,-1L,3L,-4L,-1L,-5L,-5L,-4L,-8L,-1L,-8L,4L,-4L,7L,4L,7L,11L,3L,14L,-5L,10L,-11L,-1L,-15L,-16L,-11L,-26L,0L,-25L,15L,-10L,25L,15L,24L,40L,9L,49L,-16L,33L,-41L,-7L,-50L,-57L,-34L,-90L,6L,-83L,56L,-27L,89L,62L,82L,145L,26L,171L,-63L,108L,-146L,-37L,-172L,-209L,-109L,-316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089077Inst : IEnumerable<long>
{
public static readonly long[] Value=A089077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089077.Bytes);
public long this[int i]=>Value[i];

public static A089077Inst Instance=new A089077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089078
{
public static readonly long[] Value={ 3L,6L,1L,5L,7L,1L,1L,4L,1L,38L,43L,1L,3L,2L,1L,1L,1L,1L,2L,4L,1L,4L,5L,1L,5L,1L,7L,22L,2L,5L,1L,1L,2L,1L,1L,31L,2L,1L,1L,3L,1L,44L,1L,89L,1L,8L,5L,2L,5L,1L,1L,4L,2L,8L,1L,17L,1L,4L,3L,4L,3L,2L,1L,1L,4L,2L,1L,9L,1L,15L,13L,1L,39L,20L,2L,152L,3L,2L,4L,1L,30L,1L,3L,1L,2L,1L,2L,16L,3L,24L,1L,9L,1L,172L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089078Inst : IEnumerable<long>
{
public static readonly long[] Value=A089078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089078.Bytes);
public long this[int i]=>Value[i];

public static A089078Inst Instance=new A089078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089079
{
public static readonly long[] Value={ 4L,6L,10L,12L,16L,18L,22L,28L,36L,40L,42L,48L,58L,60L,66L,70L,76L,78L,88L,90L,100L,102L,106L,108L,112L,126L,130L,136L,142L,148L,156L,160L,168L,172L,178L,180L,186L,190L,192L,208L,210L,216L,222L,226L,232L,240L,246L,252L,258L,262L,270L,282L,286L,288L,298L,312L,318L,328L,330L,340L,342L,346L,352L,366L,376L,388L,390L,396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089079Inst : IEnumerable<long>
{
public static readonly long[] Value=A089079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089079.Bytes);
public long this[int i]=>Value[i];

public static A089079Inst Instance=new A089079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089080
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,6L,2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,7L,2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,6L,2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,8L,2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,6L,2L,3L,2L,4L,2L,3L,2L,5L,2L,3L,2L,4L,2L,3L,2L,7L,2L,3L,2L,4L,2L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089080Inst : IEnumerable<long>
{
public static readonly long[] Value=A089080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089080.Bytes);
public long this[int i]=>Value[i];

public static A089080Inst Instance=new A089080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089081
{
public static readonly BigInteger[] Value={ 0L,1L,67108864L,2541865828329L,4503599627370496L,1490116119384765625L,BigInteger.Parse("170581728179578208256"),BigInteger.Parse("9387480337647754305649"),BigInteger.Parse("302231454903657293676544"),BigInteger.Parse("6461081889226673298932241"),BigInteger.Parse("100000000000000000000000000") };
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
public class A089081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089081Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089081.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A089081.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089081Inst Instance=new A089081Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089082
{
public static readonly BigInteger[] Value={ 5L,19L,5L,211L,5L,29L,5L,19L,5L,23L,5L,53L,5L,19L,5L,129009091L,5L,1559L,5L,19L,5L,47L,5L,101L,5L,19L,5L,68629840493971L,5L,617671248800299L,5L,19L,5L,29L,5L,8891471L,5L,19L,5L,821L,5L,431L,5L,19L,5L,1129L,5L,29L,5L,19L,5L,BigInteger.Parse("19383245658672820642055731"),5L,23L,5L,19L,5L };
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
public class A089082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A089082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089082Inst Instance=new A089082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089083
{
public static readonly long[] Value={ 0L,1L,16L,4L,81L,400L,16L,256L,1296L,4096L,36L,625L,3136L,10000L,24336L,81L,1296L,6561L,20736L,50625L,104976L,144L,2401L,12100L,38416L,93636L,194481L,360000L,256L,4096L,20736L,65536L,160000L,331776L,614656L,1048576L,400L,6561L,33124L,104976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089083Inst : IEnumerable<long>
{
public static readonly long[] Value=A089083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089083.Bytes);
public long this[int i]=>Value[i];

public static A089083Inst Instance=new A089083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089084
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,17L,19L,23L,47L,89L,125L,131L,203L,219L,455L,1475L,2867L,4649L,7291L,36893L,378878L,517914L,693028L,923373L,1835331L,3147909L,3356513L,3506524L,6782094L,20454813L,25494256L,27802807L,28081980L,47214722L,176344865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089084Inst : IEnumerable<long>
{
public static readonly long[] Value=A089084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089084.Bytes);
public long this[int i]=>Value[i];

public static A089084Inst Instance=new A089084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089085
{
public static readonly long[] Value={ 3L,5L,6L,8L,11L,17L,23L,36L,77L,93L,94L,109L,304L,497L,1330L,1996L,3027L,3053L,4529L,5841L,20556L,26558L,28167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089085Inst : IEnumerable<long>
{
public static readonly long[] Value=A089085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089085.Bytes);
public long this[int i]=>Value[i];

public static A089085Inst Instance=new A089085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089086
{
public static readonly long[] Value={ 5L,2L,1L,2L,1L,10L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,2L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089086Inst : IEnumerable<long>
{
public static readonly long[] Value=A089086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089086.Bytes);
public long this[int i]=>Value[i];

public static A089086Inst Instance=new A089086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089087
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-4L,1L,6L,-18L,12L,-1L,24L,-96L,108L,-32L,1L,120L,-600L,960L,-540L,80L,-1L,720L,-4320L,9000L,-7680L,2430L,-192L,1L,5040L,-35280L,90720L,-105000L,53760L,-10206L,448L,-1L,40320L,-322560L,987840L,-1451520L,1050000L,-344064L,40824L,-1024L,1L,362880L,-3265920L,11612160L,-20744640L,19595520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089087Inst : IEnumerable<long>
{
public static readonly long[] Value=A089087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089087.Bytes);
public long this[int i]=>Value[i];

public static A089087Inst Instance=new A089087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089088
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,8L,9L,10L,5L,12L,14L,7L,15L,16L,18L,20L,21L,22L,11L,24L,25L,26L,13L,27L,28L,30L,32L,33L,34L,17L,35L,36L,38L,19L,39L,40L,42L,44L,45L,46L,23L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,29L,60L,62L,31L,63L,64L,65L,66L,68L,69L,70L,72L,74L,37L,75L,76L,77L,78L,80L,81L,82L,41L,84L,85L,86L,43L,87L,88L,90L,91L,92L,93L,94L,47L,95L,96L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089088Inst : IEnumerable<long>
{
public static readonly long[] Value=A089088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089088.Bytes);
public long this[int i]=>Value[i];

public static A089088Inst Instance=new A089088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089089
{
public static readonly long[] Value={ 0L,1L,2L,5L,9L,19L,34L,65L,115L,210L,368L,654L,1136L,1985L,3422L,5911L,10125L,17345L,29550L,50305L,85311L,144516L,244128L,411900L,693496L,1166209L,1957842L,3283145L,5497985L,9197455L,15368386L,25655489L,42785859L,71293590L,118692688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089089Inst : IEnumerable<long>
{
public static readonly long[] Value=A089089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089089.Bytes);
public long this[int i]=>Value[i];

public static A089089Inst Instance=new A089089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089090
{
public static readonly long[] Value={ 4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,49L,4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,49L,4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,25L,4L,9L,4L,9L,4L,49L,4L,9L,4L,9L,4L,25L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089090Inst : IEnumerable<long>
{
public static readonly long[] Value=A089090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089090.Bytes);
public long this[int i]=>Value[i];

public static A089090Inst Instance=new A089090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089091
{
public static readonly long[] Value={ 9L,25L,25L,9L,49L,25L,9L,25L,49L,9L,25L,25L,9L,121L,49L,9L,25L,25L,9L,121L,25L,9L,25L,49L,9L,25L,25L,9L,49L,49L,9L,25L,25L,9L,121L,25L,9L,25L,49L,9L,25L,25L,9L,49L,49L,9L,25L,25L,9L,49L,25L,9L,25L,49L,9L,25L,25L,9L,49L,49L,9L,25L,25L,9L,49L,25L,9L,25L,121L,9L,25L,25L,9L,49L,49L,9L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089091Inst : IEnumerable<long>
{
public static readonly long[] Value=A089091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089091.Bytes);
public long this[int i]=>Value[i];

public static A089091Inst Instance=new A089091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089204
{
public static readonly long[] Value={ 1L,1L,7L,1L,5L,29L,1L,13L,101L,601L,1L,4L,13L,49L,319L,1L,19L,223L,2041L,16087L,116929L,1L,11L,151L,407L,3781L,16069L,130757L,1L,25L,131L,1627L,17443L,56809L,526961L,4778489L,1L,7L,62L,436L,1061L,2936L,30683L,155683L,1561933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089204Inst : IEnumerable<long>
{
public static readonly long[] Value=A089204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089204.Bytes);
public long this[int i]=>Value[i];

public static A089204Inst Instance=new A089204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089205
{
public static readonly BigInteger[] Value={ 0L,4L,54L,768L,12500L,233280L,4941258L,117440512L,3099363912L,90000000000L,2853116706110L,98077104930816L,3634501279107036L,144456088732254208L,6130514465332031250L,BigInteger.Parse("276701161105643274240"),BigInteger.Parse("13235844190181388226832") };
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
public class A089205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A089205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089205Inst Instance=new A089205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089206
{
public static readonly long[] Value={ 2L,3L,9L,4L,8L,32L,5L,25L,125L,625L,6L,9L,18L,54L,324L,7L,49L,343L,2401L,16807L,117649L,8L,32L,256L,512L,4096L,16384L,131072L,9L,81L,243L,2187L,19683L,59049L,531441L,4782969L,10L,25L,125L,625L,1250L,3125L,31250L,156250L,1562500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089206Inst : IEnumerable<long>
{
public static readonly long[] Value=A089206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089206.Bytes);
public long this[int i]=>Value[i];

public static A089206Inst Instance=new A089206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089207
{
public static readonly long[] Value={ 6L,40L,126L,288L,550L,936L,1470L,2176L,3078L,4200L,5566L,7200L,9126L,11368L,13950L,16896L,20230L,23976L,28158L,32800L,37926L,43560L,49726L,56448L,63750L,71656L,80190L,89376L,99238L,109800L,121086L,133120L,145926L,159528L,173950L,189216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089207Inst : IEnumerable<long>
{
public static readonly long[] Value=A089207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089207.Bytes);
public long this[int i]=>Value[i];

public static A089207Inst Instance=new A089207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089208
{
public static readonly long[] Value={ 1L,64L,19683L,16777216L,30517578125L,101559956668416L,558545864083284007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089208Inst : IEnumerable<long>
{
public static readonly long[] Value=A089208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089208.Bytes);
public long this[int i]=>Value[i];

public static A089208Inst Instance=new A089208Inst();

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