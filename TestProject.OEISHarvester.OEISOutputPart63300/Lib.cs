using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A081965
{
public static readonly long[] Value={ 1L,5L,7L,15L,16L,31L,27L,45L,49L,73L,62L,103L,86L,129L,133L,163L,146L,217L,178L,251L,248L,293L,262L,359L,316L,399L,386L,461L,418L,569L,472L,585L,580L,657L,634L,761L,675L,813L,796L,911L,830L,1039L,908L,1083L,1072L,1171L,1088L,1313L,1192L,1399L,1334L,1489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081965Inst : IEnumerable<long>
{
public static readonly long[] Value=A081965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081965.Bytes);
public long this[int i]=>Value[i];

public static A081965Inst Instance=new A081965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081966
{
public static readonly long[] Value={ 1L,8L,13L,48L,56L,144L,147L,294L,358L,624L,548L,1020L,978L,1576L,1685L,2340L,2048L,3456L,3036L,4454L,4481L,5870L,5188L,7722L,7289L,9560L,9365L,11976L,10889L,15378L,13729L,17066L,17330L,21168L,20051L,25428L,22997L,29048L,28817L,34428L,31444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081966Inst : IEnumerable<long>
{
public static readonly long[] Value=A081966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081966.Bytes);
public long this[int i]=>Value[i];

public static A081966Inst Instance=new A081966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081967
{
public static readonly long[] Value={ 1L,2L,8L,3L,4L,18L,5L,6L,7L,9261000L,9L,10L,11L,12L,329422500L,13L,14L,15L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081967Inst : IEnumerable<long>
{
public static readonly long[] Value=A081967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081967.Bytes);
public long this[int i]=>Value[i];

public static A081967Inst Instance=new A081967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081968
{
public static readonly BigInteger[] Value={ 1L,8L,18L,9261000L,329422500L,BigInteger.Parse("13456677968449745006250") };
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
public class A081968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A081968.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A081968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A081968Inst Instance=new A081968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081969
{
public static readonly BigInteger[] Value={ 1L,16L,216L,1944810000L,3913539300000L,BigInteger.Parse("9992390792252042651841000000") };
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
public class A081969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081969Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A081969.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A081969.Bytes);
public BigInteger this[int i]=>Value[i];

public static A081969Inst Instance=new A081969Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081970
{
public static readonly long[] Value={ 1L,4L,6L,210L,330L,46410L,1009470L,2454270L,358888530L,8804809860L,14908423530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081970Inst : IEnumerable<long>
{
public static readonly long[] Value=A081970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081970.Bytes);
public long this[int i]=>Value[i];

public static A081970Inst Instance=new A081970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081971
{
public static readonly BigInteger[] Value={ 1L,5L,37L,1207L,7793L,532541L,35036093L,419218787L,98431469723L,14642854403167L,6408932966879L,4075936031956831L,504163702484694137L,BigInteger.Parse("78452289445098136367"),BigInteger.Parse("9442422052170405158543"),BigInteger.Parse("711841627568479091422201") };
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
public class A081971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081971Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A081971.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A081971.Bytes);
public BigInteger this[int i]=>Value[i];

public static A081971Inst Instance=new A081971Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081988
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,12L,14L,16L,21L,22L,23L,25L,26L,28L,29L,32L,34L,36L,41L,43L,44L,47L,49L,52L,56L,58L,61L,62L,63L,65L,66L,67L,74L,76L,82L,85L,89L,92L,94L,98L,111L,112L,114L,116L,121L,122L,123L,125L,126L,128L,129L,132L,134L,136L,141L,143L,144L,147L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081988Inst : IEnumerable<long>
{
public static readonly long[] Value=A081988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081988.Bytes);
public long this[int i]=>Value[i];

public static A081988Inst Instance=new A081988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081989
{
public static readonly long[] Value={ 3L,8L,13L,18L,24L,31L,35L,38L,42L,46L,53L,57L,64L,68L,75L,79L,81L,83L,86L,97L,113L,118L,124L,131L,135L,138L,142L,146L,153L,157L,164L,168L,175L,179L,181L,183L,186L,197L,214L,222L,226L,234L,238L,241L,243L,246L,258L,262L,264L,283L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081989Inst : IEnumerable<long>
{
public static readonly long[] Value=A081989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081989.Bytes);
public long this[int i]=>Value[i];

public static A081989Inst Instance=new A081989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081990
{
public static readonly long[] Value={ 3L,8L,24L,35L,168L,528L,624L,783L,1443L,3843L,5183L,7568L,8835L,12543L,13224L,15128L,17423L,24335L,26243L,27224L,41615L,47523L,75624L,87615L,92415L,118335L,128163L,135423L,172224L,213443L,225624L,262143L,265224L,274575L,338723L,345743L,374543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081990Inst : IEnumerable<long>
{
public static readonly long[] Value=A081990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081990.Bytes);
public long this[int i]=>Value[i];

public static A081990Inst Instance=new A081990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081991
{
public static readonly long[] Value={ 1L,23L,32L,456L,465L,546L,564L,645L,654L,10789L,10798L,10879L,10897L,10978L,10987L,17089L,17098L,17809L,17890L,17908L,17980L,18079L,18097L,18709L,18790L,18907L,18970L,19078L,19087L,19708L,19780L,19807L,19870L,70189L,70198L,70819L,70891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081991Inst : IEnumerable<long>
{
public static readonly long[] Value=A081991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081991.Bytes);
public long this[int i]=>Value[i];

public static A081991Inst Instance=new A081991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081992
{
public static readonly BigInteger[] Value={ 1L,2L,6L,96L,5040L,1829520L,2162160L,243243000L,49989139200L,3821522664960L,24638764550400L,310331105884800L,48573564399360000L,BigInteger.Parse("1589664086049506987520000"),BigInteger.Parse("11157385862665072737907200") };
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
public class A081992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081992Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A081992.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A081992.Bytes);
public BigInteger this[int i]=>Value[i];

public static A081992Inst Instance=new A081992Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081993
{
public static readonly BigInteger[] Value={ 1L,55L,3330L,5833350L,11199999998880L,642096000000065520L,BigInteger.Parse("84083999999999159160"),BigInteger.Parse("853092240000000006366360"),BigInteger.Parse("21033492480000000001383782400"),BigInteger.Parse("181960466688000000000107035568640") };
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
public class A081993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081993Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A081993.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A081993.Bytes);
public BigInteger this[int i]=>Value[i];

public static A081993Inst Instance=new A081993Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081994
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,9L,11L,8L,13L,17L,19L,15L,14L,23L,29L,25L,31L,27L,16L,37L,41L,43L,47L,53L,21L,10L,59L,49L,61L,67L,55L,71L,39L,32L,73L,79L,83L,89L,97L,65L,77L,51L,38L,101L,103L,91L,107L,109L,113L,127L,95L,33L,34L,131L,121L,137L,139L,149L,151L,157L,161L,85L,57L,26L,163L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081994Inst : IEnumerable<long>
{
public static readonly long[] Value=A081994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081994.Bytes);
public long this[int i]=>Value[i];

public static A081994Inst Instance=new A081994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081995
{
public static readonly long[] Value={ 1L,3L,7L,13L,23L,37L,59L,73L,101L,131L,163L,199L,241L,293L,349L,401L,457L,523L,599L,661L,757L,713L,851L,1049L,1153L,1277L,1381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081995Inst : IEnumerable<long>
{
public static readonly long[] Value=A081995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081995.Bytes);
public long this[int i]=>Value[i];

public static A081995Inst Instance=new A081995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081996
{
public static readonly long[] Value={ 1L,2L,5L,9L,17L,29L,41L,49L,79L,103L,121L,167L,169L,251L,307L,353L,361L,461L,529L,601L,673L,761L,859L,953L,1051L,1147L,1279L,1399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081996Inst : IEnumerable<long>
{
public static readonly long[] Value=A081996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081996.Bytes);
public long this[int i]=>Value[i];

public static A081996Inst Instance=new A081996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081997
{
public static readonly long[] Value={ 1L,5L,16L,41L,88L,165L,274L,447L,680L,943L,1346L,1785L,2414L,3111L,3994L,5041L,6126L,7219L,9122L,10637L,12874L,14419L,17576L,19387L,23328L,26569L,30320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081997Inst : IEnumerable<long>
{
public static readonly long[] Value=A081997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081997.Bytes);
public long this[int i]=>Value[i];

public static A081997Inst Instance=new A081997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081998
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,11L,13L,17L,19L,21L,23L,26L,29L,31L,37L,41L,43L,47L,49L,53L,59L,60L,61L,63L,67L,71L,73L,79L,83L,88L,89L,97L,101L,103L,107L,109L,113L,115L,127L,131L,137L,139L,143L,149L,151L,155L,157L,161L,163L,167L,169L,173L,179L,181L,187L,191L,193L,197L,198L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081998Inst : IEnumerable<long>
{
public static readonly long[] Value=A081998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081998.Bytes);
public long this[int i]=>Value[i];

public static A081998Inst Instance=new A081998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081999
{
public static readonly long[] Value={ 1L,2L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081999Inst : IEnumerable<long>
{
public static readonly long[] Value=A081999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081999.Bytes);
public long this[int i]=>Value[i];

public static A081999Inst Instance=new A081999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082000
{
public static readonly long[] Value={ 1L,3L,4L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082000Inst : IEnumerable<long>
{
public static readonly long[] Value=A082000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082000.Bytes);
public long this[int i]=>Value[i];

public static A082000Inst Instance=new A082000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082001
{
public static readonly long[] Value={ 1L,5L,16L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082001Inst : IEnumerable<long>
{
public static readonly long[] Value=A082001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082001.Bytes);
public long this[int i]=>Value[i];

public static A082001Inst Instance=new A082001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082002
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,4L,8L,18L,10L,9L,15L,24L,14L,30L,16L,20L,36L,22L,42L,40L,21L,27L,28L,48L,54L,26L,45L,32L,34L,60L,50L,66L,70L,56L,72L,33L,39L,44L,78L,84L,80L,75L,38L,51L,46L,52L,69L,68L,90L,96L,98L,102L,88L,104L,57L,63L,76L,108L,110L,114L,105L,100L,120L,92L,117L,58L,62L,87L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082002Inst : IEnumerable<long>
{
public static readonly long[] Value=A082002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082002.Bytes);
public long this[int i]=>Value[i];

public static A082002Inst Instance=new A082002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082003
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,20L,32L,34L,46L,52L,58L,62L,64L,74L,94L,106L,122L,128L,134L,136L,146L,158L,166L,178L,184L,194L,206L,214L,218L,226L,232L,254L,256L,262L,278L,298L,302L,314L,326L,334L,346L,358L,362L,376L,382L,386L,394L,398L,422L,424L,446L,454L,458L,464L,466L,478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082003Inst : IEnumerable<long>
{
public static readonly long[] Value=A082003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082003.Bytes);
public long this[int i]=>Value[i];

public static A082003Inst Instance=new A082003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082004
{
public static readonly long[] Value={ 1L,3L,6L,9L,15L,21L,27L,33L,39L,57L,63L,81L,93L,99L,111L,123L,129L,147L,171L,177L,189L,213L,231L,243L,267L,279L,291L,297L,303L,333L,339L,363L,369L,387L,393L,399L,405L,411L,441L,501L,513L,531L,537L,567L,573L,579L,591L,597L,627L,639L,651L,675L,681L,693L,699L,717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082004Inst : IEnumerable<long>
{
public static readonly long[] Value=A082004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082004.Bytes);
public long this[int i]=>Value[i];

public static A082004Inst Instance=new A082004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082005
{
public static readonly long[] Value={ 1L,5L,22L,45L,99L,181L,260L,441L,535L,824L,1063L,1437L,1962L,2325L,3114L,3545L,4052L,5063L,6554L,7247L,8734L,9706L,11270L,12875L,16101L,16930L,20137L,20958L,24068L,27492L,29591L,32862L,35482L,42080L,44659L,48992L,51983L,55769L,58300L,65916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082005Inst : IEnumerable<long>
{
public static readonly long[] Value=A082005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082005.Bytes);
public long this[int i]=>Value[i];

public static A082005Inst Instance=new A082005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082006
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,7L,9L,11L,13L,19L,17L,21L,8L,23L,31L,25L,27L,29L,37L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082006Inst : IEnumerable<long>
{
public static readonly long[] Value=A082006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082006.Bytes);
public long this[int i]=>Value[i];

public static A082006Inst Instance=new A082006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082007
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,9L,12L,4L,5L,7L,8L,10L,11L,13L,14L,15L,30L,45L,60L,75L,90L,105L,120L,135L,150L,165L,180L,195L,210L,225L,240L,16L,17L,31L,32L,46L,47L,61L,62L,76L,77L,91L,92L,106L,107L,121L,122L,136L,137L,151L,152L,166L,167L,181L,182L,196L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082007Inst : IEnumerable<long>
{
public static readonly long[] Value=A082007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082007.Bytes);
public long this[int i]=>Value[i];

public static A082007Inst Instance=new A082007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082008
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,10L,13L,5L,6L,8L,9L,11L,12L,14L,15L,16L,31L,46L,61L,76L,91L,106L,121L,136L,151L,166L,181L,196L,211L,226L,241L,17L,18L,32L,33L,47L,48L,62L,63L,77L,78L,92L,93L,107L,108L,122L,123L,137L,138L,152L,153L,167L,168L,182L,183L,197L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082008Inst : IEnumerable<long>
{
public static readonly long[] Value=A082008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082008.Bytes);
public long this[int i]=>Value[i];

public static A082008Inst Instance=new A082008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082009
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,1L,6L,6L,2L,9L,9L,2L,12L,12L,4L,15L,15L,16L,18L,18L,16L,21L,21L,17L,24L,24L,17L,27L,27L,4L,30L,30L,31L,33L,33L,31L,36L,36L,32L,39L,39L,32L,42L,42L,5L,45L,45L,46L,48L,48L,46L,51L,51L,47L,54L,54L,47L,57L,57L,5L,60L,60L,61L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082009Inst : IEnumerable<long>
{
public static readonly long[] Value=A082009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082009.Bytes);
public long this[int i]=>Value[i];

public static A082009Inst Instance=new A082009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082010
{
public static readonly long[] Value={ 0L,2L,1L,5L,2L,9L,3L,12L,4L,15L,5L,18L,6L,21L,7L,25L,8L,28L,9L,31L,10L,34L,11L,37L,12L,41L,13L,44L,14L,47L,15L,50L,16L,53L,17L,57L,18L,60L,19L,63L,20L,66L,21L,69L,22L,73L,23L,76L,24L,79L,25L,82L,26L,85L,27L,89L,28L,92L,29L,95L,30L,98L,31L,101L,32L,105L,33L,108L,34L,111L,35L,114L,36L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082010Inst : IEnumerable<long>
{
public static readonly long[] Value=A082010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082010.Bytes);
public long this[int i]=>Value[i];

public static A082010Inst Instance=new A082010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082011
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,19L,11L,17L,23L,29L,31L,37L,41L,43L,53L,47L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,113L,107L,109L,127L,131L,137L,139L,149L,157L,151L,163L,167L,173L,179L,181L,191L,197L,227L,193L,199L,211L,223L,229L,233L,239L,241L,251L,271L,257L,263L,269L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082011Inst : IEnumerable<long>
{
public static readonly long[] Value=A082011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082011.Bytes);
public long this[int i]=>Value[i];

public static A082011Inst Instance=new A082011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082012
{
public static readonly long[] Value={ 2L,3L,19L,11L,53L,47L,113L,107L,227L,193L,347L,317L,503L,467L,709L,659L,883L,887L,1423L,1151L,1549L,1453L,1871L,1783L,2281L,2153L,2633L,2593L,3313L,3037L,3673L,3541L,4133L,4073L,4679L,4651L,5657L,5303L,6091L,5939L,6971L,6679L,7877L,7477L,8369L,8243L,9461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082012Inst : IEnumerable<long>
{
public static readonly long[] Value=A082012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082012.Bytes);
public long this[int i]=>Value[i];

public static A082012Inst Instance=new A082012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082013
{
public static readonly long[] Value={ 2L,5L,7L,29L,31L,73L,79L,157L,151L,271L,257L,419L,397L,653L,571L,797L,769L,1033L,1013L,1303L,1289L,1627L,1607L,2029L,1979L,2417L,2371L,2819L,2789L,3319L,3299L,3881L,3797L,4597L,4357L,5197L,4973L,5711L,5639L,6329L,6301L,7177L,7013L,7907L,7823L,8863L,8681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082013Inst : IEnumerable<long>
{
public static readonly long[] Value=A082013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082013.Bytes);
public long this[int i]=>Value[i];

public static A082013Inst Instance=new A082013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082014
{
public static readonly long[] Value={ 2L,8L,39L,80L,205L,378L,665L,1056L,1629L,2290L,3201L,4356L,5707L,7406L,9255L,11472L,14161L,17280L,20767L,24400L,28917L,33660L,38985L,45192L,51875L,59098L,66825L,75572L,84709L,95040L,106361L,117376L,129921L,143514L,157955L,174024L,190143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082014Inst : IEnumerable<long>
{
public static readonly long[] Value=A082014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082014.Bytes);
public long this[int i]=>Value[i];

public static A082014Inst Instance=new A082014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082015
{
public static readonly long[] Value={ 2L,4L,13L,20L,41L,63L,95L,132L,181L,229L,291L,363L,439L,529L,617L,717L,833L,960L,1093L,1220L,1377L,1530L,1695L,1883L,2075L,2273L,2475L,2699L,2921L,3168L,3431L,3668L,3937L,4221L,4513L,4834L,5139L,5465L,5789L,6140L,6493L,6855L,7251L,7631L,8047L,8474L,8881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082015Inst : IEnumerable<long>
{
public static readonly long[] Value=A082015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082015.Bytes);
public long this[int i]=>Value[i];

public static A082015Inst Instance=new A082015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082016
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,7L,6L,8L,9L,13L,10L,11L,12L,14L,18L,15L,16L,17L,19L,20L,21L,22L,23L,24L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082016Inst : IEnumerable<long>
{
public static readonly long[] Value=A082016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082016.Bytes);
public long this[int i]=>Value[i];

public static A082016Inst Instance=new A082016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082017
{
public static readonly long[] Value={ 1L,2L,7L,6L,18L,15L,28L,29L,49L,45L,75L,66L,94L,91L,130L,120L,155L,153L,201L,190L,232L,231L,288L,276L,325L,326L,391L,378L,462L,435L,508L,496L,589L,561L,641L,630L,732L,703L,790L,780L,891L,861L,955L,946L,1066L,1035L,1136L,1128L,1257L,1225L,1333L,1326L,1464L,1431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082017Inst : IEnumerable<long>
{
public static readonly long[] Value=A082017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082017.Bytes);
public long this[int i]=>Value[i];

public static A082017Inst Instance=new A082017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082018
{
public static readonly long[] Value={ 1L,4L,3L,13L,10L,21L,22L,40L,36L,64L,55L,81L,78L,115L,105L,138L,136L,182L,171L,211L,210L,265L,253L,300L,301L,364L,351L,433L,406L,477L,465L,556L,528L,606L,595L,695L,666L,751L,741L,850L,820L,912L,903L,1021L,990L,1089L,1081L,1208L,1176L,1282L,1275L,1411L,1378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082018Inst : IEnumerable<long>
{
public static readonly long[] Value=A082018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082018.Bytes);
public long this[int i]=>Value[i];

public static A082018Inst Instance=new A082018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082019
{
public static readonly long[] Value={ 1L,5L,12L,25L,41L,60L,85L,112L,145L,180L,221L,264L,313L,365L,420L,481L,544L,613L,684L,761L,840L,925L,1012L,1105L,1200L,1301L,1404L,1513L,1624L,1741L,1860L,1985L,2112L,2245L,2380L,2521L,2664L,2813L,2964L,3121L,3281L,3444L,3613L,3784L,3961L,4140L,4325L,4512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082019Inst : IEnumerable<long>
{
public static readonly long[] Value=A082019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082019.Bytes);
public long this[int i]=>Value[i];

public static A082019Inst Instance=new A082019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082036
{
public static readonly long[] Value={ 1L,13L,86L,546L,3768L,28920L,246960L,2333520L,24232320L,274700160L,3378412800L,44826566400L,638509132800L,9720379468800L,157531172198400L,2708193616128000L,49231324606464000L,943638746738688000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082036Inst : IEnumerable<long>
{
public static readonly long[] Value=A082036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082036.Bytes);
public long this[int i]=>Value[i];

public static A082036Inst Instance=new A082036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082037
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,6L,6L,1L,4L,10L,24L,24L,1L,5L,14L,42L,120L,120L,1L,6L,18L,60L,216L,720L,720L,1L,7L,22L,78L,312L,1320L,5040L,5040L,1L,8L,26L,96L,408L,1920L,9360L,40320L,40320L,1L,9L,30L,114L,504L,2520L,13680L,75600L,362880L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082037Inst : IEnumerable<long>
{
public static readonly long[] Value=A082037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082037.Bytes);
public long this[int i]=>Value[i];

public static A082037Inst Instance=new A082037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082038
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,7L,14L,6L,1L,13L,42L,78L,24L,1L,21L,86L,258L,504L,120L,1L,31L,146L,546L,1752L,3720L,720L,1L,43L,222L,942L,3768L,13320L,30960L,5040L,1L,57L,314L,1446L,6552L,28920L,113040L,287280L,40320L,1L,73L,422L,2058L,10104L,50520L,246960L,1063440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082038Inst : IEnumerable<long>
{
public static readonly long[] Value=A082038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082038.Bytes);
public long this[int i]=>Value[i];

public static A082038Inst Instance=new A082038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082039
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,7L,1L,1L,13L,21L,13L,1L,1L,21L,43L,43L,21L,1L,1L,31L,73L,91L,73L,31L,1L,1L,43L,111L,157L,157L,111L,43L,1L,1L,57L,157L,241L,273L,241L,157L,57L,1L,1L,73L,211L,343L,421L,421L,343L,211L,73L,1L,1L,91L,273L,463L,601L,651L,601L,463L,273L,91L,1L,1L,111L,343L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082039Inst : IEnumerable<long>
{
public static readonly long[] Value=A082039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082039.Bytes);
public long this[int i]=>Value[i];

public static A082039Inst Instance=new A082039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082040
{
public static readonly long[] Value={ 1L,13L,43L,91L,157L,241L,343L,463L,601L,757L,931L,1123L,1333L,1561L,1807L,2071L,2353L,2653L,2971L,3307L,3661L,4033L,4423L,4831L,5257L,5701L,6163L,6643L,7141L,7657L,8191L,8743L,9313L,9901L,10507L,11131L,11773L,12433L,13111L,13807L,14521L,15253L,16003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082040Inst : IEnumerable<long>
{
public static readonly long[] Value=A082040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082040.Bytes);
public long this[int i]=>Value[i];

public static A082040Inst Instance=new A082040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082041
{
public static readonly long[] Value={ 1L,21L,73L,157L,273L,421L,601L,813L,1057L,1333L,1641L,1981L,2353L,2757L,3193L,3661L,4161L,4693L,5257L,5853L,6481L,7141L,7833L,8557L,9313L,10101L,10921L,11773L,12657L,13573L,14521L,15501L,16513L,17557L,18633L,19741L,20881L,22053L,23257L,24493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082041Inst : IEnumerable<long>
{
public static readonly long[] Value=A082041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082041.Bytes);
public long this[int i]=>Value[i];

public static A082041Inst Instance=new A082041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082042
{
public static readonly long[] Value={ 1L,2L,10L,60L,408L,3120L,26640L,252000L,2620800L,29756160L,366508800L,4869849600L,69455232000L,1058593536000L,17174123366400L,295534407168000L,5377157001216000L,103149354147840000L,2080771454361600000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082042Inst : IEnumerable<long>
{
public static readonly long[] Value=A082042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082042.Bytes);
public long this[int i]=>Value[i];

public static A082042Inst Instance=new A082042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082043
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,9L,9L,1L,1L,16L,25L,16L,1L,1L,25L,49L,49L,25L,1L,1L,36L,81L,100L,81L,36L,1L,1L,49L,121L,169L,169L,121L,49L,1L,1L,64L,169L,256L,289L,256L,169L,64L,1L,1L,81L,225L,361L,441L,441L,361L,225L,81L,1L,1L,100L,289L,484L,625L,676L,625L,484L,289L,100L,1L,1L,121L,361L,625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082043Inst : IEnumerable<long>
{
public static readonly long[] Value=A082043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082043.Bytes);
public long this[int i]=>Value[i];

public static A082043Inst Instance=new A082043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082044
{
public static readonly long[] Value={ 1L,4L,25L,100L,289L,676L,1369L,2500L,4225L,6724L,10201L,14884L,21025L,28900L,38809L,51076L,66049L,84100L,105625L,131044L,160801L,195364L,235225L,280900L,332929L,391876L,458329L,532900L,616225L,708964L,811801L,925444L,1050625L,1188100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082044Inst : IEnumerable<long>
{
public static readonly long[] Value=A082044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082044.Bytes);
public long this[int i]=>Value[i];

public static A082044Inst Instance=new A082044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082045
{
public static readonly long[] Value={ 1L,2L,6L,20L,59L,150L,336L,680L,1269L,2218L,3674L,5820L,8879L,13118L,18852L,26448L,36329L,48978L,64942L,84836L,109347L,139238L,175352L,218616L,270045L,330746L,401922L,484876L,581015L,691854L,819020L,964256L,1129425L,1316514L,1527638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082045Inst : IEnumerable<long>
{
public static readonly long[] Value=A082045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082045.Bytes);
public long this[int i]=>Value[i];

public static A082045Inst Instance=new A082045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082046
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,11L,11L,1L,1L,19L,29L,19L,1L,1L,29L,55L,55L,29L,1L,1L,41L,89L,109L,89L,41L,1L,1L,55L,131L,181L,181L,131L,55L,1L,1L,71L,181L,271L,305L,271L,181L,71L,1L,1L,89L,239L,379L,461L,461L,379L,239L,89L,1L,1L,109L,305L,505L,649L,701L,649L,505L,305L,109L,1L,1L,131L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082046Inst : IEnumerable<long>
{
public static readonly long[] Value=A082046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082046.Bytes);
public long this[int i]=>Value[i];

public static A082046Inst Instance=new A082046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082047
{
public static readonly long[] Value={ 1L,2L,7L,24L,69L,170L,371L,736L,1353L,2338L,3839L,6040L,9165L,13482L,19307L,27008L,37009L,49794L,65911L,85976L,110677L,140778L,177123L,220640L,272345L,333346L,404847L,488152L,584669L,695914L,823515L,969216L,1134881L,1322498L,1534183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082047Inst : IEnumerable<long>
{
public static readonly long[] Value=A082047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082047.Bytes);
public long this[int i]=>Value[i];

public static A082047Inst Instance=new A082047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082048
{
public static readonly long[] Value={ 2L,3L,5L,5L,7L,7L,11L,9L,11L,11L,13L,13L,17L,15L,17L,17L,19L,19L,23L,21L,23L,23L,29L,25L,29L,27L,29L,29L,31L,31L,37L,33L,35L,35L,37L,37L,41L,39L,41L,41L,43L,43L,47L,45L,47L,47L,53L,49L,53L,51L,53L,53L,59L,55L,59L,57L,59L,59L,61L,61L,67L,63L,65L,65L,67L,67L,71L,69L,71L,71L,73L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082048Inst : IEnumerable<long>
{
public static readonly long[] Value=A082048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082048.Bytes);
public long this[int i]=>Value[i];

public static A082048Inst Instance=new A082048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082049
{
public static readonly long[] Value={ 9L,9L,9L,25L,15L,15L,15L,25L,21L,21L,21L,25L,25L,25L,49L,27L,35L,33L,33L,33L,35L,35L,49L,39L,39L,49L,45L,45L,45L,49L,49L,49L,121L,51L,55L,55L,55L,77L,57L,65L,63L,63L,63L,65L,65L,77L,69L,69L,77L,75L,75L,75L,77L,77L,121L,81L,81L,85L,85L,85L,91L,87L,91L,91L,91L,121L,93L,95L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082049Inst : IEnumerable<long>
{
public static readonly long[] Value=A082049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082049.Bytes);
public long this[int i]=>Value[i];

public static A082049Inst Instance=new A082049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082050
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,11L,0L,10L,12L,7L,11L,23L,0L,16L,23L,10L,17L,38L,0L,27L,24L,13L,23L,55L,5L,28L,39L,16L,29L,61L,0L,42L,47L,19L,40L,86L,0L,40L,42L,35L,41L,88L,0L,57L,77L,25L,47L,103L,0L,57L,71L,28L,53L,119L,16L,80L,60L,31L,59L,153L,0L,64L,96L,42L,70L,121L,0L,87L,95L,56L,71L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082050Inst : IEnumerable<long>
{
public static readonly long[] Value=A082050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082050.Bytes);
public long this[int i]=>Value[i];

public static A082050Inst Instance=new A082050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082051
{
public static readonly long[] Value={ 1L,1L,4L,5L,1L,10L,8L,5L,13L,11L,1L,26L,14L,8L,19L,21L,1L,37L,20L,15L,32L,23L,1L,50L,26L,14L,40L,40L,1L,65L,32L,21L,37L,35L,8L,89L,38L,20L,56L,55L,1L,80L,44L,27L,73L,47L,1L,114L,57L,36L,55L,70L,1L,118L,56L,40L,80L,59L,1L,141L,62L,32L,104L,85L,14L,131L,68L,39L,73L,88L,1L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082051Inst : IEnumerable<long>
{
public static readonly long[] Value=A082051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082051.Bytes);
public long this[int i]=>Value[i];

public static A082051Inst Instance=new A082051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082068
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,1L,3L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,3L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,3L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,3L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,7L,2L,1L,2L,5L,2L,1L,1L,3L,1L,1L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082068Inst : IEnumerable<long>
{
public static readonly long[] Value=A082068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082068.Bytes);
public long this[int i]=>Value[i];

public static A082068Inst Instance=new A082068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082069
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,5L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,5L,3L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,5L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,7L,1L,5L,2L,1L,2L,1L,2L,1L,1L,1L,2L,3L,2L,1L,2L,1L,2L,1L,2L,1L,2L,5L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082069Inst : IEnumerable<long>
{
public static readonly long[] Value=A082069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082069.Bytes);
public long this[int i]=>Value[i];

public static A082069Inst Instance=new A082069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082070
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,1L,2L,3L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,1L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082070Inst : IEnumerable<long>
{
public static readonly long[] Value=A082070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082070.Bytes);
public long this[int i]=>Value[i];

public static A082070Inst Instance=new A082070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082071
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,5L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082071Inst : IEnumerable<long>
{
public static readonly long[] Value=A082071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082071.Bytes);
public long this[int i]=>Value[i];

public static A082071Inst Instance=new A082071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082072
{
public static readonly long[] Value={ 1L,1L,2L,7L,2L,2L,2L,5L,13L,2L,2L,2L,2L,2L,2L,31L,2L,13L,2L,2L,2L,2L,2L,2L,31L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,7L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,127L,2L,2L,2L,2L,2L,2L,2L,5L,2L,2L,2L,2L,2L,2L,2L,2L,11L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082072Inst : IEnumerable<long>
{
public static readonly long[] Value=A082072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082072.Bytes);
public long this[int i]=>Value[i];

public static A082072Inst Instance=new A082072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082073
{
public static readonly long[] Value={ 8L,4L,12L,8L,4L,12L,8L,12L,16L,8L,4L,8L,4L,24L,12L,8L,16L,8L,12L,4L,32L,4L,8L,16L,12L,8L,4L,12L,20L,4L,20L,12L,4L,20L,16L,8L,4L,8L,12L,12L,16L,8L,4L,48L,12L,20L,16L,12L,8L,16L,8L,12L,4L,24L,12L,8L,12L,4L,24L,8L,24L,24L,4L,8L,4L,24L,12L,12L,8L,24L,4L,20L,4L,48L,8L,4L,12L,24L,20L,12L,4L,8L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082073Inst : IEnumerable<long>
{
public static readonly long[] Value=A082073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082073.Bytes);
public long this[int i]=>Value[i];

public static A082073Inst Instance=new A082073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082074
{
public static readonly long[] Value={ 2L,1L,3L,2L,1L,3L,2L,3L,4L,2L,1L,2L,1L,6L,3L,2L,4L,2L,3L,1L,8L,1L,2L,4L,3L,2L,1L,3L,5L,1L,5L,3L,1L,5L,4L,2L,1L,2L,3L,3L,4L,2L,1L,12L,3L,5L,4L,3L,2L,4L,2L,3L,1L,6L,3L,2L,3L,1L,6L,2L,6L,6L,1L,2L,1L,6L,3L,3L,2L,6L,1L,5L,1L,12L,2L,1L,3L,6L,5L,3L,1L,2L,3L,4L,3L,2L,6L,1L,3L,2L,3L,6L,7L,3L,2L,3L,1L,3L,2L,3L,7L,3L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082074Inst : IEnumerable<long>
{
public static readonly long[] Value=A082074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082074.Bytes);
public long this[int i]=>Value[i];

public static A082074Inst Instance=new A082074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082075
{
public static readonly long[] Value={ 4L,4L,8L,4L,8L,12L,4L,12L,8L,4L,8L,4L,20L,4L,20L,4L,8L,12L,12L,4L,12L,12L,8L,12L,12L,4L,12L,12L,12L,8L,12L,24L,4L,20L,16L,12L,8L,12L,4L,36L,12L,8L,4L,20L,4L,12L,8L,4L,8L,4L,20L,24L,16L,8L,16L,12L,8L,12L,12L,12L,4L,12L,24L,8L,28L,8L,12L,4L,8L,36L,24L,12L,4L,12L,20L,4L,20L,4L,20L,4L,8L,28L,20L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082075Inst : IEnumerable<long>
{
public static readonly long[] Value=A082075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082075.Bytes);
public long this[int i]=>Value[i];

public static A082075Inst Instance=new A082075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082076
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,3L,2L,1L,2L,1L,5L,1L,5L,1L,2L,3L,3L,1L,3L,3L,2L,3L,3L,1L,3L,3L,3L,2L,3L,6L,1L,5L,4L,3L,2L,3L,1L,9L,3L,2L,1L,5L,1L,3L,2L,1L,2L,1L,5L,6L,4L,2L,4L,3L,2L,3L,3L,3L,1L,3L,6L,2L,7L,2L,3L,1L,2L,9L,6L,3L,1L,3L,5L,1L,5L,1L,5L,1L,2L,7L,5L,1L,3L,2L,7L,3L,2L,3L,3L,6L,1L,3L,5L,7L,3L,2L,4L,9L,2L,7L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082076Inst : IEnumerable<long>
{
public static readonly long[] Value=A082076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082076.Bytes);
public long this[int i]=>Value[i];

public static A082076Inst Instance=new A082076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082077
{
public static readonly long[] Value={ 79L,281L,349L,439L,643L,677L,787L,1171L,1733L,1811L,2141L,2347L,2389L,2767L,2791L,3323L,3329L,3529L,3929L,4157L,4349L,4751L,4799L,4919L,4951L,5003L,5189L,5323L,5347L,5521L,5857L,5861L,6287L,6337L,6473L,6967L,6997L,7507L,7933L,8233L,8377L,8429L,9377L,9623L,9629L,10093L,10333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082077Inst : IEnumerable<long>
{
public static readonly long[] Value=A082077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082077.Bytes);
public long this[int i]=>Value[i];

public static A082077Inst Instance=new A082077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082078
{
public static readonly long[] Value={ 17L,53L,157L,173L,193L,229L,349L,439L,607L,659L,701L,709L,977L,1153L,1187L,1301L,1619L,2281L,2287L,2293L,2671L,2819L,2843L,3067L,3313L,3539L,3673L,3727L,3833L,4013L,4051L,4517L,4951L,5101L,5897L,6079L,6203L,6211L,6323L,6679L,6869L,7321L,7589L,7643L,7907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082078Inst : IEnumerable<long>
{
public static readonly long[] Value=A082078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082078.Bytes);
public long this[int i]=>Value[i];

public static A082078Inst Instance=new A082078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082079
{
public static readonly long[] Value={ 491L,757L,1787L,3571L,6337L,6451L,6991L,7741L,7907L,8821L,10141L,10267L,10657L,12911L,15299L,16189L,18223L,18701L,19801L,19843L,19853L,19937L,21961L,22543L,22739L,22807L,23893L,23909L,24767L,25169L,25391L,26591L,26641L,26693L,26713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082079Inst : IEnumerable<long>
{
public static readonly long[] Value=A082079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082079.Bytes);
public long this[int i]=>Value[i];

public static A082079Inst Instance=new A082079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082080
{
public static readonly long[] Value={ 2L,5L,79L,17L,491L,53L,71L,29L,37L,983L,5503L,173L,157L,353L,5297L,263L,179L,383L,137L,2939L,2083L,751L,353L,5501L,1523L,149L,4561L,1259L,397L,787L,8803L,8803L,607L,227L,3671L,17443L,57097L,3607L,23671L,12539L,1217L,11087L,1087L,21407L,19759L,953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082080Inst : IEnumerable<long>
{
public static readonly long[] Value=A082080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082080.Bytes);
public long this[int i]=>Value[i];

public static A082080Inst Instance=new A082080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082081
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,5L,7L,8L,9L,7L,11L,7L,13L,9L,8L,16L,17L,11L,19L,9L,7L,13L,23L,11L,25L,8L,27L,11L,29L,7L,31L,32L,9L,19L,7L,13L,37L,7L,16L,13L,41L,7L,43L,8L,9L,25L,47L,19L,49L,27L,9L,17L,53L,29L,16L,8L,13L,31L,59L,7L,61L,9L,16L,64L,11L,16L,67L,7L,8L,9L,71L,17L,73L,16L,11L,23L,11L,11L,79L,7L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082081Inst : IEnumerable<long>
{
public static readonly long[] Value=A082081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082081.Bytes);
public long this[int i]=>Value[i];

public static A082081Inst Instance=new A082081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082082
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,5L,4L,5L,7L,4L,9L,7L,9L,9L,10L,9L,7L,10L,13L,13L,14L,10L,14L,15L,17L,18L,19L,16L,18L,21L,16L,17L,22L,17L,23L,20L,24L,23L,22L,24L,27L,24L,28L,28L,26L,28L,28L,30L,28L,33L,34L,27L,35L,35L,36L,36L,35L,32L,32L,38L,35L,39L,43L,38L,44L,41L,36L,45L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082082Inst : IEnumerable<long>
{
public static readonly long[] Value=A082082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082082.Bytes);
public long this[int i]=>Value[i];

public static A082082Inst Instance=new A082082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082083
{
public static readonly long[] Value={ 0L,2L,5L,11L,16L,7L,37L,149L,7L,27L,11L,11L,23L,2389L,49L,11L,31L,19L,67L,109L,13L,8L,25L,8L,461L,179L,1319L,9L,193L,16L,7L,4931L,121L,7L,9L,8L,7L,8L,2895630887L,25L,19L,13L,19L,41L,2209493509721L,32L,5939L,23L,43L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082083Inst : IEnumerable<long>
{
public static readonly long[] Value=A082083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082083.Bytes);
public long this[int i]=>Value[i];

public static A082083Inst Instance=new A082083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082100
{
public static readonly BigInteger[] Value={ 5L,50L,1300L,65000L,7930000L,1348100000L,390949000000L,141523538000000L,75007475140000000L,BigInteger.Parse("63156294067880000000"),BigInteger.Parse("60756354893300560000000"),BigInteger.Parse("83236206203821767200000000"),BigInteger.Parse("140003298834828212430400000000") };
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
public class A082100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082100Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A082100.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A082100.Bytes);
public BigInteger this[int i]=>Value[i];

public static A082100Inst Instance=new A082100Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082101
{
public static readonly long[] Value={ 2L,5L,13L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082101Inst : IEnumerable<long>
{
public static readonly long[] Value=A082101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082101.Bytes);
public long this[int i]=>Value[i];

public static A082101Inst Instance=new A082101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082102
{
public static readonly BigInteger[] Value={ 11L,31L,89L,761L,2251L,6689L,59561L,14365291L,10461401779L,282437925089L,150094669656737489L,BigInteger.Parse("239299329512092506300739"),BigInteger.Parse("2153693964201457673153371"),BigInteger.Parse("107752636643058216783050887908587014548761") };
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
public class A082102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082102Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A082102.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A082102.Bytes);
public BigInteger this[int i]=>Value[i];

public static A082102Inst Instance=new A082102Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082103
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,8L,10L,15L,21L,24L,36L,49L,51L,86L,116L,134L,176L,284L,345L,498L,544L,649L,844L,1051L,1171L,1384L,1497L,1514L,1638L,1856L,2860L,2890L,3235L,3584L,4047L,5990L,7729L,8935L,9907L,15241L,15864L,17629L,19264L,28239L,43730L,46879L,65379L,89468L,128787L,139976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082103Inst : IEnumerable<long>
{
public static readonly long[] Value=A082103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082103.Bytes);
public long this[int i]=>Value[i];

public static A082103Inst Instance=new A082103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082104
{
public static readonly long[] Value={ 1L,2L,4L,11L,33L,151L,988L,11453L,247357L,10608128L,901029366L,148187993520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082104Inst : IEnumerable<long>
{
public static readonly long[] Value=A082104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082104.Bytes);
public long this[int i]=>Value[i];

public static A082104Inst Instance=new A082104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082105
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,13L,13L,1L,1L,22L,33L,22L,1L,1L,33L,61L,61L,33L,1L,1L,46L,97L,118L,97L,46L,1L,1L,61L,141L,193L,193L,141L,61L,1L,1L,78L,193L,286L,321L,286L,193L,78L,1L,1L,97L,253L,397L,481L,481L,397L,253L,97L,1L,1L,118L,321L,526L,673L,726L,673L,526L,321L,118L,1L,1L,141L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082105Inst : IEnumerable<long>
{
public static readonly long[] Value=A082105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082105.Bytes);
public long this[int i]=>Value[i];

public static A082105Inst Instance=new A082105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082106
{
public static readonly long[] Value={ 1L,6L,33L,118L,321L,726L,1441L,2598L,4353L,6886L,10401L,15126L,21313L,29238L,39201L,51526L,66561L,84678L,106273L,131766L,161601L,196246L,236193L,281958L,334081L,393126L,459681L,534358L,617793L,710646L,813601L,927366L,1052673L,1190278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082106Inst : IEnumerable<long>
{
public static readonly long[] Value=A082106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082106.Bytes);
public long this[int i]=>Value[i];

public static A082106Inst Instance=new A082106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082107
{
public static readonly long[] Value={ 1L,2L,8L,28L,79L,190L,406L,792L,1437L,2458L,4004L,6260L,9451L,13846L,19762L,27568L,37689L,50610L,66880L,87116L,112007L,142318L,178894L,222664L,274645L,335946L,407772L,491428L,588323L,699974L,828010L,974176L,1140337L,1328482L,1540728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082107Inst : IEnumerable<long>
{
public static readonly long[] Value=A082107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082107.Bytes);
public long this[int i]=>Value[i];

public static A082107Inst Instance=new A082107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082108
{
public static readonly long[] Value={ 1L,11L,29L,55L,89L,131L,181L,239L,305L,379L,461L,551L,649L,755L,869L,991L,1121L,1259L,1405L,1559L,1721L,1891L,2069L,2255L,2449L,2651L,2861L,3079L,3305L,3539L,3781L,4031L,4289L,4555L,4829L,5111L,5401L,5699L,6005L,6319L,6641L,6971L,7309L,7655L,8009L,8371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082108Inst : IEnumerable<long>
{
public static readonly long[] Value=A082108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082108.Bytes);
public long this[int i]=>Value[i];

public static A082108Inst Instance=new A082108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082109
{
public static readonly long[] Value={ 1L,13L,33L,61L,97L,141L,193L,253L,321L,397L,481L,573L,673L,781L,897L,1021L,1153L,1293L,1441L,1597L,1761L,1933L,2113L,2301L,2497L,2701L,2913L,3133L,3361L,3597L,3841L,4093L,4353L,4621L,4897L,5181L,5473L,5773L,6081L,6397L,6721L,7053L,7393L,7741L,8097L,8461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082109Inst : IEnumerable<long>
{
public static readonly long[] Value=A082109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082109.Bytes);
public long this[int i]=>Value[i];

public static A082109Inst Instance=new A082109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082110
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,15L,15L,1L,1L,25L,37L,25L,1L,1L,37L,67L,67L,37L,1L,1L,51L,105L,127L,105L,51L,1L,1L,67L,151L,205L,205L,151L,67L,1L,1L,85L,205L,301L,337L,301L,205L,85L,1L,1L,105L,267L,415L,501L,501L,415L,267L,105L,1L,1L,127L,337L,547L,697L,751L,697L,547L,337L,127L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082110Inst : IEnumerable<long>
{
public static readonly long[] Value=A082110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082110.Bytes);
public long this[int i]=>Value[i];

public static A082110Inst Instance=new A082110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082111
{
public static readonly long[] Value={ 1L,7L,15L,25L,37L,51L,67L,85L,105L,127L,151L,177L,205L,235L,267L,301L,337L,375L,415L,457L,501L,547L,595L,645L,697L,751L,807L,865L,925L,987L,1051L,1117L,1185L,1255L,1327L,1401L,1477L,1555L,1635L,1717L,1801L,1887L,1975L,2065L,2157L,2251L,2347L,2445L,2545L,2647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082111Inst : IEnumerable<long>
{
public static readonly long[] Value=A082111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082111.Bytes);
public long this[int i]=>Value[i];

public static A082111Inst Instance=new A082111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082112
{
public static readonly long[] Value={ 1L,15L,37L,67L,105L,151L,205L,267L,337L,415L,501L,595L,697L,807L,925L,1051L,1185L,1327L,1477L,1635L,1801L,1975L,2157L,2347L,2545L,2751L,2965L,3187L,3417L,3655L,3901L,4155L,4417L,4687L,4965L,5251L,5545L,5847L,6157L,6475L,6801L,7135L,7477L,7827L,8185L,8551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082112Inst : IEnumerable<long>
{
public static readonly long[] Value=A082112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082112.Bytes);
public long this[int i]=>Value[i];

public static A082112Inst Instance=new A082112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082113
{
public static readonly long[] Value={ 1L,7L,37L,127L,337L,751L,1477L,2647L,4417L,6967L,10501L,15247L,21457L,29407L,39397L,51751L,66817L,84967L,106597L,132127L,162001L,196687L,236677L,282487L,334657L,393751L,460357L,535087L,618577L,711487L,814501L,928327L,1053697L,1191367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082113Inst : IEnumerable<long>
{
public static readonly long[] Value=A082113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082113.Bytes);
public long this[int i]=>Value[i];

public static A082113Inst Instance=new A082113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082114
{
public static readonly long[] Value={ 1L,2L,9L,32L,89L,210L,441L,848L,1521L,2578L,4169L,6480L,9737L,14210L,20217L,28128L,38369L,51426L,67849L,88256L,113337L,143858L,180665L,224688L,276945L,338546L,410697L,494704L,591977L,704034L,832505L,979136L,1145793L,1334466L,1547273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082114Inst : IEnumerable<long>
{
public static readonly long[] Value=A082114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082114.Bytes);
public long this[int i]=>Value[i];

public static A082114Inst Instance=new A082114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082115
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082115Inst : IEnumerable<long>
{
public static readonly long[] Value=A082115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082115.Bytes);
public long this[int i]=>Value[i];

public static A082115Inst Instance=new A082115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082244
{
public static readonly long[] Value={ 3L,23L,53L,197L,127L,233L,691L,379L,499L,857L,953L,1151L,1259L,1583L,2099L,2399L,2417L,2579L,2909L,3803L,3821L,4217L,4651L,5107L,5813L,6829L,6079L,6599L,14153L,10091L,8273L,10163L,9521L,12281L,13043L,11597L,12713L,13099L,16763L,15527L,16823L,22741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082244Inst : IEnumerable<long>
{
public static readonly long[] Value=A082244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082244.Bytes);
public long this[int i]=>Value[i];

public static A082244Inst Instance=new A082244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082245
{
public static readonly BigInteger[] Value={ 1L,3L,10L,73L,626L,8052L,117650L,2113665L,43053283L,1001953638L,25937424602L,743375541244L,23298085122482L,793811662272744L,29192932133689220L,1152956690052710401L,BigInteger.Parse("48661191875666868482"),BigInteger.Parse("2185928253847184914509") };
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
public class A082245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082245Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A082245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A082245.Bytes);
public BigInteger this[int i]=>Value[i];

public static A082245Inst Instance=new A082245Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082246
{
public static readonly long[] Value={ 197L,223L,251L,281L,311L,401L,431L,463L,523L,593L,659L,719L,757L,827L,863L,947L,991L,1063L,1171L,1753L,1901L,2347L,2393L,2647L,2689L,2731L,2777L,2819L,2953L,3347L,3389L,3533L,3643L,3701L,3761L,3821L,4177L,4217L,4451L,4493L,5507L,5717L,5849L,5927L,6029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082246Inst : IEnumerable<long>
{
public static readonly long[] Value=A082246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082246.Bytes);
public long this[int i]=>Value[i];

public static A082246Inst Instance=new A082246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082247
{
public static readonly long[] Value={ 3456789L,13141516171819L,20212223242526L,27282930313233L,34353637383940L,41424344454647L,48495051525354L,55565758596061L,62636465666768L,69707172737475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082247Inst : IEnumerable<long>
{
public static readonly long[] Value=A082247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082247.Bytes);
public long this[int i]=>Value[i];

public static A082247Inst Instance=new A082247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082248
{
public static readonly long[] Value={ 493827L,1877359453117L,2887460463218L,3897561473319L,4907662483420L,5917763493521L,6927864503622L,7937965513723L,8948066523824L,9958167533925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082248Inst : IEnumerable<long>
{
public static readonly long[] Value=A082248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082248.Bytes);
public long this[int i]=>Value[i];

public static A082248Inst Instance=new A082248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082249
{
public static readonly BigInteger[] Value={ 22212019181716L,29282726252423L,36353433323130L,43424140393837L,50494847464544L,57565554535251L,64636261605958L,71706968676665L,78777675747372L,85848382818079L,92919089888786L,99989796959493L,BigInteger.Parse("108107106105104103102") };
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
public class A082249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A082249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A082249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A082249Inst Instance=new A082249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082250
{
public static readonly ulong[] Value={ 3173145597388L,4183246607489L,5193347617590L,6203448627691L,7213549637792L,8223650647893L,9233751657994L,10243852668095L,11253953678196L,12264054688297L,13274155698398L,14284256708499L,15443872300729157586UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082250Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A082250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082250.Bytes);
public ulong this[int i]=>Value[i];

public static A082250Inst Instance=new A082250Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082251
{
public static readonly long[] Value={ 127L,401L,439L,479L,593L,881L,929L,977L,1163L,1213L,1321L,1367L,1459L,1511L,1601L,1747L,1801L,1951L,1999L,2053L,2111L,2393L,2713L,3299L,3457L,3517L,3571L,3739L,3793L,4091L,4253L,4621L,4691L,4969L,5413L,5521L,5827L,5987L,6173L,6379L,6947L,7151L,7741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082251Inst : IEnumerable<long>
{
public static readonly long[] Value=A082251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082251.Bytes);
public long this[int i]=>Value[i];

public static A082251Inst Instance=new A082251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082252
{
public static readonly long[] Value={ 41L,152L,263L,33704L,43805L,53906L,64007L,74108L,84209L,94310L,104411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082252Inst : IEnumerable<long>
{
public static readonly long[] Value=A082252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082252.Bytes);
public long this[int i]=>Value[i];

public static A082252Inst Instance=new A082252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082253
{
public static readonly long[] Value={ 2469L,135782L,222426283L,323436384L,424446485L,525456586L,626466687L,727476788L,828486889L,929496990L,1030507091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082253Inst : IEnumerable<long>
{
public static readonly long[] Value=A082253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082253.Bytes);
public long this[int i]=>Value[i];

public static A082253Inst Instance=new A082253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082254
{
public static readonly long[] Value={ 20576L,131516852L,21902526953L,32003537054L,42104547155L,52205557256L,62306567357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082254Inst : IEnumerable<long>
{
public static readonly long[] Value=A082254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082254.Bytes);
public long this[int i]=>Value[i];

public static A082254Inst Instance=new A082254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082255
{
public static readonly long[] Value={ 7098637639L,164268952147740L,265279053157841L,366289154167942L,467299255178043L,568309356188144L,669319457198245L,770329558208346L,871339659218447L,972349760228548L,1073359861238649L,11743699622487387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082255Inst : IEnumerable<long>
{
public static readonly long[] Value=A082255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082255.Bytes);
public long this[int i]=>Value[i];

public static A082255Inst Instance=new A082255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082256
{
public static readonly long[] Value={ 13717421L,11234681268351302L,21335691369361403L,31436701470371504L,41537711571381605L,51638721672391706L,61739731773401807L,71840741874411908L,81941751975422009L,92042762076432110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082256Inst : IEnumerable<long>
{
public static readonly long[] Value=A082256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082256.Bytes);
public long this[int i]=>Value[i];

public static A082256Inst Instance=new A082256Inst();

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