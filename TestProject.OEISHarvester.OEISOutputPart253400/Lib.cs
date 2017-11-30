using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A094775
{
public static readonly long[] Value={ 1L,6L,2L,3L,4L,8L,7L,4L,0L,1L,6L,4L,0L,1L,3L,3L,0L,0L,3L,0L,2L,6L,2L,1L,1L,1L,2L,7L,6L,6L,3L,9L,8L,4L,1L,0L,1L,5L,1L,4L,6L,7L,9L,6L,9L,0L,7L,1L,2L,2L,7L,4L,3L,9L,1L,4L,0L,3L,8L,7L,4L,1L,7L,5L,5L,1L,4L,9L,8L,7L,1L,7L,0L,1L,7L,3L,1L,7L,3L,2L,8L,4L,9L,1L,5L,3L,6L,6L,6L,0L,5L,0L,1L,3L,7L,1L,6L,8L,6L,2L,4L,3L,0L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094775Inst : IEnumerable<long>
{
public static readonly long[] Value=A094775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094775.Bytes);
public long this[int i]=>Value[i];

public static A094775Inst Instance=new A094775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094776
{
public static readonly long[] Value={ 86L,91L,168L,153L,107L,71L,93L,71L,78L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094776Inst : IEnumerable<long>
{
public static readonly long[] Value=A094776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094776.Bytes);
public long this[int i]=>Value[i];

public static A094776Inst Instance=new A094776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094777
{
public static readonly BigInteger[] Value={ 1L,57L,12675L,24318165L,414295148741L,62567386502084877L,BigInteger.Parse("83677847847984287628595"),BigInteger.Parse("990966953618170260281935463385"),BigInteger.Parse("103919148791293834318983090438798793469"),BigInteger.Parse("96498428501909654589630887978835098088148177857"),BigInteger.Parse("793474866816582266820936671790189132321673383112185151899"),BigInteger.Parse("57774258489513238998237970307483999327287210756991189655942651331169"),BigInteger.Parse("37249792307686396442294904767024517674249157948208717533254799550970595875237705"),BigInteger.Parse("212667732900366224249789357650440598098805861083269127196623872213228196352455447575029701325") };
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
public class A094777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094777Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094777.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094777.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094777Inst Instance=new A094777Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094778
{
public static readonly long[] Value={ 0L,5L,4L,2L,5L,2L,2L,2L,2L,2L,2L,2L,5L,2L,2L,2L,4L,4L,15L,5L,2L,4L,4L,2L,5L,2L,4L,4L,2L,5L,2L,2L,2L,2L,7L,2L,4L,5L,10L,2L,7L,2L,4L,7L,8L,2L,2L,5L,5L,8L,5L,13L,8L,2L,7L,8L,13L,10L,4L,2L,4L,2L,4L,4L,8L,4L,4L,2L,5L,2L,2L,2L,2L,2L,2L,4L,2L,5L,5L,2L,2L,24L,10L,2L,4L,2L,26L,5L,2L,2L,4L,10L,2L,5L,2L,4L,70L,4L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094778Inst : IEnumerable<long>
{
public static readonly long[] Value=A094778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094778.Bytes);
public long this[int i]=>Value[i];

public static A094778Inst Instance=new A094778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094779
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,6L,12L,29L,58L,2L,4L,50L,100L,332L,664L,1757L,3514L,8458L,16916L,38694L,77388L,171572L,343144L,745074L,1490148L,3188308L,6376616L,13496132L,26992264L,56658968L,113317936L,236330717L,472661434L,980680538L,1961361076L,4052366942L,8104733884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094779Inst : IEnumerable<long>
{
public static readonly long[] Value=A094779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094779.Bytes);
public long this[int i]=>Value[i];

public static A094779Inst Instance=new A094779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094780
{
public static readonly long[] Value={ 0L,0L,2L,12L,58L,4L,100L,664L,3514L,16916L,77388L,343144L,1490148L,6376616L,26992264L,113317936L,472661434L,1961361076L,8104733884L,33374212936L,137031378124L,11497939448L,94924291832L,562662294608L,2936768405732L,14326881917576L,67031420473208L,304860388037136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094780Inst : IEnumerable<long>
{
public static readonly long[] Value=A094780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094780.Bytes);
public long this[int i]=>Value[i];

public static A094780Inst Instance=new A094780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094781
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,1L,2L,1L,1L,2L,1L,3L,3L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,3L,2L,2L,3L,1L,3L,2L,2L,3L,1L,3L,3L,3L,2L,2L,3L,3L,3L,1L,1L,1L,2L,2L,2L,1L,2L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,2L,1L,3L,2L,1L,2L,3L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094781Inst : IEnumerable<long>
{
public static readonly long[] Value=A094781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094781.Bytes);
public long this[int i]=>Value[i];

public static A094781Inst Instance=new A094781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094782
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,3L,2L,1L,1L,2L,1L,1L,2L,3L,3L,2L,1L,3L,1L,1L,3L,1L,2L,1L,1L,3L,1L,1L,2L,3L,1L,1L,2L,3L,3L,2L,1L,1L,2L,3L,1L,3L,3L,2L,3L,3L,2L,2L,2L,3L,1L,3L,1L,2L,1L,1L,2L,1L,2L,2L,3L,1L,3L,1L,3L,2L,1L,3L,1L,1L,2L,3L,3L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,3L,3L,3L,3L,4L,3L,3L,3L,3L,4L,3L,2L,3L,3L,2L,1L,1L,2L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094782Inst : IEnumerable<long>
{
public static readonly long[] Value=A094782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094782.Bytes);
public long this[int i]=>Value[i];

public static A094782Inst Instance=new A094782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094783
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,24L,48L,60L,120L,240L,360L,1680L,2520L,5040L,10080L,15120L,25200L,27720L,55440L,110880L,166320L,277200L,720720L,1441440L,2162160L,3603600L,7207200L,10810800L,122522400L,183783600L,2327925600L,3491888400L,80313433200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094783Inst : IEnumerable<long>
{
public static readonly long[] Value=A094783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094783.Bytes);
public long this[int i]=>Value[i];

public static A094783Inst Instance=new A094783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094784
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,26L,28L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094784Inst : IEnumerable<long>
{
public static readonly long[] Value=A094784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094784.Bytes);
public long this[int i]=>Value[i];

public static A094784Inst Instance=new A094784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094785
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,6L,0L,0L,2L,22L,0L,0L,10L,19L,91L,0L,0L,60L,114L,138L,408L,0L,0L,420L,798L,966L,918L,1938L,0L,0L,3360L,6384L,7728L,7344L,5890L,9614L,0L,0L,30240L,57456L,69552L,66096L,53010L,37191L,49335L,0L,0L,302400L,574560L,695520L,660960L,530100L,371910L,233220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094785Inst : IEnumerable<long>
{
public static readonly long[] Value=A094785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094785.Bytes);
public long this[int i]=>Value[i];

public static A094785Inst Instance=new A094785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094786
{
public static readonly long[] Value={ 2L,7L,23L,47L,79L,167L,223L,241L,359L,439L,727L,839L,1087L,1223L,1367L,1847L,2207L,2399L,3023L,3373L,3719L,3967L,4759L,5039L,5623L,5927L,6857L,7919L,8647L,10607L,11447L,13687L,14159L,14639L,16127L,17159L,18223L,19319L,19681L,21023L,24023L,25919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094786Inst : IEnumerable<long>
{
public static readonly long[] Value=A094786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094786.Bytes);
public long this[int i]=>Value[i];

public static A094786Inst Instance=new A094786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094787
{
public static readonly long[] Value={ 3L,2L,5L,5L,3L,2L,2L,17L,7L,17L,5L,13L,3L,2L,17L,11L,19L,7L,13L,5L,11L,3L,2L,3L,2L,23L,5L,53L,3L,2L,5L,17L,3L,2L,29L,13L,107L,11L,61L,41L,23L,7L,101L,5L,19L,3L,2L,73L,79L,31L,13L,29L,11L,67L,73L,113L,7L,23L,5L,61L,3L,2L,37L,17L,79L,59L,61L,13L,31L,11L,29L,53L,71L,7L,53L,5L,23L,3L,2L,41L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094787Inst : IEnumerable<long>
{
public static readonly long[] Value=A094787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094787.Bytes);
public long this[int i]=>Value[i];

public static A094787Inst Instance=new A094787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094836
{
public static readonly BigInteger[] Value={ -15L,15L,40545L,109552575L,296011017105L,799821658665135L,2161117825702177665L,BigInteger.Parse("5839339565225625385695"),BigInteger.Parse("15777893344121814089970225"),BigInteger.Parse("42631861976477576445474162255"),BigInteger.Parse("115191275282549067433857096442785"),BigInteger.Parse("311246783181585603728705429114242815") };
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
public class A094836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094836Inst Instance=new A094836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094837
{
public static readonly long[] Value={ 1L,2L,4L,10L,24L,46L,100L,225L,525L,1225L,3136L,7056L,17640L,44100L,108900L,261360L,637065L,1656369L,4008004L,10020010L,25050025L,64128064L,155739584L,393853824L,1012766976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094837Inst : IEnumerable<long>
{
public static readonly long[] Value=A094837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094837.Bytes);
public long this[int i]=>Value[i];

public static A094837Inst Instance=new A094837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094838
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,4L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,12L,12L,13L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094838Inst : IEnumerable<long>
{
public static readonly long[] Value=A094838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094838.Bytes);
public long this[int i]=>Value[i];

public static A094838Inst Instance=new A094838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094839
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,2L,1L,1L,2L,1L,2L,2L,2L,3L,1L,1L,2L,1L,2L,2L,2L,3L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,4L,1L,1L,2L,2L,4L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,2L,2L,2L,3L,1L,1L,2L,2L,2L,3L,1L,2L,1L,4L,1L,1L,2L,4L,1L,1L,2L,2L,4L,1L,2L,1L,1L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094839Inst : IEnumerable<long>
{
public static readonly long[] Value=A094839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094839.Bytes);
public long this[int i]=>Value[i];

public static A094839Inst Instance=new A094839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094840
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,2L,3L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,3L,1L,1L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,2L,3L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,2L,3L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,3L,1L,1L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,2L,3L,1L,2L,1L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094840Inst : IEnumerable<long>
{
public static readonly long[] Value=A094840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094840.Bytes);
public long this[int i]=>Value[i];

public static A094840Inst Instance=new A094840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094841
{
public static readonly long[] Value={ 19L,43L,43L,67L,67L,163L,163L,163L,163L,163L,163L,77683L,77683L,1333963L,2404147L,2404147L,20950603L,36254563L,51599563L,96295483L,96295483L,114148483L,269497867L,269497867L,269497867L,269497867L,585811843L,52947440683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094841Inst : IEnumerable<long>
{
public static readonly long[] Value=A094841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094841.Bytes);
public long this[int i]=>Value[i];

public static A094841Inst Instance=new A094841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094842
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,22L,22L,79L,107L,107L,311L,432L,487L,665L,665L,692L,1044L,1044L,1044L,1044L,1536L,13909L,13909L,15204L,29351L,29351L,44332L,70877L,70877L,70877L,70877L,149460L,223574L,296475L,296475L,553436L,553436L,553436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094842Inst : IEnumerable<long>
{
public static readonly long[] Value=A094842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094842.Bytes);
public long this[int i]=>Value[i];

public static A094842Inst Instance=new A094842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094843
{
public static readonly ulong[] Value={ 19L,43L,67L,163L,77683L,1333963L,2404147L,20950603L,36254563L,51599563L,96295483L,114148483L,269497867L,585811843L,52947440683L,71837718283L,229565917267L,575528148427L,1432817816347L,6778817202523L,16501779755323L,30059924764123L,110587910656507L,4311527414591923L,10472407114788067L,22261805373620443L,132958087830686827L,441899002218793387L,2278509757859388307L,5694230275645018963L,9828323860172600203UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094843Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A094843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094843.Bytes);
public ulong this[int i]=>Value[i];

public static A094843Inst Instance=new A094843Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094844
{
public static readonly long[] Value={ 1L,1L,1L,1L,22L,79L,107L,311L,432L,487L,665L,692L,1044L,1536L,13909L,15204L,29351L,44332L,70877L,149460L,223574L,296475L,553436L,3791896L,5798780L,8035685L,19412108L,33684408L,77949544L,119705436L,156104956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094844Inst : IEnumerable<long>
{
public static readonly long[] Value=A094844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094844.Bytes);
public long this[int i]=>Value[i];

public static A094844Inst Instance=new A094844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094845
{
public static readonly long[] Value={ 19L,43L,67L,163L,222643L,1333963L,2404147L,20950603L,51599563L,96295483L,146161723L,1408126003L,3341091163L,52947440683L,193310265163L,229565917267L,915809911867L,1432817816347L,30059924764123L,3126717241727227L,8842819893041227L,13688678408873323L,22261805373620443L,4908856524312968467L,7961860547428719787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094845Inst : IEnumerable<long>
{
public static readonly long[] Value=A094845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094845.Bytes);
public long this[int i]=>Value[i];

public static A094845Inst Instance=new A094845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094846
{
public static readonly long[] Value={ 1L,33L,79L,107L,311L,487L,665L,857L,2293L,3523L,13909L,26713L,29351L,59801L,70877L,296475L,3201195L,5188215L,6524653L,8035685L,121139393L,140879803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094846Inst : IEnumerable<long>
{
public static readonly long[] Value=A094846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094846.Bytes);
public long this[int i]=>Value[i];

public static A094846Inst Instance=new A094846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094847
{
public static readonly long[] Value={ 5L,53L,173L,173L,293L,437L,9173L,9173L,24653L,74093L,74093L,74093L,170957L,214037L,214037L,214037L,2004917L,44401013L,71148173L,154554077L,154554077L,163520117L,163520117L,163520117L,261153653L,261153653L,1728061733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094847Inst : IEnumerable<long>
{
public static readonly long[] Value=A094847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094847.Bytes);
public long this[int i]=>Value[i];

public static A094847Inst Instance=new A094847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094848
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,4L,5L,5L,5L,3L,2L,2L,2L,3L,2L,6L,2L,2L,9L,9L,9L,3L,3L,1L,1L,1L,7L,2L,1L,1L,2L,2L,2L,2L,1L,1L,4L,4L,4L,4L,2L,1L,1L,4L,4L,4L,4L,4L,3L,3L,3L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094848Inst : IEnumerable<long>
{
public static readonly long[] Value=A094848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094848.Bytes);
public long this[int i]=>Value[i];

public static A094848Inst Instance=new A094848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094849
{
public static readonly long[] Value={ 5L,53L,173L,293L,437L,9173L,24653L,74093L,170957L,214037L,2004917L,44401013L,71148173L,154554077L,163520117L,261153653L,1728061733L,9447241877L,19553206613L,49107823133L,385995595277L,13213747959653L,14506773263237L,57824199003317L,160909740894437L,370095509388197L,1409029796180597L,4075316253649373L,18974003020179917L,224117990614052477L,637754768063384837L,4472988326827347533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094849Inst : IEnumerable<long>
{
public static readonly long[] Value=A094849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094849.Bytes);
public long this[int i]=>Value[i];

public static A094849Inst Instance=new A094849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094850
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,4L,5L,3L,2L,3L,2L,6L,2L,9L,3L,1L,7L,2L,1L,2L,1L,1L,4L,4L,2L,1L,1L,4L,4L,3L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094850Inst : IEnumerable<long>
{
public static readonly long[] Value=A094850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094850.Bytes);
public long this[int i]=>Value[i];

public static A094850Inst Instance=new A094850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094851
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,5L,5L,3L,1L,1L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,1L,9L,1L,1L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094851Inst : IEnumerable<long>
{
public static readonly long[] Value=A094851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094851.Bytes);
public long this[int i]=>Value[i];

public static A094851Inst Instance=new A094851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094884
{
public static readonly long[] Value={ 1L,1L,4L,4L,1L,2L,2L,8L,0L,5L,6L,3L,5L,3L,6L,8L,5L,9L,5L,2L,0L,0L,1L,4L,5L,5L,6L,7L,1L,6L,0L,6L,0L,4L,1L,5L,3L,0L,7L,2L,3L,0L,6L,7L,5L,3L,6L,7L,5L,5L,4L,1L,2L,2L,5L,0L,0L,8L,5L,4L,6L,1L,4L,7L,6L,9L,5L,8L,3L,1L,7L,2L,9L,2L,7L,5L,3L,3L,6L,3L,1L,5L,0L,4L,8L,6L,5L,8L,9L,1L,0L,6L,7L,6L,7L,3L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094884Inst : IEnumerable<long>
{
public static readonly long[] Value=A094884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094884.Bytes);
public long this[int i]=>Value[i];

public static A094884Inst Instance=new A094884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094885
{
public static readonly long[] Value={ 4L,3L,9L,8L,2L,7L,2L,3L,8L,9L,4L,4L,7L,9L,4L,6L,3L,9L,5L,9L,7L,1L,9L,8L,7L,0L,2L,9L,2L,9L,2L,8L,8L,5L,8L,6L,8L,7L,8L,6L,7L,4L,0L,4L,9L,7L,9L,7L,8L,8L,3L,4L,9L,1L,7L,0L,3L,8L,0L,9L,8L,0L,9L,0L,2L,1L,6L,4L,4L,4L,4L,3L,2L,1L,1L,6L,2L,0L,4L,4L,3L,0L,0L,3L,8L,5L,4L,6L,4L,3L,5L,2L,9L,2L,9L,4L,7L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094885Inst : IEnumerable<long>
{
public static readonly long[] Value=A094885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094885.Bytes);
public long this[int i]=>Value[i];

public static A094885Inst Instance=new A094885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094886
{
public static readonly long[] Value={ 5L,0L,8L,3L,2L,0L,3L,6L,9L,2L,3L,1L,5L,2L,5L,9L,8L,1L,5L,8L,0L,9L,5L,0L,9L,0L,1L,3L,2L,4L,2L,1L,9L,8L,8L,4L,1L,8L,3L,1L,8L,3L,9L,2L,9L,3L,2L,2L,1L,1L,5L,4L,1L,2L,0L,4L,8L,2L,3L,3L,2L,8L,0L,9L,2L,4L,9L,9L,7L,9L,1L,4L,3L,4L,5L,2L,6L,9L,8L,6L,0L,1L,8L,6L,6L,0L,8L,8L,6L,2L,0L,3L,5L,3L,9L,4L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094886Inst : IEnumerable<long>
{
public static readonly long[] Value=A094886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094886.Bytes);
public long this[int i]=>Value[i];

public static A094886Inst Instance=new A094886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094887
{
public static readonly long[] Value={ 2L,2L,8L,8L,2L,4L,5L,6L,1L,1L,2L,7L,0L,7L,3L,7L,1L,9L,0L,4L,0L,0L,2L,9L,1L,1L,3L,4L,3L,2L,1L,2L,0L,8L,3L,0L,6L,1L,4L,4L,6L,1L,3L,5L,0L,7L,3L,5L,1L,0L,8L,2L,4L,5L,0L,0L,1L,7L,0L,9L,2L,2L,9L,5L,3L,9L,1L,6L,6L,3L,4L,5L,8L,5L,5L,0L,6L,7L,2L,6L,3L,0L,0L,9L,7L,3L,1L,7L,8L,2L,1L,3L,5L,3L,4L,7L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094887Inst : IEnumerable<long>
{
public static readonly long[] Value=A094887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094887.Bytes);
public long this[int i]=>Value[i];

public static A094887Inst Instance=new A094887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094888
{
public static readonly long[] Value={ 1L,0L,1L,6L,6L,4L,0L,7L,3L,8L,4L,6L,3L,0L,5L,1L,9L,6L,3L,1L,6L,1L,9L,0L,1L,8L,0L,2L,6L,4L,8L,4L,3L,9L,7L,6L,8L,3L,6L,6L,3L,6L,7L,8L,5L,8L,6L,4L,4L,2L,3L,0L,8L,2L,4L,0L,9L,6L,4L,6L,6L,5L,6L,1L,8L,4L,9L,9L,9L,5L,8L,2L,8L,6L,9L,0L,5L,3L,9L,7L,2L,0L,3L,7L,3L,2L,1L,7L,7L,2L,4L,0L,7L,0L,7L,8L,8L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094888Inst : IEnumerable<long>
{
public static readonly long[] Value=A094888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094888.Bytes);
public long this[int i]=>Value[i];

public static A094888Inst Instance=new A094888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094889
{
public static readonly long[] Value={ 33075L,99225L,165375L,231525L,259875L,297675L,363825L,429975L,467775L,496125L,552825L,562275L,571725L,606375L,628425L,675675L,694575L,716625L,760725L,779625L,798525L,826875L,848925L,883575L,893025L,921375L,937125L,959175L,1003275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094889Inst : IEnumerable<long>
{
public static readonly long[] Value=A094889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094889.Bytes);
public long this[int i]=>Value[i];

public static A094889Inst Instance=new A094889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094890
{
public static readonly long[] Value={ 0L,1L,6L,10L,36L,630L,741L,1081L,2211L,7140L,10011L,10153L,13366L,15576L,17766L,23220L,24531L,25651L,28920L,33411L,42486L,47586L,52326L,59685L,61776L,69006L,112575L,113050L,121771L,125751L,128778L,129286L,146611L,156520L,163306L,165025L,167331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094890Inst : IEnumerable<long>
{
public static readonly long[] Value=A094890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094890.Bytes);
public long this[int i]=>Value[i];

public static A094890Inst Instance=new A094890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094891
{
public static readonly long[] Value={ 1L,7L,34L,144L,563L,2095L,7532L,26410L,90853L,307893L,1030886L,3417450L,11235151L,36676453L,119003432L,384098710L,1234016321L,3948461521L,12588083810L,40001960362L,126745795259L,400532044957L,1262690290868L,3971944688584L,12469123686533L,39071957204695L,122222999571622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094891Inst : IEnumerable<long>
{
public static readonly long[] Value=A094891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094891.Bytes);
public long this[int i]=>Value[i];

public static A094891Inst Instance=new A094891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094892
{
public static readonly long[] Value={ 46L,35L,33L,32L,30L,29L,27L,31L,27L,27L,26L,25L,30L,26L,22L,27L,26L,27L,24L,24L,26L,23L,26L,26L,22L,24L,26L,27L,20L,25L,23L,25L,23L,24L,22L,23L,26L,21L,21L,24L,21L,26L,24L,23L,25L,22L,25L,20L,25L,22L,21L,22L,21L,22L,21L,18L,26L,22L,21L,26L,23L,24L,22L,19L,21L,24L,21L,17L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094892Inst : IEnumerable<long>
{
public static readonly long[] Value=A094892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094892.Bytes);
public long this[int i]=>Value[i];

public static A094892Inst Instance=new A094892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094893
{
public static readonly long[] Value={ 1L,4L,12L,34L,84L,212L,488L,1162L,2580L,5932L,12888L,28948L,61992L,136936L,290256L,633178L,1331892L,2877308L,6016760L,12897340L,26843256L,57175384L,118545072L,251163204L,519103624L,1094915512L,2256939888L,4742198632L,9752832720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094893Inst : IEnumerable<long>
{
public static readonly long[] Value=A094893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094893.Bytes);
public long this[int i]=>Value[i];

public static A094893Inst Instance=new A094893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094894
{
public static readonly long[] Value={ 3L,2L,5L,7L,17L,31L,61L,109L,211L,383L,677L,1217L,2137L,3733L,6521L,11279L,19463L,33347L,56963L,97159L,165443L,280549L,474809L,801611L,1351841L,2273989L,3821689L,6412541L,10742339L,17974841L,30045019L,50163697L,83669419L,139420003L,232106309L,386086573L,641716373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094894Inst : IEnumerable<long>
{
public static readonly long[] Value=A094894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094894.Bytes);
public long this[int i]=>Value[i];

public static A094894Inst Instance=new A094894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094895
{
public static readonly BigInteger[] Value={ 1L,280L,8524L,295840L,10014256L,340831360L,11585508544L,393929320960L,13393420731136L,455377714186240L,15482831007960064L,526416344465121280L,17898154990259286016UL,BigInteger.Parse("608537275441252433920"),BigInteger.Parse("20690267318823093059584") };
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
public class A094895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094895Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094895.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094895Inst Instance=new A094895Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094896
{
public static readonly long[] Value={ 0L,0L,0L,13L,0L,0L,0L,0L,0L,37L,0L,0L,0L,53L,0L,61L,0L,0L,73L,0L,0L,0L,89L,0L,97L,0L,0L,109L,113L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,157L,0L,0L,0L,173L,0L,181L,0L,0L,193L,0L,0L,0L,0L,0L,0L,0L,0L,229L,233L,0L,241L,0L,0L,0L,257L,0L,0L,0L,0L,277L,0L,0L,0L,293L,0L,0L,0L,0L,313L,317L,0L,0L,0L,0L,337L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094896Inst : IEnumerable<long>
{
public static readonly long[] Value=A094896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094896.Bytes);
public long this[int i]=>Value[i];

public static A094896Inst Instance=new A094896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094897
{
public static readonly long[] Value={ 3L,0L,11L,0L,0L,23L,0L,0L,0L,0L,0L,47L,0L,0L,59L,0L,67L,71L,0L,79L,83L,0L,0L,0L,0L,0L,107L,0L,0L,0L,0L,127L,131L,0L,0L,0L,0L,0L,0L,0L,163L,167L,0L,0L,179L,0L,0L,191L,0L,0L,0L,0L,211L,0L,0L,223L,227L,0L,0L,239L,0L,0L,251L,0L,0L,263L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,307L,311L,0L,0L,0L,0L,331L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094897Inst : IEnumerable<long>
{
public static readonly long[] Value=A094897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094897.Bytes);
public long this[int i]=>Value[i];

public static A094897Inst Instance=new A094897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094898
{
public static readonly long[] Value={ 7L,0L,0L,17L,0L,0L,0L,0L,0L,41L,0L,0L,0L,0L,0L,0L,71L,0L,0L,83L,0L,0L,0L,0L,101L,0L,0L,113L,0L,0L,0L,131L,0L,0L,0L,0L,0L,0L,0L,0L,167L,0L,0L,0L,0L,0L,0L,0L,197L,0L,0L,0L,0L,0L,0L,227L,0L,233L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,281L,0L,0L,0L,0L,0L,0L,311L,0L,317L,0L,0L,0L,0L,0L,0L,0L,0L,353L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094898Inst : IEnumerable<long>
{
public static readonly long[] Value=A094898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094898.Bytes);
public long this[int i]=>Value[i];

public static A094898Inst Instance=new A094898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094899
{
public static readonly long[] Value={ 2L,1L,1L,1L,3L,2L,3L,3L,4L,6L,5L,7L,7L,7L,7L,9L,10L,9L,11L,11L,10L,12L,12L,13L,16L,16L,15L,15L,14L,14L,20L,19L,21L,19L,23L,22L,23L,24L,24L,25L,26L,24L,28L,26L,26L,25L,29L,34L,34L,32L,32L,33L,31L,34L,35L,36L,37L,35L,36L,36L,34L,37L,43L,42L,41L,40L,46L,47L,50L,48L,48L,48L,50L,51L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094899Inst : IEnumerable<long>
{
public static readonly long[] Value=A094899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094899.Bytes);
public long this[int i]=>Value[i];

public static A094899Inst Instance=new A094899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094964
{
public static readonly long[] Value={ 3L,8L,2L,8L,6L,5L,6L,1L,6L,2L,0L,5L,1L,1L,7L,6L,3L,4L,9L,2L,1L,6L,8L,0L,7L,8L,5L,8L,1L,2L,3L,2L,7L,1L,5L,3L,8L,3L,4L,1L,3L,8L,0L,6L,0L,0L,7L,6L,7L,2L,4L,7L,4L,6L,7L,8L,8L,4L,6L,4L,8L,6L,7L,7L,0L,9L,9L,4L,9L,4L,2L,0L,3L,6L,6L,3L,5L,2L,0L,7L,5L,2L,6L,0L,3L,7L,1L,1L,5L,0L,4L,1L,8L,0L,7L,0L,0L,9L,2L,7L,6L,8L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094964Inst : IEnumerable<long>
{
public static readonly long[] Value=A094964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094964.Bytes);
public long this[int i]=>Value[i];

public static A094964Inst Instance=new A094964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094965
{
public static readonly long[] Value={ 2L,1L,2L,6L,6L,7L,1L,4L,1L,1L,0L,7L,5L,2L,9L,7L,4L,2L,8L,2L,4L,4L,4L,3L,0L,8L,0L,6L,3L,7L,2L,1L,0L,0L,0L,8L,4L,1L,8L,7L,4L,2L,8L,9L,0L,6L,8L,3L,9L,7L,8L,2L,5L,2L,8L,4L,6L,2L,5L,2L,2L,4L,5L,6L,4L,3L,6L,3L,9L,5L,2L,8L,2L,3L,9L,3L,0L,3L,6L,9L,0L,3L,6L,8L,5L,4L,9L,8L,8L,0L,3L,4L,3L,9L,5L,3L,3L,0L,1L,1L,6L,9L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094965Inst : IEnumerable<long>
{
public static readonly long[] Value=A094965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094965.Bytes);
public long this[int i]=>Value[i];

public static A094965Inst Instance=new A094965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094966
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,8L,8L,21L,21L,55L,55L,144L,144L,377L,377L,987L,987L,2584L,2584L,6765L,6765L,17711L,17711L,46368L,46368L,121393L,121393L,317811L,317811L,832040L,832040L,2178309L,2178309L,5702887L,5702887L,14930352L,14930352L,39088169L,39088169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094966Inst : IEnumerable<long>
{
public static readonly long[] Value=A094966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094966.Bytes);
public long this[int i]=>Value[i];

public static A094966Inst Instance=new A094966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094967
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,5L,13L,13L,34L,34L,89L,89L,233L,233L,610L,610L,1597L,1597L,4181L,4181L,10946L,10946L,28657L,28657L,75025L,75025L,196418L,196418L,514229L,514229L,1346269L,1346269L,3524578L,3524578L,9227465L,9227465L,24157817L,24157817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094967Inst : IEnumerable<long>
{
public static readonly long[] Value=A094967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094967.Bytes);
public long this[int i]=>Value[i];

public static A094967Inst Instance=new A094967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094968
{
public static readonly long[] Value={ 1L,4L,7L,14L,25L,48L,91L,178L,349L,692L,1375L,2742L,5473L,10936L,21859L,43706L,87397L,174780L,349543L,699070L,1398121L,2796224L,5592427L,11184834L,22369645L,44739268L,89478511L,178956998L,357913969L,715827912L,1431655795L,2863311562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094968Inst : IEnumerable<long>
{
public static readonly long[] Value=A094968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094968.Bytes);
public long this[int i]=>Value[i];

public static A094968Inst Instance=new A094968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094969
{
public static readonly long[] Value={ 1L,2L,6L,15L,39L,97L,244L,610L,1525L,3814L,9536L,23841L,59604L,149011L,372529L,931322L,2328306L,5820766L,14551915L,36379788L,90949470L,227373675L,568434188L,1421085471L,3552713678L,8881784197L,22204460492L,55511151231L,138777878078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094969Inst : IEnumerable<long>
{
public static readonly long[] Value=A094969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094969.Bytes);
public long this[int i]=>Value[i];

public static A094969Inst Instance=new A094969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094970
{
public static readonly long[] Value={ 1L,3L,12L,42L,150L,525L,1838L,6433L,22518L,78815L,275854L,965491L,3379220L,11827271L,41395451L,144884079L,507094277L,1774829971L,6211904899L,21741667147L,76095835015L,266335422555L,932173978944L,3262608926305L,11419131242070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094970Inst : IEnumerable<long>
{
public static readonly long[] Value=A094970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094970.Bytes);
public long this[int i]=>Value[i];

public static A094970Inst Instance=new A094970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094971
{
public static readonly long[] Value={ 1L,4L,20L,91L,410L,1845L,8303L,37366L,168151L,756680L,3405062L,15322783L,68952523L,310286355L,1396288601L,6283298708L,28274844190L,127236798856L,572565594852L,2576545176835L,11594453295761L,52175039830928L,234787679239180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094971Inst : IEnumerable<long>
{
public static readonly long[] Value=A094971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094971.Bytes);
public long this[int i]=>Value[i];

public static A094971Inst Instance=new A094971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094972
{
public static readonly long[] Value={ 1L,5L,30L,166L,915L,5032L,27680L,152243L,837339L,4605366L,25329516L,139312339L,766217865L,4214198259L,23178090428L,127479497357L,701137235467L,3856254795069L,21209401372879L,116651707550839L,641584391529617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094972Inst : IEnumerable<long>
{
public static readonly long[] Value=A094972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094972.Bytes);
public long this[int i]=>Value[i];

public static A094972Inst Instance=new A094972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094973
{
public static readonly long[] Value={ 1L,9L,36L,196L,225L,324L,900L,1225L,4225L,11025L,41616L,53361L,88209L,108900L,176400L,324900L,374544L,1413721L,8643600L,12723489L,43956900L,48024900L,52490025L,158407396L,432224100L,468506025L,846984609L,1631432881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094973Inst : IEnumerable<long>
{
public static readonly long[] Value=A094973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094973.Bytes);
public long this[int i]=>Value[i];

public static A094973Inst Instance=new A094973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094974
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,12L,21L,35L,59L,99L,165L,275L,459L,765L,1276L,2126L,3544L,5907L,9846L,16410L,27351L,45585L,75975L,126625L,211042L,351737L,586229L,977048L,1628414L,2714024L,4523373L,7538956L,12564927L,20941545L,34902576L,58170960L,96951601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094974Inst : IEnumerable<long>
{
public static readonly long[] Value=A094974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094974.Bytes);
public long this[int i]=>Value[i];

public static A094974Inst Instance=new A094974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094975
{
public static readonly long[] Value={ 1L,2L,5L,12L,29L,69L,161L,376L,878L,2050L,4783L,11162L,26044L,60771L,141799L,330865L,772020L,1801380L,4203220L,9807513L,22884198L,53396463L,124591747L,290714077L,678332846L,1582776641L,3693145496L,8617339492L,20107125483L,46916626127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094975Inst : IEnumerable<long>
{
public static readonly long[] Value=A094975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094975.Bytes);
public long this[int i]=>Value[i];

public static A094975Inst Instance=new A094975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094976
{
public static readonly long[] Value={ 1L,2L,7L,18L,50L,134L,359L,958L,2557L,6818L,18183L,48490L,129307L,344820L,919522L,2452059L,6538825L,17436866L,46498311L,123995496L,330654658L,881745755L,2351322014L,6270192038L,16720512102L,44588032273L,118901419396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094976Inst : IEnumerable<long>
{
public static readonly long[] Value=A094976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094976.Bytes);
public long this[int i]=>Value[i];

public static A094976Inst Instance=new A094976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094977
{
public static readonly long[] Value={ 1L,3L,11L,37L,123L,411L,1371L,4572L,15241L,50805L,169350L,564502L,1881676L,6272254L,20907515L,69691719L,232305731L,774352437L,2581174791L,8603915972L,28679719907L,95599066359L,318663554532L,1062211848441L,3540706161472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094977Inst : IEnumerable<long>
{
public static readonly long[] Value=A094977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094977.Bytes);
public long this[int i]=>Value[i];

public static A094977Inst Instance=new A094977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094978
{
public static readonly long[] Value={ 1L,3L,13L,49L,180L,662L,2430L,8910L,32671L,119796L,439252L,1610592L,5905506L,21653524L,79396256L,291119607L,1067438559L,3913941385L,14351118413L,52620767516L,192942814227L,707456985499L,2594008946832L,9511366138386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094978Inst : IEnumerable<long>
{
public static readonly long[] Value=A094978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094978.Bytes);
public long this[int i]=>Value[i];

public static A094978Inst Instance=new A094978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094979
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,3L,4L,5L,7L,9L,11L,14L,18L,22L,28L,35L,44L,55L,69L,86L,108L,135L,169L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094979Inst : IEnumerable<long>
{
public static readonly long[] Value=A094979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094979.Bytes);
public long this[int i]=>Value[i];

public static A094979Inst Instance=new A094979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095044
{
public static readonly long[] Value={ 0L,1L,22L,33L,83L,122L,135L,141L,145L,159L,175L,200L,226L,229L,231L,238L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095044Inst : IEnumerable<long>
{
public static readonly long[] Value=A095044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095044.Bytes);
public long this[int i]=>Value[i];

public static A095044Inst Instance=new A095044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095045
{
public static readonly long[] Value={ 0L,1L,3L,30L,37L,50L,55L,76L,98L,117L,129L,133L,157L,189L,199L,222L,293L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095045Inst : IEnumerable<long>
{
public static readonly long[] Value=A095045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095045.Bytes);
public long this[int i]=>Value[i];

public static A095045Inst Instance=new A095045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095046
{
public static readonly long[] Value={ 0L,1L,19L,28L,96L,118L,151L,153L,176L,202L,240L,254L,290L,296L,300L,307L,337L,361L,366L,369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095046Inst : IEnumerable<long>
{
public static readonly long[] Value=A095046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095046.Bytes);
public long this[int i]=>Value[i];

public static A095046Inst Instance=new A095046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095047
{
public static readonly long[] Value={ 1L,3L,4L,9L,10L,11L,12L,13L,14L,16L,19L,23L,25L,27L,29L,30L,33L,34L,35L,36L,37L,39L,40L,41L,42L,44L,47L,48L,49L,52L,53L,56L,57L,61L,62L,64L,69L,75L,76L,79L,81L,83L,85L,86L,87L,89L,90L,92L,99L,100L,101L,102L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095047Inst : IEnumerable<long>
{
public static readonly long[] Value=A095047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095047.Bytes);
public long this[int i]=>Value[i];

public static A095047Inst Instance=new A095047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095048
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,4L,3L,4L,1L,5L,2L,4L,3L,5L,2L,6L,2L,5L,4L,2L,3L,6L,3L,4L,5L,5L,3L,6L,2L,6L,2L,5L,4L,7L,3L,5L,3L,6L,2L,6L,3L,3L,5L,5L,3L,6L,4L,4L,4L,6L,3L,9L,2L,7L,5L,5L,3L,7L,2L,4L,6L,6L,4L,4L,3L,7L,5L,7L,2L,8L,3L,5L,5L,8L,2L,7L,3L,7L,6L,4L,3L,7L,4L,6L,6L,4L,3L,9L,4L,6L,3L,5L,3L,7L,3L,6L,3L,5L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095048Inst : IEnumerable<long>
{
public static readonly long[] Value=A095048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095048.Bytes);
public long this[int i]=>Value[i];

public static A095048Inst Instance=new A095048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095049
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,2L,5L,4L,6L,6L,10L,6L,10L,9L,9L,9L,10L,9L,10L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095049Inst : IEnumerable<long>
{
public static readonly long[] Value=A095049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095049.Bytes);
public long this[int i]=>Value[i];

public static A095049Inst Instance=new A095049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095050
{
public static readonly long[] Value={ 108L,216L,270L,304L,306L,312L,324L,360L,380L,406L,432L,450L,504L,540L,570L,608L,612L,624L,630L,648L,654L,702L,708L,714L,720L,728L,756L,760L,780L,810L,812L,864L,870L,900L,910L,912L,918L,924L,936L,945L,954L,972L,980L,1008L,1014L,1026L,1032L,1036L,1038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095050Inst : IEnumerable<long>
{
public static readonly long[] Value=A095050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095050.Bytes);
public long this[int i]=>Value[i];

public static A095050Inst Instance=new A095050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095051
{
public static readonly long[] Value={ 1L,0L,3L,8L,69L,384L,4375L,34152L,464457L,5051456L,75865131L,1032865800L,18108977293L,286975230528L,5639956035519L,105513165321704L,2269311347406225L,48066460265622912L,1146324511845384787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095051Inst : IEnumerable<long>
{
public static readonly long[] Value=A095051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095051.Bytes);
public long this[int i]=>Value[i];

public static A095051Inst Instance=new A095051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095052
{
public static readonly long[] Value={ 0L,1L,3L,10L,25L,78L,283L,906L,3044L,10920L,37920L,135182L,487555L,1764216L,6415902L,23585285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095052Inst : IEnumerable<long>
{
public static readonly long[] Value=A095052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095052.Bytes);
public long this[int i]=>Value[i];

public static A095052Inst Instance=new A095052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095053
{
public static readonly long[] Value={ 1L,1L,5L,11L,28L,105L,362L,1093L,3659L,13001L,45171L,159510L,563833L,2008295L,7333827L,26730538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095053Inst : IEnumerable<long>
{
public static readonly long[] Value=A095053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095053.Bytes);
public long this[int i]=>Value[i];

public static A095053Inst Instance=new A095053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095054
{
public static readonly long[] Value={ 1L,2L,2L,4L,7L,10L,20L,32L,65L,97L,203L,334L,718L,1130L,2381L,3953L,8266L,13911L,28995L,49564L,105524L,178910L,376969L,650703L,1383287L,2380394L,5044969L,8780393L,18699214L,32618497L,69349061L,121625616L,259051224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095054Inst : IEnumerable<long>
{
public static readonly long[] Value=A095054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095054.Bytes);
public long this[int i]=>Value[i];

public static A095054Inst Instance=new A095054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095055
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,3L,7L,11L,27L,40L,80L,130L,343L,482L,1180L,1756L,4473L,6479L,15387L,24022L,58714L,89306L,213397L,335115L,802311L,1265350L,2965114L,4781514L,11185644L,18079040L,42048314L,68709969L,159433693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095055Inst : IEnumerable<long>
{
public static readonly long[] Value=A095055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095055.Bytes);
public long this[int i]=>Value[i];

public static A095055Inst Instance=new A095055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095056
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,3L,0L,4L,2L,3L,2L,2L,2L,4L,1L,3L,4L,5L,3L,2L,1L,5L,1L,0L,2L,5L,2L,2L,8L,6L,0L,5L,3L,4L,2L,3L,2L,2L,0L,3L,5L,0L,1L,5L,3L,7L,0L,1L,2L,5L,1L,5L,2L,6L,0L,6L,0L,2L,3L,2L,1L,2L,0L,2L,3L,5L,3L,6L,2L,2L,2L,5L,2L,7L,1L,3L,2L,3L,1L,6L,2L,4L,3L,3L,2L,6L,1L,1L,5L,7L,2L,4L,2L,5L,0L,3L,4L,3L,1L,2L,1L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095056Inst : IEnumerable<long>
{
public static readonly long[] Value=A095056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095056.Bytes);
public long this[int i]=>Value[i];

public static A095056Inst Instance=new A095056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095057
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,5L,4L,10L,6L,13L,11L,9L,16L,16L,18L,25L,15L,19L,15L,37L,17L,37L,29L,29L,32L,40L,23L,49L,31L,51L,39L,37L,30L,52L,46L,40L,42L,62L,43L,57L,42L,68L,52L,78L,60L,89L,54L,63L,59L,92L,58L,79L,82L,99L,73L,87L,47L,99L,74L,72L,81L,106L,56L,102L,85L,117L,85L,97L,64L,132L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095057Inst : IEnumerable<long>
{
public static readonly long[] Value=A095057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095057.Bytes);
public long this[int i]=>Value[i];

public static A095057Inst Instance=new A095057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095058
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,0L,4L,4L,3L,1L,5L,1L,4L,0L,3L,2L,8L,1L,11L,4L,5L,0L,7L,1L,2L,0L,1L,5L,4L,0L,7L,5L,1L,1L,9L,0L,6L,0L,7L,1L,6L,0L,4L,7L,2L,1L,10L,3L,3L,1L,2L,1L,6L,0L,4L,3L,0L,1L,8L,3L,3L,0L,3L,1L,8L,1L,2L,2L,3L,0L,9L,1L,5L,2L,5L,8L,3L,0L,10L,3L,0L,2L,4L,4L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095058Inst : IEnumerable<long>
{
public static readonly long[] Value=A095058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095058.Bytes);
public long this[int i]=>Value[i];

public static A095058Inst Instance=new A095058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095059
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,0L,9L,5L,14L,4L,16L,9L,18L,0L,21L,21L,21L,7L,41L,22L,31L,5L,37L,20L,33L,14L,37L,45L,47L,0L,69L,31L,36L,34L,55L,34L,71L,10L,60L,50L,69L,22L,81L,52L,59L,5L,97L,71L,79L,42L,67L,86L,95L,13L,103L,61L,81L,47L,98L,50L,110L,0L,108L,87L,116L,36L,125L,98L,98L,29L,126L,90L,125L,46L,107L,100L,125L,8L,158L,81L,109L,65L,156L,94L,131L,27L,127L,144L,146L,38L,167L,129L,137L,6L,127L,112L,178L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095059Inst : IEnumerable<long>
{
public static readonly long[] Value=A095059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095059.Bytes);
public long this[int i]=>Value[i];

public static A095059Inst Instance=new A095059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095108
{
public static readonly long[] Value={ 3L,3L,3L,7L,7L,3L,3L,11L,3L,13L,61L,3L,3L,3L,7L,45L,3L,7L,7L,35L,7L,35L,3L,3L,3L,3L,15L,3L,15L,3L,7L,3L,45L,3L,3L,3L,7L,7L,3L,3L,3L,7L,7L,67L,3L,7L,3L,7L,3L,7L,57L,7L,3L,7L,15L,7L,45L,7L,23L,3L,3L,11L,7L,3L,89L,13L,55L,3L,45L,35L,3L,7L,7L,3L,3L,3L,13L,7L,15L,3L,19L,3L,7L,3L,7L,3L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095108Inst : IEnumerable<long>
{
public static readonly long[] Value=A095108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095108.Bytes);
public long this[int i]=>Value[i];

public static A095108Inst Instance=new A095108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095109
{
public static readonly long[] Value={ 0L,0L,0L,3L,13L,40L,194L,389L,1407L,3646L,13300L,39166L,131464L,389575L,1627565L,5556317L,19913811L,72249861L,272188855L,996509475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095109Inst : IEnumerable<long>
{
public static readonly long[] Value=A095109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095109.Bytes);
public long this[int i]=>Value[i];

public static A095109Inst Instance=new A095109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095110
{
public static readonly long[] Value={ 2L,6L,24L,80L,303L,847L,3401L,12816L,47255L,168306L,628058L,2243714L,8741445L,33079519L,125266470L,474015314L,1806320048L,6945673364L,26539784794L,102630867522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095110Inst : IEnumerable<long>
{
public static readonly long[] Value=A095110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095110.Bytes);
public long this[int i]=>Value[i];

public static A095110Inst Instance=new A095110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095111
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095111Inst : IEnumerable<long>
{
public static readonly long[] Value=A095111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095111.Bytes);
public long this[int i]=>Value[i];

public static A095111Inst Instance=new A095111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095112
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,5L,1L,7L,4L,7L,1L,13L,1L,9L,8L,15L,1L,17L,1L,19L,10L,13L,1L,29L,6L,15L,13L,25L,1L,31L,1L,31L,14L,19L,12L,43L,1L,21L,16L,43L,1L,41L,1L,37L,29L,25L,1L,61L,8L,37L,20L,43L,1L,53L,16L,57L,22L,31L,1L,77L,1L,33L,37L,63L,18L,61L,1L,55L,26L,59L,1L,95L,1L,39L,43L,61L,18L,71L,1L,91L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095112Inst : IEnumerable<long>
{
public static readonly long[] Value=A095112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095112.Bytes);
public long this[int i]=>Value[i];

public static A095112Inst Instance=new A095112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095113
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,12L,7L,12L,12L,17L,11L,25L,13L,23L,23L,24L,18L,37L,19L,34L,31L,35L,24L,51L,31L,41L,36L,46L,29L,66L,32L,49L,47L,54L,48L,78L,38L,60L,55L,68L,42L,91L,43L,70L,69L,72L,48L,103L,57L,87L,72L,82L,53L,112L,72L,92L,80L,89L,59L,138L,61L,95L,93L,98L,83L,139L,67L,109L,96L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095113Inst : IEnumerable<long>
{
public static readonly long[] Value=A095113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095113.Bytes);
public long this[int i]=>Value[i];

public static A095113Inst Instance=new A095113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095114
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,16L,20L,24L,29L,34L,39L,45L,51L,57L,63L,70L,77L,84L,91L,99L,107L,115L,123L,132L,141L,150L,159L,168L,178L,188L,198L,208L,218L,229L,240L,251L,262L,273L,285L,297L,309L,321L,333L,345L,358L,371L,384L,397L,410L,423L,437L,451L,465L,479L,493L,507L,522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095114Inst : IEnumerable<long>
{
public static readonly long[] Value=A095114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095114.Bytes);
public long this[int i]=>Value[i];

public static A095114Inst Instance=new A095114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095115
{
public static readonly long[] Value={ 1L,3L,7L,12L,18L,10L,19L,30L,17L,31L,16L,36L,57L,35L,58L,34L,59L,33L,60L,32L,61L,98L,136L,97L,137L,96L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095115Inst : IEnumerable<long>
{
public static readonly long[] Value=A095115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095115.Bytes);
public long this[int i]=>Value[i];

public static A095115Inst Instance=new A095115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095116
{
public static readonly long[] Value={ 2L,4L,7L,10L,15L,18L,23L,26L,31L,38L,41L,48L,53L,56L,61L,68L,75L,78L,85L,90L,93L,100L,105L,112L,121L,126L,129L,134L,137L,142L,157L,162L,169L,172L,183L,186L,193L,200L,205L,212L,219L,222L,233L,236L,241L,244L,257L,270L,275L,278L,283L,290L,293L,304L,311L,318L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095116Inst : IEnumerable<long>
{
public static readonly long[] Value=A095116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095116.Bytes);
public long this[int i]=>Value[i];

public static A095116Inst Instance=new A095116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095117
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,8L,9L,11L,12L,13L,14L,16L,17L,19L,20L,21L,22L,24L,25L,27L,28L,29L,30L,32L,33L,34L,35L,36L,37L,39L,40L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,54L,55L,57L,58L,59L,60L,62L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,74L,76L,77L,79L,80L,81L,82L,83L,84L,86L,87L,88L,89L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095117Inst : IEnumerable<long>
{
public static readonly long[] Value=A095117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095117.Bytes);
public long this[int i]=>Value[i];

public static A095117Inst Instance=new A095117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095118
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,5L,1L,5L,10L,5L,1L,14L,1L,5L,10L,21L,1L,14L,1L,21L,10L,5L,1L,30L,26L,5L,10L,21L,1L,39L,1L,21L,10L,5L,26L,66L,1L,5L,10L,46L,1L,50L,1L,21L,35L,5L,1L,66L,50L,30L,10L,21L,1L,50L,26L,70L,10L,5L,1L,91L,1L,5L,59L,85L,26L,50L,1L,21L,10L,79L,1L,130L,1L,5L,35L,21L,50L,50L,1L,110L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095118Inst : IEnumerable<long>
{
public static readonly long[] Value=A095118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095118.Bytes);
public long this[int i]=>Value[i];

public static A095118Inst Instance=new A095118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095119
{
public static readonly long[] Value={ 1L,840L,900L,1080L,1225L,1260L,1440L,1600L,1680L,1800L,1848L,1890L,1980L,2016L,2100L,2160L,2340L,2400L,2520L,2640L,2700L,2772L,2800L,2880L,2970L,3024L,3080L,3120L,3136L,3150L,3240L,3276L,3300L,3360L,3465L,3528L,3600L,3640L,3696L,3780L,3900L,3960L,3969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095119Inst : IEnumerable<long>
{
public static readonly long[] Value=A095119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095119.Bytes);
public long this[int i]=>Value[i];

public static A095119Inst Instance=new A095119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095120
{
public static readonly long[] Value={ 3L,19L,101L,409L,1531L,5507L,19273L,65677L,220859L,733559L,2412763L,7867543L,25485179L,82064011L,262960069L,839001707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095120Inst : IEnumerable<long>
{
public static readonly long[] Value=A095120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095120.Bytes);
public long this[int i]=>Value[i];

public static A095120Inst Instance=new A095120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095121
{
public static readonly long[] Value={ 1L,2L,6L,14L,30L,62L,126L,254L,510L,1022L,2046L,4094L,8190L,16382L,32766L,65534L,131070L,262142L,524286L,1048574L,2097150L,4194302L,8388606L,16777214L,33554430L,67108862L,134217726L,268435454L,536870910L,1073741822L,2147483646L,4294967294L,8589934590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095121Inst : IEnumerable<long>
{
public static readonly long[] Value=A095121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095121.Bytes);
public long this[int i]=>Value[i];

public static A095121Inst Instance=new A095121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095122
{
public static readonly long[] Value={ 0L,1L,1L,6L,15L,45L,120L,325L,861L,2278L,5995L,15753L,41328L,108345L,283881L,743590L,1947351L,5099221L,13351528L,34957341L,91523685L,239618886L,627341331L,1642418641L,4299936480L,11257426225L,29472399505L,77159865030L,202007345631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095122Inst : IEnumerable<long>
{
public static readonly long[] Value=A095122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095122.Bytes);
public long this[int i]=>Value[i];

public static A095122Inst Instance=new A095122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095123
{
public static readonly long[] Value={ 1L,-3L,0L,8L,-9L,3L,8L,-27L,24L,19L,-48L,24L,17L,-54L,57L,46L,-147L,51L,145L,-222L,123L,160L,-459L,315L,306L,-678L,360L,326L,-870L,633L,612L,-1581L,723L,1286L,-2301L,1242L,1522L,-3864L,2451L,2455L,-5478L,2934L,2924L,-7044L,4599L,4622L,-11271L,5514L,8133L,-15591L,8508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095123Inst : IEnumerable<long>
{
public static readonly long[] Value=A095123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095123.Bytes);
public long this[int i]=>Value[i];

public static A095123Inst Instance=new A095123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095156
{
public static readonly long[] Value={ 6L,4L,3L,21L,2L,15L,13L,12L,11L,10L,9L,8L,72L,7L,63L,6L,56L,53L,51L,5L,46L,44L,42L,41L,4L,38L,36L,35L,34L,33L,32L,31L,3L,29L,28L,271L,27L,26L,251L,25L,24L,233L,23L,223L,22L,213L,21L,205L,201L,2L,193L,19L,186L,182L,18L,176L,173L,17L,167L,164L,162L,16L,157L,154L,152L,15L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095156Inst : IEnumerable<long>
{
public static readonly long[] Value=A095156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095156.Bytes);
public long this[int i]=>Value[i];

public static A095156Inst Instance=new A095156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095157
{
public static readonly long[] Value={ 11L,2L,30L,4L,50L,6L,70L,8L,90L,10L,116L,124L,132L,144L,156L,164L,172L,182L,192L,204L,214L,228L,234L,246L,252L,266L,274L,282L,294L,306L,3110L,328L,332L,348L,352L,3614L,372L,3810L,394L,4016L,418L,4214L,432L,444L,456L,4618L,4712L,486L,4924L,506L,514L,528L,5340L,546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095157Inst : IEnumerable<long>
{
public static readonly long[] Value=A095157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095157.Bytes);
public long this[int i]=>Value[i];

public static A095157Inst Instance=new A095157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095158
{
public static readonly long[] Value={ 1L,24L,39L,420L,540L,657L,720L,848L,976L,10175L,11200L,1296L,1328L,14212L,15164L,16384L,17220L,1821L,19200L,2019L,21180L,2217L,23160L,2415L,25140L,2613L,27120L,2811L,29100L,3009L,31080L,3207L,33060L,3405L,35040L,3603L,37020L,3801L,39000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095158Inst : IEnumerable<long>
{
public static readonly long[] Value=A095158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095158.Bytes);
public long this[int i]=>Value[i];

public static A095158Inst Instance=new A095158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095159
{
public static readonly long[] Value={ 1L,2L,-5L,28L,-81L,704L,-325L,768L,-20825L,311296L,-83349L,1507328L,-1334025L,3145728L,-5337189L,130023424L,-1366504425L,7516192768L,-5466528925L,12884901888L,-87470372561L,2954937499648L,-349899121845L,12919261626368L,-22394407746529L,52776558133248L,-89580335298125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095159Inst : IEnumerable<long>
{
public static readonly long[] Value=A095159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095159.Bytes);
public long this[int i]=>Value[i];

public static A095159Inst Instance=new A095159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095160
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,18L,24L,25L,33L,36L,38L,48L,49L,52L,56L,66L,67L,70L,72L,74L,76L,78L,129L,132L,133L,136L,137L,144L,146L,148L,164L,176L,177L,192L,193L,194L,195L,264L,265L,266L,267L,274L,288L,289L,290L,292L,294L,304L,320L,322L,328L,388L,392L,393L,416L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095160Inst : IEnumerable<long>
{
public static readonly long[] Value=A095160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095160.Bytes);
public long this[int i]=>Value[i];

public static A095160Inst Instance=new A095160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095161
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,3L,5L,4L,5L,4L,5L,4L,5L,6L,5L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,9L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,12L,11L,12L,11L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095161Inst : IEnumerable<long>
{
public static readonly long[] Value=A095161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095161.Bytes);
public long this[int i]=>Value[i];

public static A095161Inst Instance=new A095161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095162
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,15L,17L,26L,31L,42L,49L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095162Inst : IEnumerable<long>
{
public static readonly long[] Value=A095162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095162.Bytes);
public long this[int i]=>Value[i];

public static A095162Inst Instance=new A095162Inst();

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