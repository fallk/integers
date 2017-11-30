using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A104579
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,1L,4L,3L,0L,1L,4L,3L,6L,4L,0L,1L,5L,12L,6L,8L,5L,0L,1L,6L,16L,24L,10L,10L,6L,0L,1L,13L,24L,34L,40L,15L,12L,7L,0L,1L,16L,53L,60L,60L,60L,21L,14L,8L,0L,1L,25L,72L,135L,120L,95L,84L,28L,16L,9L,0L,1L,42L,126L,200L,275L,210L,140L,112L,36L,18L,10L,0L,1L,57L,220L,381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104579Inst : IEnumerable<long>
{
public static readonly long[] Value=A104579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104579.Bytes);
public long this[int i]=>Value[i];

public static A104579Inst Instance=new A104579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104580
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,4L,5L,3L,1L,7L,12L,9L,4L,1L,13L,26L,25L,14L,5L,1L,24L,56L,63L,44L,20L,6L,1L,44L,118L,153L,125L,70L,27L,7L,1L,81L,244L,359L,336L,220L,104L,35L,8L,1L,149L,499L,819L,864L,646L,357L,147L,44L,9L,1L,274L,1010L,1830L,2144L,1800L,1134L,546L,200L,54L,10L,1L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104580Inst : IEnumerable<long>
{
public static readonly long[] Value=A104580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104580.Bytes);
public long this[int i]=>Value[i];

public static A104580Inst Instance=new A104580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104581
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,2L,-2L,3L,-3L,3L,-4L,4L,-4L,5L,-5L,5L,-6L,6L,-6L,7L,-7L,7L,-8L,8L,-8L,9L,-9L,9L,-10L,10L,-10L,11L,-11L,11L,-12L,12L,-12L,13L,-13L,13L,-14L,14L,-14L,15L,-15L,15L,-16L,16L,-16L,17L,-17L,17L,-18L,18L,-18L,19L,-19L,19L,-20L,20L,-20L,21L,-21L,21L,-22L,22L,-22L,23L,-23L,23L,-24L,24L,-24L,25L,-25L,25L,-26L,26L,-26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104581Inst : IEnumerable<long>
{
public static readonly long[] Value=A104581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104581.Bytes);
public long this[int i]=>Value[i];

public static A104581Inst Instance=new A104581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104582
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,7L,4L,2L,1L,12L,7L,4L,2L,1L,20L,12L,7L,4L,2L,1L,33L,20L,12L,7L,4L,2L,1L,54L,33L,20L,12L,7L,4L,2L,1L,88L,54L,33L,20L,12L,7L,4L,2L,1L,143L,88L,54L,33L,20L,12L,7L,4L,2L,1L,232L,143L,88L,54L,33L,20L,12L,7L,4L,2L,1L,376L,232L,143L,88L,54L,33L,20L,12L,7L,4L,2L,1L,609L,376L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104582Inst : IEnumerable<long>
{
public static readonly long[] Value=A104582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104582.Bytes);
public long this[int i]=>Value[i];

