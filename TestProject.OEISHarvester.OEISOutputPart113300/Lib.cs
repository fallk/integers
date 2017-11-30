using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A242101
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,24L,32L,44L,58L,80L,104L,138L,180L,236L,302L,390L,496L,634L,800L,1010L,1264L,1586L,1970L,2448L,3024L,3734L,4582L,5622L,6862L,8372L,10168L,12336L,14912L,18010L,21672L,26052L,31226L,37384L,44632L,53226L,63318L,75238L,89202L,105630L,124832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242101Inst : IEnumerable<long>
{
public static readonly long[] Value=A242101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242101.Bytes);
public long this[int i]=>Value[i];

public static A242101Inst Instance=new A242101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242102
{
public static readonly long[] Value={ 1713L,2319L,2923L,4341L,6159L,7167L,8983L,103101L,151149L,157151L,163157L,167163L,173167L,191181L,197193L,233229L,257251L,277271L,283281L,311307L,337331L,367359L,373367L,421419L,431421L,439433L,449443L,463461L,467463L,479467L,487479L,509503L,521509L,547541L,557547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242102Inst : IEnumerable<long>
{
public static readonly long[] Value=A242102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242102.Bytes);
public long this[int i]=>Value[i];

public static A242102Inst Instance=new A242102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242103
{
public static readonly long[] Value={ 7L,9L,11L,14L,29L,76L,121L,199L,329L,521L,659L,1364L,3571L,4523L,7307L,9349L,24476L,64079L,167761L,212533L,439204L,1149851L,3010349L,7881196L,20633239L,54018521L,141422324L,370248451L,969323029L,2537720636L,6643838879L,17393796001L,45537549124L,119218851371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242103Inst : IEnumerable<long>
{
public static readonly long[] Value=A242103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242103.Bytes);
public long this[int i]=>Value[i];

public static A242103Inst Instance=new A242103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242104
{
public static readonly long[] Value={ 3L,5L,17L,11L,3L,5L,17L,7L,17L,47L,2L,7L,37L,17L,67L,29L,13L,11L,3L,7L,19L,89L,97L,19L,23L,43L,5L,5L,5L,23L,2L,5L,3L,5L,13L,11L,23L,7L,11L,13L,2L,7L,13L,13L,2L,2L,5L,5L,5L,19L,23L,53L,43L,47L,3L,3L,17L,19L,5L,23L,3L,7L,29L,3L,7L,5L,2L,7L,3L,19L,5L,5L,23L,23L,3L,13L,19L,13L,3L,2L,89L,7L,3L,7L,2L,17L,7L,131L,2L,5L,13L,17L,13L,13L,17L,2L,5L,19L,7L,5L,3L,5L,43L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242104Inst : IEnumerable<long>
{
public static readonly long[] Value=A242104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242104.Bytes);
public long this[int i]=>Value[i];

public static A242104Inst Instance=new A242104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242105
{
public static readonly BigInteger[] Value={ 1L,2L,7L,44L,428L,5802L,102322L,2239844L,58849332L,1810039960L,63930543419L,2553881719348L,113979459829296L,5625823639358928L,304505544257483550L,17944306197698666740UL,BigInteger.Parse("1144180970802458374244"),BigInteger.Parse("78517953136289477587608"),BigInteger.Parse("5771772521253777092098050") };
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
public class A242105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242105Inst Instance=new A242105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242106
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,4L,3L,1L,0L,1L,17L,121L,269L,241L,100L,24L,3L,1L,0L,1L,172L,15239L,316622L,1951089L,4820228L,5769214L,3768929L,1451594L,347251L,53628L,5645L,451L,37L,3L,1L,0L,1L,2811L,10802952L,3316523460L,170309112972L,2577666563670L,15839885888526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242106Inst : IEnumerable<long>
{
public static readonly long[] Value=A242106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242106.Bytes);
public long this[int i]=>Value[i];

public static A242106Inst Instance=new A242106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242107
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,-1L,2L,-3L,1L,-5L,-7L,-13L,-16L,11L,-57L,131L,-113L,389L,670L,2311L,3983L,9L,23647L,-81511L,140576L,-484247L,-833503L,-5751815L,-14871471L,-17124617L,-147165662L,710017141L,-2273917871L,9644648819L,11396432249L,204006839259L,808162720720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242107Inst : IEnumerable<long>
{
public static readonly long[] Value=A242107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242107.Bytes);
public long this[int i]=>Value[i];

public static A242107Inst Instance=new A242107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242108
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,3L,1L,5L,7L,13L,16L,11L,57L,131L,113L,389L,670L,2311L,3983L,9L,23647L,81511L,140576L,484247L,833503L,5751815L,14871471L,17124617L,147165662L,710017141L,2273917871L,9644648819L,11396432249L,204006839259L,808162720720L,2405317965859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242108Inst : IEnumerable<long>
{
public static readonly long[] Value=A242108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242108.Bytes);
public long this[int i]=>Value[i];

public static A242108Inst Instance=new A242108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242109
{
public static readonly long[] Value={ 2L,2917L,13457L,15377L,15877L,21317L,78401L,147457L,190097L,215297L,217157L,287297L,401957L,414737L,577601L,1299601L,1308737L,1313317L,1378277L,1547537L,1623077L,1664101L,1731857L,1742401L,1822501L,1887877L,1976837L,2044901L,2390117L,2421137L,2446097L,2483777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242109Inst : IEnumerable<long>
{
public static readonly long[] Value=A242109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242109.Bytes);
public long this[int i]=>Value[i];

public static A242109Inst Instance=new A242109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242110
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,8L,11L,13L,21L,23L,33L,39L,54L,63L,88L,98L,132L,157L,200L,237L,303L,356L,440L,526L,643L,767L,931L,1103L,1317L,1581L,1860L,2215L,2615L,3100L,3631L,4302L,4999L,5907L,6865L,8059L,9322L,10950L,12613L,14744L,16988L,19756L,22694L,26344L,30192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242110Inst : IEnumerable<long>
{
public static readonly long[] Value=A242110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242110.Bytes);
public long this[int i]=>Value[i];

public static A242110Inst Instance=new A242110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242111
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,2L,2L,2L,5L,1L,5L,2L,2L,2L,7L,1L,4L,2L,2L,3L,4L,1L,6L,2L,2L,3L,4L,1L,4L,2L,3L,2L,8L,1L,4L,2L,3L,2L,4L,1L,5L,4L,2L,2L,7L,1L,4L,3L,2L,3L,5L,1L,8L,2L,2L,2L,4L,1L,11L,3L,2L,3L,4L,2L,4L,2L,2L,2L,5L,2L,6L,3L,2L,2L,7L,1L,7L,2L,2L,2L,7L,1L,5L,2L,2L,3L,6L,1L,4L,2L,2L,3L,7L,1L,5L,4L,3L,2L,4L,1L,4L,2L,3L,3L,5L,1L,4L,3L,3L,3L,4L,1L,8L,4L,2L,2L,4L,1L,6L,2L,3L,2L,5L,1L,6L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242111Inst : IEnumerable<long>
{
public static readonly long[] Value=A242111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242111.Bytes);
public long this[int i]=>Value[i];

public static A242111Inst Instance=new A242111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242160
{
public static readonly BigInteger[] Value={ 1L,8L,72L,600L,5280L,48312L,465036L,4708704L,50160825L,561623920L,6600378928L,81297463104L,1047817553016L,14109488456400L,198192170408400L,2899804394683680L,44131025207930595L,697636040687261280L,11441167306954104500UL,BigInteger.Parse("194421818718469399200") };
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
public class A242160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242160Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242160.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242160Inst Instance=new A242160Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242161
{
public static readonly BigInteger[] Value={ 1L,9L,90L,825L,7920L,78507L,813813L,8828820L,100321650L,1193450830L,14850852588L,193081474872L,2619543882540L,37037407198050L,545028468623100L,8336937634715580L,132393075623791785L,2180112627147691500L,BigInteger.Parse("37183793747600839625"),BigInteger.Parse("656173638174834222300") };
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
public class A242161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242161Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242161.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242161.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242161Inst Instance=new A242161Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242162
{
public static readonly BigInteger[] Value={ 1L,10L,110L,1100L,11440L,122122L,1356355L,15695680L,189496450L,2386901660L,31351799908L,429069944160L,6112269059260L,90535884261900L,1392850530925700L,22231833692574880L,367758543399421625L,6298103145093331000L,BigInteger.Parse("111551381242802518875"),BigInteger.Parse("2041429096543928691600") };
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
public class A242162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242162Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242162.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242162Inst Instance=new A242162Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242163
{
public static readonly BigInteger[] Value={ 1L,11L,132L,1430L,16016L,183183L,2170168L,26682656L,341093610L,4535113154L,62703599816L,901046882736L,13446991930372L,208232533802370L,3342841274221680L,55579584231437200L,956172212838496225L,17004878491751993700UL,BigInteger.Parse("312343867479847052850"),BigInteger.Parse("5920144379977393205640") };
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
public class A242163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242163Inst Instance=new A242163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242164
{
public static readonly BigInteger[] Value={ 1L,1L,3L,20L,175L,2016L,28182L,465036L,8828820L,189496450L,4535113154L,119706872376L,3454013050488L,108140144894600L,3650830138093500L,132194177662402800L,5110163818369981650L,BigInteger.Parse("210037720563156731850"),BigInteger.Parse("9146299175093615073000"),BigInteger.Parse("420627290039763259876500") };
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
public class A242164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242164Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242164.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242164.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242164Inst Instance=new A242164Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242165
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,3L,2L,0L,0L,1L,0L,3L,2L,3L,0L,1L,0L,3L,2L,3L,0L,1L,0L,9L,4L,3L,6L,5L,0L,9L,2L,3L,0L,1L,0L,3L,2L,3L,0L,1L,0L,3L,2L,9L,0L,5L,6L,3L,4L,9L,0L,1L,0L,9L,4L,3L,6L,5L,0L,15L,2L,3L,0L,1L,0L,7L,4L,3L,4L,5L,0L,1L,0L,1L,0L,5L,4L,3L,14L,9L,0L,7L,10L,9L,4L,13L,6L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242165Inst : IEnumerable<long>
{
public static readonly long[] Value=A242165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242165.Bytes);
public long this[int i]=>Value[i];

public static A242165Inst Instance=new A242165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242166
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,2L,3L,2L,5L,2L,2L,9L,3L,9L,2L,4L,2L,33L,9L,17L,2L,2L,28L,2L,129L,27L,33L,2L,5L,2L,244L,5L,513L,81L,65L,2L,2L,33L,2L,1540L,25L,2049L,243L,129L,2L,6L,9L,257L,7L,4132L,125L,8193L,729L,257L,2L,2L,51L,81L,2049L,49L,66340L,625L,32769L,2187L,513L,2L,17L,2L,376L,729L,16385L,343L,159652L,3125L,131073L,6561L,1025L,2L,2L,161L,2L,4376L,6561L,131073L,2401L,1279396L,15625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242166Inst : IEnumerable<long>
{
public static readonly long[] Value=A242166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242166.Bytes);
public long this[int i]=>Value[i];

public static A242166Inst Instance=new A242166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242167
{
public static readonly long[] Value={ 16L,80L,298L,934L,2632L,6890L,17118L,40908L,94884L,214956L,477922L,1046544L,2263228L,4843834L,10277132L,21645226L,45303842L,94314954L,195443594L,403391590L,829703588L,1701379556L,3479560910L,7099569872L,14455857024L,29380784736L,59618421994L,120801765892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242167Inst : IEnumerable<long>
{
public static readonly long[] Value=A242167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242167.Bytes);
public long this[int i]=>Value[i];

public static A242167Inst Instance=new A242167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242168
{
public static readonly long[] Value={ 1L,2L,8L,8L,3L,0L,0L,8L,8L,8L,6L,7L,3L,9L,2L,1L,2L,3L,0L,1L,8L,0L,9L,0L,1L,4L,9L,3L,9L,3L,0L,9L,6L,3L,4L,4L,4L,2L,2L,5L,8L,7L,3L,8L,0L,7L,1L,3L,8L,7L,9L,6L,1L,9L,5L,0L,3L,2L,0L,1L,4L,9L,4L,2L,6L,9L,8L,6L,4L,4L,2L,4L,1L,8L,5L,2L,0L,4L,9L,7L,8L,8L,7L,6L,8L,2L,0L,9L,3L,4L,4L,4L,4L,1L,1L,1L,3L,3L,9L,8L,1L,3L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242168Inst : IEnumerable<long>
{
public static readonly long[] Value=A242168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242168.Bytes);
public long this[int i]=>Value[i];

public static A242168Inst Instance=new A242168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242169
{
public static readonly BigInteger[] Value={ 2L,5L,7L,173L,563L,13L,41L,369581L,937L,61L,23L,29L,2141L,12148537L,31L,157L,59L,37L,506251L,151L,3019L,769L,47L,6730949L,79L,53L,3853L,661L,BigInteger.Parse("138961158000728258971"),1361L,421L,96920594213L,51378681049L,457L,71L };
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
public class A242169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242169Inst Instance=new A242169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242170
{
public static readonly long[] Value={ 1L,3L,7L,19L,17L,47L,131L,41L,43L,1279L,503L,113L,2917L,569L,198623L,14083L,26693L,201611L,42998951L,41931041L,52635749L,1296973L,169097L,1451L,1304394227L,107L,233L,173L,2062225210273L,719L,191L,31551555041L,6301L,563L,3769L,967L,9539L,5073466546857451L,4542977L,9739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242170Inst : IEnumerable<long>
{
public static readonly long[] Value=A242170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242170.Bytes);
public long this[int i]=>Value[i];

public static A242170Inst Instance=new A242170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242171
{
public static readonly long[] Value={ 1L,2L,5L,3L,13L,7L,877L,23L,19L,4639L,22619L,37L,27644437L,1800937L,251L,241L,255755771L,19463L,271L,61L,24709L,17L,89L,123419L,367L,101L,157L,67L,75979L,107L,11L,179167L,5694673L,111509L,980424262253L,193L,44101L,5399L,6353L,3221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242171Inst : IEnumerable<long>
{
public static readonly long[] Value=A242171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242171.Bytes);
public long this[int i]=>Value[i];

public static A242171Inst Instance=new A242171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242172
{
public static readonly long[] Value={ 1L,3L,6L,15L,30L,70L,140L,315L,630L,1386L,2772L,6006L,12012L,25740L,51480L,109395L,218790L,461890L,923780L,1939938L,3879876L,8112468L,16224936L,33801950L,67603900L,140408100L,280816200L,581690700L,1163381400L,2404321560L,4808643120L,9917826435L,19835652870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242172Inst : IEnumerable<long>
{
public static readonly long[] Value=A242172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242172.Bytes);
public long this[int i]=>Value[i];

public static A242172Inst Instance=new A242172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242173
{
public static readonly BigInteger[] Value={ 3L,13L,7L,107L,11L,89L,31L,265729L,19L,9887L,23L,113L,79L,373L,53L,3089L,151L,127L,719L,193L,43L,482673878761L,47L,61403L,109L,37889L,1223L,3251609L,59L,181L,BigInteger.Parse("22504880485262968151"),3598831L,67L,69593L,179L,13828116559L,4247285503L,1579L,19095283759L,619L };
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
public class A242173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242173.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242173Inst Instance=new A242173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242174
{
public static readonly BigInteger[] Value={ 2L,3L,41L,5L,7L,349L,61L,75617L,31L,13L,499L,643897693L,17L,19L,1729774061L,101L,2859112064587L,138407L,83L,167L,59L,29L,653L,257L,BigInteger.Parse("997540809461453561581"),347L,13679L,37L,BigInteger.Parse("160449179727717672892660463"),211L,151L,43L,97L,73L,47L };
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
public class A242174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242174Inst Instance=new A242174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242175
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,9L,11L,16L,21L,33L,35L,101L,105L,131L,158L,165L,191L,234L,251L,435L,453L,459L,561L,579L,604L,671L,744L,753L,933L,941L,963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242175Inst : IEnumerable<long>
{
public static readonly long[] Value=A242175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242175.Bytes);
public long this[int i]=>Value[i];

public static A242175Inst Instance=new A242175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242384
{
public static readonly long[] Value={ 3L,11L,59L,139L,179L,311L,419L,541L,919L,1399L,1621L,2111L,3119L,5099L,6379L,8059L,8839L,9377L,15661L,16007L,16741L,17107L,21011L,21839L,23539L,24419L,28081L,30011L,31489L,33533L,35617L,37811L,39461L,41759L,44699L,45293L,60899L,68819L,71059L,78007L,83639L,84457L,86111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242384Inst : IEnumerable<long>
{
public static readonly long[] Value=A242384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242384.Bytes);
public long this[int i]=>Value[i];

public static A242384Inst Instance=new A242384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242385
{
public static readonly long[] Value={ 13L,97L,113L,193L,283L,397L,479L,673L,953L,1439L,1597L,2297L,2699L,3469L,4219L,4483L,5323L,7219L,8273L,9209L,9403L,10799L,12097L,13219L,14879L,15373L,15619L,21313L,23399L,26237L,27883L,32029L,32749L,34217L,37243L,39989L,41203L,42433L,43669L,46219L,55219L,60509L,62497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242385Inst : IEnumerable<long>
{
public static readonly long[] Value=A242385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242385.Bytes);
public long this[int i]=>Value[i];

public static A242385Inst Instance=new A242385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242386
{
public static readonly long[] Value={ 2L,3L,109L,211L,347L,409L,1051L,1493L,2111L,2273L,3167L,4219L,4441L,10099L,10853L,10903L,11353L,11909L,12823L,12973L,13421L,13831L,14543L,14639L,20551L,21011L,21347L,21661L,21863L,22271L,23581L,23981L,30047L,30557L,31259L,31307L,31963L,32069L,32213L,32467L,32869L,33029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242386Inst : IEnumerable<long>
{
public static readonly long[] Value=A242386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242386.Bytes);
public long this[int i]=>Value[i];

public static A242386Inst Instance=new A242386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242387
{
public static readonly long[] Value={ 3L,5L,7L,97L,109L,281L,359L,389L,409L,509L,631L,653L,691L,743L,827L,857L,907L,937L,967L,1549L,2111L,2767L,4219L,4441L,7001L,9007L,9337L,9661L,10099L,11503L,12919L,13421L,16759L,17569L,21011L,21611L,23831L,26261L,26861L,28181L,29287L,29483L,30497L,31307L,32213L,33029L,33629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242387Inst : IEnumerable<long>
{
public static readonly long[] Value=A242387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242387.Bytes);
public long this[int i]=>Value[i];

public static A242387Inst Instance=new A242387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242388
{
public static readonly long[] Value={ 2L,3L,5L,4L,7L,13L,5L,9L,17L,33L,6L,11L,21L,41L,81L,7L,13L,25L,49L,97L,193L,8L,15L,29L,57L,113L,225L,449L,9L,17L,33L,65L,129L,257L,513L,1025L,10L,19L,37L,73L,145L,289L,577L,1153L,2305L,11L,21L,41L,81L,161L,321L,641L,1281L,2561L,5121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242388Inst : IEnumerable<long>
{
public static readonly long[] Value=A242388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242388.Bytes);
public long this[int i]=>Value[i];

public static A242388Inst Instance=new A242388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242389
{
public static readonly long[] Value={ 2L,3L,7L,13L,31L,58L,127L,249L,508L,1016L,2047L,4080L,8191L,16374L,32759L,65521L,131071L,262123L,524287L,1048554L,2097141L,4194290L,8388607L,16777180L,33554426L,67108848L,134217715L,268435428L,536870911L,10737417182L,2147483647L,4294967265L,8589934577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242389Inst : IEnumerable<long>
{
public static readonly long[] Value=A242389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242389.Bytes);
public long this[int i]=>Value[i];

public static A242389Inst Instance=new A242389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242390
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,5L,1L,8L,0L,12L,7L,18L,1L,14L,11L,27L,31L,5L,3L,17L,42L,0L,50L,15L,35L,40L,27L,33L,1L,56L,65L,9L,79L,4L,30L,23L,60L,70L,88L,11L,106L,127L,17L,98L,41L,0L,122L,141L,9L,37L,77L,163L,119L,20L,0L,57L,182L,168L,98L,92L,202L,21L,199L,154L,6L,129L,227L,81L,2L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242390Inst : IEnumerable<long>
{
public static readonly long[] Value=A242390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242390.Bytes);
public long this[int i]=>Value[i];

public static A242390Inst Instance=new A242390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242391
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,10L,16L,28L,49L,91L,186L,266L,670L,884L,2350L,3028L,8259L,10536L,30241L,37382L,108628L,135550L,391202L,503750L,1429838L,1884659L,5222976L,7107138L,19119324L,27088726L,70366026L,103884570L,259884905L,399686188L,962312254L,1543116240L,3576132805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242391Inst : IEnumerable<long>
{
public static readonly long[] Value=A242391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242391.Bytes);
public long this[int i]=>Value[i];

public static A242391Inst Instance=new A242391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242392
{
public static readonly long[] Value={ 0L,0L,2L,3L,3L,2L,3L,4L,4L,3L,5L,6L,2L,5L,6L,3L,6L,6L,2L,3L,4L,5L,6L,7L,8L,7L,4L,8L,2L,3L,4L,5L,5L,6L,7L,8L,7L,4L,8L,2L,3L,4L,6L,8L,9L,10L,3L,5L,6L,7L,8L,9L,9L,2L,4L,5L,6L,7L,8L,9L,10L,12L,10L,3L,5L,6L,7L,9L,10L,11L,12L,15L,2L,4L,5L,8L,12L,14L,6L,9L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242392Inst : IEnumerable<long>
{
public static readonly long[] Value=A242392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242392.Bytes);
public long this[int i]=>Value[i];

public static A242392Inst Instance=new A242392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242393
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,19L,23L,29L,30L,42L,90L,132L,150L,156L,168L,240L,360L,420L,756L,924L,960L,1260L,2160L,2520L,4620L,5040L,6720L,7560L,14280L,16380L,18480L,20160L,31680L,35280L,41580L,45360L,50400L,65520L,98280L,110880L,171360L,226800L,249480L,257040L,262080L,277200L,332640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242393Inst : IEnumerable<long>
{
public static readonly long[] Value=A242393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242393.Bytes);
public long this[int i]=>Value[i];

public static A242393Inst Instance=new A242393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242394
{
public static readonly long[] Value={ 6L,18L,30L,42L,54L,66L,66L,102L,114L,126L,138L,150L,150L,162L,198L,210L,222L,234L,222L,270L,258L,294L,306L,318L,330L,330L,366L,354L,390L,402L,390L,426L,450L,462L,450L,486L,474L,486L,510L,546L,558L,546L,558L,594L,606L,630L,642L,654L,618L,678L,690L,690L,726L,738L,750L,738L,750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242394Inst : IEnumerable<long>
{
public static readonly long[] Value=A242394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242394.Bytes);
public long this[int i]=>Value[i];

public static A242394Inst Instance=new A242394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242395
{
public static readonly long[] Value={ 14L,26L,38L,58L,70L,82L,98L,110L,122L,142L,154L,166L,182L,194L,206L,218L,238L,250L,262L,278L,290L,302L,322L,334L,346L,362L,374L,386L,398L,418L,430L,442L,458L,470L,482L,502L,514L,526L,542L,554L,566L,578L,598L,610L,622L,638L,650L,662L,682L,694L,706L,722L,734L,746L,766L,778L,790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242395Inst : IEnumerable<long>
{
public static readonly long[] Value=A242395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242395.Bytes);
public long this[int i]=>Value[i];

public static A242395Inst Instance=new A242395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242396
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,14L,18L,20L,22L,24L,26L,28L,32L,34L,36L,38L,40L,42L,44L,48L,50L,52L,54L,56L,58L,62L,64L,66L,68L,70L,72L,74L,78L,80L,82L,84L,86L,88L,92L,94L,96L,98L,100L,102L,104L,108L,110L,112L,114L,116L,118L,122L,124L,126L,128L,130L,132L,134L,138L,140L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242396Inst : IEnumerable<long>
{
public static readonly long[] Value=A242396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242396.Bytes);
public long this[int i]=>Value[i];

public static A242396Inst Instance=new A242396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242397
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,2L,1L,2L,2L,2L,2L,1L,1L,1L,3L,1L,1L,4L,3L,1L,2L,2L,1L,4L,2L,1L,2L,3L,1L,2L,2L,1L,5L,2L,4L,2L,1L,3L,2L,1L,3L,4L,1L,1L,2L,2L,1L,3L,5L,1L,1L,5L,2L,2L,1L,3L,4L,2L,2L,2L,1L,1L,5L,2L,2L,3L,3L,3L,3L,1L,5L,2L,2L,4L,4L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242397Inst : IEnumerable<long>
{
public static readonly long[] Value=A242397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242397.Bytes);
public long this[int i]=>Value[i];

public static A242397Inst Instance=new A242397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242398
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,5L,9L,9L,12L,12L,16L,16L,16L,18L,19L,22L,23L,25L,28L,38L,38L,42L,49L,53L,56L,58L,59L,61L,79L,79L,79L,81L,83L,100L,100L,101L,101L,103L,109L,118L,121L,122L,123L,124L,132L,135L,137L,137L,152L,153L,157L,158L,159L,166L,173L,173L,177L,177L,181L,184L,188L,188L,189L,189L,190L,197L,199L,204L,205L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242398Inst : IEnumerable<long>
{
public static readonly long[] Value=A242398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242398.Bytes);
public long this[int i]=>Value[i];

public static A242398Inst Instance=new A242398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242399
{
public static readonly long[] Value={ 0L,4L,8L,12L,16L,11L,24L,19L,23L,36L,40L,44L,48L,52L,47L,33L,28L,32L,72L,76L,80L,57L,61L,56L,69L,64L,68L,108L,112L,116L,120L,124L,119L,132L,127L,131L,144L,148L,152L,156L,160L,155L,141L,136L,140L,99L,103L,107L,84L,88L,83L,96L,91L,95L,216L,220L,224L,228L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242399Inst : IEnumerable<long>
{
public static readonly long[] Value=A242399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242399.Bytes);
public long this[int i]=>Value[i];

public static A242399Inst Instance=new A242399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242448
{
public static readonly long[] Value={ 1L,3L,6L,12L,22L,38L,64L,106L,174L,284L,462L,750L,1216L,1970L,3190L,5164L,8358L,13526L,21888L,35418L,57310L,92732L,150046L,242782L,392832L,635618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242448Inst : IEnumerable<long>
{
public static readonly long[] Value=A242448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242448.Bytes);
public long this[int i]=>Value[i];

public static A242448Inst Instance=new A242448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242449
{
public static readonly BigInteger[] Value={ 1L,28L,3612L,1064480L,560632400L,462479403072L,550095467201728L,891290348282967040L,BigInteger.Parse("1887146395301619304704"),BigInteger.Parse("5058811707344107766328320"),BigInteger.Parse("16746136671945501439084657664"),BigInteger.Parse("67088193422344140016282100785152"),BigInteger.Parse("319900900946743851959321101768511488") };
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
public class A242449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242449Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242449.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242449.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242449Inst Instance=new A242449Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242450
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,42L,132L,429L,1430L,4862L,16795L,1L,58783L,3L,208002L,10L,742865L,35L,2674314L,126L,9694383L,462L,35355954L,1716L,129638355L,6435L,477614391L,24308L,1L,1767170815L,92372L,3L,6563767715L,352694L,11L,24464914983L,1351996L,41L,91477363496L,5199988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242450Inst : IEnumerable<long>
{
public static readonly long[] Value=A242450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242450.Bytes);
public long this[int i]=>Value[i];

public static A242450Inst Instance=new A242450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242451
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,0L,1L,0L,6L,1L,0L,1L,0L,15L,0L,0L,0L,1L,0L,23L,7L,1L,0L,0L,1L,0L,53L,10L,0L,0L,0L,0L,1L,0L,94L,32L,0L,1L,0L,0L,0L,1L,0L,203L,31L,21L,0L,0L,0L,0L,0L,1L,0L,404L,71L,35L,0L,1L,0L,0L,0L,0L,1L,0L,855L,77L,91L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1648L,222L,105L,71L,0L,1L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242451Inst : IEnumerable<long>
{
public static readonly long[] Value=A242451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242451.Bytes);
public long this[int i]=>Value[i];

public static A242451Inst Instance=new A242451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242452
{
public static readonly long[] Value={ 1L,3L,8L,21L,54L,140L,362L,937L,2425L,6275L,16239L,42024L,108751L,281430L,728295L,1884709L,4877320L,12621710L,32662931L,84526348L,218740428L,566064618L,1464883079L,3790878933L,9810177543L,25387142435L,65697791726L,170015189725L,439971633412L,1138574962157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242452Inst : IEnumerable<long>
{
public static readonly long[] Value=A242452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242452.Bytes);
public long this[int i]=>Value[i];

public static A242452Inst Instance=new A242452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242453
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,5L,6L,7L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,11L,11L,11L,11L,12L,13L,13L,13L,13L,13L,13L,14L,14L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,18L,19L,19L,19L,19L,19L,19L,19L,19L,19L,20L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242453Inst : IEnumerable<long>
{
public static readonly long[] Value=A242453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242453.Bytes);
public long this[int i]=>Value[i];

public static A242453Inst Instance=new A242453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242454
{
public static readonly long[] Value={ 6L,15L,28L,36L,45L,55L,78L,91L,105L,136L,153L,171L,190L,231L,253L,276L,325L,351L,406L,465L,528L,630L,703L,780L,820L,861L,1035L,1081L,1176L,1225L,1275L,1431L,1540L,1596L,1653L,1711L,1770L,2016L,2080L,2211L,2346L,2701L,2775L,2850L,3003L,3160L,3240L,3321L,3403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242454Inst : IEnumerable<long>
{
public static readonly long[] Value=A242454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242454.Bytes);
public long this[int i]=>Value[i];

public static A242454Inst Instance=new A242454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242455
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,15L,16L,17L,19L,20L,23L,24L,25L,29L,30L,31L,32L,35L,37L,40L,41L,43L,47L,48L,50L,53L,55L,59L,60L,61L,64L,67L,71L,73L,75L,77L,79L,80L,83L,89L,96L,97L,100L,101L,103L,107L,109L,113L,120L,121L,125L,127L,128L,131L,137L,139L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242455Inst : IEnumerable<long>
{
public static readonly long[] Value=A242455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242455.Bytes);
public long this[int i]=>Value[i];

public static A242455Inst Instance=new A242455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242456
{
public static readonly BigInteger[] Value={ 1L,2L,8L,24L,144L,720L,5760L,51840L,518400L,3628800L,43545600L,479001600L,6706022400L,100590336000L,1609445376000L,20922789888000L,376610217984000L,6402373705728000L,128047474114560000L,2688996956405760000L,BigInteger.Parse("59157933040926720000"),BigInteger.Parse("1124000727777607680000"),BigInteger.Parse("26976017466662584320000"),BigInteger.Parse("674400436666564608000000") };
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
public class A242456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242456.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242456Inst Instance=new A242456Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242457
{
public static readonly long[] Value={ 2L,3L,3L,0L,0L,0L,0L,4L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242457Inst : IEnumerable<long>
{
public static readonly long[] Value=A242457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242457.Bytes);
public long this[int i]=>Value[i];

public static A242457Inst Instance=new A242457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242458
{
public static readonly long[] Value={ 1L,1360L,1361L,1362L,1363L,1364L,1365L,1366L,1367L,1368L,1370L,1371L,1372L,1373L,1374L,1375L,1376L,1377L,1378L,1379L,2490L,2491L,2492L,2493L,2494L,2495L,2496L,2497L,2498L,2499L,2500L,2501L,2502L,2503L,2504L,2505L,2506L,2507L,2508L,2509L,3590L,3591L,3592L,3593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242458Inst : IEnumerable<long>
{
public static readonly long[] Value=A242458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242458.Bytes);
public long this[int i]=>Value[i];

public static A242458Inst Instance=new A242458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242459
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,12L,20L,24L,27L,29L,42L,54L,72L,75L,103L,128L,131L,151L,153L,162L,164L,181L,204L,208L,209L,211L,237L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242459Inst : IEnumerable<long>
{
public static readonly long[] Value=A242459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242459.Bytes);
public long this[int i]=>Value[i];

public static A242459Inst Instance=new A242459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242460
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,0L,3L,2L,2L,0L,2L,0L,2L,2L,2L,0L,3L,0L,2L,2L,2L,0L,2L,2L,2L,3L,2L,0L,2L,0L,5L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,0L,2L,3L,2L,0L,3L,2L,3L,2L,2L,0L,4L,2L,2L,2L,2L,0L,3L,0L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,0L,2L,3L,2L,2L,2L,0L,3L,2L,2L,0L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242460Inst : IEnumerable<long>
{
public static readonly long[] Value=A242460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242460.Bytes);
public long this[int i]=>Value[i];

public static A242460Inst Instance=new A242460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242461
{
public static readonly long[] Value={ 3L,7L,3L,3L,6L,4L,6L,1L,7L,7L,0L,1L,6L,7L,4L,0L,8L,4L,2L,4L,8L,4L,4L,8L,4L,3L,6L,6L,7L,9L,2L,7L,0L,5L,9L,5L,0L,0L,2L,5L,7L,6L,4L,6L,7L,0L,0L,4L,2L,7L,7L,3L,8L,4L,4L,4L,4L,9L,3L,8L,5L,7L,0L,3L,1L,5L,1L,3L,0L,5L,6L,5L,5L,1L,3L,3L,5L,3L,3L,3L,5L,5L,8L,8L,8L,1L,6L,9L,8L,8L,9L,0L,6L,5L,0L,3L,8L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242461Inst : IEnumerable<long>
{
public static readonly long[] Value=A242461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242461.Bytes);
public long this[int i]=>Value[i];

public static A242461Inst Instance=new A242461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242462
{
public static readonly BigInteger[] Value={ 10L,46L,1036L,7246L,26248636L,11628145306L,461742021916246L,7849614372576166L,BigInteger.Parse("44750651538056716666"),BigInteger.Parse("17139499539075722482696"),BigInteger.Parse("188534494929832947309646"),BigInteger.Parse("69192159639248691662639716"),BigInteger.Parse("2144956948816709441541831166"),BigInteger.Parse("13721289601580490297543093962506") };
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
public class A242462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242462Inst Instance=new A242462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242463
{
public static readonly BigInteger[] Value={ 253L,2773L,130285L,651421L,219528541L,257067920341L,4370154645781L,292800361267261L,11023640801351071741UL,BigInteger.Parse("13475008472558425746927448861"),BigInteger.Parse("5107028211099643358085503117941"),BigInteger.Parse("1313771981231475489737485570488833367541") };
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
public class A242463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242463Inst Instance=new A242463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242496
{
public static readonly long[] Value={ 0L,1L,7L,23L,72L,204L,564L,1521L,4059L,10747L,28336L,74504L,195576L,512865L,1344063L,3521007L,9221688L,24148468L,63230860L,165555665L,433454835L,1134839091L,2971111392L,7778574288L,20364739632L,53315851969L,139583151799L,365434146311L,956720165544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242496Inst : IEnumerable<long>
{
public static readonly long[] Value=A242496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242496.Bytes);
public long this[int i]=>Value[i];

public static A242496Inst Instance=new A242496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242497
{
public static readonly long[] Value={ 3L,4L,5L,13L,14L,15L,51L,52L,53L,193L,194L,195L,723L,724L,725L,2701L,2702L,2703L,10083L,10084L,10085L,37633L,37634L,37635L,140451L,140452L,140453L,524173L,524174L,524175L,1956243L,1956244L,1956245L,7300801L,7300802L,7300803L,27246963L,27246964L,27246965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242497Inst : IEnumerable<long>
{
public static readonly long[] Value=A242497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242497.Bytes);
public long this[int i]=>Value[i];

public static A242497Inst Instance=new A242497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242498
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,1L,2L,1L,0L,1L,1L,1L,0L,3L,2L,0L,1L,3L,4L,1L,4L,3L,0L,1L,1L,2L,1L,6L,9L,3L,5L,4L,0L,1L,4L,9L,6L,11L,16L,6L,6L,5L,0L,1L,1L,3L,3L,11L,24L,18L,19L,25L,10L,7L,6L,0L,1L,5L,16L,18L,28L,51L,40L,31L,36L,15L,8L,7L,0L,1L,1L,4L,6L,19L,51L,60L,65L,95L,75L,48L,49L,21L,9L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242498Inst : IEnumerable<long>
{
public static readonly long[] Value=A242498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242498.Bytes);
public long this[int i]=>Value[i];

public static A242498Inst Instance=new A242498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242499
{
public static readonly long[] Value={ 1L,0L,1L,3L,1L,9L,11L,18L,51L,65L,151L,290L,477L,1043L,1835L,3486L,6931L,12540L,24607L,46797L,87979L,171072L,323269L,619245L,1190619L,2264925L,4357211L,8343322L,15973309L,30711853L,58846191L,113027716L,217192103L,416964202L,801880039L,1541412015L,2963997227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242499Inst : IEnumerable<long>
{
public static readonly long[] Value=A242499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242499.Bytes);
public long this[int i]=>Value[i];

public static A242499Inst Instance=new A242499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242500
{
public static readonly long[] Value={ 1L,0L,2L,4L,3L,16L,19L,40L,95L,136L,321L,588L,1057L,2240L,3998L,7848L,15339L,28464L,56143L,106788L,204083L,396704L,755052L,1457456L,2806531L,5377112L,10382243L,19947252L,38382957L,73996576L,142311198L,274283168L,528438319L,1017784016L,1962451118L,3781912684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242500Inst : IEnumerable<long>
{
public static readonly long[] Value=A242500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242500.Bytes);
public long this[int i]=>Value[i];

public static A242500Inst Instance=new A242500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242501
{
public static readonly long[] Value={ 1L,0L,3L,5L,6L,25L,31L,75L,162L,259L,609L,1106L,2122L,4410L,8076L,16197L,31527L,59961L,118844L,227700L,441507L,860860L,1654731L,3218501L,6226818L,12027405L,23337471L,45082050L,87258876L,168935018L,326536646L,632132760L,1222716653L,2364969824L,4576680195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242501Inst : IEnumerable<long>
{
public static readonly long[] Value=A242501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242501.Bytes);
public long this[int i]=>Value[i];

public static A242501Inst Instance=new A242501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242502
{
public static readonly long[] Value={ 1L,0L,4L,6L,10L,36L,48L,126L,259L,456L,1064L,1956L,3939L,8112L,15300L,31174L,60951L,118580L,236456L,458172L,900185L,1765556L,3431792L,6728410L,13107393L,25538448L,49856392L,96966572L,188914574L,367741688L,715053048L,1391512424L,2705016795L,5258241032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242502Inst : IEnumerable<long>
{
public static readonly long[] Value=A242502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242502.Bytes);
public long this[int i]=>Value[i];

public static A242502Inst Instance=new A242502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242503
{
public static readonly long[] Value={ 1L,0L,5L,7L,15L,49L,71L,196L,394L,753L,1746L,3285L,6865L,14124L,27445L,56661L,111892L,222222L,446524L,876876L,1744353L,3448783L,6782633L,13411528L,26346074L,51799306L,101840098L,199601828L,391637976L,767247094L,1501758784L,2939789022L,5747749147L,11235696151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242503Inst : IEnumerable<long>
{
public static readonly long[] Value=A242503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242503.Bytes);
public long this[int i]=>Value[i];

public static A242503Inst Instance=new A242503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242504
{
public static readonly long[] Value={ 1L,0L,6L,8L,21L,64L,101L,288L,576L,1180L,2727L,5280L,11363L,23496L,46981L,98176L,196482L,397644L,806351L,1606488L,3234335L,6456048L,12849330L,25637632L,50835950L,100883304L,199903578L,395067760L,781029504L,1540973568L,3037666097L,5984978112L,11775884581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242504Inst : IEnumerable<long>
{
public static readonly long[] Value=A242504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242504.Bytes);
public long this[int i]=>Value[i];

public static A242504Inst Instance=new A242504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242505
{
public static readonly long[] Value={ 1L,0L,7L,9L,28L,81L,139L,405L,815L,1771L,4092L,8173L,18019L,37609L,77246L,163345L,331968L,683631L,1400777L,2832362L,5770056L,11640546L,23446366L,47227530L,94582628L,189487950L,378658714L,754877809L,1504215522L,2990469337L,5939101301L,11782590061L,23340439078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242505Inst : IEnumerable<long>
{
public static readonly long[] Value=A242505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242505.Bytes);
public long this[int i]=>Value[i];

public static A242505Inst Instance=new A242505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242506
{
public static readonly long[] Value={ 1L,0L,8L,10L,36L,100L,186L,550L,1122L,2564L,5940L,12246L,27560L,58240L,122642L,262458L,542243L,1134944L,2352136L,4826980L,9949352L,20300312L,41377116L,84172508L,170322099L,344527304L,694617960L,1397219682L,2807142612L,5625453196L,11258808682L,22498804286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242506Inst : IEnumerable<long>
{
public static readonly long[] Value=A242506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242506.Bytes);
public long this[int i]=>Value[i];

public static A242506Inst Instance=new A242506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242507
{
public static readonly long[] Value={ 1L,0L,9L,11L,45L,121L,243L,726L,1509L,3601L,8385L,17836L,40873L,87633L,188855L,409116L,859674L,1827160L,3832786L,7981398L,16644666L,34362355L,70866846L,145637147L,297814569L,608309130L,1237764177L,2512564769L,5090761029L,10286177231L,20750532587L,41778968976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242507Inst : IEnumerable<long>
{
public static readonly long[] Value=A242507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242507.Bytes);
public long this[int i]=>Value[i];

public static A242507Inst Instance=new A242507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242508
{
public static readonly long[] Value={ 1L,0L,10L,12L,55L,144L,311L,936L,1989L,4928L,11557L,25340L,59025L,128576L,283100L,620976L,1327258L,2862528L,6080645L,12845064L,27102284L,56625624L,118144679L,245331648L,507035957L,1045854240L,2148159266L,4400962876L,8993987459L,18326508928L,37269909849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242508Inst : IEnumerable<long>
{
public static readonly long[] Value=A242508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242508.Bytes);
public long this[int i]=>Value[i];

public static A242508Inst Instance=new A242508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242509
{
public static readonly long[] Value={ 1L,5L,24L,115L,550L,2631L,12584L,60191L,287901L,1377066L,6586677L,31504891L,150691790L,720777469L,3447567781L,16490143094L,78874393932L,377265981421L,1804509849677L,8631193794141L,41284067429916L,197466800561799L,944508129929499L,4517699202928696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242509Inst : IEnumerable<long>
{
public static readonly long[] Value=A242509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242509.Bytes);
public long this[int i]=>Value[i];

public static A242509Inst Instance=new A242509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242510
{
public static readonly long[] Value={ 1L,2L,3L,8L,15L,32L,67L,138L,289L,600L,1249L,2600L,5409L,11258L,23427L,48752L,101455L,211128L,439363L,914322L,1902721L,3959600L,8240001L,17147600L,35684481L,74260082L,154536643L,321593688L,669242575L,1392706512L,2898248707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242510Inst : IEnumerable<long>
{
public static readonly long[] Value=A242510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242510.Bytes);
public long this[int i]=>Value[i];

public static A242510Inst Instance=new A242510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242511
{
public static readonly long[] Value={ 1L,1L,2L,6L,28L,100L,330L,1050L,3024L,8736L,23220L,62700L,158004L,406692L,986986L,2452450L,5788640L,14002560L,32357052L,76640148L,174174520L,405623400L,909582212L,2089064516L,4633556448L,10519464000L,23120533800L,51977741400L,113365499940L,252725219460L,547593359850L,1211884139250L,2610998927040L,5741708459520L,12309472580460L,26917328938500L,57457069777800L,125016198060600L,265832233972140L,575824335603660L,1220234181784800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242511Inst : IEnumerable<long>
{
public static readonly long[] Value=A242511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242511.Bytes);
public long this[int i]=>Value[i];

public static A242511Inst Instance=new A242511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242672
{
public static readonly long[] Value={ 3L,8L,6L,9L,5L,1L,9L,2L,4L,1L,3L,9L,7L,9L,9L,9L,4L,9L,5L,6L,9L,4L,1L,6L,7L,2L,7L,8L,7L,7L,9L,0L,8L,3L,4L,3L,2L,1L,9L,4L,6L,0L,6L,4L,3L,2L,5L,1L,9L,6L,9L,3L,3L,4L,4L,0L,4L,3L,9L,6L,0L,8L,9L,1L,1L,7L,0L,5L,9L,6L,2L,9L,9L,7L,8L,9L,8L,0L,3L,1L,5L,6L,0L,7L,0L,3L,6L,0L,6L,6L,7L,6L,1L,8L,4L,9L,3L,0L,8L,7L,1L,9L,7L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242672Inst : IEnumerable<long>
{
public static readonly long[] Value=A242672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242672.Bytes);
public long this[int i]=>Value[i];

public static A242672Inst Instance=new A242672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242673
{
public static readonly long[] Value={ 8L,0L,4L,3L,5L,2L,2L,6L,2L,8L,4L,5L,6L,3L,7L,5L,8L,4L,6L,5L,4L,6L,3L,8L,5L,8L,7L,7L,8L,4L,0L,7L,0L,5L,5L,1L,0L,4L,2L,7L,1L,6L,9L,8L,5L,7L,8L,6L,6L,4L,2L,1L,5L,8L,6L,5L,6L,5L,4L,4L,7L,8L,2L,7L,2L,0L,9L,1L,3L,6L,5L,8L,9L,2L,1L,0L,1L,3L,1L,9L,3L,6L,3L,1L,4L,4L,6L,7L,4L,3L,4L,6L,3L,8L,1L,5L,2L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242673Inst : IEnumerable<long>
{
public static readonly long[] Value=A242673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242673.Bytes);
public long this[int i]=>Value[i];

public static A242673Inst Instance=new A242673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242674
{
public static readonly long[] Value={ 5L,8L,0L,1L,6L,4L,2L,2L,3L,9L,2L,0L,8L,5L,5L,3L,4L,6L,4L,2L,6L,0L,0L,8L,3L,2L,3L,5L,7L,2L,9L,9L,7L,2L,7L,6L,6L,3L,3L,0L,8L,8L,6L,3L,8L,1L,1L,1L,1L,0L,1L,4L,0L,4L,3L,1L,6L,8L,7L,4L,1L,1L,7L,9L,2L,1L,6L,6L,1L,3L,8L,7L,7L,9L,6L,9L,2L,9L,2L,4L,9L,1L,8L,4L,5L,9L,3L,1L,5L,2L,6L,8L,4L,4L,7L,0L,3L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242674Inst : IEnumerable<long>
{
public static readonly long[] Value=A242674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242674.Bytes);
public long this[int i]=>Value[i];

public static A242674Inst Instance=new A242674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242675
{
public static readonly long[] Value={ 2L,29L,89L,101L,281L,269L,641L,461L,701L,761L,1049L,941L,1109L,1601L,1361L,2621L,2309L,1889L,2441L,2141L,2609L,3929L,3701L,3461L,3449L,5849L,4241L,4289L,5081L,8669L,7589L,5381L,6569L,9941L,8861L,7229L,7829L,8501L,8069L,8609L,9749L,10601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242675Inst : IEnumerable<long>
{
public static readonly long[] Value=A242675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242675.Bytes);
public long this[int i]=>Value[i];

public static A242675Inst Instance=new A242675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242676
{
public static readonly BigInteger[] Value={ 1L,6L,13068L,150917976L,5056995703824L,371384787345228000L,BigInteger.Parse("50779532534302850198976"),BigInteger.Parse("11616723683566425573507775872"),BigInteger.Parse("4123257155075936045020928754053376"),BigInteger.Parse("2146734309994687055429549444238169536000"),BigInteger.Parse("1569808063009967047226374755685187772671339520") };
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
public class A242676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242676Inst Instance=new A242676Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242677
{
public static readonly long[] Value={ 15L,33L,55L,57L,65L,69L,77L,87L,115L,121L,129L,143L,169L,205L,209L,265L,299L,305L,321L,339L,361L,415L,417L,447L,451L,481L,493L,505L,517L,519L,535L,551L,553L,581L,611L,623L,667L,687L,695L,721L,737L,779L,789L,799L,865L,871L,893L,901L,905L,923L,943L,949L,955L,973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242677Inst : IEnumerable<long>
{
public static readonly long[] Value=A242677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242677.Bytes);
public long this[int i]=>Value[i];

public static A242677Inst Instance=new A242677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242678
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,14L,16L,19L,21L,24L,27L,30L,33L,37L,40L,44L,48L,51L,55L,59L,63L,67L,72L,75L,80L,83L,88L,91L,97L,99L,105L,107L,113L,115L,122L,123L,130L,131L,137L,138L,144L,144L,150L,150L,156L,157L,163L,163L,169L,168L,173L,173L,178L,178L,183L,181L,185L,184L,188L,187L,191L,188L,191L,188L,190L,188L,190L,185L,188L,184L,185L,182L,183L,177L,179L,172L,173L,169L,169L,161L,164L,155L,157L,152L,152L,144L,147L,135L,138L,132L,131L,124L,127L,115L,120L,112L,111L,105L,107L,93L,100L,92L,90L,87L,87L,74L,83L,73L,71L,71L,68L,56L,66L,55L,53L,55L,50L,41L,52L,39L,38L,42L,35L,27L,39L,26L,26L,32L,23L,18L,29L,16L,18L,23L,14L,11L,21L,9L,11L,17L,8L,7L,16L,4L,7L,12L,4L,4L,10L,2L,4L,8L,2L,2L,7L,0L,2L,5L,0L,1L,4L,0L,1L,3L,0L,0L,2L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242678Inst : IEnumerable<long>
{
public static readonly long[] Value=A242678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242678.Bytes);
public long this[int i]=>Value[i];

public static A242678Inst Instance=new A242678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242679
{
public static readonly long[] Value={ 4L,11L,18L,25L,32L,36L,43L,50L,57L,64L,71L,75L,82L,89L,96L,103L,114L,121L,128L,135L,142L,146L,153L,160L,167L,174L,185L,192L,199L,206L,213L,217L,224L,231L,238L,245L,256L,263L,270L,277L,284L,288L,295L,302L,309L,316L,327L,334L,341L,348L,355L,359L,366L,373L,380L,387L,398L,405L,412L,419L,426L,430L,437L,444L,451L,458L,469L,476L,483L,490L,497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242679Inst : IEnumerable<long>
{
public static readonly long[] Value=A242679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242679.Bytes);
public long this[int i]=>Value[i];

public static A242679Inst Instance=new A242679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242680
{
public static readonly long[] Value={ 1L,2L,3L,9L,11L,41L,63L,77L,91L,99L,219L,303L,411L,999L,1353L,5291L,6363L,6993L,7777L,8547L,9009L,9191L,9901L,9999L,12561L,23661L,41841L,47027L,75609L,90243L,99999L,110011L,122859L,124533L,125341L,152207L,169983L,170017L,473211L,487179L,513513L,575757L,578369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242680Inst : IEnumerable<long>
{
public static readonly long[] Value=A242680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242680.Bytes);
public long this[int i]=>Value[i];

public static A242680Inst Instance=new A242680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242681
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,11L,11L,11L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,14L,15L,14L,14L,14L,14L,14L,16L,14L,15L,14L,14L,13L,15L,13L,15L,13L,13L,12L,14L,11L,14L,11L,11L,10L,11L,8L,12L,8L,8L,9L,9L,6L,10L,6L,6L,7L,6L,4L,8L,4L,4L,6L,4L,3L,7L,2L,3L,5L,2L,2L,5L,1L,2L,4L,2L,1L,4L,0L,1L,3L,0L,1L,3L,0L,1L,2L,0L,0L,2L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242681Inst : IEnumerable<long>
{
public static readonly long[] Value=A242681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242681.Bytes);
public long this[int i]=>Value[i];

public static A242681Inst Instance=new A242681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242682
{
public static readonly long[] Value={ 1L,0L,2L,0L,5L,0L,10L,0L,20L,0L,36L,0L,65L,0L,110L,0L,185L,0L,300L,0L,481L,0L,740L,1L,1141L,4L,1710L,11L,2546L,26L,3718L,57L,5396L,114L,7703L,218L,10938L,400L,15323L,707L,21344L,1214L,29411L,2036L,40305L,3336L,54787L,5354L,74049L,8435L,99377L,13072L,132714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242682Inst : IEnumerable<long>
{
public static readonly long[] Value=A242682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242682.Bytes);
public long this[int i]=>Value[i];

public static A242682Inst Instance=new A242682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242683
{
public static readonly long[] Value={ 1L,0L,2L,0L,5L,0L,10L,0L,20L,0L,36L,0L,65L,0L,110L,0L,185L,0L,300L,0L,470L,1L,730L,4L,1110L,11L,1661L,26L,2447L,57L,3566L,114L,5120L,218L,7288L,400L,10248L,707L,14292L,1214L,19732L,2036L,27115L,3324L,36865L,5318L,49907L,8352L,67020L,12896L,89621L,19593L,119001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242683Inst : IEnumerable<long>
{
public static readonly long[] Value=A242683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242683.Bytes);
public long this[int i]=>Value[i];

public static A242683Inst Instance=new A242683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242684
{
public static readonly long[] Value={ 1L,0L,2L,0L,5L,0L,10L,0L,20L,0L,36L,0L,65L,0L,110L,0L,185L,0L,290L,1L,461L,4L,702L,11L,1066L,26L,1572L,57L,2311L,114L,3319L,218L,4750L,400L,6673L,707L,9332L,1214L,12916L,2025L,17750L,3291L,24164L,5242L,32743L,8191L,44027L,12565L,58913L,18992L,78374L,28291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242684Inst : IEnumerable<long>
{
public static readonly long[] Value=A242684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242684.Bytes);
public long this[int i]=>Value[i];

public static A242684Inst Instance=new A242684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242685
{
public static readonly long[] Value={ 1L,0L,2L,0L,5L,0L,10L,0L,20L,0L,36L,0L,65L,0L,110L,0L,176L,1L,282L,4L,436L,11L,663L,26L,987L,57L,1452L,114L,2093L,218L,2994L,400L,4210L,707L,5917L,1204L,8171L,1995L,11264L,3222L,15331L,5096L,20843L,7891L,28029L,12021L,37663L,18008L,50158L,26584L,66775L,38723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242685Inst : IEnumerable<long>
{
public static readonly long[] Value=A242685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242685.Bytes);
public long this[int i]=>Value[i];

public static A242685Inst Instance=new A242685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242686
{
public static readonly long[] Value={ 1L,0L,2L,0L,5L,0L,10L,0L,20L,0L,36L,0L,65L,0L,102L,1L,169L,4L,260L,11L,402L,26L,594L,57L,883L,114L,1263L,218L,1813L,400L,2565L,698L,3595L,1177L,4981L,1933L,6879L,3091L,9403L,4827L,12810L,7404L,17347L,11141L,23393L,16483L,31430L,24041L,41987L,34612L,56010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242686Inst : IEnumerable<long>
{
public static readonly long[] Value=A242686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242686.Bytes);
public long this[int i]=>Value[i];

public static A242686Inst Instance=new A242686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242687
{
public static readonly long[] Value={ 1L,0L,2L,0L,5L,0L,10L,0L,20L,0L,36L,0L,58L,1L,96L,4L,150L,11L,231L,26L,343L,57L,506L,114L,723L,218L,1056L,392L,1478L,674L,2096L,1122L,2903L,1817L,4061L,2853L,5561L,4397L,7700L,6628L,10486L,9798L,14327L,14283L,19405L,20544L,26355L,29143L,35500L,40917L,47932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242687Inst : IEnumerable<long>
{
public static readonly long[] Value=A242687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242687.Bytes);
public long this[int i]=>Value[i];

public static A242687Inst Instance=new A242687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242736
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,3L,3L,3L,4L,4L,5L,6L,6L,6L,7L,8L,8L,9L,9L,10L,10L,11L,12L,13L,13L,13L,14L,14L,15L,16L,17L,18L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,25L,27L,28L,29L,29L,30L,30L,31L,32L,33L,33L,34L,34L,35L,36L,36L,37L,39L,39L,40L,40L,42L,43L,44L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242736Inst : IEnumerable<long>
{
public static readonly long[] Value=A242736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242736.Bytes);
public long this[int i]=>Value[i];

public static A242736Inst Instance=new A242736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242737
{
public static readonly long[] Value={ 1L,1L,2L,4L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242737Inst : IEnumerable<long>
{
public static readonly long[] Value=A242737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242737.Bytes);
public long this[int i]=>Value[i];

public static A242737Inst Instance=new A242737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242738
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,19L,29L,41L,59L,89L,131L,197L,293L,439L,659L,991L,1481L,2221L,3329L,4993L,7487L,11239L,16843L,25253L,37879L,56821L,85223L,127837L,191773L,287629L,431441L,647161L,970747L,1456121L,2184179L,3276253L,4914373L,7371571L,11057357L,16586039L,24879017L,37318507L,55977767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242738Inst : IEnumerable<long>
{
public static readonly long[] Value=A242738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242738.Bytes);
public long this[int i]=>Value[i];

public static A242738Inst Instance=new A242738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242739
{
public static readonly long[] Value={ 4L,14L,74L,77L,111L,141L,177L,411L,417L,447L,471L,717L,771L,1111L,1114L,1141L,1147L,1174L,1177L,1411L,1417L,1441L,1477L,1711L,1714L,1717L,1774L,4117L,4141L,4171L,4174L,4411L,4414L,4417L,4471L,4474L,4711L,4714L,4717L,4741L,4747L,4771L,4777L,7111L,7114L,7117L,7141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242739Inst : IEnumerable<long>
{
public static readonly long[] Value=A242739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242739.Bytes);
public long this[int i]=>Value[i];

public static A242739Inst Instance=new A242739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242740
{
public static readonly long[] Value={ 1L,3L,9L,21L,27L,73L,99L,111L,271L,693L,707L,777L,819L,909L,999L,2151L,2629L,3441L,3813L,4551L,6987L,7227L,7373L,9999L,18981L,19019L,20007L,20979L,23199L,24453L,25641L,27027L,27417L,30303L,81819L,82113L,83883L,99999L,125523L,172013L,194841L,201917L,238139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242740Inst : IEnumerable<long>
{
public static readonly long[] Value=A242740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242740.Bytes);
public long this[int i]=>Value[i];

public static A242740Inst Instance=new A242740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242741
{
public static readonly long[] Value={ 29131L,119327070011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242741Inst : IEnumerable<long>
{
public static readonly long[] Value=A242741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242741.Bytes);
public long this[int i]=>Value[i];

public static A242741Inst Instance=new A242741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242742
{
public static readonly long[] Value={ 5L,7L,9L,8L,11L,13L,15L,4L,17L,19L,21L,8L,23L,25L,7L,27L,26L,9L,31L,33L,10L,35L,6L,37L,39L,14L,41L,43L,45L,8L,47L,49L,18L,51L,16L,9L,55L,21L,57L,20L,59L,61L,63L,8L,65L,8L,25L,69L,22L,11L,73L,75L,26L,45L,34L,79L,81L,80L,83L,85L,4L,87L,28L,89L,91L,3L,93L,32L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242742Inst : IEnumerable<long>
{
public static readonly long[] Value=A242742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242742.Bytes);
public long this[int i]=>Value[i];

public static A242742Inst Instance=new A242742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242743
{
public static readonly long[] Value={ 9L,2L,9L,6L,9L,5L,3L,9L,8L,3L,4L,1L,6L,1L,0L,2L,1L,4L,9L,8L,5L,3L,8L,4L,9L,7L,3L,6L,6L,5L,8L,7L,8L,1L,2L,1L,7L,6L,5L,8L,8L,2L,3L,7L,5L,1L,5L,1L,8L,0L,2L,1L,6L,7L,5L,8L,2L,3L,4L,3L,1L,4L,2L,9L,7L,0L,1L,9L,2L,0L,8L,4L,7L,4L,5L,7L,2L,5L,0L,8L,1L,2L,5L,6L,1L,8L,5L,3L,1L,2L,1L,0L,4L,4L,7L,7L,4L,6L,1L,5L,8L,8L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242743Inst : IEnumerable<long>
{
public static readonly long[] Value=A242743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242743.Bytes);
public long this[int i]=>Value[i];

public static A242743Inst Instance=new A242743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242744
{
public static readonly long[] Value={ 3L,4L,3L,4L,3L,6L,4L,4L,5L,10L,6L,6L,4L,10L,8L,16L,9L,18L,6L,10L,11L,6L,4L,12L,13L,6L,5L,12L,15L,30L,9L,16L,17L,12L,18L,18L,12L,26L,6L,40L,21L,42L,22L,22L,12L,16L,6L,42L,16L,12L,26L,52L,27L,44L,18L,6L,12L,58L,30L,30L,31L,12L,12L,10L,33L,66L,22L,16L,35L,70L,36L,36L,37L,18L,38L,66L,9L,78L,12L,12L,41L,82L,16L,42L,28L,58L,44L,30L,12L,18L,30L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242744Inst : IEnumerable<long>
{
public static readonly long[] Value=A242744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242744.Bytes);
public long this[int i]=>Value[i];

public static A242744Inst Instance=new A242744Inst();

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