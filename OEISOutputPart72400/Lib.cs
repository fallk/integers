using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190900
{
public static readonly long[] Value={ 2L,5L,7L,8L,13L,14L,19L,20L,23L,26L,29L,30L,32L,35L,39L,41L,46L,50L,52L,53L,62L,63L,65L,74L,77L,92L,95L,104L,107L,109L,110L,116L,119L,128L,158L,159L,170L,173L,182L,185L,221L,248L,251L,317L,545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190900Inst : IEnumerable<long>
{
public static readonly long[] Value=A190900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190900.Bytes);
public long this[int i]=>Value[i];

public static A190900Inst Instance=new A190900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190901
{
public static readonly BigInteger[] Value={ 1L,1L,8L,15L,384L,945L,46080L,135135L,10321920L,34459425L,3715891200L,13749310575L,1961990553600L,7905853580625L,1428329123020800L,6190283353629375L,1371195958099968000L,6332659870762850625L,BigInteger.Parse("1678343852714360832000") };
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
public class A190901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190901Inst Instance=new A190901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190902
{
public static readonly long[] Value={ 1L,-2L,-3L,0L,-5L,36L,-7L,0L,0L,100L,-11L,0L,-13L,196L,225L,0L,-17L,0L,-19L,0L,441L,484L,-23L,0L,0L,676L,0L,0L,-29L,810000L,-31L,0L,1089L,1156L,1225L,0L,-37L,1444L,1521L,0L,-41L,3111696L,-43L,0L,0L,2116L,-47L,0L,0L,0L,2601L,0L,-53L,0L,3025L,0L,3249L,3364L,-59L,0L,-61L,3844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190902Inst : IEnumerable<long>
{
public static readonly long[] Value=A190902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190902.Bytes);
public long this[int i]=>Value[i];

public static A190902Inst Instance=new A190902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190903
{
public static readonly BigInteger[] Value={ 1L,1L,10L,162L,280L,12320L,524880L,1106560L,96342400L,7142567040L,17041024000L,2324549427200L,254561089305600L,664565853952000L,126757680265216000L,BigInteger.Parse("18763697892715776000"),BigInteger.Parse("52580450364682240000"),BigInteger.Parse("13106744139423334400000") };
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
public class A190903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190903Inst Instance=new A190903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190904
{
public static readonly long[] Value={ 1L,1L,1L,0L,-3L,-12L,-27L,0L,441L,3024L,11529L,0L,-442827L,-4390848L,-23444883L,0L,1636819569L,21224560896L,145703137041L,0L,-16106380394643L,-257991277243392L,-2164638920874507L,0L,347592265948756521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190904Inst : IEnumerable<long>
{
public static readonly long[] Value=A190904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190904.Bytes);
public long this[int i]=>Value[i];

public static A190904Inst Instance=new A190904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190905
{
public static readonly long[] Value={ 1L,1L,3L,9L,18L,60L,117L,371L,747L,2199L,4697L,12735L,28571L,72815L,169176L,412440L,978086L,2316754L,5547293L,12909723L,30966639L,71357601L,170636159L,391242623L,930120982L,2128073530L,5023630830L,11486060090L,26918052717L,61539213693L,143227189518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190905Inst : IEnumerable<long>
{
public static readonly long[] Value=A190905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190905.Bytes);
public long this[int i]=>Value[i];

public static A190905Inst Instance=new A190905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190906
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,1L,1L,1L,9L,9L,9L,3L,3L,3L,9L,9L,9L,1L,1L,1L,3L,3L,3L,1L,1L,1L,27L,27L,27L,9L,9L,9L,27L,27L,27L,3L,3L,3L,9L,9L,9L,3L,3L,3L,27L,27L,27L,9L,9L,9L,27L,27L,27L,1L,1L,1L,3L,3L,3L,1L,1L,1L,9L,9L,9L,3L,3L,3L,9L,9L,9L,1L,1L,1L,3L,3L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190906Inst : IEnumerable<long>
{
public static readonly long[] Value=A190906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190906.Bytes);
public long this[int i]=>Value[i];

public static A190906Inst Instance=new A190906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190907
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,5L,3L,1L,10L,15L,21L,2L,1L,15L,35L,84L,18L,10L,1L,21L,70L,252L,90L,110L,5L,1L,28L,126L,630L,330L,660L,65L,35L,1L,36L,210L,1386L,990L,2860L,455L,525L,14L,1L,45L,330L,2772L,2574L,10010L,2275L,4200L,238L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190907Inst : IEnumerable<long>
{
public static readonly long[] Value=A190907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190907.Bytes);
public long this[int i]=>Value[i];

public static A190907Inst Instance=new A190907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191100
{
public static readonly long[] Value={ 2L,6L,1L,6L,4L,1L,21L,6L,1L,30L,33L,2L,5L,42L,2L,6L,26L,2L,57L,30L,2L,13L,69L,0L,8L,78L,1L,42L,5L,10L,93L,6L,2L,102L,105L,2L,28L,114L,13L,30L,62L,5L,129L,66L,1L,20L,28L,2L,11L,30L,2L,78L,40L,2L,165L,42L,10L,174L,177L,3L,6L,186L,7L,6L,98L,22L,201L,102L,2L,210L,213L,0L,110L,222L,5L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191100Inst : IEnumerable<long>
{
public static readonly long[] Value=A191100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191100.Bytes);
public long this[int i]=>Value[i];

public static A191100Inst Instance=new A191100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191101
{
public static readonly long[] Value={ 6L,18L,43L,72L,145L,210L,364L,432L,768L,938L,1441L,1680L,2483L,2448L,4010L,4480L,6154L,6798L,9063L,9000L,12901L,13962L,17848L,19152L,24100L,21450L,31869L,33824L,41383L,43758L,52886L,52920L,66638L,69958L,82915L,86760L,102009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191101Inst : IEnumerable<long>
{
public static readonly long[] Value=A191101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191101.Bytes);
public long this[int i]=>Value[i];

public static A191101Inst Instance=new A191101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191102
{
public static readonly long[] Value={ 6L,5L,7L,8L,9L,3L,3L,8L,3L,9L,6L,2L,5L,2L,5L,9L,3L,1L,8L,0L,8L,6L,9L,4L,3L,7L,7L,1L,0L,6L,0L,6L,6L,7L,8L,9L,1L,9L,6L,1L,3L,2L,7L,4L,8L,4L,9L,8L,1L,1L,6L,6L,1L,6L,3L,8L,0L,8L,4L,3L,5L,8L,9L,9L,9L,7L,5L,9L,1L,1L,9L,4L,9L,5L,4L,3L,8L,9L,2L,7L,9L,2L,2L,0L,9L,1L,4L,4L,4L,9L,8L,6L,0L,6L,0L,5L,0L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191102Inst : IEnumerable<long>
{
public static readonly long[] Value=A191102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191102.Bytes);
public long this[int i]=>Value[i];

public static A191102Inst Instance=new A191102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191103
{
public static readonly long[] Value={ 3L,6L,7L,10L,14L,17L,21L,24L,28L,31L,35L,38L,39L,42L,45L,46L,49L,53L,56L,60L,63L,67L,70L,74L,77L,78L,81L,85L,88L,92L,95L,99L,102L,106L,109L,110L,113L,116L,117L,120L,124L,127L,131L,134L,138L,141L,145L,148L,149L,152L,156L,159L,163L,166L,170L,173L,177L,180L,181L,184L,187L,188L,191L,195L,198L,202L,205L,209L,212L,216L,219L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191103Inst : IEnumerable<long>
{
public static readonly long[] Value=A191103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191103.Bytes);
public long this[int i]=>Value[i];

public static A191103Inst Instance=new A191103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191104
{
public static readonly long[] Value={ 2L,5L,9L,12L,13L,16L,19L,20L,23L,27L,30L,34L,37L,41L,44L,48L,51L,52L,55L,58L,59L,62L,66L,69L,73L,76L,80L,83L,84L,87L,90L,91L,94L,98L,101L,105L,108L,112L,115L,119L,122L,123L,126L,129L,130L,133L,137L,140L,144L,147L,151L,154L,155L,158L,161L,162L,165L,169L,172L,176L,179L,183L,186L,190L,193L,194L,197L,200L,201L,204L,208L,211L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191104Inst : IEnumerable<long>
{
public static readonly long[] Value=A191104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191104.Bytes);
public long this[int i]=>Value[i];

public static A191104Inst Instance=new A191104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191105
{
public static readonly long[] Value={ 1L,4L,8L,11L,15L,18L,22L,25L,26L,29L,32L,33L,36L,40L,43L,47L,50L,54L,57L,61L,64L,65L,68L,71L,72L,75L,79L,82L,86L,89L,93L,96L,97L,100L,103L,104L,107L,111L,114L,118L,121L,125L,128L,132L,135L,136L,139L,142L,143L,146L,150L,153L,157L,160L,164L,167L,168L,171L,174L,175L,178L,182L,185L,189L,192L,196L,199L,203L,206L,207L,210L,213L,214L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191105Inst : IEnumerable<long>
{
public static readonly long[] Value=A191105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191105.Bytes);
public long this[int i]=>Value[i];

public static A191105Inst Instance=new A191105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191106
{
public static readonly long[] Value={ 1L,3L,7L,9L,19L,21L,25L,27L,55L,57L,61L,63L,73L,75L,79L,81L,163L,165L,169L,171L,181L,183L,187L,189L,217L,219L,223L,225L,235L,237L,241L,243L,487L,489L,493L,495L,505L,507L,511L,513L,541L,543L,547L,549L,559L,561L,565L,567L,649L,651L,655L,657L,667L,669L,673L,675L,703L,705L,709L,711L,721L,723L,727L,729L,1459L,1461L,1465L,1467L,1477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191106Inst : IEnumerable<long>
{
public static readonly long[] Value=A191106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191106.Bytes);
public long this[int i]=>Value[i];

public static A191106Inst Instance=new A191106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191107
{
public static readonly long[] Value={ 1L,4L,10L,13L,28L,31L,37L,40L,82L,85L,91L,94L,109L,112L,118L,121L,244L,247L,253L,256L,271L,274L,280L,283L,325L,328L,334L,337L,352L,355L,361L,364L,730L,733L,739L,742L,757L,760L,766L,769L,811L,814L,820L,823L,838L,841L,847L,850L,973L,976L,982L,985L,1000L,1003L,1009L,1012L,1054L,1057L,1063L,1066L,1081L,1084L,1090L,1093L,2188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191107Inst : IEnumerable<long>
{
public static readonly long[] Value=A191107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191107.Bytes);
public long this[int i]=>Value[i];

public static A191107Inst Instance=new A191107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191108
{
public static readonly long[] Value={ 1L,5L,13L,17L,37L,41L,49L,53L,109L,113L,121L,125L,145L,149L,157L,161L,325L,329L,337L,341L,361L,365L,373L,377L,433L,437L,445L,449L,469L,473L,481L,485L,973L,977L,985L,989L,1009L,1013L,1021L,1025L,1081L,1085L,1093L,1097L,1117L,1121L,1129L,1133L,1297L,1301L,1309L,1313L,1333L,1337L,1345L,1349L,1405L,1409L,1417L,1421L,1441L,1445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191108Inst : IEnumerable<long>
{
public static readonly long[] Value=A191108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191108.Bytes);
public long this[int i]=>Value[i];

public static A191108Inst Instance=new A191108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191109
{
public static readonly long[] Value={ 1L,2L,5L,8L,14L,17L,23L,26L,41L,44L,50L,53L,68L,71L,77L,80L,122L,125L,131L,134L,149L,152L,158L,161L,203L,206L,212L,215L,230L,233L,239L,242L,365L,368L,374L,377L,392L,395L,401L,404L,446L,449L,455L,458L,473L,476L,482L,485L,608L,611L,617L,620L,635L,638L,644L,647L,689L,692L,698L,701L,716L,719L,725L,728L,1094L,1097L,1103L,1106L,1121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191109Inst : IEnumerable<long>
{
public static readonly long[] Value=A191109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191109.Bytes);
public long this[int i]=>Value[i];

public static A191109Inst Instance=new A191109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191110
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,17L,27L,29L,33L,35L,45L,47L,51L,53L,81L,83L,87L,89L,99L,101L,105L,107L,135L,137L,141L,143L,153L,155L,159L,161L,243L,245L,249L,251L,261L,263L,267L,269L,297L,299L,303L,305L,315L,317L,321L,323L,405L,407L,411L,413L,423L,425L,429L,431L,459L,461L,465L,467L,477L,479L,483L,485L,729L,731L,735L,737L,747L,749L,753L,755L,783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191110Inst : IEnumerable<long>
{
public static readonly long[] Value=A191110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191110.Bytes);
public long this[int i]=>Value[i];

public static A191110Inst Instance=new A191110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191111
{
public static readonly long[] Value={ 11L,1110L,1120L,1130L,1140L,1150L,1160L,1170L,1180L,1190L,11100L,11110L,11120L,11130L,11140L,11150L,11160L,11170L,11180L,11190L,11200L,11210L,11220L,11230L,11240L,11250L,11260L,11270L,11280L,11290L,11300L,11310L,11320L,11330L,11340L,11350L,11360L,11370L,11380L,11390L,11400L,11410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191111Inst : IEnumerable<long>
{
public static readonly long[] Value=A191111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191111.Bytes);
public long this[int i]=>Value[i];

public static A191111Inst Instance=new A191111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191112
{
public static readonly BigInteger[] Value={ 1L,3L,12L,42L,165L,3000L,2142L,39270L,838695L,2185092L,194467182L,649154415L,33547795512L,40753286805L,24563658547425L,1364238471026340L,2297427262231332L,1662166966658270160L,783186317937632697L,BigInteger.Parse("404695317060455732220"),BigInteger.Parse("162293533192142440777455"),BigInteger.Parse("634357227813958501290435") };
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
public class A191112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191112Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191112.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191112.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191112Inst Instance=new A191112Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191113
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,16L,22L,28L,38L,40L,46L,54L,62L,64L,82L,86L,110L,112L,118L,136L,150L,158L,160L,182L,184L,190L,214L,244L,246L,254L,256L,326L,328L,334L,342L,352L,406L,438L,446L,448L,470L,472L,478L,542L,544L,550L,568L,598L,630L,638L,640L,726L,730L,734L,736L,758L,760L,766L,854L,974L,976L,982L,1000L,1014L,1022L,1024L,1054L,1216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191113Inst : IEnumerable<long>
{
public static readonly long[] Value=A191113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191113.Bytes);
public long this[int i]=>Value[i];

public static A191113Inst Instance=new A191113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191114
{
public static readonly long[] Value={ 1L,3L,7L,11L,19L,27L,31L,43L,55L,75L,79L,91L,107L,123L,127L,163L,171L,219L,223L,235L,271L,299L,315L,319L,363L,367L,379L,427L,487L,491L,507L,511L,651L,655L,667L,683L,703L,811L,875L,891L,895L,939L,943L,955L,1083L,1087L,1099L,1135L,1195L,1259L,1275L,1279L,1451L,1459L,1467L,1471L,1515L,1519L,1531L,1707L,1947L,1951L,1963L,1999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191114Inst : IEnumerable<long>
{
public static readonly long[] Value=A191114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191114.Bytes);
public long this[int i]=>Value[i];

public static A191114Inst Instance=new A191114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191115
{
public static readonly long[] Value={ 1L,4L,10L,16L,28L,40L,46L,64L,82L,112L,118L,136L,160L,184L,190L,244L,256L,328L,334L,352L,406L,448L,472L,478L,544L,550L,568L,640L,730L,736L,760L,766L,976L,982L,1000L,1024L,1054L,1216L,1312L,1336L,1342L,1408L,1414L,1432L,1624L,1630L,1648L,1702L,1792L,1888L,1912L,1918L,2176L,2188L,2200L,2206L,2272L,2278L,2296L,2560L,2920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191115Inst : IEnumerable<long>
{
public static readonly long[] Value=A191115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191115.Bytes);
public long this[int i]=>Value[i];

public static A191115Inst Instance=new A191115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191212
{
public static readonly long[] Value={ 1L,5L,6L,8L,17L,20L,22L,26L,53L,62L,68L,70L,80L,82L,90L,106L,120L,161L,188L,206L,212L,214L,242L,248L,250L,272L,274L,282L,320L,322L,330L,362L,376L,426L,440L,485L,566L,568L,620L,638L,644L,646L,728L,746L,752L,754L,818L,824L,826L,848L,850L,858L,962L,968L,970L,992L,994L,1002L,1088L,1090L,1098L,1130L,1144L,1280L,1282L,1290L,1322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191212Inst : IEnumerable<long>
{
public static readonly long[] Value=A191212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191212.Bytes);
public long this[int i]=>Value[i];

public static A191212Inst Instance=new A191212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191213
{
public static readonly long[] Value={ 1L,5L,6L,15L,17L,20L,22L,26L,51L,53L,60L,62L,68L,70L,80L,82L,90L,106L,141L,159L,161L,186L,188L,204L,206L,212L,214L,240L,242L,248L,250L,272L,274L,282L,320L,322L,330L,362L,426L,465L,483L,485L,546L,564L,566L,618L,620L,636L,638L,644L,646L,726L,728L,744L,746L,752L,754L,816L,818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191213Inst : IEnumerable<long>
{
public static readonly long[] Value=A191213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191213.Bytes);
public long this[int i]=>Value[i];

public static A191213Inst Instance=new A191213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191214
{
public static readonly long[] Value={ 1L,4L,5L,8L,11L,12L,15L,18L,19L,22L,25L,26L,29L,30L,32L,33L,36L,37L,39L,40L,43L,44L,46L,47L,50L,51L,53L,54L,57L,58L,61L,64L,65L,68L,71L,72L,75L,78L,79L,82L,85L,86L,89L,90L,92L,93L,96L,97L,99L,100L,103L,104L,106L,107L,110L,111L,114L,117L,118L,121L,124L,125L,128L,131L,132L,135L,138L,139L,142L,143L,145L,146L,149L,150L,152L,153L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191214Inst : IEnumerable<long>
{
public static readonly long[] Value=A191214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191214.Bytes);
public long this[int i]=>Value[i];

public static A191214Inst Instance=new A191214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191215
{
public static readonly long[] Value={ 2L,3L,6L,7L,9L,10L,13L,14L,16L,17L,20L,21L,23L,24L,27L,28L,31L,34L,35L,38L,41L,42L,45L,48L,49L,52L,55L,56L,59L,60L,62L,63L,66L,67L,69L,70L,73L,74L,76L,77L,80L,81L,83L,84L,87L,88L,91L,94L,95L,98L,101L,102L,105L,108L,109L,112L,113L,115L,116L,119L,120L,122L,123L,126L,127L,129L,130L,133L,134L,136L,137L,140L,141L,144L,147L,148L,151L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191215Inst : IEnumerable<long>
{
public static readonly long[] Value=A191215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191215.Bytes);
public long this[int i]=>Value[i];

public static A191215Inst Instance=new A191215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191216
{
public static readonly long[] Value={ 361L,230456L,1005768L,3462570L,11006128L,25925028L,61456764L,127697940L,249379116L,448408452L,740850012L,1263239320L,1914568816L,2884222410L,4371191782L,6287341056L,8758591370L,11640682466L,15938770638L,21721208748L,29153150298L,38784336168L,49888704100L,62506263054L,76188213990L,95511276660L,118760260290L,150724895476L,187405610004L,243040520764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191216Inst : IEnumerable<long>
{
public static readonly long[] Value=A191216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191216.Bytes);
public long this[int i]=>Value[i];

public static A191216Inst Instance=new A191216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191217
{
public static readonly long[] Value={ 5L,10L,13L,17L,20L,26L,29L,34L,37L,40L,41L,45L,52L,53L,58L,61L,68L,73L,74L,80L,82L,89L,90L,97L,101L,104L,106L,109L,113L,116L,117L,122L,136L,137L,146L,148L,149L,153L,157L,160L,164L,173L,178L,180L,181L,193L,194L,197L,202L,208L,212L,218L,226L,229L,232L,233L,234L,241L,244L,245L,257L,261L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191217Inst : IEnumerable<long>
{
public static readonly long[] Value=A191217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191217.Bytes);
public long this[int i]=>Value[i];

public static A191217Inst Instance=new A191217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191218
{
public static readonly long[] Value={ 5L,13L,17L,29L,37L,41L,45L,53L,61L,73L,89L,97L,101L,109L,113L,117L,137L,149L,153L,157L,173L,181L,193L,197L,229L,233L,241L,245L,257L,261L,269L,277L,281L,293L,313L,317L,325L,333L,337L,349L,353L,369L,373L,389L,397L,401L,405L,409L,421L,425L,433L,449L,457L,461L,477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191218Inst : IEnumerable<long>
{
public static readonly long[] Value=A191218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191218.Bytes);
public long this[int i]=>Value[i];

public static A191218Inst Instance=new A191218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191219
{
public static readonly long[] Value={ 5L,9L,13L,41L,49L,61L,113L,121L,169L,181L,225L,289L,313L,421L,441L,613L,625L,761L,925L,1013L,1201L,1301L,1521L,1681L,1741L,1849L,1861L,2025L,2113L,2381L,2401L,2521L,3121L,3481L,3613L,3969L,4325L,4513L,4761L,4901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191219Inst : IEnumerable<long>
{
public static readonly long[] Value=A191219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191219.Bytes);
public long this[int i]=>Value[i];

public static A191219Inst Instance=new A191219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191220
{
public static readonly long[] Value={ 6L,5L,6L,1L,7L,6L,3L,4L,3L,5L,5L,8L,6L,8L,3L,5L,3L,5L,9L,9L,1L,7L,8L,0L,0L,1L,5L,7L,8L,1L,5L,2L,3L,0L,3L,9L,0L,8L,9L,0L,4L,7L,9L,0L,4L,2L,8L,0L,0L,6L,8L,6L,5L,5L,1L,3L,1L,9L,2L,4L,4L,8L,6L,0L,3L,0L,5L,5L,2L,9L,1L,4L,0L,1L,5L,3L,7L,5L,7L,7L,9L,4L,3L,5L,3L,3L,0L,0L,6L,9L,0L,8L,9L,9L,6L,9L,7L,1L,5L,6L,4L,8L,3L,3L,9L,5L,9L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191220Inst : IEnumerable<long>
{
public static readonly long[] Value=A191220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191220.Bytes);
public long this[int i]=>Value[i];

public static A191220Inst Instance=new A191220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191221
{
public static readonly long[] Value={ 1L,10L,11L,19L,35L,37L,53L,59L,73L,91L,95L,100L,101L,143L,181L,218L,232L,250L,272L,296L,298L,323L,341L,343L,365L,383L,385L,418L,436L,454L,490L,509L,527L,547L,563L,583L,610L,634L,650L,656L,670L,692L,725L,727L,745L,749L,767L,787L,812L,814L,838L,850L,892L,905L,947L,949L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191221Inst : IEnumerable<long>
{
public static readonly long[] Value=A191221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191221.Bytes);
public long this[int i]=>Value[i];

public static A191221Inst Instance=new A191221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191222
{
public static readonly BigInteger[] Value={ 1L,3L,5L,17L,107L,598L,5688L,77906L,1352347L,34249359L,1204670396L,58155968015L,3946610726739L,371524667930965L,48587161215494423L,8859996760746649440L,BigInteger.Parse("2245679398171585663077"),BigInteger.Parse("791847513412090215745935") };
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
public class A191222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191222Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191222.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191222.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191222Inst Instance=new A191222Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191223
{
public static readonly BigInteger[] Value={ 1L,3L,6L,16L,88L,534L,4001L,49783L,802282L,16846980L,518093110L,21604679482L,1210757513851L,95028176738441L,10229389014494032L,1500221649654979714L,BigInteger.Parse("303756994018728446946"),BigInteger.Parse("84493641616490831589232") };
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
public class A191223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191223.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191223Inst Instance=new A191223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191224
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,29L,74L,267L,1270L,6853L,46338L,452697L,5888876L,103743236L,2568916974L,83100685126L,3548166614885L,196909507948313L,14058252177537760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191224Inst : IEnumerable<long>
{
public static readonly long[] Value=A191224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191224.Bytes);
public long this[int i]=>Value[i];

public static A191224Inst Instance=new A191224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191225
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,2L,0L,2L,1L,1L,2L,1L,2L,0L,2L,3L,2L,1L,2L,2L,2L,1L,4L,2L,2L,1L,0L,4L,3L,5L,1L,3L,2L,1L,5L,1L,2L,3L,4L,4L,4L,2L,2L,2L,4L,2L,3L,4L,3L,5L,4L,3L,2L,5L,4L,2L,5L,1L,6L,1L,5L,5L,7L,2L,2L,1L,10L,6L,6L,2L,2L,5L,0L,3L,7L,5L,4L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191225Inst : IEnumerable<long>
{
public static readonly long[] Value=A191225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191225.Bytes);
public long this[int i]=>Value[i];

public static A191225Inst Instance=new A191225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191226
{
public static readonly long[] Value={ 1L,2L,12L,22L,29L,36L,65L,69L,117L,118L,73L,100L,108L,154L,161L,200L,254L,172L,274L,239L,340L,321L,334L,330L,345L,471L,378L,481L,357L,526L,522L,515L,610L,635L,612L,655L,648L,792L,809L,731L,797L,594L,806L,851L,988L,886L,963L,933L,1005L,1111L,927L,1124L,970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191226Inst : IEnumerable<long>
{
public static readonly long[] Value=A191226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191226.Bytes);
public long this[int i]=>Value[i];

public static A191226Inst Instance=new A191226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191227
{
public static readonly long[] Value={ 79L,194L,153L,284L,420L,333L,454L,592L,504L,412L,652L,512L,486L,617L,613L,660L,1130L,753L,1002L,849L,1060L,957L,1034L,1037L,1198L,961L,969L,1056L,1368L,1400L,1264L,1314L,1301L,1683L,1510L,1571L,1532L,1625L,1771L,1810L,1745L,1907L,1961L,1877L,1851L,2104L,2097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191227Inst : IEnumerable<long>
{
public static readonly long[] Value=A191227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191227.Bytes);
public long this[int i]=>Value[i];

public static A191227Inst Instance=new A191227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191260
{
public static readonly long[] Value={ 4L,12L,21L,29L,35L,39L,47L,56L,64L,68L,76L,84L,93L,101L,107L,111L,119L,128L,136L,144L,153L,161L,170L,178L,184L,188L,196L,205L,213L,217L,225L,233L,242L,250L,256L,260L,268L,277L,285L,294L,302L,308L,312L,320L,329L,337L,343L,347L,355L,364L,372L,376L,384L,392L,401L,409L,415L,419L,427L,436L,444L,452L,461L,469L,478L,486L,492L,496L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191260Inst : IEnumerable<long>
{
public static readonly long[] Value=A191260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191260.Bytes);
public long this[int i]=>Value[i];

public static A191260Inst Instance=new A191260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191261
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191261Inst : IEnumerable<long>
{
public static readonly long[] Value=A191261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191261.Bytes);
public long this[int i]=>Value[i];

public static A191261Inst Instance=new A191261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191262
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,12L,14L,15L,17L,19L,20L,22L,24L,25L,27L,29L,30L,32L,34L,36L,38L,40L,41L,43L,45L,47L,49L,51L,52L,54L,56L,58L,60L,62L,63L,65L,67L,69L,71L,73L,74L,76L,78L,79L,81L,83L,84L,86L,88L,89L,91L,93L,95L,97L,99L,100L,102L,104L,105L,107L,109L,110L,112L,114L,115L,117L,119L,121L,123L,125L,126L,128L,130L,131L,133L,135L,136L,138L,140L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191262Inst : IEnumerable<long>
{
public static readonly long[] Value=A191262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191262.Bytes);
public long this[int i]=>Value[i];

public static A191262Inst Instance=new A191262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191263
{
public static readonly long[] Value={ 2L,7L,9L,11L,13L,18L,23L,28L,33L,35L,37L,39L,44L,46L,48L,50L,55L,57L,59L,61L,66L,68L,70L,72L,77L,82L,87L,92L,94L,96L,98L,103L,108L,113L,118L,120L,122L,124L,129L,134L,139L,144L,146L,148L,150L,155L,160L,165L,170L,172L,174L,176L,181L,183L,185L,187L,192L,194L,196L,198L,203L,205L,207L,209L,214L,219L,224L,229L,231L,233L,235L,240L,242L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191263Inst : IEnumerable<long>
{
public static readonly long[] Value=A191263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191263.Bytes);
public long this[int i]=>Value[i];

public static A191263Inst Instance=new A191263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191264
{
public static readonly long[] Value={ 5L,16L,21L,26L,31L,42L,53L,64L,75L,80L,85L,90L,101L,106L,111L,116L,127L,132L,137L,142L,153L,158L,163L,168L,179L,190L,201L,212L,217L,222L,227L,238L,249L,260L,271L,276L,281L,286L,297L,308L,319L,330L,335L,340L,345L,356L,367L,378L,389L,394L,399L,404L,415L,420L,425L,430L,441L,446L,451L,456L,467L,472L,477L,482L,493L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191264Inst : IEnumerable<long>
{
public static readonly long[] Value=A191264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191264.Bytes);
public long this[int i]=>Value[i];

public static A191264Inst Instance=new A191264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191265
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191265Inst : IEnumerable<long>
{
public static readonly long[] Value=A191265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191265.Bytes);
public long this[int i]=>Value[i];

public static A191265Inst Instance=new A191265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191266
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,17L,19L,20L,22L,23L,25L,27L,28L,30L,31L,33L,34L,36L,37L,39L,40L,42L,43L,45L,46L,48L,49L,51L,53L,54L,56L,57L,59L,60L,62L,63L,65L,66L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,83L,84L,86L,87L,89L,90L,92L,93L,95L,96L,98L,99L,101L,103L,104L,106L,107L,109L,110L,112L,113L,115L,116L,118L,119L,121L,122L,124L,125L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191266Inst : IEnumerable<long>
{
public static readonly long[] Value=A191266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191266.Bytes);
public long this[int i]=>Value[i];

public static A191266Inst Instance=new A191266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191267
{
public static readonly long[] Value={ 3L,6L,12L,15L,21L,24L,26L,29L,32L,38L,41L,47L,50L,52L,55L,58L,64L,67L,73L,79L,82L,88L,91L,97L,100L,102L,105L,108L,114L,117L,123L,126L,128L,131L,134L,140L,143L,149L,155L,158L,164L,167L,173L,176L,178L,181L,184L,190L,193L,199L,202L,204L,207L,210L,216L,219L,221L,224L,227L,233L,236L,242L,245L,247L,250L,253L,259L,262L,268L,271L,273L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191267Inst : IEnumerable<long>
{
public static readonly long[] Value=A191267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191267.Bytes);
public long this[int i]=>Value[i];

public static A191267Inst Instance=new A191267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191268
{
public static readonly long[] Value={ 9L,18L,35L,44L,61L,70L,76L,85L,94L,111L,120L,137L,146L,152L,161L,170L,187L,196L,213L,230L,239L,256L,265L,282L,291L,297L,306L,315L,332L,341L,358L,367L,373L,382L,391L,408L,417L,434L,451L,460L,477L,486L,503L,512L,518L,527L,536L,553L,562L,579L,588L,594L,603L,612L,629L,638L,644L,653L,662L,679L,688L,705L,714L,720L,729L,738L,755L,764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191268Inst : IEnumerable<long>
{
public static readonly long[] Value=A191268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191268.Bytes);
public long this[int i]=>Value[i];

public static A191268Inst Instance=new A191268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191269
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191269Inst : IEnumerable<long>
{
public static readonly long[] Value=A191269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191269.Bytes);
public long this[int i]=>Value[i];

public static A191269Inst Instance=new A191269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191270
{
public static readonly long[] Value={ 3L,6L,11L,14L,19L,21L,24L,27L,32L,35L,40L,42L,45L,48L,53L,58L,61L,66L,69L,74L,76L,79L,82L,87L,90L,95L,97L,100L,103L,108L,113L,116L,121L,124L,129L,131L,134L,137L,142L,144L,147L,150L,155L,158L,163L,165L,168L,171L,176L,179L,184L,186L,189L,192L,197L,202L,205L,210L,213L,218L,220L,223L,226L,231L,234L,239L,241L,244L,247L,252L,257L,260L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191270Inst : IEnumerable<long>
{
public static readonly long[] Value=A191270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191270.Bytes);
public long this[int i]=>Value[i];

public static A191270Inst Instance=new A191270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191271
{
public static readonly long[] Value={ 8L,16L,29L,37L,50L,55L,63L,71L,84L,92L,105L,110L,118L,126L,139L,152L,160L,173L,181L,194L,199L,207L,215L,228L,236L,249L,254L,262L,270L,283L,296L,304L,317L,325L,338L,343L,351L,359L,372L,377L,385L,393L,406L,414L,427L,432L,440L,448L,461L,469L,482L,487L,495L,503L,516L,529L,537L,550L,558L,571L,576L,584L,592L,605L,613L,626L,631L,639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191271Inst : IEnumerable<long>
{
public static readonly long[] Value=A191271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191271.Bytes);
public long this[int i]=>Value[i];

public static A191271Inst Instance=new A191271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191272
{
public static readonly long[] Value={ 0L,4L,17L,63L,256L,1025L,4095L,16384L,65537L,262143L,1048576L,4194305L,16777215L,67108864L,268435457L,1073741823L,4294967296L,17179869185L,68719476735L,274877906944L,1099511627777L,4398046511103L,17592186044416L,70368744177665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191272Inst : IEnumerable<long>
{
public static readonly long[] Value=A191272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191272.Bytes);
public long this[int i]=>Value[i];

public static A191272Inst Instance=new A191272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191273
{
public static readonly BigInteger[] Value={ 1L,4L,9L,25L,168L,1360L,12423L,197679L,4404447L,124898323L,5318804048L,324994451931L,26856733887752L,3172635060583667L,535764786560787509L,BigInteger.Parse("125858757883842762915"),BigInteger.Parse("41716808217942795412293") };
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
public class A191273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191273Inst Instance=new A191273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191274
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,8L,35L,208L,1147L,10098L,106904L,1615656L,31267328L,833655362L,29769092579L,1422289731681L,88322500448612L,7254260374065120L,782791757341222545L,BigInteger.Parse("111845565903325791194"),BigInteger.Parse("21080332457396845047136") };
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
public class A191274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191274.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191274Inst Instance=new A191274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191275
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,11L,12L,13L,15L,17L,19L,21L,23L,24L,25L,27L,29L,31L,33L,35L,36L,37L,39L,41L,43L,45L,47L,48L,49L,51L,53L,55L,57L,59L,60L,61L,63L,65L,67L,69L,71L,72L,73L,75L,77L,79L,81L,83L,84L,85L,87L,89L,91L,93L,95L,96L,97L,99L,101L,103L,105L,107L,108L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191275Inst : IEnumerable<long>
{
public static readonly long[] Value=A191275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191275.Bytes);
public long this[int i]=>Value[i];

public static A191275Inst Instance=new A191275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191324
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,11L,13L,14L,17L,20L,22L,23L,26L,31L,34L,35L,40L,41L,44L,47L,52L,53L,61L,62L,67L,68L,71L,79L,80L,92L,94L,95L,101L,103L,104L,107L,119L,121L,122L,125L,134L,139L,142L,143L,152L,155L,157L,158L,161L,179L,182L,184L,185L,188L,202L,203L,206L,209L,214L,215L,229L,233L,236L,238L,239L,242L,269L,274L,277L,278L,283L,284L,287L,304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191324Inst : IEnumerable<long>
{
public static readonly long[] Value=A191324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191324.Bytes);
public long this[int i]=>Value[i];

public static A191324Inst Instance=new A191324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191325
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,15L,17L,18L,19L,22L,25L,27L,28L,30L,32L,33L,37L,40L,42L,45L,47L,48L,49L,55L,60L,62L,63L,67L,70L,72L,73L,75L,80L,82L,90L,92L,93L,94L,100L,105L,108L,109L,112L,117L,120L,122L,123L,135L,137L,138L,139L,141L,150L,155L,157L,162L,163L,167L,168L,175L,180L,182L,183L,184L,187L,200L,202L,205L,207L,208L,211L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191325Inst : IEnumerable<long>
{
public static readonly long[] Value=A191325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191325.Bytes);
public long this[int i]=>Value[i];

public static A191325Inst Instance=new A191325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191326
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,10L,13L,14L,15L,19L,21L,22L,28L,31L,33L,35L,42L,45L,46L,49L,52L,63L,66L,67L,69L,73L,77L,78L,94L,98L,99L,100L,103L,108L,109L,115L,117L,122L,147L,148L,150L,154L,157L,161L,162L,163L,171L,172L,175L,182L,183L,220L,222L,225L,231L,234L,235L,241L,243L,244L,255L,256L,258L,262L,269L,273L,274L,343L,346L,350L,351L,352L,360L,361L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191326Inst : IEnumerable<long>
{
public static readonly long[] Value=A191326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191326.Bytes);
public long this[int i]=>Value[i];

public static A191326Inst Instance=new A191326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191327
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,12L,17L,24L,25L,30L,35L,42L,59L,60L,62L,75L,84L,87L,105L,122L,147L,150L,155L,187L,206L,210L,217L,262L,294L,304L,305L,367L,375L,387L,427L,467L,514L,515L,525L,542L,654L,655L,721L,735L,759L,760L,762L,917L,937L,967L,1029L,1064L,1067L,1167L,1284L,1285L,1287L,1312L,1354L,1355L,1494L,1634L,1635L,1637L,1799L,1802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191327Inst : IEnumerable<long>
{
public static readonly long[] Value=A191327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191327.Bytes);
public long this[int i]=>Value[i];

public static A191327Inst Instance=new A191327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191328
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,18L,21L,23L,25L,26L,30L,32L,35L,37L,38L,41L,42L,43L,49L,50L,53L,58L,60L,61L,63L,68L,70L,71L,74L,81L,83L,86L,88L,95L,96L,98L,100L,101L,105L,113L,114L,116L,118L,123L,135L,138L,140L,142L,143L,146L,147L,158L,160L,163L,165L,166L,168L,172L,175L,188L,189L,190L,193L,196L,200L,205L,221L,224L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191328Inst : IEnumerable<long>
{
public static readonly long[] Value=A191328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191328.Bytes);
public long this[int i]=>Value[i];

public static A191328Inst Instance=new A191328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191329
{
public static readonly long[] Value={ 1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191329Inst : IEnumerable<long>
{
public static readonly long[] Value=A191329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191329.Bytes);
public long this[int i]=>Value[i];

public static A191329Inst Instance=new A191329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191330
{
public static readonly long[] Value={ 4L,8L,10L,14L,20L,24L,26L,30L,36L,40L,46L,50L,52L,56L,62L,66L,68L,72L,76L,78L,82L,88L,92L,94L,98L,104L,108L,114L,118L,120L,124L,130L,134L,136L,140L,144L,146L,150L,156L,160L,162L,166L,172L,176L,178L,182L,186L,188L,192L,198L,202L,204L,208L,214L,218L,224L,228L,230L,234L,240L,244L,246L,250L,254L,256L,260L,266L,270L,272L,276L,282L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191330Inst : IEnumerable<long>
{
public static readonly long[] Value=A191330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191330.Bytes);
public long this[int i]=>Value[i];

public static A191330Inst Instance=new A191330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191331
{
public static readonly long[] Value={ 2L,6L,12L,16L,18L,22L,28L,32L,34L,38L,42L,44L,48L,54L,58L,60L,64L,70L,74L,80L,84L,86L,90L,96L,100L,102L,106L,110L,112L,116L,122L,126L,128L,132L,138L,142L,148L,152L,154L,158L,164L,168L,170L,174L,180L,184L,190L,194L,196L,200L,206L,210L,212L,216L,220L,222L,226L,232L,236L,238L,242L,248L,252L,258L,262L,264L,268L,274L,278L,280L,284L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191331Inst : IEnumerable<long>
{
public static readonly long[] Value=A191331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191331.Bytes);
public long this[int i]=>Value[i];

public static A191331Inst Instance=new A191331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191332
{
public static readonly long[] Value={ 0L,1L,2L,5L,1L,5L,2L,3L,9L,2L,5L,6L,3L,2L,4L,2L,9L,1L,3L,6L,5L,4L,4L,3L,1L,3L,1L,7L,0L,5L,5L,1L,9L,5L,0L,6L,5L,3L,6L,5L,6L,1L,3L,5L,2L,5L,1L,3L,4L,4L,5L,7L,0L,1L,1L,8L,6L,3L,4L,3L,6L,2L,5L,4L,4L,2L,8L,1L,4L,6L,3L,0L,6L,6L,5L,7L,6L,7L,5L,6L,6L,8L,4L,8L,8L,3L,1L,3L,7L,1L,2L,7L,4L,4L,6L,4L,3L,9L,3L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191332Inst : IEnumerable<long>
{
public static readonly long[] Value=A191332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191332.Bytes);
public long this[int i]=>Value[i];

public static A191332Inst Instance=new A191332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191333
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,4L,7L,6L,0L,7L,4L,3L,6L,7L,5L,7L,0L,8L,6L,3L,4L,5L,5L,6L,8L,6L,8L,2L,9L,4L,4L,8L,0L,4L,9L,3L,4L,6L,3L,4L,3L,8L,6L,4L,7L,4L,8L,6L,5L,5L,4L,2L,9L,8L,8L,1L,3L,6L,5L,6L,3L,7L,4L,5L,5L,7L,1L,8L,5L,3L,6L,9L,3L,3L,4L,2L,3L,2L,4L,3L,3L,1L,5L,1L,1L,6L,8L,6L,2L,8L,7L,2L,5L,5L,3L,5L,6L,0L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191333Inst : IEnumerable<long>
{
public static readonly long[] Value=A191333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191333.Bytes);
public long this[int i]=>Value[i];

public static A191333Inst Instance=new A191333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191334
{
public static readonly long[] Value={ 1L,2L,8L,0L,4L,8L,7L,8L,0L,3L,9L,3L,3L,7L,1L,6L,5L,4L,6L,9L,2L,9L,5L,8L,2L,6L,5L,0L,9L,8L,6L,8L,7L,6L,5L,5L,3L,7L,5L,7L,5L,1L,6L,0L,8L,8L,3L,6L,5L,6L,0L,6L,8L,0L,5L,1L,1L,8L,8L,4L,0L,4L,0L,9L,5L,6L,8L,6L,6L,3L,2L,2L,5L,0L,4L,3L,2L,0L,2L,2L,3L,8L,5L,3L,8L,8L,1L,6L,6L,9L,8L,2L,3L,3L,9L,9L,8L,6L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191334Inst : IEnumerable<long>
{
public static readonly long[] Value=A191334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191334.Bytes);
public long this[int i]=>Value[i];

public static A191334Inst Instance=new A191334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191335
{
public static readonly long[] Value={ 3L,7L,1L,9L,5L,1L,2L,1L,9L,6L,0L,6L,6L,2L,8L,3L,4L,5L,3L,0L,7L,0L,4L,1L,7L,3L,4L,9L,0L,1L,3L,1L,2L,3L,4L,4L,6L,2L,4L,2L,4L,8L,3L,9L,1L,1L,6L,3L,4L,3L,9L,3L,1L,9L,4L,8L,8L,1L,1L,5L,9L,5L,9L,0L,4L,3L,1L,3L,3L,6L,7L,7L,4L,9L,5L,6L,7L,9L,7L,7L,6L,1L,4L,6L,1L,1L,8L,3L,3L,0L,1L,7L,6L,5L,9L,5L,7L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191335Inst : IEnumerable<long>
{
public static readonly long[] Value=A191335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191335.Bytes);
public long this[int i]=>Value[i];

public static A191335Inst Instance=new A191335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191336
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,1L,0L,1L,1L,0L,1L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,1L,2L,1L,1L,2L,1L,1L,0L,1L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,1L,2L,1L,1L,2L,1L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,1L,0L,1L,1L,0L,1L,1L,2L,1L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,1L,2L,1L,1L,0L,1L,1L,0L,1L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,1L,2L,1L,1L,2L,1L,1L,0L,1L,1L,2L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191336Inst : IEnumerable<long>
{
public static readonly long[] Value=A191336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191336.Bytes);
public long this[int i]=>Value[i];

public static A191336Inst Instance=new A191336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191337
{
public static readonly long[] Value={ 6L,7L,12L,13L,19L,22L,28L,29L,34L,35L,44L,50L,51L,56L,57L,66L,67L,72L,73L,79L,82L,88L,89L,94L,95L,101L,104L,110L,111L,116L,117L,126L,132L,133L,139L,148L,149L,154L,155L,161L,164L,170L,171L,176L,177L,183L,186L,192L,193L,198L,199L,208L,214L,215L,221L,230L,231L,236L,237L,243L,246L,252L,253L,258L,259L,265L,268L,274L,275L,280L,281L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191337Inst : IEnumerable<long>
{
public static readonly long[] Value=A191337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191337.Bytes);
public long this[int i]=>Value[i];

public static A191337Inst Instance=new A191337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191338
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,11L,14L,17L,18L,20L,21L,23L,24L,27L,30L,33L,36L,37L,39L,40L,42L,43L,45L,46L,49L,52L,55L,58L,59L,61L,62L,64L,65L,68L,71L,74L,77L,78L,80L,81L,83L,84L,86L,87L,90L,93L,96L,97L,99L,100L,102L,103L,105L,106L,109L,112L,115L,118L,119L,121L,122L,124L,125L,127L,128L,131L,134L,137L,138L,140L,141L,143L,144L,146L,147L,150L,153L,156L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191338Inst : IEnumerable<long>
{
public static readonly long[] Value=A191338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191338.Bytes);
public long this[int i]=>Value[i];

public static A191338Inst Instance=new A191338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191339
{
public static readonly long[] Value={ 3L,9L,10L,15L,16L,25L,26L,31L,32L,38L,41L,47L,48L,53L,54L,60L,63L,69L,70L,75L,76L,85L,91L,92L,98L,107L,108L,113L,114L,120L,123L,129L,130L,135L,136L,142L,145L,151L,152L,157L,158L,167L,173L,174L,180L,189L,190L,195L,196L,202L,205L,211L,212L,217L,218L,224L,227L,233L,234L,239L,240L,249L,250L,255L,256L,262L,271L,272L,277L,278L,284L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191339Inst : IEnumerable<long>
{
public static readonly long[] Value=A191339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191339.Bytes);
public long this[int i]=>Value[i];

public static A191339Inst Instance=new A191339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191404
{
public static readonly long[] Value={ 4L,7L,11L,13L,17L,20L,23L,27L,29L,33L,37L,39L,43L,46L,49L,53L,55L,59L,62L,65L,69L,71L,75L,79L,81L,85L,88L,91L,95L,97L,101L,105L,107L,111L,114L,117L,121L,123L,127L,130L,133L,137L,139L,143L,147L,149L,153L,156L,159L,163L,165L,169L,172L,175L,179L,181L,185L,189L,191L,195L,198L,201L,205L,207L,211L,215L,217L,221L,224L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191404Inst : IEnumerable<long>
{
public static readonly long[] Value=A191404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191404.Bytes);
public long this[int i]=>Value[i];

public static A191404Inst Instance=new A191404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191405
{
public static readonly long[] Value={ 1L,3L,6L,9L,12L,15L,17L,20L,23L,26L,29L,31L,34L,37L,40L,43L,46L,49L,51L,54L,57L,60L,63L,65L,68L,71L,74L,77L,80L,83L,85L,88L,91L,94L,97L,99L,102L,105L,108L,111L,113L,116L,119L,122L,125L,128L,131L,133L,136L,139L,142L,145L,147L,150L,153L,156L,159L,162L,165L,167L,170L,173L,176L,179L,181L,184L,187L,190L,193L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191405Inst : IEnumerable<long>
{
public static readonly long[] Value=A191405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191405.Bytes);
public long this[int i]=>Value[i];

public static A191405Inst Instance=new A191405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191406
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,16L,19L,21L,25L,27L,30L,33L,35L,39L,41L,45L,47L,50L,53L,55L,59L,61L,64L,67L,69L,73L,75L,79L,81L,84L,87L,89L,93L,95L,98L,101L,103L,107L,109L,112L,115L,117L,121L,123L,127L,129L,132L,135L,137L,141L,143L,146L,149L,151L,155L,157L,161L,163L,166L,169L,171L,175L,177L,180L,183L,185L,189L,191L,194L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191406Inst : IEnumerable<long>
{
public static readonly long[] Value=A191406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191406.Bytes);
public long this[int i]=>Value[i];

public static A191406Inst Instance=new A191406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191407
{
public static readonly long[] Value={ 4L,6L,9L,12L,14L,18L,20L,23L,26L,28L,32L,34L,37L,40L,43L,46L,48L,52L,54L,57L,60L,62L,66L,68L,71L,74L,77L,80L,82L,86L,88L,91L,94L,96L,100L,102L,105L,108L,110L,114L,116L,119L,122L,125L,128L,130L,134L,136L,139L,142L,144L,148L,150L,153L,156L,159L,162L,164L,168L,170L,173L,176L,178L,182L,184L,187L,190L,192L,196L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191407Inst : IEnumerable<long>
{
public static readonly long[] Value=A191407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191407.Bytes);
public long this[int i]=>Value[i];

public static A191407Inst Instance=new A191407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191408
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,2L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,1L,2L,4L,3L,1L,1L,4L,2L,6L,1L,1L,2L,1L,1L,4L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,4L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191408Inst : IEnumerable<long>
{
public static readonly long[] Value=A191408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191408.Bytes);
public long this[int i]=>Value[i];

public static A191408Inst Instance=new A191408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191409
{
public static readonly BigInteger[] Value={ 5L,131L,54869L,863585783L,BigInteger.Parse("174960197237646244878763893842845824429634127969") };
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
public class A191409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191409Inst Instance=new A191409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191410
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,2L,0L,0L,3L,2L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,2L,0L,0L,0L,4L,2L,0L,0L,1L,0L,0L,0L,5L,0L,0L,0L,2L,2L,0L,0L,4L,4L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,1L,4L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,3L,4L,0L,0L,6L,2L,0L,0L,2L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191410Inst : IEnumerable<long>
{
public static readonly long[] Value=A191410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191410.Bytes);
public long this[int i]=>Value[i];

public static A191410Inst Instance=new A191410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191411
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,2L,1L,0L,0L,2L,1L,0L,2L,4L,2L,0L,4L,0L,1L,0L,4L,2L,3L,0L,0L,6L,0L,0L,6L,4L,3L,0L,4L,4L,2L,0L,2L,6L,4L,0L,8L,4L,1L,0L,0L,4L,5L,0L,0L,0L,2L,0L,6L,0L,4L,0L,4L,2L,3L,0L,6L,8L,0L,0L,8L,8L,1L,0L,8L,4L,7L,0L,4L,10L,0L,0L,8L,4L,5L,0L,0L,4L,3L,0L,4L,10L,6L,0L,12L,0L,2L,0L,4L,8L,8L,0L,4L,0L,0L,0L,14L,4L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191411Inst : IEnumerable<long>
{
public static readonly long[] Value=A191411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191411.Bytes);
public long this[int i]=>Value[i];

public static A191411Inst Instance=new A191411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191412
{
public static readonly long[] Value={ 1L,1L,3L,9L,34L,139L,643L,3198L,17186L,98438L,598551L,3842893L,25957607L,183858842L,1361853786L,10523285935L,84648613474L,707461189513L,6132612218266L,55050390426042L,510994289786018L,4898133459331104L,48424584171850411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191412Inst : IEnumerable<long>
{
public static readonly long[] Value=A191412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191412.Bytes);
public long this[int i]=>Value[i];

public static A191412Inst Instance=new A191412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191413
{
public static readonly long[] Value={ 7L,8L,15L,28L,47L,72L,103L,140L,183L,232L,287L,348L,415L,488L,567L,652L,743L,840L,943L,1052L,1167L,1288L,1415L,1548L,1687L,1832L,1983L,2140L,2303L,2472L,2647L,2828L,3015L,3208L,3407L,3612L,3823L,4040L,4263L,4492L,4727L,4968L,5215L,5468L,5727L,5992L,6263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191413Inst : IEnumerable<long>
{
public static readonly long[] Value=A191413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191413.Bytes);
public long this[int i]=>Value[i];

public static A191413Inst Instance=new A191413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191414
{
public static readonly long[] Value={ 1L,3L,8L,15L,24L,24L,48L,63L,80L,72L,120L,120L,168L,144L,192L,255L,288L,240L,360L,360L,384L,360L,528L,504L,624L,504L,728L,720L,840L,576L,960L,1023L,960L,864L,1152L,1200L,1368L,1080L,1344L,1512L,1680L,1152L,1848L,1800L,1920L,1584L,2208L,2040L,2400L,1872L,2304L,2520L,2808L,2184L,2880L,3024L,2880L,2520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191414Inst : IEnumerable<long>
{
public static readonly long[] Value=A191414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191414.Bytes);
public long this[int i]=>Value[i];

public static A191414Inst Instance=new A191414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191415
{
public static readonly BigInteger[] Value={ 1L,0L,6L,12L,340L,2340L,58338L,786240L,20890224L,428954400L,12845444040L,351885980160L,12049309321608L,408370359196800L,15960347878230000L,639599649237319680L,BigInteger.Parse("28303809398414031360"),BigInteger.Parse("1302999243310662912000"),BigInteger.Parse("64651744760744124697536"),BigInteger.Parse("3352722890027561625600000") };
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
public class A191415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191415Inst Instance=new A191415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191416
{
public static readonly long[] Value={ 1L,0L,2L,3L,16L,70L,360L,2212L,14488L,106272L,846530L,7287896L,67550052L,669276452L,7062219710L,79046250480L,935246925616L,11662366603504L,152856287604594L,2100714749805472L,30205647605518900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191416Inst : IEnumerable<long>
{
public static readonly long[] Value=A191416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191416.Bytes);
public long this[int i]=>Value[i];

public static A191416Inst Instance=new A191416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191417
{
public static readonly BigInteger[] Value={ 1L,0L,0L,4L,0L,0L,32L,0L,0L,384L,0L,0L,6912L,0L,0L,202752L,0L,0L,9060352L,0L,0L,537133056L,0L,0L,38729089024L,0L,0L,3250319523840L,0L,0L,309812206239744L,0L,0L,33002445042876416L,0L,0L,3882425071117008896L,0L,0L,BigInteger.Parse("499695395684082515968"),0L,0L };
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
public class A191417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191417Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191417.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191417Inst Instance=new A191417Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191418
{
public static readonly BigInteger[] Value={ 0L,2L,0L,0L,16L,0L,0L,192L,0L,0L,3456L,0L,0L,101376L,0L,0L,4530176L,0L,0L,268566528L,0L,0L,19364544512L,0L,0L,1625159761920L,0L,0L,154906103119872L,0L,0L,16501222521438208L,0L,0L,1941212535558504448L,0L,0L,BigInteger.Parse("249847697842041257984"),0L,0L,BigInteger.Parse("34914299540455999668224") };
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
public class A191418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191418Inst Instance=new A191418Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191419
{
public static readonly BigInteger[] Value={ 1L,0L,0L,8L,0L,0L,128L,0L,0L,2560L,0L,0L,60416L,0L,0L,1728512L,0L,0L,63438848L,0L,0L,3096477696L,0L,0L,196811685888L,0L,0L,15408280109056L,0L,0L,1413600665141248L,0L,0L,147160243434946560L,0L,0L,17047411713181220864UL,0L,0L,BigInteger.Parse("2169625122325921792000") };
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
public class A191419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191419Inst Instance=new A191419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191468
{
public static readonly long[] Value={ 0L,3L,39L,387L,3471L,29643L,246519L,2019027L,16386591L,132264603L,1063976199L,8541106467L,68475336111L,548535110763L,4391942995479L,35153854510707L,281322388820031L,2251036874232123L,18010583812216359L,144096114589527747L,1152826137175206351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191468Inst : IEnumerable<long>
{
public static readonly long[] Value=A191468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191468.Bytes);
public long this[int i]=>Value[i];

public static A191468Inst Instance=new A191468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191469
{
public static readonly long[] Value={ 2L,3L,6L,9L,21L,25L,33L,49L,54L,133L,245L,255L,318L,1023L,1486L,3334L,6821L,8555L,11605L,42502L,44409L,90291L,92511L,140303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191469Inst : IEnumerable<long>
{
public static readonly long[] Value=A191469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191469.Bytes);
public long this[int i]=>Value[i];

public static A191469Inst Instance=new A191469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191470
{
public static readonly BigInteger[] Value={ 1L,0L,2L,-3L,28L,-120L,1122L,-8127L,88096L,-885216L,11291624L,-143432883L,2131731944L,-32515910232L,555050034224L,-9845456006487L,190381188822016L,-3842126730651264L,83143449079579584L,-1878918839085535971L,BigInteger.Parse("45029979676319086976") };
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
public class A191470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191470Inst Instance=new A191470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191471
{
public static readonly long[] Value={ 1L,0L,2L,-3L,4L,-30L,162L,-252L,400L,-27912L,200744L,705672L,-4202296L,-223340208L,1418238416L,29398266888L,-114981277184L,-8193860510784L,30889433635776L,2261786651427072L,-3830504174333824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191471Inst : IEnumerable<long>
{
public static readonly long[] Value=A191471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191471.Bytes);
public long this[int i]=>Value[i];

public static A191471Inst Instance=new A191471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191472
{
public static readonly long[] Value={ 5L,6L,10L,8L,10L,8L,10L,16L,10L,14L,14L,8L,10L,16L,18L,10L,14L,14L,8L,14L,14L,16L,22L,16L,8L,10L,8L,10L,32L,22L,16L,10L,22L,14L,14L,18L,14L,16L,18L,10L,22L,14L,10L,8L,26L,36L,20L,8L,10L,16L,10L,22L,22L,18L,18L,10L,14L,14L,8L,22L,38L,22L,8L,10L,32L,26L,26L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191472Inst : IEnumerable<long>
{
public static readonly long[] Value=A191472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191472.Bytes);
public long this[int i]=>Value[i];

public static A191472Inst Instance=new A191472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191473
{
public static readonly long[] Value={ 3L,5L,7L,13L,31L,37L,79L,109L,127L,157L,199L,229L,367L,397L,607L,661L,727L,829L,967L,997L,1039L,1213L,1399L,1693L,1759L,1789L,1999L,2053L,2143L,2221L,2383L,2389L,2503L,3229L,3319L,3469L,3823L,4093L,4159L,4357L,4591L,4597L,4639L,4789L,4903L,4933L,5431L,5581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191473Inst : IEnumerable<long>
{
public static readonly long[] Value=A191473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191473.Bytes);
public long this[int i]=>Value[i];

public static A191473Inst Instance=new A191473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191474
{
public static readonly long[] Value={ 2L,5L,3L,549755813881L,5L,3L,47L,13L,41L,3L,97L,2011L,23L,536870869L,17L,11L,5L,3L,61L,953L,439L,433L,173L,167L,31L,536870869L,409L,149L,19L,911L,140737488355201L,16253L,887L,373L,107L,2147483497L,32611L,349L,89L,83L,3917L,331L,16193L,2096959L,59L,313L,33554221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191474Inst : IEnumerable<long>
{
public static readonly long[] Value=A191474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191474.Bytes);
public long this[int i]=>Value[i];

public static A191474Inst Instance=new A191474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191475
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,1L,3L,5L,2L,4L,1L,6L,3L,5L,2L,7L,4L,1L,6L,3L,8L,5L,2L,7L,4L,1L,9L,6L,3L,8L,5L,2L,10L,7L,4L,1L,9L,6L,3L,11L,8L,5L,2L,10L,7L,4L,12L,1L,9L,6L,3L,11L,8L,5L,13L,2L,10L,7L,4L,12L,1L,9L,6L,14L,3L,11L,8L,5L,13L,2L,10L,7L,15L,4L,12L,1L,9L,6L,14L,3L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191475Inst : IEnumerable<long>
{
public static readonly long[] Value=A191475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191475.Bytes);
public long this[int i]=>Value[i];

public static A191475Inst Instance=new A191475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191476
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,2L,1L,3L,2L,4L,1L,3L,2L,4L,1L,3L,5L,2L,4L,1L,3L,5L,2L,4L,6L,1L,3L,5L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,1L,8L,3L,5L,7L,2L,4L,6L,1L,8L,3L,5L,7L,2L,9L,4L,6L,1L,8L,3L,5L,7L,2L,9L,4L,6L,1L,8L,3L,10L,5L,7L,2L,9L,4L,6L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191476Inst : IEnumerable<long>
{
public static readonly long[] Value=A191476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191476.Bytes);
public long this[int i]=>Value[i];

public static A191476Inst Instance=new A191476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191477
{
public static readonly BigInteger[] Value={ 2L,5L,15L,92L,716L,8595L,156804L,4204649L,170016558L,10240395108L,922770471915L,124331209274267L,25029189338772296L,7533759271342997075L,BigInteger.Parse("3389438730483714015640"),BigInteger.Parse("2279436096066483952197622") };
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
public class A191477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191477.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191477Inst Instance=new A191477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191478
{
public static readonly BigInteger[] Value={ 2L,7L,28L,231L,3022L,63851L,2254102L,129926375L,12346854981L,1930513304865L,496013097993148L,209682700667891310L,BigInteger.Parse("145774046555290357339"),BigInteger.Parse("166670977286765976049136"),BigInteger.Parse("313418443881609705847873703") };
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
public class A191478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191478.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191478Inst Instance=new A191478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191479
{
public static readonly BigInteger[] Value={ 2L,8L,42L,445L,8336L,273578L,16060725L,1663317205L,304789975903L,99026690954574L,56934478978072688L,BigInteger.Parse("57952230532394115913"),BigInteger.Parse("104449989219446543530778"),BigInteger.Parse("333288010626782017792094457"),BigInteger.Parse("1882901103468898454919475637369") };
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
public class A191479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191479.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191479Inst Instance=new A191479Inst();

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