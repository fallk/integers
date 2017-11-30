using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A093967
{
public static readonly long[] Value={ 0L,1L,4L,15L,48L,145L,420L,1183L,3264L,8865L,23780L,63151L,166320L,434993L,1130948L,2925375L,7533312L,19323713L,49395780L,125877071L,319888560L,810893265L,2050891876L,5176349663L,13040153280L,32793453025L,82337215012L,206424991215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093967Inst : IEnumerable<long>
{
public static readonly long[] Value=A093967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093967.Bytes);
public long this[int i]=>Value[i];

public static A093967Inst Instance=new A093967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093968
{
public static readonly long[] Value={ 0L,1L,2L,6L,8L,20L,24L,56L,64L,144L,160L,352L,384L,832L,896L,1920L,2048L,4352L,4608L,9728L,10240L,21504L,22528L,47104L,49152L,102400L,106496L,221184L,229376L,475136L,491520L,1015808L,1048576L,2162688L,2228224L,4587520L,4718592L,9699328L,9961472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093968Inst : IEnumerable<long>
{
public static readonly long[] Value=A093968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093968.Bytes);
public long this[int i]=>Value[i];

public static A093968Inst Instance=new A093968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093969
{
public static readonly long[] Value={ 0L,1L,0L,3L,8L,25L,72L,203L,560L,1521L,4080L,10835L,28536L,74633L,194040L,501915L,1292512L,3315425L,8474976L,21597091L,54884200L,139127289L,351877416L,888121195L,2237336592L,5626467025L,14126832720L,35416929267L,88670846936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093969Inst : IEnumerable<long>
{
public static readonly long[] Value=A093969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093969.Bytes);
public long this[int i]=>Value[i];

public static A093969Inst Instance=new A093969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093970
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,21L,31L,55L,99L,145L,252L,430L,620L,1042L,1786L,2597L,4304L,7241L,10374L,17098L,28967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093970Inst : IEnumerable<long>
{
public static readonly long[] Value=A093970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093970.Bytes);
public long this[int i]=>Value[i];

public static A093970Inst Instance=new A093970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093971
{
public static readonly long[] Value={ 0L,1L,2L,7L,16L,40L,86L,195L,404L,873L,1795L,3727L,7585L,15537L,31368L,63582L,127933L,257746L,517312L,1038993L,2081696L,4173322L,8355792L,16731799L,33484323L,67014365L,134069494L,268234688L,536562699L,1073326281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093971Inst : IEnumerable<long>
{
public static readonly long[] Value=A093971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093971.Bytes);
public long this[int i]=>Value[i];

public static A093971Inst Instance=new A093971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094004
{
public static readonly long[] Value={ 1L,4L,5L,8L,9L,14L,15L,66L,68L,70L,123L,124L,125L,132L,133L,134L,135L,136L,138L,139L,140L,142L,143L,144L,145L,146L,147L,148L,149L,150L,151L,152L,153L,154L,155L,156L,157L,158L,159L,160L,161L,162L,163L,164L,165L,166L,167L,179L,180L,181L,182L,183L,184L,185L,186L,187L,188L,189L,190L,191L,192L,193L,194L,195L,196L,197L,198L,200L,201L,202L,203L,204L,205L,206L,207L,209L,250L,251L,252L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094004Inst : IEnumerable<long>
{
public static readonly long[] Value=A094004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094004.Bytes);
public long this[int i]=>Value[i];

public static A094004Inst Instance=new A094004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094005
{
public static readonly long[] Value={ 2L,11L,30L,82L,199L,480L,1097L,2630L,5828L,12830L,27873L,60071L,128355L,273543L,580149L,1226626L,2584822L,5433676L,11392986L,23838396L,49776503L,103755527L,215904926L,448602871L,930771041L,1928682932L,3991605129L,8251710234L,17040335019L,35154540729L,72456654860L,149208536983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094005Inst : IEnumerable<long>
{
public static readonly long[] Value=A094005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094005.Bytes);
public long this[int i]=>Value[i];

public static A094005Inst Instance=new A094005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094006
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,1L,1L,2L,3L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,2L,2L,3L,4L,1L,1L,1L,2L,3L,1L,1L,1L,2L,3L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,2L,2L,3L,4L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,2L,2L,3L,4L,1L,2L,2L,2L,2L,3L,4L,1L,2L,2L,2L,2L,3L,4L,2L,3L,1L,1L,1L,2L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094006Inst : IEnumerable<long>
{
public static readonly long[] Value=A094006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094006.Bytes);
public long this[int i]=>Value[i];

public static A094006Inst Instance=new A094006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094007
{
public static readonly long[] Value={ 3L,5L,8L,14L,20L,35L,41L,65L,239L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094007Inst : IEnumerable<long>
{
public static readonly long[] Value=A094007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094007.Bytes);
public long this[int i]=>Value[i];

public static A094007Inst Instance=new A094007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094008
{
public static readonly BigInteger[] Value={ 3L,7L,71L,18089L,10391023L,781379079653017L,2111421691000680031L,BigInteger.Parse("1430286763442005122380663256416207") };
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
public class A094008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094008Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094008.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094008.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094008Inst Instance=new A094008Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094009
{
public static readonly long[] Value={ 1L,3L,7L,5L,10L,12L,33L,38L,47L,39L,67L,37L,120L,71L,189L,568L,119L,411L,952L,909L,1438L,1215L,2107L,3435L,10644L,4390L,19154L,12144L,21458L,27294L,54773L,104306L,115552L,46620L,112657L,100468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094009Inst : IEnumerable<long>
{
public static readonly long[] Value=A094009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094009.Bytes);
public long this[int i]=>Value[i];

public static A094009Inst Instance=new A094009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094010
{
public static readonly long[] Value={ 6L,7L,9L,11L,15L,19L,40L,54L,38L,67L,63L,56L,37L,69L,352L,236L,258L,600L,1234L,979L,901L,3384L,2268L,4675L,5087L,5820L,3184L,12294L,41082L,25557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094010Inst : IEnumerable<long>
{
public static readonly long[] Value=A094010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094010.Bytes);
public long this[int i]=>Value[i];

public static A094010Inst Instance=new A094010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094011
{
public static readonly long[] Value={ 3L,6L,6L,6L,10L,6L,6L,6L,12L,6L,9L,6L,6L,12L,6L,6L,6L,6L,12L,12L,6L,6L,6L,6L,6L,6L,12L,6L,12L,6L,6L,6L,6L,12L,12L,6L,6L,6L,6L,6L,9L,6L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,6L,12L,15L,6L,6L,6L,12L,6L,6L,6L,6L,6L,12L,6L,6L,6L,9L,6L,9L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,6L,10L,12L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094011Inst : IEnumerable<long>
{
public static readonly long[] Value=A094011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094011.Bytes);
public long this[int i]=>Value[i];

public static A094011Inst Instance=new A094011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094012
{
public static readonly long[] Value={ 0L,1L,2L,6L,24L,100L,408L,1624L,6336L,24336L,92320L,346720L,1291392L,4776512L,17562496L,64245120L,233969664L,848748800L,3068269056L,11057710592L,39740405760L,142466343936L,509572929536L,1818872207360L,6480018948096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094012Inst : IEnumerable<long>
{
public static readonly long[] Value=A094012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094012.Bytes);
public long this[int i]=>Value[i];

public static A094012Inst Instance=new A094012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094013
{
public static readonly long[] Value={ 1L,0L,4L,16L,80L,384L,1856L,8960L,43264L,208896L,1008640L,4870144L,23515136L,113541120L,548225024L,2647064576L,12781158400L,61712891904L,297976201216L,1438756372480L,6946930294784L,33542746669056L,161958707855360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094013Inst : IEnumerable<long>
{
public static readonly long[] Value=A094013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094013.Bytes);
public long this[int i]=>Value[i];

public static A094013Inst Instance=new A094013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094014
{
public static readonly long[] Value={ 1L,-2L,8L,-16L,64L,-128L,512L,-1024L,4096L,-8192L,32768L,-65536L,262144L,-524288L,2097152L,-4194304L,16777216L,-33554432L,134217728L,-268435456L,1073741824L,-2147483648L,8589934592L,-17179869184L,68719476736L,-137438953472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094014Inst : IEnumerable<long>
{
public static readonly long[] Value=A094014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094014.Bytes);
public long this[int i]=>Value[i];

public static A094014Inst Instance=new A094014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094015
{
public static readonly long[] Value={ 1L,4L,8L,32L,64L,256L,512L,2048L,4096L,16384L,32768L,131072L,262144L,1048576L,2097152L,8388608L,16777216L,67108864L,134217728L,536870912L,1073741824L,4294967296L,8589934592L,34359738368L,68719476736L,274877906944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094015Inst : IEnumerable<long>
{
public static readonly long[] Value=A094015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094015.Bytes);
public long this[int i]=>Value[i];

public static A094015Inst Instance=new A094015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094016
{
public static readonly long[] Value={ 5L,10L,11L,13L,22L,25L,29L,31L,32L,36L,41L,47L,49L,50L,52L,54L,57L,60L,67L,69L,72L,76L,79L,88L,90L,92L,98L,99L,102L,104L,105L,107L,109L,110L,112L,113L,121L,122L,125L,130L,135L,141L,143L,144L,148L,150L,151L,154L,160L,163L,165L,168L,170L,171L,174L,179L,182L,184L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094016Inst : IEnumerable<long>
{
public static readonly long[] Value=A094016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094016.Bytes);
public long this[int i]=>Value[i];

public static A094016Inst Instance=new A094016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094017
{
public static readonly long[] Value={ 2L,3L,4L,5L,5L,7L,10L,10L,7L,9L,7L,5L,13L,15L,15L,15L,17L,17L,15L,17L,18L,17L,29L,21L,17L,28L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094017Inst : IEnumerable<long>
{
public static readonly long[] Value=A094017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094017.Bytes);
public long this[int i]=>Value[i];

public static A094017Inst Instance=new A094017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094018
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,10L,13L,15L,17L,18L,29L,31L,36L,42L,45L,46L,50L,66L,75L,78L,80L,86L,129L,132L,134L,140L,156L,165L,169L,170L,174L,189L,267L,293L,298L,323L,389L,394L,521L,535L,542L,553L,557L,594L,606L,611L,618L,717L,771L,812L,914L,1030L,1043L,1064L,1069L,1113L,1118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094018Inst : IEnumerable<long>
{
public static readonly long[] Value=A094018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094018.Bytes);
public long this[int i]=>Value[i];

public static A094018Inst Instance=new A094018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094019
{
public static readonly long[] Value={ 2L,5L,7L,10L,14L,17L,21L,24L,28L,32L,36L,40L,44L,48L,53L,57L,62L,66L,71L,76L,80L,85L,90L,95L,100L,105L,110L,115L,120L,125L,130L,135L,140L,146L,151L,156L,162L,167L,172L,178L,183L,189L,194L,200L,206L,211L,217L,222L,228L,234L,239L,245L,251L,257L,262L,268L,274L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094019Inst : IEnumerable<long>
{
public static readonly long[] Value=A094019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094019.Bytes);
public long this[int i]=>Value[i];

public static A094019Inst Instance=new A094019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094068
{
public static readonly long[] Value={ 3L,29L,107L,239L,281L,857L,1061L,1151L,1619L,1667L,1721L,2267L,2339L,2801L,2999L,3167L,3257L,3467L,3557L,4271L,4337L,4547L,4799L,4931L,5279L,5501L,5849L,5867L,6359L,6659L,6689L,7349L,8009L,8219L,8231L,8387L,9857L,10007L,10859L,13001L,13691L,15269L,15971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094068Inst : IEnumerable<long>
{
public static readonly long[] Value=A094068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094068.Bytes);
public long this[int i]=>Value[i];

public static A094068Inst Instance=new A094068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094069
{
public static readonly long[] Value={ 7L,13L,37L,79L,349L,397L,457L,613L,769L,1213L,1429L,1783L,2347L,2377L,2473L,3907L,4129L,4513L,4783L,5437L,5647L,7477L,7603L,7879L,8803L,9829L,10429L,10453L,10627L,11443L,11863L,11923L,12109L,13033L,13099L,13327L,14173L,14779L,15679L,16057L,16069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094069Inst : IEnumerable<long>
{
public static readonly long[] Value=A094069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094069.Bytes);
public long this[int i]=>Value[i];

public static A094069Inst Instance=new A094069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094070
{
public static readonly BigInteger[] Value={ 1L,4L,20L,150L,1352L,15428L,203464L,3162960L,55405140L,1101298600L,24222234720L,590544046744L,15715973012248L,456341011254560L,14312979247985120L,484253161428902192L,17550722413456774848UL,BigInteger.Parse("680244627812139042016") };
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
public class A094070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094070Inst Instance=new A094070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094071
{
public static readonly BigInteger[] Value={ 1L,2L,10L,75L,572L,6293L,92962L,1395180L,25482135L,582310475L,13697614020L,364311810217L,11551145067139L,380339218683310L,13636394439014770L,563142483841155427L,BigInteger.Parse("24264229405883569164"),BigInteger.Parse("1114389674994185476663") };
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
public class A094071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094071.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094071Inst Instance=new A094071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094072
{
public static readonly BigInteger[] Value={ 1L,6L,50L,615L,10192L,214571L,5544394L,171367020L,6208928376L,259542887975L,12356823485580L,662921411131909L,39714830070598204L,2636484537372437498L,BigInteger.Parse("192653800829700013970"),BigInteger.Parse("15405383160836582657251") };
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
public class A094072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094072.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094072Inst Instance=new A094072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094073
{
public static readonly BigInteger[] Value={ 4L,240L,49938L,24608160L,23465221750L,38341895571708L,98780305524248572L,BigInteger.Parse("377796303580335320432"),BigInteger.Parse("2048907276496726375662702"),BigInteger.Parse("15198414983297581845761672560"),BigInteger.Parse("149768511689247547252666676150490") };
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
public class A094073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094073Inst Instance=new A094073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094074
{
public static readonly BigInteger[] Value={ 1L,5L,129L,7485L,755265L,116338005L,25263540225L,7328358482445L,2730934406225025L,1269262202389906725L,BigInteger.Parse("718835160819268317825"),BigInteger.Parse("486853691847850902700125"),BigInteger.Parse("388278919916351519293663425") };
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
public class A094074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094074Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094074.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094074.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094074Inst Instance=new A094074Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094075
{
public static readonly long[] Value={ 105L,13440L,229635L,1720320L,8203125L,29393280L,86472015L,220200960L,502211745L,1050000000L,2046152955L,3762339840L,6588594285L,11068417920L,17940234375L,28185722880L,43085560665L,64283103360L,93856532595L,134400000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094075Inst : IEnumerable<long>
{
public static readonly long[] Value=A094075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094075.Bytes);
public long this[int i]=>Value[i];

public static A094075Inst Instance=new A094075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094076
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,2L,3L,1L,4L,2L,1L,2L,5L,3L,1L,8L,2L,1L,4L,2L,7L,3L,2L,1L,2L,1L,2L,7L,2L,3L,1L,10L,1L,4L,4L,2L,5L,3L,1L,4L,1L,2L,1L,6L,4L,2L,1L,2L,3L,1L,4L,5L,9L,3L,1L,20L,2L,1L,6L,7L,2L,1L,2L,5L,4L,4L,1L,2L,27L,3L,4L,4L,2L,15L,3L,2L,3L,10L,1L,8L,1L,4L,2L,7L,3L,2L,1L,2L,5L,3L,2L,3L,2L,7L,5L,1L,6L,4L,4L,9L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094076Inst : IEnumerable<long>
{
public static readonly long[] Value=A094076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094076.Bytes);
public long this[int i]=>Value[i];

public static A094076Inst Instance=new A094076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094077
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,10L,5L,13L,7L,17L,8L,20L,9L,23L,11L,27L,12L,30L,14L,34L,15L,37L,16L,40L,18L,44L,19L,47L,21L,51L,22L,54L,24L,58L,25L,61L,26L,64L,28L,68L,29L,71L,31L,75L,32L,78L,33L,81L,35L,85L,36L,88L,38L,92L,39L,95L,41L,99L,42L,102L,43L,105L,45L,109L,46L,112L,48L,116L,49L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094077Inst : IEnumerable<long>
{
public static readonly long[] Value=A094077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094077.Bytes);
public long this[int i]=>Value[i];

public static A094077Inst Instance=new A094077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094078
{
public static readonly long[] Value={ 4L,6L,6L,9L,2L,0L,1L,9L,3L,1L,8L,5L,9L,9L,0L,7L,7L,3L,1L,5L,5L,8L,8L,5L,2L,6L,2L,6L,0L,8L,2L,3L,9L,7L,8L,7L,4L,5L,5L,7L,3L,1L,5L,7L,1L,2L,5L,4L,9L,3L,2L,2L,9L,8L,0L,1L,2L,6L,8L,7L,1L,9L,7L,4L,3L,6L,0L,8L,5L,1L,7L,6L,6L,1L,2L,1L,9L,2L,2L,6L,2L,5L,4L,2L,5L,9L,0L,4L,6L,9L,9L,2L,7L,3L,1L,4L,8L,8L,0L,9L,1L,0L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094078Inst : IEnumerable<long>
{
public static readonly long[] Value=A094078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094078.Bytes);
public long this[int i]=>Value[i];

public static A094078Inst Instance=new A094078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094079
{
public static readonly long[] Value={ 5L,13L,25L,37L,41L,85L,65L,61L,85L,125L,101L,149L,113L,205L,173L,145L,145L,277L,265L,181L,197L,269L,377L,221L,293L,257L,317L,505L,265L,457L,433L,409L,365L,313L,569L,601L,493L,425L,365L,493L,445L,401L,557L,485L,421L,709L,641L,881L,533L,485L,481L,877L,785L,809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094079Inst : IEnumerable<long>
{
public static readonly long[] Value=A094079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094079.Bytes);
public long this[int i]=>Value[i];

public static A094079Inst Instance=new A094079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094080
{
public static readonly long[] Value={ 7L,17L,31L,47L,49L,113L,79L,71L,97L,161L,119L,191L,127L,271L,217L,167L,161L,367L,343L,199L,223L,329L,497L,241L,353L,287L,383L,673L,287L,593L,553L,511L,433L,337L,751L,791L,623L,503L,391L,607L,521L,439L,697L,569L,449L,919L,809L,1169L,617L,527L,511L,1153L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094080Inst : IEnumerable<long>
{
public static readonly long[] Value=A094080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094080.Bytes);
public long this[int i]=>Value[i];

public static A094080Inst Instance=new A094080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094081
{
public static readonly long[] Value={ 5L,185L,1313L,4925L,13325L,29585L,57545L,101813L,167765L,261545L,390065L,561005L,782813L,1064705L,1416665L,1849445L,2374565L,3004313L,3751745L,4630685L,5655725L,6842225L,8206313L,9764885L,11535605L,13536905L,15787985L,18308813L,21120125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094081Inst : IEnumerable<long>
{
public static readonly long[] Value=A094081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094081.Bytes);
public long this[int i]=>Value[i];

public static A094081Inst Instance=new A094081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094082
{
public static readonly long[] Value={ 1L,8L,7L,9L,8L,5L,3L,8L,6L,2L,1L,7L,5L,2L,5L,8L,5L,3L,3L,4L,8L,6L,3L,0L,6L,1L,4L,5L,0L,7L,0L,9L,6L,0L,0L,3L,8L,8L,1L,9L,8L,7L,3L,4L,0L,0L,4L,8L,9L,2L,8L,9L,9L,0L,4L,8L,2L,9L,6L,1L,7L,6L,6L,9L,1L,2L,2L,2L,9L,6L,3L,8L,6L,6L,6L,1L,2L,1L,4L,2L,1L,1L,3L,6L,1L,7L,6L,5L,0L,1L,9L,7L,3L,8L,9L,1L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094082Inst : IEnumerable<long>
{
public static readonly long[] Value=A094082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094082.Bytes);
public long this[int i]=>Value[i];

public static A094082Inst Instance=new A094082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094083
{
public static readonly long[] Value={ 1L,1L,1L,4L,9L,64L,25L,256L,1225L,16384L,3969L,65536L,53361L,1048576L,184041L,4194304L,41409225L,1073741824L,147744025L,4294967296L,2133423721L,68719476736L,7775536041L,274877906944L,457028729521L,17592186044416L,1690195005625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094083Inst : IEnumerable<long>
{
public static readonly long[] Value=A094083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094083.Bytes);
public long this[int i]=>Value[i];

public static A094083Inst Instance=new A094083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094100
{
public static readonly long[] Value={ 1L,-2L,9L,-64L,560L,-5370L,53788L,-555864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094100Inst : IEnumerable<long>
{
public static readonly long[] Value=A094100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094100.Bytes);
public long this[int i]=>Value[i];

public static A094100Inst Instance=new A094100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094101
{
public static readonly long[] Value={ 1L,16L,360L,9104L,246020L,6940128L,201819688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094101Inst : IEnumerable<long>
{
public static readonly long[] Value=A094101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094101.Bytes);
public long this[int i]=>Value[i];

public static A094101Inst Instance=new A094101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094102
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,3L,2L,1L,1L,1L,1L,2L,3L,5L,3L,2L,1L,1L,1L,1L,2L,3L,5L,8L,5L,3L,2L,1L,1L,1L,1L,2L,3L,5L,8L,13L,8L,5L,3L,2L,1L,1L,1L,1L,2L,3L,5L,8L,13L,21L,13L,8L,5L,3L,2L,1L,1L,1L,1L,2L,3L,5L,8L,13L,21L,34L,21L,13L,8L,5L,3L,2L,1L,1L,1L,1L,2L,3L,5L,8L,13L,21L,34L,55L,34L,21L,13L,8L,5L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094102Inst : IEnumerable<long>
{
public static readonly long[] Value=A094102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094102.Bytes);
public long this[int i]=>Value[i];

public static A094102Inst Instance=new A094102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094103
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,8L,9L,13L,16L,22L,26L,37L,43L,60L,71L,98L,115L,160L,187L,259L,304L,420L,492L,681L,797L,1102L,1291L,1784L,2089L,2888L,3381L,4673L,5472L,7562L,8854L,12237L,14327L,19800L,23183L,32038L,37511L,51840L,60695L,83879L,98208L,135720L,158904L,219601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094103Inst : IEnumerable<long>
{
public static readonly long[] Value=A094103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094103.Bytes);
public long this[int i]=>Value[i];

public static A094103Inst Instance=new A094103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094104
{
public static readonly long[] Value={ 7L,11L,17L,43L,53L,61L,89L,179L,241L,313L,331L,353L,449L,593L,673L,683L,691L,719L,733L,809L,859L,1021L,1051L,1237L,1259L,1321L,1481L,1709L,1741L,1933L,1979L,2083L,2111L,2137L,2221L,2237L,2311L,2333L,2371L,2473L,2531L,2741L,2767L,2957L,3163L,3469L,3643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094104Inst : IEnumerable<long>
{
public static readonly long[] Value=A094104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094104.Bytes);
public long this[int i]=>Value[i];

public static A094104Inst Instance=new A094104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094105
{
public static readonly long[] Value={ 13L,19L,29L,37L,47L,127L,137L,181L,283L,307L,317L,367L,389L,541L,563L,577L,587L,677L,743L,811L,839L,907L,929L,937L,947L,1031L,1093L,1283L,1297L,1453L,1489L,1567L,1801L,1847L,1913L,2027L,2347L,2381L,2467L,2477L,2617L,2647L,2657L,2729L,2749L,2777L,2803L,2819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094105Inst : IEnumerable<long>
{
public static readonly long[] Value=A094105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094105.Bytes);
public long this[int i]=>Value[i];

public static A094105Inst Instance=new A094105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094106
{
public static readonly long[] Value={ 8L,7L,8L,5L,10L,12L,16L,14L,18L,22L,24L,26L,27L,28L,34L,35L,37L,39L,40L,45L,43L,46L,49L,51L,55L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094106Inst : IEnumerable<long>
{
public static readonly long[] Value=A094106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094106.Bytes);
public long this[int i]=>Value[i];

public static A094106Inst Instance=new A094106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094107
{
public static readonly long[] Value={ 5L,11L,53L,61L,103L,151L,173L,271L,277L,347L,503L,541L,557L,593L,733L,853L,1291L,1427L,1493L,1663L,1907L,2411L,2543L,2677L,2713L,2797L,2903L,3061L,3163L,3253L,3313L,3463L,3511L,3631L,3727L,4021L,4127L,4211L,4391L,4457L,4561L,4657L,4871L,4937L,5101L,5743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094107Inst : IEnumerable<long>
{
public static readonly long[] Value=A094107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094107.Bytes);
public long this[int i]=>Value[i];

public static A094107Inst Instance=new A094107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094108
{
public static readonly BigInteger[] Value={ 5L,11L,127L,5051L,BigInteger.Parse("4470115461512684340891257138125051110076800700282905015819080092370422104067183317016903680000000000000079") };
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
public class A094108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094108Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094108.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094108.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094108Inst Instance=new A094108Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094109
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,8L,12L,15L,17L,21L,24L,28L,34L,39L,44L,48L,54L,57L,61L,64L,68L,74L,79L,84L,90L,92L,96L,100L,101L,103L,107L,111L,114L,118L,124L,129L,134L,140L,143L,149L,154L,158L,164L,169L,174L,180L,185L,191L,195L,199L,204L,208L,214L,219L,224L,230L,235L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094109Inst : IEnumerable<long>
{
public static readonly long[] Value=A094109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094109.Bytes);
public long this[int i]=>Value[i];

public static A094109Inst Instance=new A094109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094110
{
public static readonly long[] Value={ 1L,3L,8L,13L,21L,30L,36L,45L,54L,63L,73L,85L,95L,105L,119L,137L,158L,178L,200L,210L,223L,244L,263L,283L,304L,320L,338L,361L,381L,402L,416L,434L,455L,475L,497L,519L,538L,560L,576L,597L,619L,637L,658L,678L,700L,712L,730L,748L,770L,789L,811L,829L,851L,871L,893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094110Inst : IEnumerable<long>
{
public static readonly long[] Value=A094110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094110.Bytes);
public long this[int i]=>Value[i];

public static A094110Inst Instance=new A094110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094111
{
public static readonly long[] Value={ 1L,2L,6L,9L,13L,19L,26L,34L,46L,57L,70L,81L,94L,113L,123L,137L,151L,168L,184L,205L,217L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094111Inst : IEnumerable<long>
{
public static readonly long[] Value=A094111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094111.Bytes);
public long this[int i]=>Value[i];

public static A094111Inst Instance=new A094111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094112
{
public static readonly long[] Value={ 1L,0L,2L,0L,3L,3L,0L,12L,8L,4L,0L,60L,40L,15L,5L,0L,360L,240L,90L,24L,6L,0L,2520L,1680L,630L,168L,35L,7L,0L,20160L,13440L,5040L,1344L,280L,48L,8L,0L,181440L,120960L,45360L,12096L,2520L,432L,63L,9L,0L,1814400L,1209600L,453600L,120960L,25200L,4320L,630L,80L,10L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094112Inst : IEnumerable<long>
{
public static readonly long[] Value=A094112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094112.Bytes);
public long this[int i]=>Value[i];

public static A094112Inst Instance=new A094112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094113
{
public static readonly long[] Value={ 1L,7L,44L,268L,1609L,9583L,56792L,335448L,1976689L,11627735L,68308580L,400870468L,2350563097L,13773547487L,80663415344L,472175746096L,2762854639585L,16160861104423L,94502471413916L,552472329537660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094113Inst : IEnumerable<long>
{
public static readonly long[] Value=A094113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094113.Bytes);
public long this[int i]=>Value[i];

public static A094113Inst Instance=new A094113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094114
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,2L,0L,1L,0L,4L,3L,4L,2L,3L,2L,4L,3L,4L,0L,1L,0L,2L,1L,2L,0L,1L,0L,8L,7L,8L,6L,7L,6L,8L,7L,8L,4L,5L,4L,6L,5L,6L,4L,5L,4L,8L,7L,8L,6L,7L,6L,8L,7L,8L,0L,1L,0L,2L,1L,2L,0L,1L,0L,4L,3L,4L,2L,3L,2L,4L,3L,4L,0L,1L,0L,2L,1L,2L,0L,1L,0L,16L,15L,16L,14L,15L,14L,16L,15L,16L,12L,13L,12L,14L,13L,14L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094114Inst : IEnumerable<long>
{
public static readonly long[] Value=A094114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094114.Bytes);
public long this[int i]=>Value[i];

public static A094114Inst Instance=new A094114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094115
{
public static readonly long[] Value={ 0L,1L,1L,4L,6L,9L,9L,10L,10L,19L,27L,36L,42L,49L,55L,64L,72L,81L,81L,82L,82L,85L,87L,90L,90L,91L,91L,118L,144L,171L,195L,220L,244L,271L,297L,324L,342L,361L,379L,400L,420L,441L,459L,478L,496L,523L,549L,576L,600L,625L,649L,676L,702L,729L,729L,730L,730L,733L,735L,738L,738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094115Inst : IEnumerable<long>
{
public static readonly long[] Value=A094115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094115.Bytes);
public long this[int i]=>Value[i];

public static A094115Inst Instance=new A094115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094132
{
public static readonly long[] Value={ 9L,7L,9L,5L,3L,6L,5L,7L,8L,7L,5L,7L,8L,5L,2L,5L,7L,2L,6L,7L,0L,2L,5L,3L,8L,3L,8L,3L,8L,4L,4L,6L,4L,9L,7L,6L,9L,5L,4L,5L,2L,0L,4L,7L,2L,9L,4L,4L,2L,4L,5L,6L,8L,9L,1L,0L,8L,4L,4L,6L,3L,1L,5L,9L,1L,7L,8L,6L,0L,9L,6L,6L,4L,1L,0L,1L,7L,5L,5L,4L,3L,6L,6L,8L,9L,5L,1L,0L,3L,8L,2L,7L,6L,0L,5L,5L,7L,9L,7L,3L,2L,4L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094132Inst : IEnumerable<long>
{
public static readonly long[] Value=A094132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094132.Bytes);
public long this[int i]=>Value[i];

public static A094132Inst Instance=new A094132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094133
{
public static readonly BigInteger[] Value={ 3L,17L,593L,32993L,2097593L,8589935681L,59604644783353249L,BigInteger.Parse("523347633027360537213687137"),BigInteger.Parse("43143988327398957279342419750374600193"),BigInteger.Parse("4318114567396436564035293097707729426477458833"),BigInteger.Parse("5052785737795758503064406447721934417290878968063369478337") };
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
public class A094133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094133Inst Instance=new A094133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094134
{
public static readonly long[] Value={ 9L,7L,1L,4L,6L,8L,9L,4L,4L,5L,5L,0L,7L,8L,9L,0L,1L,4L,3L,5L,2L,3L,9L,7L,7L,8L,8L,1L,4L,8L,5L,2L,7L,7L,7L,7L,4L,7L,5L,7L,3L,3L,5L,3L,5L,0L,6L,8L,7L,5L,0L,9L,9L,2L,8L,4L,8L,6L,6L,8L,0L,3L,4L,3L,4L,8L,5L,9L,2L,4L,7L,4L,5L,6L,2L,2L,5L,2L,9L,5L,9L,3L,5L,4L,0L,5L,4L,7L,8L,4L,8L,1L,5L,6L,4L,1L,8L,1L,7L,7L,8L,4L,9L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094134Inst : IEnumerable<long>
{
public static readonly long[] Value=A094134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094134.Bytes);
public long this[int i]=>Value[i];

public static A094134Inst Instance=new A094134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094135
{
public static readonly long[] Value={ 9L,8L,2L,0L,7L,1L,4L,2L,8L,2L,6L,5L,9L,9L,1L,4L,8L,8L,3L,3L,6L,9L,0L,6L,9L,5L,4L,7L,7L,4L,6L,1L,4L,8L,0L,5L,6L,6L,2L,5L,1L,6L,3L,8L,0L,9L,4L,0L,1L,7L,0L,4L,6L,5L,4L,0L,1L,6L,3L,6L,7L,3L,2L,7L,7L,3L,1L,9L,8L,0L,7L,0L,0L,9L,9L,1L,2L,7L,6L,2L,9L,6L,5L,3L,6L,5L,2L,3L,6L,8L,6L,6L,1L,6L,3L,7L,1L,2L,2L,9L,7L,0L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094135Inst : IEnumerable<long>
{
public static readonly long[] Value=A094135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094135.Bytes);
public long this[int i]=>Value[i];

public static A094135Inst Instance=new A094135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094136
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,3L,7L,1L,1L,9L,9L,3L,1L,5L,11L,3L,1L,5L,13L,1L,13L,3L,7L,1L,5L,15L,3L,7L,1L,17L,5L,17L,17L,1L,7L,9L,5L,3L,1L,7L,19L,19L,5L,3L,1L,7L,21L,9L,21L,21L,1L,11L,7L,23L,5L,9L,3L,1L,23L,23L,7L,5L,3L,1L,25L,7L,11L,25L,25L,5L,13L,9L,1L,7L,11L,5L,3L,9L,1L,27L,29L,7L,11L,29L,3L,1L,29L,29L,7L,29L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094136Inst : IEnumerable<long>
{
public static readonly long[] Value=A094136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094136.Bytes);
public long this[int i]=>Value[i];

public static A094136Inst Instance=new A094136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094137
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,5L,1L,5L,6L,2L,1L,7L,7L,8L,2L,8L,8L,9L,3L,9L,1L,10L,11L,10L,11L,1L,11L,12L,11L,4L,12L,3L,2L,12L,13L,14L,13L,13L,13L,14L,2L,1L,14L,14L,14L,15L,4L,16L,2L,1L,15L,17L,16L,5L,16L,17L,16L,16L,2L,1L,17L,17L,17L,17L,4L,18L,19L,3L,2L,18L,20L,19L,18L,19L,20L,19L,19L,20L,19L,1L,7L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094137Inst : IEnumerable<long>
{
public static readonly long[] Value=A094137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094137.Bytes);
public long this[int i]=>Value[i];

public static A094137Inst Instance=new A094137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094138
{
public static readonly long[] Value={ 2L,3L,4L,6L,5L,8L,8L,6L,7L,11L,10L,10L,8L,13L,13L,11L,9L,14L,16L,10L,14L,13L,18L,11L,16L,16L,14L,19L,12L,21L,17L,20L,19L,13L,20L,23L,18L,16L,14L,21L,21L,20L,19L,17L,15L,22L,25L,25L,23L,22L,16L,28L,23L,28L,21L,26L,19L,17L,25L,24L,24L,22L,20L,18L,29L,25L,30L,28L,27L,23L,33L,28L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094138Inst : IEnumerable<long>
{
public static readonly long[] Value=A094138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094138.Bytes);
public long this[int i]=>Value[i];

public static A094138Inst Instance=new A094138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094139
{
public static readonly long[] Value={ 9L,8L,4L,0L,4L,7L,5L,1L,2L,1L,1L,3L,1L,5L,4L,1L,1L,7L,0L,5L,6L,7L,5L,3L,3L,2L,1L,2L,9L,7L,8L,2L,7L,8L,8L,4L,0L,4L,3L,5L,8L,1L,6L,8L,2L,2L,6L,3L,4L,4L,5L,2L,7L,2L,8L,9L,8L,0L,2L,6L,2L,3L,0L,1L,4L,9L,0L,4L,1L,7L,9L,4L,5L,1L,6L,3L,5L,6L,8L,3L,2L,0L,6L,1L,6L,8L,3L,4L,4L,0L,7L,8L,0L,2L,4L,3L,4L,8L,8L,9L,4L,1L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094139Inst : IEnumerable<long>
{
public static readonly long[] Value=A094139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094139.Bytes);
public long this[int i]=>Value[i];

public static A094139Inst Instance=new A094139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094140
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,14L,7L,5L,6L,18L,9L,21L,7L,33L,22L,11L,8L,45L,39L,9L,13L,30L,60L,10L,30L,15L,33L,84L,11L,68L,60L,51L,34L,12L,91L,95L,65L,39L,13L,57L,38L,19L,70L,42L,14L,105L,84L,144L,42L,21L,15L,138L,112L,115L,80L,92L,48L,16L,46L,23L,119L,85L,51L,17L,100L,126L,209L,75L,50L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094140Inst : IEnumerable<long>
{
public static readonly long[] Value=A094140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094140.Bytes);
public long this[int i]=>Value[i];

public static A094140Inst Instance=new A094140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094141
{
public static readonly long[] Value={ 9L,8L,5L,6L,3L,1L,2L,4L,1L,6L,6L,7L,3L,8L,3L,9L,4L,5L,5L,2L,7L,2L,4L,8L,3L,8L,8L,7L,3L,1L,3L,2L,3L,9L,7L,6L,4L,0L,0L,2L,8L,4L,1L,6L,6L,0L,9L,5L,5L,2L,0L,7L,9L,9L,9L,5L,8L,3L,4L,1L,4L,6L,8L,9L,3L,0L,5L,6L,2L,4L,1L,9L,4L,7L,1L,5L,5L,6L,1L,1L,7L,6L,3L,3L,7L,9L,1L,7L,8L,0L,9L,1L,3L,3L,4L,4L,7L,2L,2L,3L,9L,3L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094141Inst : IEnumerable<long>
{
public static readonly long[] Value=A094141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094141.Bytes);
public long this[int i]=>Value[i];

public static A094141Inst Instance=new A094141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094142
{
public static readonly long[] Value={ 6L,15L,28L,42L,45L,99L,72L,66L,91L,143L,110L,170L,120L,238L,195L,156L,153L,322L,304L,190L,210L,299L,437L,231L,323L,272L,350L,589L,276L,525L,493L,460L,399L,325L,660L,696L,558L,464L,378L,550L,483L,420L,627L,527L,435L,814L,725L,1025L,575L,506L,496L,1015L,897L,924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094142Inst : IEnumerable<long>
{
public static readonly long[] Value=A094142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094142.Bytes);
public long this[int i]=>Value[i];

public static A094142Inst Instance=new A094142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094143
{
public static readonly long[] Value={ 6L,30L,84L,210L,180L,1386L,504L,330L,546L,2574L,990L,3570L,840L,7854L,4290L,1716L,1224L,14490L,11856L,1710L,2730L,8970L,26220L,2310L,9690L,4080L,11550L,49476L,3036L,35700L,29580L,23460L,13566L,3900L,60060L,66120L,36270L,18096L,4914L,31350L,18354L,7980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094143Inst : IEnumerable<long>
{
public static readonly long[] Value=A094143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094143.Bytes);
public long this[int i]=>Value[i];

public static A094143Inst Instance=new A094143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094144
{
public static readonly long[] Value={ 5L,7L,15L,17L,19L,51L,73L,89L,131L,153L,245L,333L,441L,463L,825L,1771L,2027L,9157L,10875L,20515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094144Inst : IEnumerable<long>
{
public static readonly long[] Value=A094144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094144.Bytes);
public long this[int i]=>Value[i];

public static A094144Inst Instance=new A094144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094145
{
public static readonly long[] Value={ 9L,8L,6L,9L,2L,8L,9L,1L,6L,0L,5L,4L,9L,8L,9L,9L,1L,9L,2L,7L,9L,3L,3L,8L,7L,1L,7L,9L,5L,3L,9L,2L,1L,3L,4L,9L,4L,0L,5L,2L,9L,5L,4L,1L,5L,9L,6L,7L,1L,3L,4L,7L,5L,4L,7L,0L,7L,2L,7L,2L,1L,3L,9L,9L,2L,9L,1L,5L,2L,5L,0L,4L,2L,9L,6L,3L,1L,8L,9L,6L,5L,3L,9L,9L,2L,6L,2L,6L,5L,5L,0L,9L,7L,7L,4L,1L,8L,4L,5L,0L,3L,0L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094145Inst : IEnumerable<long>
{
public static readonly long[] Value=A094145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094145.Bytes);
public long this[int i]=>Value[i];

public static A094145Inst Instance=new A094145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094146
{
public static readonly long[] Value={ 9L,8L,8L,0L,1L,1L,6L,1L,6L,3L,9L,2L,8L,1L,3L,2L,9L,1L,5L,8L,2L,4L,3L,9L,9L,0L,4L,6L,2L,3L,9L,0L,0L,7L,8L,9L,8L,6L,1L,9L,5L,1L,3L,4L,7L,1L,6L,9L,3L,5L,9L,9L,9L,2L,6L,2L,4L,5L,1L,7L,3L,9L,9L,6L,7L,9L,5L,6L,3L,1L,7L,4L,2L,8L,3L,2L,1L,3L,7L,7L,2L,8L,3L,9L,9L,7L,0L,5L,3L,3L,5L,7L,7L,9L,2L,7L,7L,0L,0L,9L,2L,1L,7L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094146Inst : IEnumerable<long>
{
public static readonly long[] Value=A094146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094146.Bytes);
public long this[int i]=>Value[i];

public static A094146Inst Instance=new A094146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094147
{
public static readonly long[] Value={ 2L,8L,18L,20L,32L,50L,72L,80L,90L,98L,128L,162L,180L,200L,242L,272L,288L,320L,338L,360L,392L,450L,468L,500L,512L,578L,648L,650L,720L,722L,800L,810L,882L,968L,980L,1058L,1088L,1152L,1250L,1280L,1332L,1352L,1440L,1458L,1568L,1620L,1682L,1800L,1872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094147Inst : IEnumerable<long>
{
public static readonly long[] Value=A094147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094147.Bytes);
public long this[int i]=>Value[i];

public static A094147Inst Instance=new A094147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094212
{
public static readonly long[] Value={ 1L,2L,12872L,1470944L,622116992L,125858012672L,36758056208384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094212Inst : IEnumerable<long>
{
public static readonly long[] Value=A094212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094212.Bytes);
public long this[int i]=>Value[i];

public static A094212Inst Instance=new A094212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094213
{
public static readonly BigInteger[] Value={ 1L,2L,48622L,9373652L,9263421862L,3433541316152L,2140802758677844L,984101481334553024L,BigInteger.Parse("536617781178725122150"),BigInteger.Parse("265166261617029717011822"),BigInteger.Parse("138567978655457801631498052"),BigInteger.Parse("70126939586658252408697345838") };
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
public class A094213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094213Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094213.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094213Inst Instance=new A094213Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094214
{
public static readonly long[] Value={ 6L,1L,8L,0L,3L,3L,9L,8L,8L,7L,4L,9L,8L,9L,4L,8L,4L,8L,2L,0L,4L,5L,8L,6L,8L,3L,4L,3L,6L,5L,6L,3L,8L,1L,1L,7L,7L,2L,0L,3L,0L,9L,1L,7L,9L,8L,0L,5L,7L,6L,2L,8L,6L,2L,1L,3L,5L,4L,4L,8L,6L,2L,2L,7L,0L,5L,2L,6L,0L,4L,6L,2L,8L,1L,8L,9L,0L,2L,4L,4L,9L,7L,0L,7L,2L,0L,7L,2L,0L,4L,1L,8L,9L,3L,9L,1L,1L,3L,7L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094214Inst : IEnumerable<long>
{
public static readonly long[] Value=A094214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094214.Bytes);
public long this[int i]=>Value[i];

public static A094214Inst Instance=new A094214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094215
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,3L,2L,1L,1L,1L,0L,1L,1L,2L,2L,2L,3L,2L,3L,2L,1L,2L,2L,2L,3L,3L,3L,2L,1L,1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,3L,3L,3L,2L,2L,2L,2L,3L,3L,3L,4L,3L,3L,2L,1L,1L,1L,0L,1L,1L,2L,2L,2L,3L,3L,4L,3L,3L,4L,3L,3L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094215Inst : IEnumerable<long>
{
public static readonly long[] Value=A094215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094215.Bytes);
public long this[int i]=>Value[i];

public static A094215Inst Instance=new A094215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094216
{
public static readonly long[] Value={ 1L,1L,2L,7L,8L,3L,6L,38L,93L,111L,65L,15L,24L,226L,874L,1821L,2224L,1600L,630L,105L,120L,1524L,8200L,24860L,47185L,58465L,47474L,24430L,7245L,945L,720L,11628L,81080L,326712L,852690L,1522375L,1905168L,1676325L,1018682L,407925L,97020L,10395L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094216Inst : IEnumerable<long>
{
public static readonly long[] Value=A094216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094216.Bytes);
public long this[int i]=>Value[i];

public static A094216Inst Instance=new A094216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094217
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094217Inst : IEnumerable<long>
{
public static readonly long[] Value=A094217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094217.Bytes);
public long this[int i]=>Value[i];

public static A094217Inst Instance=new A094217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094218
{
public static readonly long[] Value={ 0L,0L,0L,2L,25L,198L,1274L,7280L,38556L,193800L,937992L,4412826L,20309575L,91861770L,409704750L,1806342720L,7887861960L,34166674800L,146977222320L,628521016500L,2673950235138L,11324837666604L,47773836727540L,200828153398752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094218Inst : IEnumerable<long>
{
public static readonly long[] Value=A094218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094218.Bytes);
public long this[int i]=>Value[i];

public static A094218Inst Instance=new A094218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094219
{
public static readonly long[] Value={ 0L,0L,0L,0L,7L,112L,1092L,8400L,56100L,341088L,1939938L,10498488L,54679625L,276276000L,1362040680L,6580248480L,31256180280L,146350008000L,676868787000L,3097351569312L,14042319855102L,63144549413792L,281895309883000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094219Inst : IEnumerable<long>
{
public static readonly long[] Value=A094219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094219.Bytes);
public long this[int i]=>Value[i];

public static A094219Inst Instance=new A094219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094220
{
public static readonly long[] Value={ 199L,243051733L,498161423L,2490123989L,5417375591L,8785408259L,8988840499L,10385475431L,11283287357L,14384731703L,18012540899L,18346623637L,21848966327L,25708013101L,26160970331L,26230852979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094220Inst : IEnumerable<long>
{
public static readonly long[] Value=A094220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094220.Bytes);
public long this[int i]=>Value[i];

public static A094220Inst Instance=new A094220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094221
{
public static readonly BigInteger[] Value={ 1L,-2L,-180L,2808000L,63248290560000L,BigInteger.Parse("-13040516214928232110080000"),BigInteger.Parse("-173699422048124050990739961787485511680000"),BigInteger.Parse("1013027110717881203216509560866301885575342298295136595148800000") };
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
public class A094221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094221Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094221.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094221.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094221Inst Instance=new A094221Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094222
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,14L,16L,17L,18L,20L,22L,24L,26L,28L,30L,33L,35L,37L,38L,40L,42L,45L,47L,48L,50L,52L,54L,56L,58L,60L,63L,65L,67L,68L,70L,73L,74L,76L,78L,81L,82L,84L,87L,89L,90L,93L,95L,97L,98L,100L,102L,105L,108L,110L,113L,114L,117L,119L,121L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094222Inst : IEnumerable<long>
{
public static readonly long[] Value=A094222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094222.Bytes);
public long this[int i]=>Value[i];

public static A094222Inst Instance=new A094222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094223
{
public static readonly BigInteger[] Value={ 1L,2L,7L,68L,2251L,247016L,89254228L,108168781424L,451141297789858L,6625037125817801312L,BigInteger.Parse("348562672319990399962384"),BigInteger.Parse("66545827618461283102105245248"),BigInteger.Parse("46543235997095840080425299916917968") };
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
public class A094223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094223.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094223Inst Instance=new A094223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094224
{
public static readonly long[] Value={ 18L,28L,6L,6L,58L,22L,13L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094224Inst : IEnumerable<long>
{
public static readonly long[] Value=A094224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094224.Bytes);
public long this[int i]=>Value[i];

public static A094224Inst Instance=new A094224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094225
{
public static readonly long[] Value={ 1L,2L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094225Inst : IEnumerable<long>
{
public static readonly long[] Value=A094225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094225.Bytes);
public long this[int i]=>Value[i];

public static A094225Inst Instance=new A094225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094226
{
public static readonly long[] Value={ 4L,6L,11L,13L,17L,19L,23L,28L,30L,36L,41L,43L,46L,53L,59L,61L,67L,71L,72L,79L,83L,88L,97L,101L,103L,106L,108L,113L,127L,130L,137L,138L,149L,151L,156L,163L,167L,173L,178L,181L,191L,193L,197L,198L,211L,223L,227L,229L,232L,239L,240L,250L,257L,262L,268L,271L,276L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094226Inst : IEnumerable<long>
{
public static readonly long[] Value=A094226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094226.Bytes);
public long this[int i]=>Value[i];

public static A094226Inst Instance=new A094226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094227
{
public static readonly long[] Value={ 0L,1L,3L,5L,8L,10L,13L,15L,18L,21L,24L,27L,30L,33L,36L,40L,43L,46L,50L,53L,57L,61L,64L,68L,72L,75L,79L,83L,87L,91L,95L,99L,102L,106L,111L,115L,119L,123L,127L,131L,135L,139L,144L,148L,152L,157L,161L,165L,170L,174L,178L,183L,187L,192L,196L,201L,205L,210L,214L,219L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094227Inst : IEnumerable<long>
{
public static readonly long[] Value=A094227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094227.Bytes);
public long this[int i]=>Value[i];

public static A094227Inst Instance=new A094227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094244
{
public static readonly long[] Value={ 4L,1L,3L,1L,0L,0L,6L,1L,6L,6L,0L,2L,7L,9L,5L,3L,9L,9L,1L,9L,4L,0L,6L,8L,6L,1L,8L,9L,0L,5L,6L,1L,2L,0L,4L,4L,9L,6L,4L,4L,0L,9L,6L,2L,3L,8L,4L,8L,8L,4L,0L,2L,0L,9L,9L,5L,2L,9L,7L,7L,3L,0L,6L,1L,8L,8L,8L,1L,4L,3L,2L,9L,3L,6L,5L,9L,3L,3L,0L,0L,1L,0L,9L,2L,2L,9L,6L,5L,4L,5L,6L,0L,0L,8L,7L,4L,6L,7L,2L,8L,1L,4L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094244Inst : IEnumerable<long>
{
public static readonly long[] Value=A094244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094244.Bytes);
public long this[int i]=>Value[i];

public static A094244Inst Instance=new A094244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094245
{
public static readonly long[] Value={ 5L,5L,4L,6L,7L,3L,2L,5L,8L,8L,9L,9L,4L,5L,5L,3L,0L,1L,4L,4L,9L,7L,1L,5L,9L,5L,2L,4L,0L,0L,0L,1L,7L,0L,3L,8L,7L,3L,1L,9L,1L,1L,2L,6L,4L,0L,4L,1L,3L,4L,7L,1L,0L,0L,8L,8L,9L,6L,3L,1L,4L,9L,4L,6L,2L,5L,1L,1L,4L,8L,9L,2L,6L,0L,2L,6L,0L,0L,3L,3L,6L,2L,7L,4L,6L,3L,7L,9L,9L,6L,1L,3L,2L,9L,9L,4L,7L,2L,4L,2L,5L,3L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094245Inst : IEnumerable<long>
{
public static readonly long[] Value=A094245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094245.Bytes);
public long this[int i]=>Value[i];

public static A094245Inst Instance=new A094245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094246
{
public static readonly long[] Value={ 1L,2L,2L,2L,7L,4L,7L,6L,8L,4L,4L,7L,3L,3L,1L,5L,8L,7L,0L,1L,0L,9L,6L,2L,4L,4L,8L,5L,0L,1L,6L,4L,8L,4L,1L,3L,8L,6L,0L,6L,6L,6L,6L,1L,7L,9L,5L,2L,7L,7L,1L,9L,8L,6L,7L,4L,7L,3L,8L,9L,2L,9L,9L,9L,6L,2L,9L,1L,6L,1L,0L,2L,0L,9L,8L,3L,8L,9L,3L,9L,7L,7L,2L,1L,7L,9L,0L,7L,1L,1L,8L,7L,8L,8L,3L,2L,9L,3L,7L,2L,7L,2L,2L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094246Inst : IEnumerable<long>
{
public static readonly long[] Value=A094246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094246.Bytes);
public long this[int i]=>Value[i];

public static A094246Inst Instance=new A094246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094247
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,1L,0L,0L,-1L,1L,-1L,0L,0L,2L,0L,0L,-1L,2L,-1L,0L,-1L,0L,0L,0L,0L,1L,-2L,0L,0L,2L,0L,0L,-1L,0L,-2L,0L,-1L,2L,0L,0L,-1L,2L,0L,0L,0L,1L,0L,0L,0L,1L,-1L,0L,-2L,2L,0L,0L,0L,0L,-2L,0L,0L,2L,0L,0L,-1L,2L,0L,0L,-2L,0L,0L,0L,-1L,2L,-2L,0L,0L,0L,0L,0L,-1L,1L,-2L,0L,0L,2L,0L,0L,0L,2L,-1L,0L,0L,0L,0L,0L,0L,2L,-1L,0L,-1L,2L,0L,0L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094247Inst : IEnumerable<long>
{
public static readonly long[] Value=A094247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094247.Bytes);
public long this[int i]=>Value[i];

public static A094247Inst Instance=new A094247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094248
{
public static readonly long[] Value={ 1L,7L,7L,19L,49L,73L,193L,391L,751L,1747L,3457L,7249L,15649L,31783L,67543L,141811L,294001L,621337L,1297057L,2712679L,5700799L,11910643L,24964993L,52325281L,109483201L,229475527L,480592807L,1006367059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094248Inst : IEnumerable<long>
{
public static readonly long[] Value=A094248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094248.Bytes);
public long this[int i]=>Value[i];

public static A094248Inst Instance=new A094248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094249
{
public static readonly long[] Value={ 53L,353L,433L,733L,1609L,7789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094249Inst : IEnumerable<long>
{
public static readonly long[] Value=A094249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094249.Bytes);
public long this[int i]=>Value[i];

public static A094249Inst Instance=new A094249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094250
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,7L,1L,3L,8L,15L,1L,3L,9L,22L,31L,1L,3L,10L,31L,63L,63L,1L,3L,11L,42L,117L,185L,127L,1L,3L,12L,55L,199L,459L,550L,255L,1L,3L,13L,70L,315L,981L,1825L,1644L,511L,1L,3L,14L,87L,471L,1871L,4888L,7287L,4925L,1023L,1L,3L,15L,106L,673L,3273L,11203L,24420L,29133L,14767L,2047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094250Inst : IEnumerable<long>
{
public static readonly long[] Value=A094250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094250.Bytes);
public long this[int i]=>Value[i];

public static A094250Inst Instance=new A094250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094251
{
public static readonly long[] Value={ 0L,0L,2L,18L,104L,580L,3282L,19236L,117672L,753048L,5041880L,35283402L,257718540L,1961679824L,15534932350L,127788932430L,1090212468512L,9632275777296L,88013486026710L,830637659785996L,8087069127986020L,81132805319035260L,837852685505824120L,8897619270153977254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094251Inst : IEnumerable<long>
{
public static readonly long[] Value=A094251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094251.Bytes);
public long this[int i]=>Value[i];

public static A094251Inst Instance=new A094251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094252
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,15L,3L,7L,13L,25L,3L,19L,6L,35L,19L,2L,19L,21L,59L,62L,54L,10L,62L,18L,12L,23L,80L,96L,67L,111L,96L,5L,78L,132L,8L,128L,98L,123L,143L,12L,141L,40L,98L,90L,88L,53L,93L,97L,187L,186L,47L,2L,117L,241L,34L,27L,51L,266L,108L,259L,115L,278L,30L,281L,227L,244L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094252Inst : IEnumerable<long>
{
public static readonly long[] Value=A094252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094252.Bytes);
public long this[int i]=>Value[i];

public static A094252Inst Instance=new A094252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094253
{
public static readonly long[] Value={ 1L,8L,20L,120L,496L,2304L,10240L,46208L,207360L,932352L,4189184L,18827264L,84606976L,380223488L,1708703744L,7678853120L,34508439552L,155079540736L,696921096192L,3131935031296L,14074788184064L,63251524091904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094253Inst : IEnumerable<long>
{
public static readonly long[] Value=A094253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094253.Bytes);
public long this[int i]=>Value[i];

public static A094253Inst Instance=new A094253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094254
{
public static readonly long[] Value={ 1L,2L,20L,128L,752L,4352L,25088L,144512L,832256L,4792832L,27600896L,158947328L,915341312L,5271240704L,30355865600L,174812463104L,1006704852992L,5797382193152L,33385793454080L,192261121900544L,1107187673858048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094254Inst : IEnumerable<long>
{
public static readonly long[] Value=A094254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094254.Bytes);
public long this[int i]=>Value[i];

public static A094254Inst Instance=new A094254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094255
{
public static readonly long[] Value={ 1L,4L,9L,28L,75L,211L,577L,1591L,4367L,12004L,32975L,90607L,248931L,683946L,1879112L,5162835L,14184754L,38972316L,107075529L,294187633L,808273837L,2220714167L,6101361970L,16763354312L,46056937364L,126540395519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094255Inst : IEnumerable<long>
{
public static readonly long[] Value=A094255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094255.Bytes);
public long this[int i]=>Value[i];

public static A094255Inst Instance=new A094255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094256
{
public static readonly long[] Value={ 1L,7L,34L,143L,560L,2108L,7752L,28101L,100947L,360526L,1282735L,4552624L,16131656L,57099056L,201962057L,714012495L,2523515514L,8916942687L,31504028992L,111295205284L,393151913464L,1388758662221L,4905479957435L,17327203698086L,61202661233823L,216176614077600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094256Inst : IEnumerable<long>
{
public static readonly long[] Value=A094256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094256.Bytes);
public long this[int i]=>Value[i];

public static A094256Inst Instance=new A094256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094257
{
public static readonly BigInteger[] Value={ 1L,7L,175L,3423L,65807L,1263367L,24251423L,465522687L,8936020191L,171532889927L,3292688640591L,63205362446303L,1213269239181167L,23289515157668039L,447057832476812095L,8581574336168940799L,BigInteger.Parse("164729063528963009727") };
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
public class A094257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094257Inst Instance=new A094257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094258
{
public static readonly BigInteger[] Value={ 1L,1L,4L,18L,96L,600L,4320L,35280L,322560L,3265920L,36288000L,439084800L,5748019200L,80951270400L,1220496076800L,19615115520000L,334764638208000L,6046686277632000L,115242726703104000L,2311256907767808000L,BigInteger.Parse("48658040163532800000"),BigInteger.Parse("1072909785605898240000"),BigInteger.Parse("24728016011107368960000"),BigInteger.Parse("594596384994354462720000") };
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
public class A094258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094258Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094258.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094258.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094258Inst Instance=new A094258Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}