public static A104582Inst Instance=new A104582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104583
{
public static readonly long[] Value={ 1L,4L,2L,9L,8L,1L,16L,18L,4L,2L,25L,32L,9L,8L,1L,36L,50L,16L,18L,4L,2L,49L,72L,25L,32L,9L,8L,1L,64L,98L,36L,50L,16L,18L,4L,2L,81L,128L,49L,72L,25L,32L,9L,8L,1L,100L,162L,64L,98L,36L,50L,16L,18L,4L,2L,121L,200L,81L,128L,49L,72L,25L,32L,9L,8L,1L,144L,242L,100L,162L,64L,98L,36L,50L,16L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104583Inst : IEnumerable<long>
{
public static readonly long[] Value=A104583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104583.Bytes);
public long this[int i]=>Value[i];

public static A104583Inst Instance=new A104583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104584
{
public static readonly long[] Value={ 0L,1L,7L,12L,26L,35L,57L,70L,100L,117L,155L,176L,222L,247L,301L,330L,392L,425L,495L,532L,610L,651L,737L,782L,876L,925L,1027L,1080L,1190L,1247L,1365L,1426L,1552L,1617L,1751L,1820L,1962L,2035L,2185L,2262L,2420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104584Inst : IEnumerable<long>
{
public static readonly long[] Value=A104584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104584.Bytes);
public long this[int i]=>Value[i];

public static A104584Inst Instance=new A104584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104585
{
public static readonly long[] Value={ 0L,2L,5L,15L,22L,40L,51L,77L,92L,126L,145L,187L,210L,260L,287L,345L,376L,442L,477L,551L,590L,672L,715L,805L,852L,950L,1001L,1107L,1162L,1276L,1335L,1457L,1520L,1650L,1717L,1855L,1926L,2072L,2147L,2301L,2380L,2542L,2625L,2795L,2882L,3060L,3151L,3337L,3432L,3626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104585Inst : IEnumerable<long>
{
public static readonly long[] Value=A104585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104585.Bytes);
public long this[int i]=>Value[i];

public static A104585Inst Instance=new A104585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104586
{
public static readonly long[] Value={ 1L,7L,2L,12L,5L,1L,26L,15L,7L,2L,35L,22L,12L,5L,1L,57L,40L,26L,15L,7L,2L,70L,51L,35L,22L,12L,5L,1L,100L,77L,57L,40L,26L,15L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104586Inst : IEnumerable<long>
{
public static readonly long[] Value=A104586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104586.Bytes);
public long this[int i]=>Value[i];

public static A104586Inst Instance=new A104586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104587
{
public static readonly long[] Value={ 1L,5L,3L,12L,9L,5L,22L,18L,13L,7L,35L,30L,24L,17L,9L,51L,45L,38L,30L,21L,11L,70L,63L,55L,46L,36L,25L,13L,92L,84L,75L,65L,54L,42L,29L,15L,117L,108L,98L,87L,75L,62L,48L,33L,17L,145L,135L,124L,112L,99L,85L,70L,54L,37L,19L,176L,165L,153L,140L,126L,111L,95L,78L,60L,41L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104587Inst : IEnumerable<long>
{
public static readonly long[] Value=A104587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104587.Bytes);
public long this[int i]=>Value[i];

public static A104587Inst Instance=new A104587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104588
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,2L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104588Inst : IEnumerable<long>
{
public static readonly long[] Value=A104588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104588.Bytes);
public long this[int i]=>Value[i];

public static A104588Inst Instance=new A104588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104589
{
public static readonly long[] Value={ 1L,2L,5L,13L,34L,55L,76L,97L,215L,333L,451L,569L,1256L,1943L,2630L,3317L,4004L,4691L,10069L,25516L,40963L,56410L,71857L,87304L,102751L,118198L,133645L,149092L,164539L,179986L,195433L,210880L,226327L,241774L,257221L,529889L,802557L,1075225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104589Inst : IEnumerable<long>
{
public static readonly long[] Value=A104589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104589.Bytes);
public long this[int i]=>Value[i];

public static A104589Inst Instance=new A104589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104590
{
public static readonly BigInteger[] Value={ 560L,191520L,42058800L,7864256400L,1407126890400L,257752421166240L,50607986220311520L,10995419195575214400UL,BigInteger.Parse("2692773804667509763200"),BigInteger.Parse("747221542837742897724800"),BigInteger.Parse("233698171655650029030743040"),BigInteger.Parse("81472765051132560093387934080"),BigInteger.Parse("31268587126068905034073041062400") };
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
public class A104590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104590.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104590Inst Instance=new A104590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104591
{
public static readonly BigInteger[] Value={ 560L,5040L,957600L,123354000L,16842764400L,2764379217600L,527554510282800L,114387072405606000L,BigInteger.Parse("27728561968887780000"),BigInteger.Parse("7418031804967840056000"),BigInteger.Parse("2167306256125914230527200"),BigInteger.Parse("685709965521372865035362400"),BigInteger.Parse("233306923207078035272369412000") };
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
public class A104591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104591.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104591Inst Instance=new A104591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104592
{
public static readonly BigInteger[] Value={ 1L,120L,10920L,988960L,99706320L,11897978400L,1729153068720L,306003079514880L,64657337524631280L,15890834362452489440UL,BigInteger.Parse("4435396700216405763840"),BigInteger.Parse("1379778057502074926142720"),BigInteger.Parse("471689356958791639787042560") };
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
public class A104592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104592Inst Instance=new A104592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104593
{
public static readonly BigInteger[] Value={ 1L,25L,1317L,96012L,8976600L,1027205280L,139315157730L,21864486188160L,3898841480307900L,778680435365714700L,BigInteger.Parse("172192746831203449890"),BigInteger.Parse("41765231538761743574100"),BigInteger.Parse("11024455369912310561835600") };
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
public class A104593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104593.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104593Inst Instance=new A104593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104594
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,3L,0L,4L,4L,5L,4L,6L,6L,7L,0L,8L,8L,9L,8L,10L,10L,11L,8L,12L,12L,13L,12L,14L,14L,15L,0L,16L,16L,17L,16L,18L,18L,19L,16L,20L,20L,21L,20L,22L,22L,23L,16L,24L,24L,25L,24L,26L,26L,27L,24L,28L,28L,29L,28L,30L,30L,31L,0L,32L,32L,33L,32L,34L,34L,35L,32L,36L,36L,37L,36L,38L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104594Inst : IEnumerable<long>
{
public static readonly long[] Value=A104594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104594.Bytes);
public long this[int i]=>Value[i];

public static A104594Inst Instance=new A104594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104595
{
public static readonly long[] Value={ 4L,106L,2382L,46680L,830848L,13804864L,218353000L,3328822880L,49325772812L,714586880940L,10164338225482L,142403410942816L,1969831979334086L,26954132420126920L,365393525753591368L,4913176199287631232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104595Inst : IEnumerable<long>
{
public static readonly long[] Value=A104595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104595.Bytes);
public long this[int i]=>Value[i];

public static A104595Inst Instance=new A104595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104596
{
public static readonly BigInteger[] Value={ 131L,8158L,313611L,9326858L,236095958L,5345316004L,111472798586L,2182345314816L,40634231364914L,726322104184848L,12550075287918360L,210738250570954064L,3453173212810875280L,BigInteger.Parse("55399287587418128520") };
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
public class A104596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104596.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104596Inst Instance=new A104596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104597
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,-1L,-2L,0L,1L,0L,-2L,-3L,0L,1L,1L,1L,-3L,-4L,0L,1L,1L,4L,3L,-4L,-5L,0L,1L,0L,3L,9L,6L,-5L,-6L,0L,1L,-1L,-2L,5L,16L,10L,-6L,-7L,0L,1L,-1L,-6L,-9L,6L,25L,15L,-7L,-8L,0L,1L,0L,-4L,-18L,-24L,5L,36L,21L,-8L,-9L,0L,1L,1L,3L,-7L,-39L,-50L,1L,49L,28L,-9L,-10L,0L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104597Inst : IEnumerable<long>
{
public static readonly long[] Value=A104597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104597.Bytes);
public long this[int i]=>Value[i];

public static A104597Inst Instance=new A104597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104598
{
public static readonly long[] Value={ 1L,10L,68L,394L,2092L,10516L,50920L,239962L,1107836L,5033020L,22572376L,100168260L,440604088L,1923626344L,8344694224L,35998921978L,154546983580L,660652406572L,2813422792696L,11940478362796L,50522190460072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104598Inst : IEnumerable<long>
{
public static readonly long[] Value=A104598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104598.Bytes);
public long this[int i]=>Value[i];

public static A104598Inst Instance=new A104598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104599
{
public static readonly long[] Value={ 1L,7L,14L,27L,64L,77L,182L,189L,273L,286L,378L,448L,714L,729L,748L,896L,924L,1254L,1547L,1728L,1729L,2079L,2261L,2926L,3003L,3289L,3542L,4096L,4914L,4928L,5005L,5103L,6630L,7293L,7371L,7722L,8372L,9177L,9660L,10206L,10556L,11571L,11648L,12096L,13090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104599Inst : IEnumerable<long>
{
public static readonly long[] Value=A104599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104599.Bytes);
public long this[int i]=>Value[i];

public static A104599Inst Instance=new A104599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104600
{
public static readonly BigInteger[] Value={ 1L,1L,5L,49L,795L,18881L,611193L,25704253L,1356235163L,87419692453L,6741175388313L,611464105166993L,64336296019640307L,7760748741918246361L,BigInteger.Parse("1062626712168331953737"),BigInteger.Parse("163738827988386433177093") };
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
public class A104600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104600Inst Instance=new A104600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104601
{
public static readonly long[] Value={ 1L,0L,2L,0L,4L,6L,0L,1L,45L,24L,0L,0L,90L,432L,120L,0L,0L,78L,2248L,4200L,720L,0L,0L,36L,5776L,43000L,43200L,5040L,0L,0L,9L,9066L,222925L,755100L,476280L,40320L,0L,0L,1L,9696L,727375L,6700500L,13003620L,5644800L,362880L,0L,0L,0L,7480L,1674840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104601Inst : IEnumerable<long>
{
public static readonly long[] Value=A104601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104601.Bytes);
public long this[int i]=>Value[i];

public static A104601Inst Instance=new A104601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104602
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,70L,642L,7246L,97052L,1503700L,26448872L,520556146L,11333475922L,270422904986L,7016943483450L,196717253145470L,5925211960335162L,190825629733950454L,6543503207678564364L,BigInteger.Parse("238019066600097607402"),BigInteger.Parse("9153956822981328930170"),BigInteger.Parse("371126108428565106918404") };
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
public class A104602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104602Inst Instance=new A104602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104603
{
public static readonly BigInteger[] Value={ 3L,10L,36L,544L,BigInteger.Parse("18518801667747479552") };
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
public class A104603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104603Inst Instance=new A104603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104604
{
public static readonly long[] Value={ 3L,22L,54L,106L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104604Inst : IEnumerable<long>
{
public static readonly long[] Value=A104604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104604.Bytes);
public long this[int i]=>Value[i];

public static A104604Inst Instance=new A104604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104605
{
public static readonly long[] Value={ 0L,-2L,1L,-2L,2L,-2L,0L,2L,-4L,-1L,3L,-4L,1L,3L,-4L,4L,-4L,0L,4L,-4L,-2L,1L,4L,-4L,-2L,2L,4L,-4L,-2L,0L,2L,4L,-6L,-3L,-1L,5L,-6L,-3L,1L,5L,-6L,-3L,2L,5L,-6L,-3L,0L,2L,5L,-6L,-1L,3L,5L,-6L,1L,3L,5L,-6L,6L,-6L,0L,6L,-6L,-2L,1L,6L,-6L,-2L,2L,6L,-6L,-2L,0L,2L,6L,-6L,-4L,-1L,3L,6L,-6L,-4L,1L,3L,6L,-6L,-4L,4L,6L,-6L,-4L,0L,4L,6L,-6L,-4L,-2L,1L,4L,6L,-6L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104605Inst : IEnumerable<long>
{
public static readonly long[] Value=A104605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104605.Bytes);
public long this[int i]=>Value[i];

public static A104605Inst Instance=new A104605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104606
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104606Inst : IEnumerable<long>
{
public static readonly long[] Value=A104606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104606.Bytes);
public long this[int i]=>Value[i];

public static A104606Inst Instance=new A104606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104607
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,0L,1L,1L,0L,1L,1L,2L,0L,0L,1L,2L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,2L,1L,1L,2L,0L,0L,2L,2L,1L,2L,1L,2L,2L,2L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,0L,1L,2L,2L,2L,0L,2L,2L,1L,0L,2L,2L,2L,0L,1L,2L,2L,2L,2L,1L,1L,0L,1L,1L,2L,0L,1L,1L,0L,2L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104607Inst : IEnumerable<long>
{
public static readonly long[] Value=A104607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104607.Bytes);
public long this[int i]=>Value[i];

public static A104607Inst Instance=new A104607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104608
{
public static readonly long[] Value={ 1L,3L,1L,1L,1L,0L,1L,2L,1L,1L,0L,0L,2L,1L,2L,3L,1L,3L,1L,2L,2L,1L,1L,1L,2L,0L,0L,2L,1L,0L,2L,2L,2L,1L,0L,2L,0L,0L,3L,3L,2L,2L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,1L,2L,2L,3L,1L,1L,3L,2L,0L,2L,2L,1L,0L,1L,2L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,0L,0L,1L,3L,3L,2L,2L,2L,3L,3L,3L,2L,3L,0L,1L,1L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104608Inst : IEnumerable<long>
{
public static readonly long[] Value=A104608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104608.Bytes);
public long this[int i]=>Value[i];

public static A104608Inst Instance=new A104608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104609
{
public static readonly long[] Value={ 1L,3L,0L,2L,2L,2L,1L,0L,1L,0L,1L,1L,3L,1L,2L,1L,2L,2L,4L,3L,3L,3L,4L,4L,3L,0L,0L,0L,4L,1L,2L,0L,1L,2L,2L,3L,2L,1L,3L,3L,2L,2L,1L,1L,4L,2L,0L,2L,2L,1L,4L,0L,4L,3L,3L,2L,3L,3L,4L,4L,2L,4L,2L,3L,4L,3L,4L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,4L,2L,1L,1L,2L,2L,3L,1L,1L,3L,1L,4L,1L,1L,4L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104609Inst : IEnumerable<long>
{
public static readonly long[] Value=A104609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104609.Bytes);
public long this[int i]=>Value[i];

public static A104609Inst Instance=new A104609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104610
{
public static readonly long[] Value={ 1L,3L,1L,1L,4L,1L,2L,3L,1L,0L,1L,1L,1L,1L,1L,3L,1L,1L,0L,2L,2L,4L,2L,3L,2L,3L,3L,0L,4L,4L,5L,5L,5L,5L,1L,1L,0L,3L,1L,2L,3L,2L,1L,1L,2L,4L,3L,5L,4L,4L,1L,1L,5L,3L,2L,5L,3L,1L,2L,2L,2L,0L,4L,1L,0L,5L,2L,3L,0L,1L,3L,0L,1L,3L,3L,3L,4L,0L,4L,1L,0L,1L,4L,4L,3L,3L,2L,5L,3L,0L,5L,5L,2L,4L,2L,0L,4L,5L,4L,0L,1L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104610Inst : IEnumerable<long>
{
public static readonly long[] Value=A104610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104610.Bytes);
public long this[int i]=>Value[i];

public static A104610Inst Instance=new A104610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104611
{
public static readonly long[] Value={ 1L,3L,6L,1L,1L,2L,3L,0L,3L,4L,1L,0L,1L,4L,2L,1L,6L,5L,1L,4L,4L,2L,5L,6L,2L,2L,4L,3L,2L,5L,3L,5L,2L,4L,4L,2L,5L,6L,5L,5L,4L,4L,6L,0L,2L,1L,3L,1L,1L,3L,1L,2L,2L,1L,1L,1L,1L,5L,4L,4L,4L,1L,1L,3L,1L,2L,6L,0L,2L,2L,3L,0L,2L,1L,2L,2L,2L,2L,0L,6L,2L,2L,5L,6L,4L,3L,6L,0L,3L,6L,2L,2L,2L,3L,0L,3L,3L,5L,6L,6L,2L,4L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104611Inst : IEnumerable<long>
{
public static readonly long[] Value=A104611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104611.Bytes);
public long this[int i]=>Value[i];

public static A104611Inst Instance=new A104611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104612
{
public static readonly long[] Value={ 1L,3L,6L,1L,3L,6L,2L,2L,2L,7L,4L,5L,1L,0L,1L,0L,1L,1L,2L,1L,1L,5L,1L,1L,0L,2L,2L,3L,2L,2L,7L,3L,3L,3L,3L,3L,0L,4L,4L,5L,4L,5L,2L,5L,5L,0L,6L,6L,6L,7L,7L,4L,7L,0L,1L,1L,0L,5L,1L,3L,2L,1L,1L,1L,2L,2L,1L,3L,5L,3L,1L,1L,4L,7L,3L,5L,0L,6L,1L,1L,7L,4L,7L,1L,3L,0L,2L,2L,1L,1L,5L,7L,6L,3L,2L,2L,4L,6L,4L,0L,1L,6L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104612Inst : IEnumerable<long>
{
public static readonly long[] Value=A104612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104612.Bytes);
public long this[int i]=>Value[i];

public static A104612Inst Instance=new A104612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104613
{
public static readonly long[] Value={ 1L,3L,6L,0L,1L,1L,0L,4L,3L,3L,1L,7L,5L,6L,1L,0L,1L,1L,1L,1L,1L,3L,1L,1L,6L,1L,1L,0L,2L,2L,3L,2L,2L,7L,2L,3L,2L,3L,3L,6L,3L,4L,2L,4L,4L,7L,5L,5L,3L,5L,5L,0L,6L,6L,6L,6L,7L,3L,7L,7L,1L,8L,8L,8L,1L,3L,0L,0L,8L,1L,6L,6L,1L,0L,2L,2L,7L,1L,4L,6L,1L,0L,4L,4L,7L,1L,0L,4L,1L,1L,6L,6L,0L,1L,3L,0L,1L,4L,8L,0L,3L,2L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104613Inst : IEnumerable<long>
{
public static readonly long[] Value=A104613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104613.Bytes);
public long this[int i]=>Value[i];

public static A104613Inst Instance=new A104613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104614
{
public static readonly long[] Value={ 1L,3L,6L,10L,1L,1L,8L,1L,2L,3L,5L,0L,4L,5L,10L,7L,7L,8L,1L,0L,1L,0L,1L,1L,2L,1L,1L,5L,1L,1L,8L,1L,1L,0L,2L,2L,3L,2L,2L,6L,2L,2L,10L,3L,3L,3L,3L,3L,8L,3L,4L,1L,4L,4L,6L,4L,4L,0L,5L,5L,6L,5L,5L,1L,6L,6L,7L,6L,7L,2L,7L,7L,8L,8L,8L,4L,8L,8L,0L,9L,9L,8L,9L,10L,4L,10L,10L,2L,1L,5L,0L,0L,0L,1L,9L,0L,1L,0L,2L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104614Inst : IEnumerable<long>
{
public static readonly long[] Value=A104614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104614.Bytes);
public long this[int i]=>Value[i];

public static A104614Inst Instance=new A104614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104615
{
public static readonly long[] Value={ 1L,3L,6L,10L,1L,4L,1L,2L,4L,9L,3L,3L,3L,10L,5L,6L,10L,7L,8L,9L,1L,0L,1L,1L,1L,1L,1L,3L,1L,1L,6L,1L,1L,8L,1L,1L,11L,2L,2L,3L,2L,2L,6L,2L,2L,10L,2L,3L,2L,3L,3L,6L,3L,3L,11L,4L,4L,3L,4L,4L,8L,4L,5L,2L,5L,5L,7L,5L,5L,1L,6L,6L,7L,6L,6L,1L,7L,7L,8L,7L,8L,2L,8L,8L,9L,9L,9L,5L,9L,9L,0L,10L,10L,8L,10L,11L,4L,11L,11L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104615Inst : IEnumerable<long>
{
public static readonly long[] Value=A104615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104615.Bytes);
public long this[int i]=>Value[i];

public static A104615Inst Instance=new A104615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104616
{
public static readonly long[] Value={ 1L,3L,6L,10L,1L,1L,7L,11L,2L,2L,0L,6L,4L,4L,1L,9L,6L,7L,10L,7L,9L,10L,1L,0L,1L,8L,4L,1L,10L,7L,1L,2L,0L,1L,10L,9L,1L,8L,8L,1L,9L,10L,2L,0L,2L,2L,7L,10L,2L,4L,8L,3L,4L,9L,3L,7L,0L,3L,0L,7L,4L,9L,4L,4L,8L,4L,4L,10L,7L,5L,2L,0L,5L,10L,9L,6L,8L,8L,6L,9L,10L,7L,0L,2L,7L,7L,10L,8L,4L,8L,8L,4L,9L,9L,7L,0L,9L,0L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104616Inst : IEnumerable<long>
{
public static readonly long[] Value=A104616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104616.Bytes);
public long this[int i]=>Value[i];

public static A104616Inst Instance=new A104616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104617
{
public static readonly long[] Value={ 1L,3L,6L,10L,0L,3L,1L,1L,1L,6L,2L,3L,10L,3L,4L,5L,13L,8L,7L,8L,10L,7L,10L,11L,1L,0L,1L,0L,1L,1L,2L,1L,1L,5L,1L,1L,7L,1L,1L,10L,1L,1L,13L,2L,2L,2L,2L,2L,6L,2L,2L,9L,2L,2L,13L,3L,3L,3L,3L,3L,8L,3L,3L,12L,4L,4L,3L,4L,4L,8L,4L,4L,13L,5L,5L,4L,5L,5L,10L,5L,6L,2L,6L,6L,8L,6L,6L,0L,7L,7L,6L,7L,7L,13L,8L,8L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104617Inst : IEnumerable<long>
{
public static readonly long[] Value=A104617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104617.Bytes);
public long this[int i]=>Value[i];

public static A104617Inst Instance=new A104617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104618
{
public static readonly long[] Value={ 1L,3L,6L,10L,1L,1L,6L,10L,2L,2L,10L,1L,3L,4L,7L,0L,5L,6L,12L,7L,8L,8L,10L,7L,11L,12L,1L,0L,1L,1L,1L,1L,1L,3L,1L,1L,5L,1L,1L,8L,1L,1L,11L,1L,1L,14L,2L,2L,2L,2L,2L,5L,2L,2L,9L,2L,2L,13L,2L,3L,2L,3L,3L,6L,3L,3L,10L,3L,3L,0L,4L,4L,5L,4L,4L,10L,4L,4L,0L,5L,5L,5L,5L,5L,11L,5L,6L,2L,6L,6L,8L,6L,6L,14L,7L,7L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104618Inst : IEnumerable<long>
{
public static readonly long[] Value=A104618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104618.Bytes);
public long this[int i]=>Value[i];

public static A104618Inst Instance=new A104618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104619
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,2L,1L,1L,14L,3L,2L,2L,5L,12L,4L,4L,4L,13L,6L,7L,11L,6L,9L,9L,10L,7L,12L,13L,1L,0L,1L,10L,5L,1L,12L,8L,1L,1L,14L,1L,9L,7L,1L,4L,3L,1L,2L,2L,1L,3L,4L,2L,7L,9L,2L,14L,1L,2L,8L,12L,2L,5L,10L,3L,5L,11L,3L,8L,15L,3L,14L,6L,3L,7L,0L,4L,3L,13L,4L,2L,13L,4L,4L,0L,5L,9L,6L,5L,1L,15L,5L,12L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104619Inst : IEnumerable<long>
{
public static readonly long[] Value=A104619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104619.Bytes);
public long this[int i]=>Value[i];

public static A104619Inst Instance=new A104619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104620
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,9L,6L,1L,8L,2L,3L,1L,4L,2L,19L,10L,1L,7L,2L,5L,31L,8L,1L,6L,2L,10L,18L,3L,14L,1L,7L,2L,11L,12L,3L,10L,4L,1L,29L,2L,8L,13L,3L,12L,62L,13L,1L,5L,2L,12L,6L,3L,9L,23L,73L,12L,1L,9L,2L,13L,11L,3L,16L,7L,80L,4L,22L,1L,8L,2L,6L,15L,3L,18L,19L,10L,4L,37L,11L,1L,9L,2L,13L,70L,3L,7L,26L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104620Inst : IEnumerable<long>
{
public static readonly long[] Value=A104620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104620.Bytes);
public long this[int i]=>Value[i];

public static A104620Inst Instance=new A104620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104621
{
public static readonly long[] Value={ 7L,1L,3L,7L,15L,31L,63L,127L,247L,493L,983L,1959L,3903L,7775L,15487L,30847L,61447L,122401L,243819L,485679L,967455L,1927135L,3838783L,7646719L,15231991L,30341581L,60439343L,120393007L,239818559L,477709983L,951581183L,1895515647L,3775799303L,7521257025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104621Inst : IEnumerable<long>
{
public static readonly long[] Value=A104621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104621.Bytes);
public long this[int i]=>Value[i];

public static A104621Inst Instance=new A104621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104622
{
public static readonly long[] Value={ 0L,2L,3L,5L,7L,10L,17L,24L,25L,26L,28L,38L,40L,49L,62L,79L,89L,114L,140L,145L,182L,248L,353L,437L,654L,702L,784L,921L,931L,986L,1206L,2136L,2137L,3351L,5411L,13264L,13757L,16348L,27087L,27160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104622Inst : IEnumerable<long>
{
public static readonly long[] Value=A104622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104622.Bytes);
public long this[int i]=>Value[i];

public static A104622Inst Instance=new A104622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104623
{
public static readonly long[] Value={ 4L,8L,9L,11L,12L,14L,15L,16L,22L,23L,32L,34L,37L,41L,42L,50L,52L,57L,58L,66L,69L,76L,77L,81L,90L,120L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104623Inst : IEnumerable<long>
{
public static readonly long[] Value=A104623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104623.Bytes);
public long this[int i]=>Value[i];

public static A104623Inst Instance=new A104623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104624
{
public static readonly long[] Value={ 1L,-2L,2L,0L,-2L,0L,4L,0L,-10L,0L,28L,0L,-84L,0L,264L,0L,-858L,0L,2860L,0L,-9724L,0L,33592L,0L,-117572L,0L,416024L,0L,-1485800L,0L,5348880L,0L,-19389690L,0L,70715340L,0L,-259289580L,0L,955277400L,0L,-3534526380L,0L,13128240840L,0L,-48932534040L,0L,182965127280L,0L,-686119227300L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104624Inst : IEnumerable<long>
{
public static readonly long[] Value=A104624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104624.Bytes);
public long this[int i]=>Value[i];

public static A104624Inst Instance=new A104624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104625
{
public static readonly long[] Value={ 1L,2L,7L,24L,87L,322L,1211L,4604L,17645L,68042L,263655L,1025632L,4002601L,15662422L,61427543L,241386924L,950160607L,3745589510L,14784496003L,58424093536L,231112008371L,915065382154L,3626113490579L,14379912928572L,57064644495359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104625Inst : IEnumerable<long>
{
public static readonly long[] Value=A104625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104625.Bytes);
public long this[int i]=>Value[i];

public static A104625Inst Instance=new A104625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104626
{
public static readonly long[] Value={ 4L,5L,6L,8L,19L,48L,124L,323L,844L,2208L,5779L,15128L,39604L,103683L,271444L,710648L,1860499L,4870848L,12752044L,33385283L,87403804L,228826128L,599074579L,1568397608L,4106118244L,10749957123L,28143753124L,73681302248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104626Inst : IEnumerable<long>
{
public static readonly long[] Value=A104626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104626.Bytes);
public long this[int i]=>Value[i];

public static A104626Inst Instance=new A104626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104627
{
public static readonly long[] Value={ 9L,10L,12L,13L,14L,16L,17L,20L,21L,25L,36L,49L,50L,54L,65L,94L,125L,126L,130L,141L,170L,246L,324L,325L,329L,340L,369L,445L,644L,845L,846L,850L,861L,890L,966L,1165L,1686L,2209L,2210L,2214L,2225L,2254L,2330L,2529L,3050L,4414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104627Inst : IEnumerable<long>
{
public static readonly long[] Value=A104627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104627.Bytes);
public long this[int i]=>Value[i];

public static A104627Inst Instance=new A104627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104628
{
public static readonly long[] Value={ 11L,15L,22L,23L,24L,26L,30L,31L,32L,34L,35L,37L,41L,42L,43L,45L,46L,51L,52L,53L,55L,66L,83L,95L,112L,127L,128L,129L,131L,142L,171L,217L,247L,293L,326L,327L,328L,330L,341L,370L,446L,568L,645L,767L,847L,848L,849L,851L,862L,891L,967L,1166L,1487L,1687L,2008L,2211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104628Inst : IEnumerable<long>
{
public static readonly long[] Value=A104628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104628.Bytes);
public long this[int i]=>Value[i];

public static A104628Inst Instance=new A104628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104629
{
public static readonly long[] Value={ 1L,2L,6L,18L,57L,186L,622L,2120L,7338L,25724L,91144L,325878L,1174281L,4260282L,15548694L,57048048L,210295326L,778483932L,2892818244L,10786724388L,40347919626L,151355847012L,569274150156L,2146336125648L,8110508473252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104629Inst : IEnumerable<long>
{
public static readonly long[] Value=A104629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104629.Bytes);
public long this[int i]=>Value[i];

public static A104629Inst Instance=new A104629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104630
{
public static readonly long[] Value={ 0L,1L,5L,18L,60L,198L,655L,2171L,7200L,23880L,79200L,262669L,871145L,2889162L,9581940L,31778622L,105394195L,349541159L,1159257600L,3844692240L,12750969600L,42288749161L,140251162205L,465144722658L,1542658254060L,5116245273558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104630Inst : IEnumerable<long>
{
public static readonly long[] Value=A104630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104630.Bytes);
public long this[int i]=>Value[i];

public static A104630Inst Instance=new A104630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104631
{
public static readonly long[] Value={ 0L,1L,4L,18L,80L,365L,1686L,7875L,37080L,175725L,837100L,4004770L,19227924L,92599533L,447118140L,2163837030L,10492874384L,50972030189L,248000853348L,1208335275170L,5894873067200L,28791371852145L,140768761906190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104631Inst : IEnumerable<long>
{
public static readonly long[] Value=A104631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104631.Bytes);
public long this[int i]=>Value[i];

public static A104631Inst Instance=new A104631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104632
{
public static readonly long[] Value={ 1L,2L,6L,20L,73L,281L,1125L,4635L,19525L,83710L,364070L,1602327L,7123041L,31937010L,144255802L,655804649L,2998354717L,13777825186L,63596593430L,294743653360L,1371017707245L,6398580086645L,29952930770185L,140604572777250L,661708404611603L,3121439743413256L,14756658303857332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104632Inst : IEnumerable<long>
{
public static readonly long[] Value=A104632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104632.Bytes);
public long this[int i]=>Value[i];

public static A104632Inst Instance=new A104632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104633
{
public static readonly long[] Value={ 1L,3L,2L,6L,6L,3L,10L,12L,9L,4L,15L,20L,18L,12L,5L,21L,30L,30L,24L,15L,6L,28L,42L,45L,40L,30L,18L,7L,36L,56L,63L,60L,50L,36L,21L,8L,45L,72L,84L,84L,75L,60L,42L,24L,9L,55L,90L,108L,112L,105L,90L,70L,48L,27L,10L,66L,110L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104633Inst : IEnumerable<long>
{
public static readonly long[] Value=A104633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104633.Bytes);
public long this[int i]=>Value[i];

public static A104633Inst Instance=new A104633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104634
{
public static readonly long[] Value={ 1L,5L,2L,14L,8L,3L,30L,20L,11L,4L,55L,40L,26L,14L,5L,91L,70L,50L,32L,17L,6L,140L,112L,85L,60L,38L,20L,7L,204L,168L,133L,100L,70L,44L,23L,8L,285L,240L,196L,154L,115L,80L,50L,26L,9L,385L,330L,276L,224L,175L,130L,90L,56L,29L,10L,506L,440L,375L,312L,252L,196L,145L,100L,62L,32L,11L,650L,572L,495L,420L,348L,280L,217L,160L,110L,68L,35L,12L,819L,728L,638L,550L,465L,384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104634Inst : IEnumerable<long>
{
public static readonly long[] Value=A104634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104634.Bytes);
public long this[int i]=>Value[i];

public static A104634Inst Instance=new A104634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104635
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,21L,23L,29L,33L,35L,39L,41L,51L,53L,63L,65L,69L,75L,81L,83L,89L,95L,99L,105L,111L,113L,119L,125L,131L,135L,141L,153L,155L,165L,173L,179L,183L,189L,191L,209L,215L,219L,221L,231L,233L,239L,243L,245L,249L,251L,261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104635Inst : IEnumerable<long>
{
public static readonly long[] Value=A104635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104635.Bytes);
public long this[int i]=>Value[i];

public static A104635Inst Instance=new A104635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104636
{
public static readonly long[] Value={ 2L,6L,8L,14L,18L,20L,26L,30L,36L,44L,48L,50L,54L,56L,68L,74L,78L,86L,90L,96L,98L,114L,116L,120L,128L,134L,138L,140L,146L,156L,158L,168L,174L,176L,186L,194L,198L,200L,204L,210L,216L,224L,228L,230L,254L,260L,270L,278L,284L,288L,296L,300L,306L,308L,320L,326L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104636Inst : IEnumerable<long>
{
public static readonly long[] Value=A104636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104636.Bytes);
public long this[int i]=>Value[i];

public static A104636Inst Instance=new A104636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104637
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,2L,2L,1L,2L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104637Inst : IEnumerable<long>
{
public static readonly long[] Value=A104637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104637.Bytes);
public long this[int i]=>Value[i];

public static A104637Inst Instance=new A104637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104638
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,3L,3L,2L,1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,3L,3L,3L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104638Inst : IEnumerable<long>
{
public static readonly long[] Value=A104638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104638.Bytes);
public long this[int i]=>Value[i];

public static A104638Inst Instance=new A104638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104639
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,1L,1L,3L,0L,2L,1L,3L,0L,3L,1L,2L,2L,4L,2L,4L,2L,3L,2L,1L,2L,2L,3L,4L,1L,3L,0L,2L,3L,4L,2L,3L,0L,5L,3L,4L,1L,3L,1L,1L,3L,2L,2L,4L,2L,5L,3L,3L,2L,2L,1L,1L,2L,5L,4L,4L,4L,5L,4L,4L,3L,3L,3L,4L,0L,3L,2L,5L,3L,3L,2L,3L,2L,4L,2L,2L,1L,3L,3L,4L,3L,4L,3L,4L,0L,4L,3L,4L,1L,4L,2L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104639Inst : IEnumerable<long>
{
public static readonly long[] Value=A104639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104639.Bytes);
public long this[int i]=>Value[i];

public static A104639Inst Instance=new A104639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104640
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,2L,2L,2L,1L,4L,2L,3L,1L,4L,1L,3L,2L,2L,0L,2L,1L,3L,2L,3L,4L,3L,3L,2L,1L,4L,2L,5L,3L,2L,1L,3L,2L,5L,0L,2L,1L,4L,2L,4L,4L,3L,4L,4L,2L,4L,1L,3L,3L,4L,4L,5L,5L,4L,1L,2L,2L,2L,1L,2L,2L,3L,3L,3L,2L,6L,3L,4L,1L,3L,3L,4L,3L,4L,2L,4L,4L,5L,3L,3L,2L,3L,2L,3L,2L,6L,2L,3L,2L,5L,2L,4L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104640Inst : IEnumerable<long>
{
public static readonly long[] Value=A104640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104640.Bytes);
public long this[int i]=>Value[i];

public static A104640Inst Instance=new A104640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104641
{
public static readonly long[] Value={ 3L,12L,18L,19L,21L,47L,53L,54L,67L,68L,69L,72L,75L,76L,78L,84L,85L,87L,89L,93L,216L,224L,236L,238L,243L,245L,247L,249L,260L,262L,275L,297L,299L,301L,303L,308L,309L,310L,323L,325L,326L,332L,333L,343L,346L,355L,356L,362L,363L,371L,374L,378L,382L,383L,387L,388L,395L,396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104641Inst : IEnumerable<long>
{
public static readonly long[] Value=A104641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104641.Bytes);
public long this[int i]=>Value[i];

public static A104641Inst Instance=new A104641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104642
{
public static readonly long[] Value={ 1L,191L,171L,3277L,2731L,28087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104642Inst : IEnumerable<long>
{
public static readonly long[] Value=A104642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104642.Bytes);
public long this[int i]=>Value[i];

public static A104642Inst Instance=new A104642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104643
{
public static readonly BigInteger[] Value={ 1L,25L,600L,13800L,303600L,6375600L,127512000L,2422728000L,43609104000L,741354768000L,11861676288000L,177925144320000L,2490952020480000L,32382376266240000L,388588515194880000L,4274473667143680000L,BigInteger.Parse("42744736671436800000"),BigInteger.Parse("384702630042931200000"),BigInteger.Parse("3077621040343449600000") };
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
public class A104643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104643Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104643.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104643.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104643Inst Instance=new A104643Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104644
{
public static readonly long[] Value={ 2L,23L,5L,2357L,7L,23L,11L,7L,61L,3L,17L,7L,25391L,6899L,1597L,3L,17L,3L,1019L,3L,17L,211L,41378209L,3L,479L,3L,262343078386137703L,3L,107L,3L,643L,3L,7L,3L,13L,3L,107069L,7L,14733071537L,3L,61911427L,3L,13L,3L,31L,3L,11L,59L,7L,647L,31L,3L,13L,3L,31517L,43L,3L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104644Inst : IEnumerable<long>
{
public static readonly long[] Value=A104644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104644.Bytes);
public long this[int i]=>Value[i];

public static A104644Inst Instance=new A104644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104645
{
public static readonly long[] Value={ 10L,6L,20L,24L,24L,60L,18L,48L,100L,48L,156L,74L,88L,68L,42L,126L,366L,106L,186L,136L,228L,104L,30L,246L,52L,218L,814L,58L,536L,174L,90L,924L,180L,298L,120L,330L,96L,508L,504L,60L,762L,588L,330L,138L,552L,726L,452L,634L,660L,354L,534L,1770L,52L,262L,834L,790L,250L,624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104645Inst : IEnumerable<long>
{
public static readonly long[] Value=A104645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104645.Bytes);
public long this[int i]=>Value[i];

public static A104645Inst Instance=new A104645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104646
{
public static readonly long[] Value={ 9L,10L,21L,34L,51L,58L,77L,106L,129L,166L,201L,262L,287L,334L,381L,454L,501L,586L,669L,718L,791L,922L,989L,1082L,1167L,1282L,1371L,1486L,1623L,1754L,1851L,2018L,2127L,2326L,2427L,2638L,2747L,2974L,3093L,3274L,3459L,3694L,3831L,4034L,4227L,4534L,4661L,4894L,5123L,5366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104646Inst : IEnumerable<long>
{
public static readonly long[] Value=A104646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104646.Bytes);
public long this[int i]=>Value[i];

public static A104646Inst Instance=new A104646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104647
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,6L,6L,12L,8L,9L,17L,13L,16L,14L,14L,28L,24L,14L,18L,32L,28L,14L,18L,32L,24L,29L,25L,25L,50L,44L,30L,41L,37L,8L,9L,17L,26L,43L,29L,31L,60L,48L,20L,23L,43L,66L,61L,29L,40L,69L,57L,20L,23L,43L,66L,52L,60L,53L,53L,106L,97L,77L,46L,58L,104L,95L,63L,89L,82L,29L,39L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104647Inst : IEnumerable<long>
{
public static readonly long[] Value=A104647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104647.Bytes);
public long this[int i]=>Value[i];

public static A104647Inst Instance=new A104647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104648
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,4L,5L,7L,8L,9L,11L,13L,15L,18L,20L,24L,28L,31L,36L,41L,47L,52L,60L,68L,76L,86L,96L,108L,121L,134L,150L,168L,185L,204L,228L,254L,279L,308L,339L,377L,411L,453L,496L,541L,597L,653L,713L,782L,851L,928L,1013L,1105L,1200L,1299L,1420L,1540L,1674L,1812L,1960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104648Inst : IEnumerable<long>
{
public static readonly long[] Value=A104648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104648.Bytes);
public long this[int i]=>Value[i];

public static A104648Inst Instance=new A104648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104649
{
public static readonly long[] Value={ 475L,551L,799L,3076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104649Inst : IEnumerable<long>
{
public static readonly long[] Value=A104649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104649.Bytes);
public long this[int i]=>Value[i];

public static A104649Inst Instance=new A104649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104650
{
public static readonly long[] Value={ 2L,3L,4L,6L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104650Inst : IEnumerable<long>
{
public static readonly long[] Value=A104650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104650.Bytes);
public long this[int i]=>Value[i];

public static A104650Inst Instance=new A104650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104651
{
public static readonly BigInteger[] Value={ 1L,175L,16589L,36191L,3430525L,325177579L,709415981L,67245150875L,6374130886969L,13905972023371L,1318139444021225L,124945713321188759L,272584862892702361L,BigInteger.Parse("25838169314458901575"),BigInteger.Parse("2449185866147811166949"),BigInteger.Parse("5343208468516779656951"),BigInteger.Parse("506479793583883944651925") };
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
public class A104651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104651.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104651Inst Instance=new A104651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104652
{
public static readonly BigInteger[] Value={ 0L,32L,3080L,6720L,637032L,60383960L,131735240L,12487111096L,1183646396800L,2582274191000L,244772352350624L,23201836730467360L,50617738823727040L,4798027663264052544L,BigInteger.Parse("454802404774267597320"),BigInteger.Parse("992208919004971638880"),BigInteger.Parse("94050938500074310327912") };
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
public class A104652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104652Inst Instance=new A104652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104653
{
public static readonly BigInteger[] Value={ 0L,1L,4L,27L,270L,3645L,62370L,1295595L,31689630L,892387125L,28439784450L,1011998000475L,39773696712750L,1711186282730925L,79990996596761250L,4037168079574504875L,BigInteger.Parse("218797477268743122750"),BigInteger.Parse("12673229445076108033125") };
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
public class A104653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A104653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104653Inst Instance=new A104653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104654
{
public static readonly long[] Value={ 1L,2L,4L,9L,5L,20L,11L,34L,17L,23L,29L,37L,41L,47L,53L,61L,71L,79L,89L,97L,107L,127L,131L,149L,157L,167L,181L,197L,211L,227L,241L,257L,277L,293L,307L,331L,347L,367L,389L,409L,431L,449L,467L,491L,521L,541L,563L,587L,613L,641L,673L,691L,719L,751L,773L,809L,839L,863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104654Inst : IEnumerable<long>
{
public static readonly long[] Value=A104654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104654.Bytes);
public long this[int i]=>Value[i];

public static A104654Inst Instance=new A104654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104655
{
public static readonly long[] Value={ 4L,8L,11L,17L,22L,30L,37L,46L,55L,66L,77L,90L,103L,117L,132L,148L,166L,183L,201L,222L,242L,264L,287L,310L,334L,360L,387L,413L,442L,470L,500L,533L,564L,598L,631L,665L,701L,738L,775L,813L,853L,893L,936L,979L,1022L,1065L,1110L,1154L,1202L,1251L,1299L,1349L,1401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104655Inst : IEnumerable<long>
{
public static readonly long[] Value=A104655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104655.Bytes);
public long this[int i]=>Value[i];

public static A104655Inst Instance=new A104655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104656
{
public static readonly long[] Value={ 1L,3L,8L,14L,18L,26L,33L,44L,52L,64L,76L,90L,104L,120L,135L,153L,171L,190L,213L,234L,255L,282L,304L,330L,358L,386L,414L,446L,478L,510L,542L,575L,611L,651L,688L,726L,766L,804L,847L,892L,933L,978L,1025L,1073L,1124L,1172L,1221L,1270L,1326L,1374L,1426L,1486L,1541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104656Inst : IEnumerable<long>
{
public static readonly long[] Value=A104656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104656.Bytes);
public long this[int i]=>Value[i];

public static A104656Inst Instance=new A104656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104657
{
public static readonly long[] Value={ 2L,10L,28L,106L,190L,292L,556L,756L,858L,906L,1012L,1030L,1032L,1060L,1372L,1450L,1488L,1720L,1722L,1758L,1782L,1822L,1972L,2356L,2436L,2446L,2620L,2748L,2788L,2998L,3186L,3300L,3318L,3360L,3466L,3510L,3822L,3852L,4138L,4326L,4506L,4908L,5236L,5518L,5782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104657Inst : IEnumerable<long>
{
public static readonly long[] Value=A104657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104657.Bytes);
public long this[int i]=>Value[i];

public static A104657Inst Instance=new A104657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104658
{
public static readonly long[] Value={ 1L,2L,5L,4L,4L,7L,4L,6L,8L,7L,6L,10L,6L,8L,13L,11L,6L,11L,3L,11L,14L,10L,6L,13L,10L,9L,12L,12L,8L,20L,5L,15L,14L,10L,12L,17L,7L,6L,15L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104658Inst : IEnumerable<long>
{
public static readonly long[] Value=A104658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104658.Bytes);
public long this[int i]=>Value[i];

public static A104658Inst Instance=new A104658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104659
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,2L,4L,2L,1L,5L,3L,2L,6L,3L,3L,3L,3L,2L,4L,4L,4L,4L,4L,4L,5L,1L,2L,6L,4L,4L,6L,4L,4L,4L,5L,4L,8L,4L,4L,7L,3L,2L,7L,3L,7L,4L,6L,3L,4L,6L,2L,6L,1L,4L,7L,2L,5L,4L,4L,4L,6L,4L,2L,3L,6L,3L,5L,4L,3L,11L,5L,4L,4L,5L,7L,3L,4L,3L,5L,4L,4L,3L,3L,6L,8L,3L,4L,4L,2L,6L,6L,1L,7L,8L,4L,4L,7L,4L,6L,6L,4L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104659Inst : IEnumerable<long>
{
public static readonly long[] Value=A104659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104659.Bytes);
public long this[int i]=>Value[i];

public static A104659Inst Instance=new A104659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104660
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,3L,1L,2L,2L,1L,2L,2L,3L,3L,3L,3L,3L,4L,3L,3L,6L,3L,4L,3L,3L,6L,4L,1L,5L,1L,4L,3L,5L,3L,6L,4L,2L,6L,2L,2L,3L,5L,3L,4L,4L,4L,2L,2L,4L,4L,3L,4L,5L,6L,3L,3L,5L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104660Inst : IEnumerable<long>
{
public static readonly long[] Value=A104660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104660.Bytes);
public long this[int i]=>Value[i];

public static A104660Inst Instance=new A104660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104661
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104661Inst : IEnumerable<long>
{
public static readonly long[] Value=A104661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104661.Bytes);
public long this[int i]=>Value[i];

public static A104661Inst Instance=new A104661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104662
{
public static readonly long[] Value={ 2L,11L,3L,5L,9L,4L,7L,21L,6L,8L,56L,13L,12L,46L,10L,14L,32L,16L,17L,15L,18L,19L,23L,20L,22L,37L,25L,24L,39L,26L,27L,67L,31L,28L,47L,30L,29L,51L,33L,41L,36L,40L,48L,55L,45L,44L,54L,34L,49L,58L,42L,60L,38L,43L,71L,35L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104662Inst : IEnumerable<long>
{
public static readonly long[] Value=A104662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104662.Bytes);
public long this[int i]=>Value[i];

public static A104662Inst Instance=new A104662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104663
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,11L,8L,5L,26L,9L,12L,7L,15L,17L,33L,43L,10L,25L,16L,19L,13L,32L,39L,21L,61L,175L,22L,20L,57L,37L,95L,14L,18L,50L,27L,40L,34L,110L,29L,24L,171L,23L,64L,28L,46L,203L,45L,31L,137L,91L,134L,35L,58L,30L,90L,54L,69L,106L,38L,73L,360L,296L,67L,88L,48L,70L,526L,109L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104663Inst : IEnumerable<long>
{
public static readonly long[] Value=A104663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104663.Bytes);
public long this[int i]=>Value[i];

public static A104663Inst Instance=new A104663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104664
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,12L,17L,21L,32L,33L,42L,44L,54L,89L,99L,157L,222L,236L,258L,327L,345L,371L,470L,495L,606L,634L,866L,891L,1219L,1383L,1540L,1626L,1660L,1878L,1989L,2064L,2758L,3534L,3954L,4053L,4113L,4468L,4618L,4783L,4862L,5134L,6394L,7176L,7480L,11649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104664Inst : IEnumerable<long>
{
public static readonly long[] Value=A104664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104664.Bytes);
public long this[int i]=>Value[i];

public static A104664Inst Instance=new A104664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104665
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,10L,13L,14L,18L,23L,28L,30L,36L,41L,49L,53L,77L,85L,102L,114L,141L,151L,163L,174L,182L,188L,244L,263L,311L,419L,434L,468L,477L,478L,655L,656L,739L,768L,890L,1002L,1027L,1099L,1118L,1166L,1365L,1397L,1440L,1574L,1575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104665Inst : IEnumerable<long>
{
public static readonly long[] Value=A104665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104665.Bytes);
public long this[int i]=>Value[i];

public static A104665Inst Instance=new A104665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104666
{
public static readonly long[] Value={ 25L,1L,2L,5L,3L,10L,7L,4L,35L,8L,11L,6L,14L,16L,47L,57L,9L,24L,15L,18L,12L,34L,232L,20L,40L,46L,21L,19L,129L,69L,36L,13L,17L,298L,31L,48L,189L,76L,26L,23L,53L,22L,30L,198L,58L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104666Inst : IEnumerable<long>
{
public static readonly long[] Value=A104666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104666.Bytes);
public long this[int i]=>Value[i];

public static A104666Inst Instance=new A104666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104667
{
public static readonly long[] Value={ 1L,25L,39L,6L,5L,4L,24L,10L,7L,2L,3L,29L,8L,11L,12L,44L,15L,35L,18L,20L,14L,9L,51L,26L,42L,13L,22L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104667Inst : IEnumerable<long>
{
public static readonly long[] Value=A104667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104667.Bytes);
public long this[int i]=>Value[i];

public static A104667Inst Instance=new A104667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104668
{
public static readonly long[] Value={ 1L,8L,6L,10L,7L,24L,9L,5L,2L,3L,11L,21L,26L,13L,12L,4L,23L,15L,64L,42L,17L,37L,25L,55L,57L,18L,46L,22L,14L,67L,72L,19L,40L,52L,33L,27L,53L,56L,80L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104668Inst : IEnumerable<long>
{
public static readonly long[] Value=A104668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104668.Bytes);
public long this[int i]=>Value[i];

public static A104668Inst Instance=new A104668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104669
{
public static readonly long[] Value={ 21L,22L,2122L,20222L,202222L,1222222L,22220222L,122222222L,2222222221L,22222222226L,202222222222L,2222212222222L,22222222222223L,212222222222222L,2222222222212222L,22222222202222222L,202222222222222222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104669Inst : IEnumerable<long>
{
public static readonly long[] Value=A104669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104669.Bytes);
public long this[int i]=>Value[i];

public static A104669Inst Instance=new A104669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104670
{
public static readonly long[] Value={ 1L,24L,216L,1200L,4950L,16632L,48048L,123552L,289575L,629200L,1283568L,2482272L,4585308L,8139600L,13953600L,23193984L,37509021L,59183784L,91333000L,138138000L,205134930L,299562120L,430775280L,610740000L,854611875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104670Inst : IEnumerable<long>
{
public static readonly long[] Value=A104670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104670.Bytes);
public long this[int i]=>Value[i];

public static A104670Inst Instance=new A104670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104671
{
public static readonly long[] Value={ 1L,36L,450L,3300L,17325L,72072L,252252L,772200L,2123550L,5348200L,12514788L,27511848L,57316350L,113954400L,217443600L,400096224L,712671399L,1232995500L,2077825750L,3418915500L,5504453955L,8687301480L,13461727500L,20510685000L,30766027500L,45484495056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104671Inst : IEnumerable<long>
{
public static readonly long[] Value=A104671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104671.Bytes);
public long this[int i]=>Value[i];

public static A104671Inst Instance=new A104671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104672
{
public static readonly long[] Value={ 1L,50L,825L,7700L,50050L,252252L,1051050L,3775200L,12033450L,34763300L,92470378L,229265400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104672Inst : IEnumerable<long>
{
public static readonly long[] Value=A104672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104672.Bytes);
public long this[int i]=>Value[i];

public static A104672Inst Instance=new A104672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104673
{
public static readonly long[] Value={ 1L,66L,1386L,16016L,126126L,756756L,3699696L,15402816L,56316546L,184940756L,554822268L,1540663488L,4001445448L,9802357488L,22805484768L,50678855040L,108088495515L,222161129190L,441579528390L,851355545040L,1596291646950L,2917485413700L,5208073135200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104673Inst : IEnumerable<long>
{
public static readonly long[] Value=A104673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104673.Bytes);
public long this[int i]=>Value[i];

public static A104673Inst Instance=new A104673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104674
{
public static readonly long[] Value={ 1L,84L,2184L,30576L,286650L,2018016L,11435424L,54609984L,259397424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104674Inst : IEnumerable<long>
{
public static readonly long[] Value=A104674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104674.Bytes);
public long this[int i]=>Value[i];

public static A104674Inst Instance=new A104674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104675
{
public static readonly long[] Value={ 6L,14L,24L,36L,50L,66L,84L,104L,126L,150L,176L,204L,234L,266L,300L,336L,374L,414L,456L,500L,546L,594L,644L,696L,750L,806L,864L,924L,986L,1050L,1116L,1184L,1254L,1326L,1400L,1476L,1554L,1634L,1716L,1800L,1886L,1974L,2064L,2156L,2250L,2346L,2444L,2544L,2646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104675Inst : IEnumerable<long>
{
public static readonly long[] Value=A104675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104675.Bytes);
public long this[int i]=>Value[i];

public static A104675Inst Instance=new A104675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104676
{
public static readonly long[] Value={ 21L,84L,216L,450L,825L,1386L,2184L,3276L,4725L,6600L,8976L,11934L,15561L,19950L,25200L,31416L,38709L,47196L,57000L,68250L,81081L,95634L,112056L,130500L,151125L,174096L,199584L,227766L,258825L,292950L,330336L,371184L,415701L,464100L,516600L,573426L,634809L,700986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104676Inst : IEnumerable<long>
{
public static readonly long[] Value=A104676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104676.Bytes);
public long this[int i]=>Value[i];

public static A104676Inst Instance=new A104676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104677
{
public static readonly long[] Value={ 56L,336L,1200L,3300L,7700L,16016L,30576L,54600L,92400L,149600L,233376L,352716L,518700L,744800L,1047200L,1445136L,1961256L,2622000L,3458000L,4504500L,5801796L,7395696L,9338000L,11687000L,14508000L,17873856L,21865536L,26572700L,32094300L,38539200L,46026816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104677Inst : IEnumerable<long>
{
public static readonly long[] Value=A104677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104677.Bytes);
public long this[int i]=>Value[i];

public static A104677Inst Instance=new A104677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104678
{
public static readonly long[] Value={ 126L,1050L,4950L,17325L,50050L,126126L,286650L,600600L,1178100L,2187900L,3879876L,6613425L,10892700L,17409700L,27096300L,41186376L,61289250L,89475750L,128378250L,181306125L,252378126L,346673250L,470401750L,631098000L,837837000L,1101476376L,1434925800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104678Inst : IEnumerable<long>
{
public static readonly long[] Value=A104678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104678.Bytes);
public long this[int i]=>Value[i];

public static A104678Inst Instance=new A104678Inst();

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