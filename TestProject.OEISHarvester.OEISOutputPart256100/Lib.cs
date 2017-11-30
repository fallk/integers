using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A136114
{
public static readonly long[] Value={ 0L,0L,0L,70L,0L,0L,782L,0L,0L,3432L,0L,715L,10045L,3290L,0L,23375L,1001L,0L,715L,2035L,7526L,84847L,0L,0L,1001L,41251L,0L,4030L,64170L,32340L,20475L,14652L,11310L,490490L,7740L,6700L,5922L,190995L,4845L,18095L,259376L,3876L,1260875L,10045L,3290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136114Inst : IEnumerable<long>
{
public static readonly long[] Value=A136114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136114.Bytes);
public long this[int i]=>Value[i];

public static A136114Inst Instance=new A136114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136115
{
public static readonly long[] Value={ 0L,0L,0L,7L,0L,0L,23L,0L,0L,48L,0L,22L,82L,47L,0L,125L,26L,0L,22L,37L,71L,238L,0L,0L,26L,166L,0L,52L,207L,147L,117L,99L,87L,572L,72L,67L,63L,357L,57L,110L,416L,51L,917L,82L,47L,1050L,217L,380L,167L,246L,0L,97L,697L,0L,374L,191L,537L,1672L,152L,112L,136L,380L,215L,2037L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136115Inst : IEnumerable<long>
{
public static readonly long[] Value=A136115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136115.Bytes);
public long this[int i]=>Value[i];

public static A136115Inst Instance=new A136115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136116
{
public static readonly long[] Value={ 7L,8L,24L,25L,29L,31L,36L,42L,49L,59L,65L,66L,69L,72L,73L,74L,76L,80L,83L,93L,94L,99L,102L,104L,110L,117L,118L,121L,122L,123L,124L,126L,127L,138L,140L,144L,149L,150L,152L,161L,163L,168L,169L,174L,175L,178L,181L,185L,188L,190L,195L,199L,203L,209L,210L,212L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136116Inst : IEnumerable<long>
{
public static readonly long[] Value=A136116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136116.Bytes);
public long this[int i]=>Value[i];

public static A136116Inst Instance=new A136116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136117
{
public static readonly long[] Value={ 70L,92L,852L,925L,1247L,1426L,1926L,2625L,3577L,5192L,6305L,6501L,7107L,7740L,7957L,8177L,8626L,9560L,10292L,12927L,13207L,14652L,15555L,16172L,18095L,20475L,20827L,21901L,22265L,22632L,23002L,23751L,24130L,28497L,29330L,31032L,33227L,33675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136117Inst : IEnumerable<long>
{
public static readonly long[] Value=A136117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136117.Bytes);
public long this[int i]=>Value[i];

public static A136117Inst Instance=new A136117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136118
{
public static readonly long[] Value={ 5L,4L,7L,12L,19L,17L,25L,20L,10L,28L,45L,42L,39L,17L,37L,21L,36L,35L,13L,33L,65L,28L,67L,32L,52L,40L,74L,31L,70L,85L,35L,16L,60L,70L,77L,68L,42L,30L,105L,76L,59L,26L,74L,49L,115L,19L,125L,115L,102L,110L,92L,56L,103L,29L,145L,100L,114L,77L,92L,47L,63L,108L,152L,95L,22L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136118Inst : IEnumerable<long>
{
public static readonly long[] Value=A136118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136118.Bytes);
public long this[int i]=>Value[i];

public static A136118Inst Instance=new A136118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136119
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,10L,11L,13L,14L,15L,17L,18L,20L,21L,22L,24L,25L,27L,28L,29L,31L,32L,34L,35L,37L,38L,39L,41L,42L,44L,45L,46L,48L,49L,51L,52L,54L,55L,56L,58L,59L,61L,62L,63L,65L,66L,68L,69L,71L,72L,73L,75L,76L,78L,79L,80L,82L,83L,85L,86L,87L,89L,90L,92L,93L,95L,96L,97L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136119Inst : IEnumerable<long>
{
public static readonly long[] Value=A136119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136119.Bytes);
public long this[int i]=>Value[i];

public static A136119Inst Instance=new A136119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136152
{
public static readonly long[] Value={ 30L,42L,60L,84L,90L,102L,110L,114L,132L,138L,140L,150L,168L,174L,180L,182L,198L,228L,230L,234L,240L,252L,258L,264L,270L,282L,294L,308L,312L,318L,348L,350L,354L,360L,374L,380L,402L,410L,434L,440L,444L,450L,468L,480L,492L,504L,522L,558L,564L,572L,588L,594L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136152Inst : IEnumerable<long>
{
public static readonly long[] Value=A136152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136152.Bytes);
public long this[int i]=>Value[i];

public static A136152Inst Instance=new A136152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136153
{
public static readonly long[] Value={ 390L,420L,462L,510L,570L,660L,770L,798L,840L,858L,930L,1020L,1050L,1092L,1110L,1218L,1230L,1260L,1290L,1302L,1320L,1410L,1428L,1430L,1482L,1554L,1560L,1610L,1638L,1710L,1722L,1848L,1890L,1914L,1932L,1950L,1974L,1980L,2030L,2040L,2070L,2090L,2100L,2130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136153Inst : IEnumerable<long>
{
public static readonly long[] Value=A136153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136153.Bytes);
public long this[int i]=>Value[i];

public static A136153Inst Instance=new A136153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136154
{
public static readonly long[] Value={ 2310L,2730L,3990L,4290L,6090L,6270L,7590L,7854L,8610L,8970L,9030L,9240L,9282L,9690L,10010L,10710L,11550L,11970L,12012L,12540L,12810L,13110L,13260L,13398L,13650L,13860L,14322L,14490L,14630L,15330L,15810L,15960L,16302L,16422L,16530L,16380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136154Inst : IEnumerable<long>
{
public static readonly long[] Value=A136154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136154.Bytes);
public long this[int i]=>Value[i];

public static A136154Inst Instance=new A136154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136155
{
public static readonly long[] Value={ 6L,12L,14L,18L,20L,24L,30L,38L,42L,44L,48L,54L,60L,62L,68L,72L,74L,80L,84L,90L,98L,102L,104L,108L,110L,114L,132L,138L,140L,150L,152L,158L,164L,168L,174L,180L,182L,192L,194L,198L,200L,212L,224L,228L,230L,234L,240L,242L,252L,258L,264L,270L,272L,278L,282L,284L,294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136155Inst : IEnumerable<long>
{
public static readonly long[] Value=A136155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136155.Bytes);
public long this[int i]=>Value[i];

public static A136155Inst Instance=new A136155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136156
{
public static readonly BigInteger[] Value={ 2L,1L,2L,30L,24L,1L,720L,15L,560L,12L,3628800L,10L,479001600L,360L,8L,315L,20922789888000L,280L,6402373705728000L,6L,240L,1814400L,BigInteger.Parse("1124000727777607680000"),5L,1596672L,239500800L,1478400L,180L,BigInteger.Parse("304888344611713860501504000000"),4L,BigInteger.Parse("265252859812191058636308480000000") };
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
public class A136156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136156.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136156Inst Instance=new A136156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136157
{
public static readonly long[] Value={ 3L,1L,3L,0L,1L,3L,0L,0L,1L,3L,0L,0L,0L,1L,3L,0L,0L,0L,0L,1L,3L,0L,0L,0L,0L,0L,1L,3L,0L,0L,0L,0L,0L,0L,1L,3L,0L,0L,0L,0L,0L,0L,0L,1L,3L,0L,0L,0L,0L,0L,0L,0L,0L,1L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136157Inst : IEnumerable<long>
{
public static readonly long[] Value=A136157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136157.Bytes);
public long this[int i]=>Value[i];

public static A136157Inst Instance=new A136157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136158
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,9L,15L,7L,1L,27L,54L,36L,10L,1L,81L,189L,162L,66L,13L,1L,243L,648L,675L,360L,105L,16L,1L,729L,2187L,2673L,1755L,675L,153L,19L,1L,2187L,7290L,10206L,7938L,3780L,1134L,210L,22L,1L,6561L,24057L,37908L,34020L,19278L,7182L,1764L,276L,25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136158Inst : IEnumerable<long>
{
public static readonly long[] Value=A136158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136158.Bytes);
public long this[int i]=>Value[i];

public static A136158Inst Instance=new A136158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136159
{
public static readonly long[] Value={ 1L,1L,3L,-1L,9L,-4L,27L,-15L,1L,81L,-54L,7L,243L,-189L,36L,-1L,729L,-648L,162L,-10L,2187L,-2187L,675L,-66L,1L,6561L,-7290L,2673L,-360L,13L,19683L,-24057L,10206L,-1755L,105L,-1L,59049L,-78732L,37908L,-7938L,675L,-16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136159Inst : IEnumerable<long>
{
public static readonly long[] Value=A136159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136159.Bytes);
public long this[int i]=>Value[i];

public static A136159Inst Instance=new A136159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136160
{
public static readonly long[] Value={ 1L,0L,4L,-3L,0L,12L,0L,-16L,0L,32L,5L,0L,-60L,0L,80L,0L,36L,0L,-192L,0L,192L,-7L,0L,168L,0L,-560L,0L,448L,0L,-64L,0L,640L,0L,-1536L,0L,1024L,9L,0L,-360L,0L,2160L,0L,-4032L,0L,2304L,0L,100L,0L,-1600L,0L,6720L,0L,-10240L,0L,5120L,-11L,0L,660L,0L,-6160L,0L,19712L,0L,-25344L,0L,11264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136160Inst : IEnumerable<long>
{
public static readonly long[] Value=A136160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136160.Bytes);
public long this[int i]=>Value[i];

public static A136160Inst Instance=new A136160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136161
{
public static readonly long[] Value={ 0L,5L,2L,1L,3L,1L,2L,1L,0L,3L,-1L,-1L,4L,-3L,-2L,5L,-5L,-3L,6L,-7L,-4L,7L,-9L,-5L,8L,-11L,-6L,9L,-13L,-7L,10L,-15L,-8L,11L,-17L,-9L,12L,-19L,-10L,13L,-21L,-11L,14L,-23L,-12L,15L,-25L,-13L,16L,-27L,-14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136161Inst : IEnumerable<long>
{
public static readonly long[] Value=A136161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136161.Bytes);
public long this[int i]=>Value[i];

public static A136161Inst Instance=new A136161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136162
{
public static readonly long[] Value={ 5L,7L,11L,13L,11L,13L,17L,19L,101L,103L,107L,109L,191L,193L,197L,199L,821L,823L,827L,829L,1481L,1483L,1487L,1489L,1871L,1873L,1877L,1879L,2081L,2083L,2087L,2089L,3251L,3253L,3257L,3259L,3461L,3463L,3467L,3469L,5651L,5653L,5657L,5659L,9431L,9433L,9437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136162Inst : IEnumerable<long>
{
public static readonly long[] Value=A136162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136162.Bytes);
public long this[int i]=>Value[i];

public static A136162Inst Instance=new A136162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136163
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,-3L,0L,2L,4L,0L,-12L,0L,8L,-1L,15L,0L,-40L,0L,24L,-4L,0L,60L,0L,-120L,0L,64L,-1L,-35L,0L,210L,0L,-336L,0L,160L,8L,0L,-168L,0L,672L,0L,-896L,0L,384L,-1L,63L,0L,-672L,0L,2016L,0L,-2304L,0L,896L,-8L,0L,360L,0L,-2400L,0L,5760L,0L,-5760L,0L,2048L,-1L,-99L,0L,1650L,0L,-7920L,0L,15840L,0L,-14080L,0L,4608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136163Inst : IEnumerable<long>
{
public static readonly long[] Value=A136163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136163.Bytes);
public long this[int i]=>Value[i];

public static A136163Inst Instance=new A136163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136164
{
public static readonly long[] Value={ 0L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,4L,2L,3L,3L,2L,2L,3L,2L,4L,3L,3L,2L,4L,2L,3L,2L,4L,2L,5L,2L,2L,3L,3L,3L,4L,2L,3L,3L,5L,2L,5L,2L,4L,4L,3L,2L,4L,2L,3L,3L,4L,2L,3L,3L,5L,3L,3L,2L,6L,2L,3L,4L,2L,3L,5L,2L,4L,3L,5L,2L,6L,2L,3L,3L,4L,3L,5L,2L,5L,2L,3L,2L,7L,3L,3L,3L,4L,2L,7L,3L,4L,3L,3L,3L,4L,2L,3L,4L,4L,2L,5L,2L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136164Inst : IEnumerable<long>
{
public static readonly long[] Value=A136164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136164.Bytes);
public long this[int i]=>Value[i];

public static A136164Inst Instance=new A136164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136165
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,2L,2L,1L,1L,2L,2L,3L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,3L,1L,2L,1L,1L,2L,4L,2L,1L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,1L,3L,2L,2L,3L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,5L,2L,2L,3L,1L,2L,2L,2L,1L,2L,4L,2L,3L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,4L,2L,2L,2L,1L,2L,4L,2L,1L,2L,2L,2L,3L,2L,2L,1L,1L,2L,2L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136165Inst : IEnumerable<long>
{
public static readonly long[] Value=A136165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136165.Bytes);
public long this[int i]=>Value[i];

public static A136165Inst Instance=new A136165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136166
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,2L,0L,3L,2L,2L,0L,3L,0L,2L,2L,4L,0L,4L,0L,5L,2L,2L,0L,5L,2L,2L,3L,5L,0L,4L,0L,5L,2L,2L,2L,6L,0L,2L,2L,6L,0L,6L,0L,5L,3L,2L,0L,7L,2L,4L,2L,5L,0L,6L,2L,6L,2L,2L,0L,7L,0L,2L,3L,6L,2L,6L,0L,5L,2L,4L,0L,9L,0L,2L,4L,5L,2L,6L,0L,8L,4L,2L,0L,8L,2L,2L,2L,7L,0L,8L,2L,5L,2L,2L,2L,9L,0L,4L,5L,8L,0L,6L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136166Inst : IEnumerable<long>
{
public static readonly long[] Value=A136166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136166.Bytes);
public long this[int i]=>Value[i];

public static A136166Inst Instance=new A136166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136167
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,2L,1L,1L,0L,2L,0L,1L,1L,3L,0L,3L,0L,2L,1L,1L,0L,4L,1L,1L,2L,2L,0L,3L,0L,4L,1L,1L,1L,5L,0L,1L,1L,3L,0L,3L,0L,2L,2L,1L,0L,6L,1L,3L,1L,2L,0L,5L,1L,3L,1L,1L,0L,6L,0L,1L,2L,5L,1L,3L,0L,2L,1L,3L,0L,6L,0L,1L,3L,2L,1L,3L,0L,5L,3L,1L,0L,5L,1L,1L,1L,4L,0L,5L,1L,2L,1L,1L,1L,8L,0L,3L,2L,5L,0L,3L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136167Inst : IEnumerable<long>
{
public static readonly long[] Value=A136167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136167.Bytes);
public long this[int i]=>Value[i];

public static A136167Inst Instance=new A136167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136232
{
public static readonly long[] Value={ 1L,4L,1L,24L,8L,1L,198L,76L,12L,1L,2116L,888L,156L,16L,1L,28052L,12542L,2350L,264L,20L,1L,446560L,209506L,41034L,4864L,400L,24L,1L,8325700L,4058806L,821562L,100988L,8710L,564L,28L,1L,178284892L,89706276L,18631332L,2352116L,209440L,14168L,756L,32L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136232Inst : IEnumerable<long>
{
public static readonly long[] Value=A136232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136232.Bytes);
public long this[int i]=>Value[i];

public static A136232Inst Instance=new A136232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136233
{
public static readonly long[] Value={ 1L,2L,1L,10L,8L,1L,75L,76L,14L,1L,753L,888L,196L,20L,1L,9534L,12542L,3087L,370L,26L,1L,146353L,209506L,55552L,7320L,598L,32L,1L,2647628L,4058806L,1136975L,159645L,14235L,880L,38L,1L,55251994L,89706276L,26224597L,3856065L,364403L,24480L,1216L,44L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136233Inst : IEnumerable<long>
{
public static readonly long[] Value=A136233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136233.Bytes);
public long this[int i]=>Value[i];

public static A136233Inst Instance=new A136233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136234
{
public static readonly long[] Value={ 1L,4L,1L,26L,10L,1L,232L,110L,16L,1L,2657L,1435L,248L,22L,1L,37405L,22135L,4240L,440L,28L,1L,627435L,397820L,81708L,9295L,686L,34L,1L,12248365L,8203057L,1773156L,214478L,17248L,986L,40L,1L,273211787L,191405232L,43039532L,5442349L,463267L,28747L,1340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136234Inst : IEnumerable<long>
{
public static readonly long[] Value=A136234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136234.Bytes);
public long this[int i]=>Value[i];

public static A136234Inst Instance=new A136234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136235
{
public static readonly long[] Value={ 1L,6L,1L,48L,12L,1L,495L,150L,18L,1L,6338L,2160L,306L,24L,1L,97681L,36103L,5643L,516L,30L,1L,1767845L,694079L,115917L,11592L,780L,36L,1L,36839663L,15164785L,2657946L,282122L,20655L,1098L,42L,1L,870101407L,372225541L,67708113L,7502470L,580780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136235Inst : IEnumerable<long>
{
public static readonly long[] Value=A136235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136235.Bytes);
public long this[int i]=>Value[i];

public static A136235Inst Instance=new A136235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136236
{
public static readonly long[] Value={ 1L,3L,1L,21L,12L,1L,208L,156L,21L,1L,2637L,2350L,399L,30L,1L,40731L,41034L,8029L,750L,39L,1L,742620L,821562L,177198L,18865L,1209L,48L,1L,15624420L,18631332L,4317936L,502335L,36478L,1776L,57L,1L,372892266L,473187270L,115949841L,14390880L,1136811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136236Inst : IEnumerable<long>
{
public static readonly long[] Value=A136236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136236.Bytes);
public long this[int i]=>Value[i];

public static A136236Inst Instance=new A136236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136237
{
public static readonly long[] Value={ 1L,6L,1L,54L,15L,1L,629L,225L,24L,1L,9003L,3770L,504L,33L,1L,153276L,71655L,10988L,891L,42L,1L,3031553L,1539315L,259236L,23903L,1386L,51L,1L,68406990L,37072448L,6688092L,672672L,44135L,1989L,60L,1L,1736020806L,992226060L,188767184L,20225436L,1442049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136237Inst : IEnumerable<long>
{
public static readonly long[] Value=A136237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136237.Bytes);
public long this[int i]=>Value[i];

public static A136237Inst Instance=new A136237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136238
{
public static readonly long[] Value={ 1L,9L,1L,99L,18L,1L,1323L,306L,27L,1L,21036L,5643L,621L,36L,1L,390012L,115917L,14580L,1044L,45L,1L,8287041L,2657946L,366129L,29754L,1575L,54L,1L,198918840L,67708113L,9968067L,882318L,52785L,2214L,63L,1L,5329794042L,1903562412L,294952140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136238Inst : IEnumerable<long>
{
public static readonly long[] Value=A136238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136238.Bytes);
public long this[int i]=>Value[i];

public static A136238Inst Instance=new A136238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136239
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,-1L,-3L,0L,1L,9L,0L,-6L,0L,1L,-1L,27L,0L,-10L,0L,1L,-19L,0L,65L,0L,-15L,0L,1L,-1L,-165L,0L,135L,0L,-21L,0L,1L,399L,0L,-624L,0L,252L,0L,-28L,0L,1L,-1L,2145L,0L,-1750L,0L,434L,0L,-36L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136239Inst : IEnumerable<long>
{
public static readonly long[] Value=A136239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136239.Bytes);
public long this[int i]=>Value[i];

public static A136239Inst Instance=new A136239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136240
{
public static readonly long[] Value={ 1L,2L,6L,12L,66L,78L,138L,150L,162L,192L,336L,348L,378L,456L,540L,612L,642L,726L,768L,918L,990L,1020L,1092L,1116L,1200L,1230L,1380L,1422L,1548L,1566L,1596L,1620L,1692L,1746L,1788L,1800L,1932L,1986L,2010L,2016L,2112L,2136L,2142L,2238L,2280L,2556L,2646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136240Inst : IEnumerable<long>
{
public static readonly long[] Value=A136240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136240.Bytes);
public long this[int i]=>Value[i];

public static A136240Inst Instance=new A136240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136241
{
public static readonly long[] Value={ 2L,4L,6L,10L,16L,28L,30L,46L,60L,66L,70L,96L,100L,126L,130L,138L,148L,180L,196L,240L,268L,306L,330L,358L,378L,396L,408L,418L,420L,448L,456L,478L,486L,490L,598L,606L,616L,618L,640L,646L,676L,708L,750L,786L,838L,856L,906L,946L,966L,976L,996L,1050L,1060L,1090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136241Inst : IEnumerable<long>
{
public static readonly long[] Value=A136241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136241.Bytes);
public long this[int i]=>Value[i];

public static A136241Inst Instance=new A136241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136242
{
public static readonly long[] Value={ 3L,4L,6L,18L,42L,60L,72L,90L,102L,132L,168L,174L,294L,384L,678L,702L,744L,762L,774L,828L,840L,858L,912L,1092L,1098L,1164L,1182L,1194L,1218L,1374L,1428L,1488L,1560L,1584L,1710L,1812L,1848L,1932L,1974L,2130L,2274L,2310L,2340L,2412L,2664L,2730L,2790L,2958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136242Inst : IEnumerable<long>
{
public static readonly long[] Value=A136242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136242.Bytes);
public long this[int i]=>Value[i];

public static A136242Inst Instance=new A136242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136243
{
public static readonly long[] Value={ 3L,4L,6L,12L,14L,20L,32L,42L,54L,60L,84L,90L,102L,104L,132L,150L,164L,182L,192L,200L,234L,242L,264L,282L,332L,350L,374L,402L,420L,432L,434L,450L,462L,464L,500L,542L,570L,572L,660L,674L,684L,692L,710L,740L,744L,762L,770L,810L,864L,882L,942L,1014L,1040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136243Inst : IEnumerable<long>
{
public static readonly long[] Value=A136243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136243.Bytes);
public long this[int i]=>Value[i];

public static A136243Inst Instance=new A136243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136244
{
public static readonly long[] Value={ 2L,5L,11L,17L,21L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136244Inst : IEnumerable<long>
{
public static readonly long[] Value=A136244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136244.Bytes);
public long this[int i]=>Value[i];

public static A136244Inst Instance=new A136244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136245
{
public static readonly BigInteger[] Value={ 1L,1L,31L,2649L,441061L,121105865L,49615422851L,28371278927921L,21590240845164949L,BigInteger.Parse("21097596332115411641"),BigInteger.Parse("25747535208630845100139"),BigInteger.Parse("38380480386387824213385401"),BigInteger.Parse("68621153798435104081277748401") };
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
public class A136245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136245Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136245.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136245Inst Instance=new A136245Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136246
{
public static readonly BigInteger[] Value={ 1L,1L,32L,2712L,449102L,122886128L,50225389432L,28670796914144L,21789885975738524L,BigInteger.Parse("21271115441652577064"),BigInteger.Parse("25938193213744579451420"),BigInteger.Parse("38638907727108476424404864"),BigInteger.Parse("69044758685363149615280762608") };
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
public class A136246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136246Inst Instance=new A136246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136247
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,1L,1L,2L,2L,-1L,1L,6L,-4L,-3L,1L,1L,-4L,-20L,6L,4L,-1L,1L,-40L,8L,44L,-8L,-5L,1L,1L,-12L,188L,-6L,-80L,10L,6L,-1L,1L,308L,136L,-546L,-10L,130L,-12L,-7L,1L,1L,416L,-1864L,-628L,1256L,50L,-196L,14L,8L,-1L,1L,-2664L,-3640L,6696L,1984L,-2506L,-126L,280L,-16L,-9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136247Inst : IEnumerable<long>
{
public static readonly long[] Value=A136247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136247.Bytes);
public long this[int i]=>Value[i];

public static A136247Inst Instance=new A136247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136312
{
public static readonly long[] Value={ 103823L,274625L,781229961L,10091699281L,22425768000L,1853614522304L,2277044900416L,4708686519081L,6168761704000L,82312875000000L,235125028708361L,259266910222125L,269648738245125L,291658484677013L,980893000925279L,1568173521032000L,1816249897646729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136312Inst : IEnumerable<long>
{
public static readonly long[] Value=A136312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136312.Bytes);
public long this[int i]=>Value[i];

public static A136312Inst Instance=new A136312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136313
{
public static readonly long[] Value={ 1L,9L,17L,3L,11L,19L,5L,13L,21L,7L,15L,1L,9L,17L,3L,11L,19L,5L,13L,21L,7L,15L,1L,9L,17L,3L,11L,19L,5L,13L,21L,7L,15L,1L,9L,17L,3L,11L,19L,5L,13L,21L,7L,15L,1L,9L,17L,3L,11L,19L,5L,13L,21L,7L,15L,1L,9L,17L,3L,11L,19L,5L,13L,21L,7L,15L,1L,9L,17L,3L,11L,19L,5L,13L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136313Inst : IEnumerable<long>
{
public static readonly long[] Value=A136313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136313.Bytes);
public long this[int i]=>Value[i];

public static A136313Inst Instance=new A136313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136314
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136314Inst : IEnumerable<long>
{
public static readonly long[] Value=A136314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136314.Bytes);
public long this[int i]=>Value[i];

public static A136314Inst Instance=new A136314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136315
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,0L,7L,4L,9L,8L,1L,2L,3L,6L,5L,0L,7L,4L,9L,8L,1L,2L,3L,6L,5L,0L,7L,4L,9L,8L,1L,2L,3L,6L,5L,0L,7L,4L,9L,8L,1L,2L,3L,6L,5L,0L,7L,4L,9L,8L,1L,2L,3L,6L,5L,0L,7L,4L,9L,8L,1L,2L,3L,6L,5L,0L,7L,4L,9L,8L,1L,2L,3L,6L,5L,0L,7L,4L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136315Inst : IEnumerable<long>
{
public static readonly long[] Value=A136315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136315.Bytes);
public long this[int i]=>Value[i];

public static A136315Inst Instance=new A136315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136316
{
public static readonly long[] Value={ 13L,24L,33L,40L,45L,48L,49L,48L,45L,40L,33L,24L,13L,0L,-15L,-32L,-51L,-72L,-95L,-120L,-147L,-176L,-207L,-240L,-275L,-312L,-351L,-392L,-435L,-480L,-527L,-576L,-627L,-680L,-735L,-792L,-851L,-912L,-975L,-1040L,-1107L,-1176L,-1247L,-1320L,-1395L,-1472L,-1551L,-1632L,-1715L,-1800L,-1887L,-1976L,-2067L,-2160L,-2255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136316Inst : IEnumerable<long>
{
public static readonly long[] Value=A136316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136316.Bytes);
public long this[int i]=>Value[i];

public static A136316Inst Instance=new A136316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136317
{
public static readonly long[] Value={ 1L,2L,11L,29L,38L,47L,56L,65L,74L,83L,92L,119L,128L,137L,2999L,3899L,3989L,3998L,4799L,4889L,4898L,4979L,4988L,4997L,5699L,5789L,5798L,5879L,5888L,5897L,5969L,5978L,5987L,5996L,6599L,6689L,6698L,6779L,6788L,6797L,6869L,6878L,6887L,29999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136317Inst : IEnumerable<long>
{
public static readonly long[] Value=A136317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136317.Bytes);
public long this[int i]=>Value[i];

public static A136317Inst Instance=new A136317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136318
{
public static readonly long[] Value={ 5L,9L,10L,17L,18L,20L,33L,34L,36L,40L,65L,66L,68L,72L,80L,129L,130L,132L,136L,144L,160L,257L,258L,260L,264L,272L,288L,320L,513L,514L,516L,520L,528L,544L,576L,640L,1025L,1026L,1028L,1032L,1040L,1056L,1088L,1152L,1280L,2049L,2050L,2052L,2056L,2064L,2080L,2112L,2176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136318Inst : IEnumerable<long>
{
public static readonly long[] Value=A136318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136318.Bytes);
public long this[int i]=>Value[i];

public static A136318Inst Instance=new A136318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136319
{
public static readonly long[] Value={ 2L,0L,9L,5L,2L,9L,3L,9L,8L,5L,2L,2L,3L,9L,1L,4L,4L,9L,2L,7L,4L,6L,8L,1L,6L,7L,1L,8L,8L,6L,6L,2L,8L,2L,5L,8L,3L,1L,6L,6L,4L,1L,1L,5L,2L,7L,5L,7L,3L,8L,3L,6L,8L,9L,4L,4L,0L,4L,7L,7L,5L,5L,4L,6L,6L,5L,4L,5L,3L,7L,8L,5L,0L,7L,6L,3L,9L,7L,8L,6L,1L,3L,7L,5L,2L,1L,8L,3L,6L,1L,4L,3L,0L,7L,4L,7L,1L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136319Inst : IEnumerable<long>
{
public static readonly long[] Value=A136319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136319.Bytes);
public long this[int i]=>Value[i];

public static A136319Inst Instance=new A136319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136320
{
public static readonly long[] Value={ 3L,1L,9L,7L,15L,13L,21L,19L,27L,25L,33L,31L,39L,37L,45L,43L,51L,49L,57L,55L,63L,61L,69L,67L,75L,73L,81L,79L,87L,85L,93L,91L,99L,97L,105L,103L,111L,109L,117L,115L,123L,121L,129L,127L,135L,133L,141L,139L,147L,145L,153L,151L,159L,157L,165L,163L,171L,169L,177L,175L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136320Inst : IEnumerable<long>
{
public static readonly long[] Value=A136320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136320.Bytes);
public long this[int i]=>Value[i];

public static A136320Inst Instance=new A136320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136321
{
public static readonly long[] Value={ 1L,-2L,1L,-1L,-4L,1L,4L,6L,-6L,1L,-7L,-4L,17L,-8L,1L,10L,-5L,-32L,32L,-10L,1L,-13L,24L,42L,-88L,51L,-12L,1L,16L,-56L,-28L,186L,-180L,74L,-14L,1L,-19L,104L,-42L,-312L,495L,-316L,101L,-16L,1L,22L,-171L,216L,396L,-1122L,1053L,-504L,132L,-18L,1L,-25L,260L,-561L,-264L,2145L,-2912L,1960L,-752L,167L,-20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136321Inst : IEnumerable<long>
{
public static readonly long[] Value=A136321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136321.Bytes);
public long this[int i]=>Value[i];

public static A136321Inst Instance=new A136321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136322
{
public static readonly long[] Value={ 1L,2L,4L,7L,14L,27L,54L,107L,213L,425L,849L,1697L,3394L,6787L,13573L,27146L,54292L,108584L,217168L,434335L,868669L,1737338L,3474676L,6949351L,13898701L,27797402L,55594804L,111189607L,222379213L,444758426L,889516852L,1779033704L,3558067408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136322Inst : IEnumerable<long>
{
public static readonly long[] Value=A136322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136322.Bytes);
public long this[int i]=>Value[i];

public static A136322Inst Instance=new A136322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136323
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,7L,1L,3L,5L,6L,3L,8L,6L,3L,1L,7L,1L,2L,2L,8L,5L,5L,7L,4L,2L,3L,7L,9L,1L,1L,6L,6L,8L,2L,6L,6L,1L,5L,1L,5L,8L,5L,8L,9L,2L,4L,5L,0L,1L,7L,1L,2L,1L,6L,9L,1L,6L,8L,5L,6L,8L,1L,2L,3L,3L,9L,7L,0L,9L,4L,4L,2L,9L,2L,5L,9L,6L,5L,5L,9L,1L,8L,2L,7L,4L,5L,1L,8L,2L,9L,2L,0L,9L,4L,0L,0L,5L,6L,3L,3L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136323Inst : IEnumerable<long>
{
public static readonly long[] Value=A136323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136323.Bytes);
public long this[int i]=>Value[i];

public static A136323Inst Instance=new A136323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136324
{
public static readonly long[] Value={ 0L,1L,1L,2L,5L,6L,21L,22L,85L,86L,341L,342L,1365L,1366L,5461L,5462L,21845L,21846L,87381L,87382L,349525L,349526L,1398101L,1398102L,5592405L,5592406L,22369621L,22369622L,89478485L,89478486L,357913941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136324Inst : IEnumerable<long>
{
public static readonly long[] Value=A136324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136324.Bytes);
public long this[int i]=>Value[i];

public static A136324Inst Instance=new A136324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136325
{
public static readonly long[] Value={ 0L,3L,24L,189L,1488L,11715L,92232L,726141L,5716896L,45009027L,354355320L,2789833533L,21964312944L,172924670019L,1361433047208L,10718539707645L,84386884613952L,664376537203971L,5230625413017816L,41180626766938557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136325Inst : IEnumerable<long>
{
public static readonly long[] Value=A136325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136325.Bytes);
public long this[int i]=>Value[i];

public static A136325Inst Instance=new A136325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136326
{
public static readonly long[] Value={ 1L,2L,4L,9L,17L,37L,69L,149L,277L,597L,1109L,2389L,4437L,9557L,17749L,38229L,70997L,152917L,283989L,611669L,1135957L,2446677L,4543829L,9786709L,18175317L,39146837L,72701269L,156587349L,290805077L,626349397L,1163220309L,2505397589L,4652881237L,10021590357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136326Inst : IEnumerable<long>
{
public static readonly long[] Value=A136326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136326.Bytes);
public long this[int i]=>Value[i];

public static A136326Inst Instance=new A136326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136327
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,49L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,121L,125L,127L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136327Inst : IEnumerable<long>
{
public static readonly long[] Value=A136327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136327.Bytes);
public long this[int i]=>Value[i];

public static A136327Inst Instance=new A136327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136424
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,11L,19L,32L,55L,95L,164L,283L,488L,842L,1451L,2503L,4318L,7447L,12844L,22152L,38207L,65898L,113657L,196029L,338101L,583137L,1005763L,1734685L,2991888L,5160244L,8900104L,15350410L,26475540L,45663552L,78757977L,135837417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136424Inst : IEnumerable<long>
{
public static readonly long[] Value=A136424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136424.Bytes);
public long this[int i]=>Value[i];

public static A136424Inst Instance=new A136424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136425
{
public static readonly long[] Value={ 1L,1L,3L,4L,8L,14L,25L,46L,84L,153L,279L,509L,927L,1691L,3082L,5618L,10241L,18667L,34028L,62029L,113070L,206113L,375719L,684889L,1248467L,2275800L,4148501L,7562201L,13784953L,25128255L,45805684L,83498067L,152206593L,277453693L,505763582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136425Inst : IEnumerable<long>
{
public static readonly long[] Value=A136425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136425.Bytes);
public long this[int i]=>Value[i];

public static A136425Inst Instance=new A136425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136426
{
public static readonly long[] Value={ 0L,0L,-1L,0L,-1L,-2L,0L,-2L,-6L,-3L,0L,-6L,-22L,-18L,-4L,0L,-24L,-100L,-105L,-40L,-5L,0L,-120L,-548L,-675L,-340L,-75L,-6L,0L,-720L,-3528L,-4872L,-2940L,-875L,-126L,-7L,0L,-5040L,-26136L,-39396L,-27076L,-9800L,-1932L,-196L,-8L,0L,-40320L,-219168L,-354372L,-269136L,-112245L,-27216L,-3822L,-288L,-9L,0L,-362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136426Inst : IEnumerable<long>
{
public static readonly long[] Value=A136426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136426.Bytes);
public long this[int i]=>Value[i];

public static A136426Inst Instance=new A136426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136427
{
public static readonly long[] Value={ 0L,1L,2L,4L,10L,24L,48L,92L,188L,388L,772L,1524L,3060L,6164L,12308L,24532L,49108L,98388L,196692L,393044L,786260L,1573204L,3146068L,6290772L,12582228L,25167188L,50333012L,100660564L,201323860L,402658644L,805311828L,1610601812L,3221214548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136427Inst : IEnumerable<long>
{
public static readonly long[] Value=A136427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136427.Bytes);
public long this[int i]=>Value[i];

public static A136427Inst Instance=new A136427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136428
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,0L,1L,7L,1L,0L,0L,1L,0L,0L,0L,0L,1L,-3L,1L,0L,0L,1L,0L,0L,0L,0L,1L,-3L,1L,0L,0L,1L,0L,0L,0L,0L,1L,7L,1L,0L,0L,1L,0L,0L,0L,0L,1L,-3L,1L,0L,0L,1L,0L,0L,0L,0L,1L,-3L,1L,0L,0L,1L,0L,0L,0L,0L,1L,-3L,1L,0L,0L,1L,0L,0L,0L,0L,1L,-3L,1L,0L,0L,1L,0L,0L,0L,0L,1L,7L,1L,0L,0L,1L,0L,0L,0L,0L,1L,67L,1L,0L,0L,1L,0L,0L,0L,0L,1L,7L,1L,0L,0L,1L,0L,0L,0L,0L,1L,-3L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136428Inst : IEnumerable<long>
{
public static readonly long[] Value=A136428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136428.Bytes);
public long this[int i]=>Value[i];

public static A136428Inst Instance=new A136428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136429
{
public static readonly long[] Value={ 1L,2L,9L,26L,84L,250L,747L,2182L,6323L,18132L,51624L,146004L,410677L,1149578L,3204477L,8899502L,24634620L,67990414L,187154271L,513939214L,1408246247L,3851081256L,10512259920L,28647203880L,77946605545L,211782868754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136429Inst : IEnumerable<long>
{
public static readonly long[] Value=A136429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136429.Bytes);
public long this[int i]=>Value[i];

public static A136429Inst Instance=new A136429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136430
{
public static readonly long[] Value={ 15L,46L,88L,159L,258L,395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136430Inst : IEnumerable<long>
{
public static readonly long[] Value=A136430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136430.Bytes);
public long this[int i]=>Value[i];

public static A136430Inst Instance=new A136430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136431
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,3L,4L,3L,0L,1L,4L,7L,7L,5L,0L,1L,5L,11L,14L,12L,8L,0L,1L,6L,16L,25L,26L,20L,13L,0L,1L,7L,22L,41L,51L,46L,33L,21L,0L,1L,8L,29L,63L,92L,97L,79L,54L,34L,0L,1L,9L,37L,92L,155L,189L,176L,133L,88L,55L,0L,1L,10L,46L,129L,247L,344L,365L,309L,221L,143L,89L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136431Inst : IEnumerable<long>
{
public static readonly long[] Value=A136431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136431.Bytes);
public long this[int i]=>Value[i];

public static A136431Inst Instance=new A136431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136432
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,9L,10L,11L,12L,14L,15L,16L,17L,19L,20L,21L,22L,24L,25L,26L,27L,29L,30L,31L,32L,33L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,47L,48L,49L,50L,51L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,71L,72L,73L,74L,75L,76L,78L,79L,80L,81L,82L,84L,85L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136432Inst : IEnumerable<long>
{
public static readonly long[] Value=A136432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136432.Bytes);
public long this[int i]=>Value[i];

public static A136432Inst Instance=new A136432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136433
{
public static readonly long[] Value={ 11L,12L,26L,79L,81L,163L,491L,492L,986L,2959L,2961L,5923L,17771L,17772L,35546L,106639L,106641L,213283L,639851L,639852L,1279706L,3839119L,3839121L,7678243L,23034731L,23034732L,46069466L,138208399L,138208401L,276416803L,829250411L,829250412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136433Inst : IEnumerable<long>
{
public static readonly long[] Value=A136433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136433.Bytes);
public long this[int i]=>Value[i];

public static A136433Inst Instance=new A136433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136434
{
public static readonly long[] Value={ 0L,-2L,2L,18L,52L,110L,198L,322L,488L,702L,970L,1298L,1692L,2158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136434Inst : IEnumerable<long>
{
public static readonly long[] Value=A136434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136434.Bytes);
public long this[int i]=>Value[i];

public static A136434Inst Instance=new A136434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136435
{
public static readonly long[] Value={ 11L,19L,23L,29L,31L,37L,59L,67L,71L,73L,79L,103L,107L,131L,149L,151L,163L,167L,179L,181L,199L,211L,227L,229L,241L,251L,257L,271L,281L,311L,337L,347L,349L,359L,379L,389L,401L,419L,421L,433L,467L,479L,509L,521L,523L,541L,547L,569L,571L,659L,661L,683L,691L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136435Inst : IEnumerable<long>
{
public static readonly long[] Value=A136435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136435.Bytes);
public long this[int i]=>Value[i];

public static A136435Inst Instance=new A136435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136436
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,3L,1L,2L,2L,1L,1L,2L,3L,4L,1L,4L,3L,2L,1L,1L,2L,3L,1L,3L,3L,2L,3L,3L,1L,3L,2L,1L,1L,2L,3L,2L,2L,5L,6L,5L,2L,2L,3L,2L,1L,1L,2L,3L,3L,1L,5L,2L,4L,3L,4L,2L,5L,1L,3L,3L,2L,1L,1L,2L,3L,4L,5L,4L,2L,6L,1L,6L,2L,4L,5L,4L,3L,2L,1L,1L,2L,3L,4L,1L,4L,6L,7L,2L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136436Inst : IEnumerable<long>
{
public static readonly long[] Value=A136436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136436.Bytes);
public long this[int i]=>Value[i];

public static A136436Inst Instance=new A136436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136437
{
public static readonly long[] Value={ 0L,1L,3L,1L,5L,7L,11L,13L,17L,5L,7L,13L,17L,19L,23L,29L,35L,37L,43L,47L,49L,55L,59L,65L,73L,77L,79L,83L,85L,89L,7L,11L,17L,19L,29L,31L,37L,43L,47L,53L,59L,61L,71L,73L,77L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136437Inst : IEnumerable<long>
{
public static readonly long[] Value=A136437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136437.Bytes);
public long this[int i]=>Value[i];

public static A136437Inst Instance=new A136437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136438
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,2L,2L,0L,0L,1L,3L,4L,4L,0L,0L,1L,4L,7L,8L,7L,0L,0L,1L,5L,11L,15L,15L,13L,0L,0L,1L,6L,16L,26L,30L,28L,24L,0L,0L,1L,7L,22L,42L,56L,58L,52L,44L,0L,0L,1L,8L,29L,64L,98L,114L,110L,96L,81L,0L,0L,1L,9L,37L,93L,162L,212L,224L,206L,177L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136438Inst : IEnumerable<long>
{
public static readonly long[] Value=A136438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136438.Bytes);
public long this[int i]=>Value[i];

public static A136438Inst Instance=new A136438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136439
{
public static readonly long[] Value={ 1L,3L,10L,34L,118L,417L,1495L,5421L,19838L,73149L,271453L,1012872L,3797228L,14294518L,54006728L,204702328L,778115558L,2965409556L,11327549778L,43361526366L,166306579062L,638969153207L,2458973656584L,9477124288144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136439Inst : IEnumerable<long>
{
public static readonly long[] Value=A136439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136439.Bytes);
public long this[int i]=>Value[i];

public static A136439Inst Instance=new A136439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136472
{
public static readonly BigInteger[] Value={ 1L,8L,136L,6552L,973832L,465833856L,739387804752L,3992649623654752L,BigInteger.Parse("74888425049167499424"),BigInteger.Parse("4962998789388515787006336"),BigInteger.Parse("1178375010889854741001146703936"),BigInteger.Parse("1013755301703927988518902015091910656") };
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
public class A136472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136472Inst Instance=new A136472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136473
{
public static readonly long[] Value={ 1L,3L,171L,13203L,97641L,354537L,2354697L,10970073L,29884473L,33894369L,38265939L,74214171L,116226009L,344380329L,751611177L,892145817L,2595432537L,4014314433L,10161972027L,11852199369L,13229694441L,22032887841L,22230967347L,22864359897L,24020090001L,26761542921L,27439598619L,27932906619L,37498011939L,166111451217L,189836046171L,197678101833L,224737264539L,325152438921L,330961409811L,730922071851L,893842021161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136473Inst : IEnumerable<long>
{
public static readonly long[] Value=A136473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136473.Bytes);
public long this[int i]=>Value[i];

public static A136473Inst Instance=new A136473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136474
{
public static readonly long[] Value={ 3L,19L,163L,1459L,17497L,52489L,87211L,135433L,139483L,1220347L,5419387L,6049243L,28934011L,86093443L,227862073L,272010961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136474Inst : IEnumerable<long>
{
public static readonly long[] Value=A136474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136474.Bytes);
public long this[int i]=>Value[i];

public static A136474Inst Instance=new A136474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136475
{
public static readonly BigInteger[] Value={ 3L,3L,19L,3L,87211L,3L,163L,135433L,272010961L,3L,1459L,139483L,10429407431911334611UL,BigInteger.Parse("918125051602568899753"),3L,227862073L,3110690934667L,BigInteger.Parse("216892513252489863991753"),BigInteger.Parse("1102099161075964924744009"),BigInteger.Parse("393063301203384521164229656203691748263012766081190297429488962985651210769817") };
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
public class A136475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136475Inst Instance=new A136475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136476
{
public static readonly long[] Value={ 9555L,12705L,15015L,18585L,21105L,32445L,41055L,43065L,46035L,47355L,51765L,125895L,129465L,228735L,257565L,324555L,375165L,400785L,409185L,537285L,693225L,4513509L,5569641L,5581695L,5959065L,6084351L,6338535L,8824095L,9597315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136476Inst : IEnumerable<long>
{
public static readonly long[] Value=A136476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136476.Bytes);
public long this[int i]=>Value[i];

public static A136476Inst Instance=new A136476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136477
{
public static readonly long[] Value={ 97L,112L,122L,135L,144L,179L,202L,207L,214L,217L,227L,354L,359L,477L,507L,569L,612L,632L,639L,732L,832L,2124L,2359L,2362L,2440L,2466L,2517L,2970L,3097L,3247L,3342L,3367L,3374L,3419L,3425L,3518L,3545L,3562L,3644L,3672L,3699L,3789L,3879L,3969L,3985L,4050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136477Inst : IEnumerable<long>
{
public static readonly long[] Value=A136477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136477.Bytes);
public long this[int i]=>Value[i];

public static A136477Inst Instance=new A136477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136478
{
public static readonly long[] Value={ 7L,7L,3L,15L,15L,15L,7L,3L,5L,7L,3L,15L,15L,27L,3L,15L,3L,27L,15L,27L,13L,3L,49L,17L,55L,27L,27L,15L,53L,77L,63L,77L,15L,45L,15L,69L,45L,77L,15L,57L,75L,27L,75L,63L,55L,75L,49L,85L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136478Inst : IEnumerable<long>
{
public static readonly long[] Value=A136478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136478.Bytes);
public long this[int i]=>Value[i];

public static A136478Inst Instance=new A136478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136479
{
public static readonly long[] Value={ 9555L,51765L,17787315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136479Inst : IEnumerable<long>
{
public static readonly long[] Value=A136479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136479.Bytes);
public long this[int i]=>Value[i];

public static A136479Inst Instance=new A136479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136480
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,2L,2L,1L,1L,4L,4L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,2L,2L,1L,1L,5L,5L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,2L,2L,1L,1L,4L,4L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,2L,2L,1L,1L,6L,6L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,2L,2L,1L,1L,4L,4L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,2L,2L,1L,1L,5L,5L,1L,1L,2L,2L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136480Inst : IEnumerable<long>
{
public static readonly long[] Value=A136480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136480.Bytes);
public long this[int i]=>Value[i];

public static A136480Inst Instance=new A136480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136481
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,-2L,1L,1L,0L,3L,-1L,-1L,0L,2L,-4L,1L,1L,0L,0L,-5L,5L,-1L,-1L,0L,0L,-2L,9L,-6L,1L,1L,0L,0L,0L,7L,-14L,7L,-1L,-1L,0L,0L,0L,2L,-16L,20L,-8L,1L,1L,0L,0L,0L,0L,-9L,30L,-27L,9L,-1L,-1L,0L,0L,0L,0L,-2L,25L,-50L,35L,-10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136481Inst : IEnumerable<long>
{
public static readonly long[] Value=A136481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136481.Bytes);
public long this[int i]=>Value[i];

public static A136481Inst Instance=new A136481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136482
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,4L,4L,1L,1L,6L,8L,6L,1L,1L,7L,14L,14L,7L,1L,1L,9L,21L,30L,21L,9L,1L,1L,10L,30L,51L,51L,30L,10L,1L,1L,12L,40L,84L,102L,84L,40L,12L,1L,1L,13L,52L,124L,186L,186L,124L,52L,13L,1L,1L,15L,65L,180L,310L,378L,310L,180L,65L,15L,1L,1L,16L,80L,245L,490L,688L,688L,490L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136482Inst : IEnumerable<long>
{
public static readonly long[] Value=A136482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136482.Bytes);
public long this[int i]=>Value[i];

public static A136482Inst Instance=new A136482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136483
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,4L,6L,8L,13L,15L,19L,22L,28L,30L,37L,41L,48L,54L,64L,69L,77L,83L,94L,98L,110L,119L,131L,139L,152L,162L,172L,183L,199L,208L,226L,234L,253L,263L,281L,294L,308L,322L,343L,357L,377L,390L,412L,424L,447L,465L,488L,504L,528L,545L,567L,585L,612L,628L,654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136483Inst : IEnumerable<long>
{
public static readonly long[] Value=A136483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136483.Bytes);
public long this[int i]=>Value[i];

public static A136483Inst Instance=new A136483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136484
{
public static readonly long[] Value={ 0L,1L,3L,6L,13L,19L,28L,37L,48L,64L,77L,94L,110L,131L,152L,172L,199L,226L,253L,281L,308L,343L,377L,412L,447L,488L,528L,567L,612L,654L,703L,750L,796L,847L,902L,957L,1013L,1068L,1129L,1187L,1252L,1313L,1378L,1446L,1511L,1582L,1650L,1725L,1800L,1877L,1955L,2034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136484Inst : IEnumerable<long>
{
public static readonly long[] Value=A136484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136484.Bytes);
public long this[int i]=>Value[i];

public static A136484Inst Instance=new A136484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136485
{
public static readonly long[] Value={ 0L,0L,4L,4L,12L,16L,24L,32L,52L,60L,76L,88L,112L,120L,148L,164L,192L,216L,256L,276L,308L,332L,376L,392L,440L,476L,524L,556L,608L,648L,688L,732L,796L,832L,904L,936L,1012L,1052L,1124L,1176L,1232L,1288L,1372L,1428L,1508L,1560L,1648L,1696L,1788L,1860L,1952L,2016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136485Inst : IEnumerable<long>
{
public static readonly long[] Value=A136485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136485.Bytes);
public long this[int i]=>Value[i];

public static A136485Inst Instance=new A136485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136486
{
public static readonly long[] Value={ 0L,4L,12L,24L,52L,76L,112L,148L,192L,256L,308L,376L,440L,524L,608L,688L,796L,904L,1012L,1124L,1232L,1372L,1508L,1648L,1788L,1952L,2112L,2268L,2448L,2616L,2812L,3000L,3184L,3388L,3608L,3828L,4052L,4272L,4516L,4748L,5008L,5252L,5512L,5784L,6044L,6328L,6600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136486Inst : IEnumerable<long>
{
public static readonly long[] Value=A136486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136486.Bytes);
public long this[int i]=>Value[i];

public static A136486Inst Instance=new A136486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136487
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,-1L,-1L,-1L,0L,2L,0L,-1L,2L,0L,-4L,0L,2L,-3L,2L,7L,-4L,-5L,2L,1L,5L,-5L,-11L,11L,7L,-7L,-1L,1L,-8L,12L,16L,-28L,-8L,20L,0L,-4L,13L,-25L,-20L,60L,-2L,-46L,12L,12L,-3L,-1L,-21L,50L,19L,-120L,38L,92L,-50L,-24L,15L,2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136487Inst : IEnumerable<long>
{
public static readonly long[] Value=A136487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136487.Bytes);
public long this[int i]=>Value[i];

public static A136487Inst Instance=new A136487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136520
{
public static readonly long[] Value={ 1L,1L,3L,13L,44L,146L,530L,1975L,7314L,27262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136520Inst : IEnumerable<long>
{
public static readonly long[] Value=A136520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136520.Bytes);
public long this[int i]=>Value[i];

public static A136520Inst Instance=new A136520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136521
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136521Inst : IEnumerable<long>
{
public static readonly long[] Value=A136521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136521.Bytes);
public long this[int i]=>Value[i];

public static A136521Inst Instance=new A136521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136522
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136522Inst : IEnumerable<long>
{
public static readonly long[] Value=A136522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136522.Bytes);
public long this[int i]=>Value[i];

public static A136522Inst Instance=new A136522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136523
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,2L,-1L,-3L,2L,4L,1L,-3L,-8L,4L,8L,1L,5L,-8L,-20L,8L,16L,-1L,5L,18L,-20L,-48L,16L,32L,-1L,-7L,18L,56L,-48L,-112L,32L,64L,1L,-7L,-32L,56L,160L,-112L,-256L,64L,128L,1L,9L,-32L,-120L,160L,432L,-256L,-576L,128L,256L,-1L,9L,50L,-120L,-400L,432L,1120L,-576L,-1280L,256L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136523Inst : IEnumerable<long>
{
public static readonly long[] Value=A136523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136523.Bytes);
public long this[int i]=>Value[i];

public static A136523Inst Instance=new A136523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136524
{
public static readonly BigInteger[] Value={ 1L,2L,24L,968L,128000L,59973152L,107564800000L,774840978000000L,BigInteger.Parse("22880602349081985024"),BigInteger.Parse("2779532441951756299960832"),BigInteger.Parse("1383517973370847653192530395136"),BigInteger.Parse("2804745232514434754535719279455029248") };
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
public class A136524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136524Inst Instance=new A136524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136525
{
public static readonly BigInteger[] Value={ 1L,3L,35L,1296L,157437L,68809488L,117274907815L,816249936543744L,BigInteger.Parse("23585997104539765625"),BigInteger.Parse("2828012919296320973299968"),BigInteger.Parse("1396969787088550953695654296875"),BigInteger.Parse("2819773093146732354646026240000000000") };
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
public class A136525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136525Inst Instance=new A136525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136526
{
public static readonly long[] Value={ 1L,0L,1L,-6L,0L,6L,0L,-42L,0L,36L,36L,0L,-288L,0L,216L,0L,468L,0L,-1944L,0L,1296L,-216L,0L,4536L,0L,-12960L,0L,7776L,0L,-4104L,0L,38880L,0L,-85536L,0L,46656L,1296L,0L,-51840L,0L,311040L,0L,-559872L,0L,279936L,0L,32400L,0L,-544320L,0L,2379456L,0L,-3639168L,0L,1679616L,-7776L,0L,505440L,0L,-5132160L,0L,17635968L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136526Inst : IEnumerable<long>
{
public static readonly long[] Value=A136526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136526.Bytes);
public long this[int i]=>Value[i];

public static A136526Inst Instance=new A136526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136527
{
public static readonly long[] Value={ 4L,2L,6L,4L,2L,8L,1L,3L,1L,9L,2L,2L,2L,1L,10L,4L,6L,4L,3L,2L,12L,2L,2L,2L,1L,2L,2L,14L,1L,3L,1L,3L,5L,3L,1L,15L,4L,2L,8L,1L,2L,4L,2L,1L,16L,2L,6L,2L,9L,2L,6L,2L,3L,2L,18L,4L,2L,4L,1L,10L,4L,2L,5L,4L,2L,20L,1L,3L,1L,3L,1L,3L,7L,3L,1L,3L,1L,21L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,22L,4L,6L,8L,3L,2L,12L,2L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136527Inst : IEnumerable<long>
{
public static readonly long[] Value=A136527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136527.Bytes);
public long this[int i]=>Value[i];

public static A136527Inst Instance=new A136527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136528
{
public static readonly long[] Value={ 2L,3L,4L,4L,4L,4L,6L,6L,6L,6L,6L,4L,5L,6L,8L,6L,8L,6L,8L,8L,8L,8L,9L,8L,6L,9L,8L,8L,9L,6L,10L,9L,9L,9L,10L,4L,8L,8L,12L,8L,10L,6L,10L,12L,10L,10L,12L,8L,12L,8L,8L,8L,12L,12L,12L,12L,12L,12L,12L,4L,7L,12L,12L,8L,12L,6L,12L,12L,12L,12L,12L,4L,6L,12L,10L,12L,12L,10L,16L,12L,12L,12L,12L,12L,8L,12L,12L,12L,16L,8L,12L,12L,12L,12L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136528Inst : IEnumerable<long>
{
public static readonly long[] Value=A136528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136528.Bytes);
public long this[int i]=>Value[i];

public static A136528Inst Instance=new A136528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136529
{
public static readonly long[] Value={ 2L,3L,2L,4L,2L,4L,2L,3L,2L,6L,2L,4L,2L,3L,2L,6L,2L,6L,2L,3L,2L,8L,2L,4L,2L,3L,2L,8L,2L,6L,2L,3L,2L,4L,2L,4L,2L,3L,2L,8L,2L,6L,2L,3L,2L,10L,2L,4L,2L,3L,2L,8L,2L,4L,2L,3L,2L,12L,2L,4L,2L,3L,2L,4L,2L,6L,2L,3L,2L,12L,2L,4L,2L,3L,2L,4L,2L,10L,2L,3L,2L,12L,2L,4L,2L,3L,2L,12L,2L,4L,2L,3L,2L,4L,2L,6L,2L,3L,2L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136529Inst : IEnumerable<long>
{
public static readonly long[] Value=A136529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136529.Bytes);
public long this[int i]=>Value[i];

public static A136529Inst Instance=new A136529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136530
{
public static readonly long[] Value={ 1L,6L,23L,74L,216L,592L,1552L,3936L,9728L,23552L,56064L,131584L,305152L,700416L,1593344L,3596288L,8060928L,17956864L,39780352L,87687168L,192413696L,420478976L,915406848L,1986002944L,4294967296L,9261023232L,19914555392L,42714791936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136530Inst : IEnumerable<long>
{
public static readonly long[] Value=A136530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136530.Bytes);
public long this[int i]=>Value[i];

public static A136530Inst Instance=new A136530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136531
{
public static readonly long[] Value={ 1L,0L,1L,1L,-1L,1L,-1L,3L,-2L,1L,2L,-5L,6L,-3L,1L,-3L,10L,-13L,10L,-4L,1L,5L,-18L,29L,-26L,15L,-5L,1L,-8L,33L,-60L,65L,-45L,21L,-6L,1L,13L,-59L,122L,-151L,125L,-71L,28L,-7L,1L,-21L,105L,-241L,338L,-321L,217L,-105L,36L,-8L,1L,34L,-185L,468L,-730L,784L,-609L,350L,-148L,45L,-9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136531Inst : IEnumerable<long>
{
public static readonly long[] Value=A136531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136531.Bytes);
public long this[int i]=>Value[i];

public static A136531Inst Instance=new A136531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136532
{
public static readonly long[] Value={ 1L,0L,-3L,-8L,-16L,4L,-60L,-65L,50L,-5L,-384L,-168L,462L,-108L,6L,-2380L,763L,3836L,-1624L,196L,-7L,-14208L,21248L,29560L,-21472L,4256L,-320L,8L,-73836L,302571L,199998L,-269127L,78840L,-9387L,486L,-9L,-176000L,3761240L,854530L,-3288940L,1360150L,-228880L,18430L,-700L,10L,3824964L,44711623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136532Inst : IEnumerable<long>
{
public static readonly long[] Value=A136532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136532.Bytes);
public long this[int i]=>Value[i];

public static A136532Inst Instance=new A136532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136533
{
public static readonly long[] Value={ 1L,3L,-3L,12L,-24L,4L,60L,-180L,65L,-5L,360L,-1440L,822L,-132L,6L,2520L,-12600L,9954L,-2478L,231L,-7L,20160L,-120960L,122832L,-41856L,5976L,-368L,8L,181440L,-1270080L,1581768L,-688392L,133380L,-12492L,549L,-9L,1814400L,-14515200L,21462480L,-11412000L,2806200L,-354720L,23610L,-780L,10L,19958400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136533Inst : IEnumerable<long>
{
public static readonly long[] Value=A136533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136533.Bytes);
public long this[int i]=>Value[i];

public static A136533Inst Instance=new A136533Inst();

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