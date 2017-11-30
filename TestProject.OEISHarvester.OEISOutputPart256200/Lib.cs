using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A136534
{
public static readonly long[] Value={ 1L,2L,2L,4L,8L,3L,7L,24L,21L,4L,11L,60L,90L,44L,5L,16L,130L,300L,260L,80L,6L,22L,2252L,840L,1120L,630L,132L,7L,29L,448L,2058L,3920L,3430L,1344L,203L,8L,37L,744L,4536L,11760L,14700L,9072L,2604L,296L,9L,46L,1170L,9180L,31248L,52920L,46872L,21420L,4680L,414L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136534Inst : IEnumerable<long>
{
public static readonly long[] Value=A136534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136534.Bytes);
public long this[int i]=>Value[i];

public static A136534Inst Instance=new A136534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136535
{
public static readonly long[] Value={ 1L,1L,2L,1L,7L,3L,1L,15L,21L,4L,1L,26L,76L,46L,5L,1L,40L,20L,250L,85L,6L,1L,57L,435L,925L,645L,141L,7L,1L,77L,833L,2695L,3185L,1421L,217L,8L,1L,100L,1456L,6664L,11956L,9016L,2800L,316L,9L,1L,126L,2376L,14616L,37044L,42336L,22176L,5076L,441L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136535Inst : IEnumerable<long>
{
public static readonly long[] Value=A136535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136535.Bytes);
public long this[int i]=>Value[i];

public static A136535Inst Instance=new A136535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136552
{
public static readonly BigInteger[] Value={ 1L,4L,44L,1120L,73112L,13931904L,8577576576L,18194461305856L,137735630840752320L,BigInteger.Parse("3788203438909701560320"),BigInteger.Parse("381994324029534476962777088"),BigInteger.Parse("141991478147899869433639040073728") };
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
public class A136552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136552.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136552Inst Instance=new A136552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136553
{
public static readonly BigInteger[] Value={ 1L,2L,9L,90L,2577L,248236L,84052116L,100270156156L,421825834327399L,6296015371464642774L,BigInteger.Parse("336474161890278633077823"),BigInteger.Parse("65028162589779857302801760924"),BigInteger.Parse("45874159173058581016227457835479612") };
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
public class A136553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136553.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136553Inst Instance=new A136553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136554
{
public static readonly BigInteger[] Value={ 1L,3L,10L,82L,2304L,232088L,81639942L,99425060368L,421915147527984L,6313762292901492960L,BigInteger.Parse("337457827116687464134048"),BigInteger.Parse("65175276571204939272971781496"),BigInteger.Parse("45944813538624773942727094008288680") };
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
public class A136554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136554Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136554.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136554.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136554Inst Instance=new A136554Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136555
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,6L,35L,1L,4L,10L,56L,1365L,1L,5L,15L,84L,1820L,169911L,1L,6L,21L,120L,2380L,201376L,67945521L,1L,7L,28L,165L,3060L,237336L,74974368L,89356415775L,1L,8L,36L,220L,3876L,278256L,82598880L,94525795200L,396861704798625L,1L,9L,45L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136555Inst : IEnumerable<long>
{
public static readonly long[] Value=A136555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136555.Bytes);
public long this[int i]=>Value[i];

public static A136555Inst Instance=new A136555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136556
{
public static readonly BigInteger[] Value={ 1L,1L,3L,35L,1365L,169911L,67945521L,89356415775L,396861704798625L,6098989894499557055L,BigInteger.Parse("331001552386330913728641"),BigInteger.Parse("64483955378425999076128999167"),BigInteger.Parse("45677647585984911164223317311276545"),BigInteger.Parse("118839819203635450208125966070067352769535"),BigInteger.Parse("1144686912178270649701033287538093722740144666625") };
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
public class A136556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136556Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136556.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136556.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136556Inst Instance=new A136556Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136557
{
public static readonly BigInteger[] Value={ 1L,2L,6L,45L,1436L,171836L,68149425L,89431630740L,396956313475102L,6099399658235428041L,BigInteger.Parse("331007760926212498510464"),BigInteger.Parse("64484289650612910347505873728"),BigInteger.Parse("45677712418497545460138258802186905") };
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
public class A136557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136557Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136557.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136557.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136557Inst Instance=new A136557Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136558
{
public static readonly BigInteger[] Value={ 2L,0L,84L,0L,276892L,0L,111457917800L,0L,6660816097416169260L,0L,BigInteger.Parse("66597307693046550483175282456"),0L,BigInteger.Parse("120167520447600665027319450022840022638104"),0L };
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
public class A136558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136558.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136558Inst Instance=new A136558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136559
{
public static readonly BigInteger[] Value={ 2L,0L,88L,0L,285088L,0L,112173964160L,0L,6667221644498203136L,0L,BigInteger.Parse("66605167708510907980664608768"),0L,BigInteger.Parse("120169056821375322042225614651624227643392"),0L };
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
public class A136559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136559Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136559.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136559.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136559Inst Instance=new A136559Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136560
{
public static readonly long[] Value={ 1L,3L,2L,1L,2L,3L,4L,5L,7L,8L,11L,13L,16L,19L,25L,28L,35L,41L,50L,58L,71L,81L,98L,113L,134L,154L,183L,208L,244L,280L,326L,371L,431L,489L,565L,641L,735L,832L,953L,1075L,1225L,1382L,1569L,1764L,1999L,2243L,2533L,2839L,3195L,3575L,4018L,4484L,5026L,5604L,6267L,6975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136560Inst : IEnumerable<long>
{
public static readonly long[] Value=A136560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136560.Bytes);
public long this[int i]=>Value[i];

public static A136560Inst Instance=new A136560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136561
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,-5L,-1L,5L,14L,13L,8L,7L,12L,26L,-30L,-17L,-9L,-2L,10L,36L,75L,45L,28L,19L,17L,27L,63L,-200L,-125L,-80L,-52L,-33L,-16L,11L,74L,524L,324L,199L,119L,67L,34L,18L,29L,103L,-1299L,-775L,-451L,-252L,-133L,-66L,-32L,-14L,15L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136561Inst : IEnumerable<long>
{
public static readonly long[] Value=A136561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136561.Bytes);
public long this[int i]=>Value[i];

public static A136561Inst Instance=new A136561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136562
{
public static readonly long[] Value={ 1L,3L,9L,14L,26L,36L,63L,74L,103L,118L,149L,169L,210L,233L,280L,302L,357L,392L,464L,489L,553L,591L,673L,713L,796L,844L,941L,987L,1083L,1134L,1238L,1292L,1398L,1463L,1596L,1652L,1769L,1840L,1980L,2046L,2172L,2250L,2416L,2492L,2565L,2715L,2836L,3051L,3130L,3298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136562Inst : IEnumerable<long>
{
public static readonly long[] Value=A136562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136562.Bytes);
public long this[int i]=>Value[i];

public static A136562Inst Instance=new A136562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136563
{
public static readonly long[] Value={ 1L,2L,4L,-5L,13L,-30L,75L,-200L,524L,-1299L,3038L,-6762L,14482L,-30162L,61691L,-124998L,252744L,-512805L,1047661L,-2158235L,4481801L,-9368303L,19674518L,-41437744L,87399483L,-184412912L,388975790L,-819684340L,1724741941L,-3621720214L,7585569484L,-15839701483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136563Inst : IEnumerable<long>
{
public static readonly long[] Value=A136563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136563.Bytes);
public long this[int i]=>Value[i];

public static A136563Inst Instance=new A136563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136564
{
public static readonly long[] Value={ 1L,1L,1L,5L,4L,1L,1L,9L,21L,16L,4L,1L,1L,18L,71L,108L,71L,22L,4L,1L,1L,27L,194L,491L,557L,326L,101L,22L,4L,1L,1L,43L,476L,1903L,3353L,3062L,1587L,497L,111L,22L,4L,1L,1L,59L,1030L,6298L,16644L,22352L,17035L,7982L,2433L,555L,111L,22L,4L,1L,1L,84L,2095L,18823L,72064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136564Inst : IEnumerable<long>
{
public static readonly long[] Value=A136564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136564.Bytes);
public long this[int i]=>Value[i];

public static A136564Inst Instance=new A136564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136565
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,3L,1L,1L,1L,4L,1L,3L,1L,3L,1L,1L,1L,4L,2L,1L,3L,3L,1L,1L,1L,5L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,3L,3L,1L,1L,5L,2L,3L,1L,3L,1L,4L,1L,4L,1L,1L,1L,3L,1L,1L,3L,6L,1L,1L,1L,3L,1L,1L,1L,5L,1L,1L,3L,3L,1L,1L,1L,5L,4L,1L,1L,3L,1L,1L,1L,4L,1L,3L,1L,3L,1L,1L,1L,6L,1L,3L,3L,2L,1L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136565Inst : IEnumerable<long>
{
public static readonly long[] Value=A136565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136565.Bytes);
public long this[int i]=>Value[i];

public static A136565Inst Instance=new A136565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136566
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,0L,1L,3L,2L,0L,1L,3L,1L,0L,0L,4L,1L,3L,1L,3L,0L,0L,1L,4L,2L,0L,3L,3L,1L,0L,1L,5L,0L,0L,0L,0L,1L,0L,0L,4L,1L,0L,1L,3L,3L,0L,1L,5L,2L,3L,0L,3L,1L,4L,0L,4L,0L,0L,1L,2L,1L,0L,3L,6L,0L,0L,1L,3L,0L,0L,1L,5L,1L,0L,3L,3L,0L,0L,1L,5L,4L,0L,1L,2L,0L,0L,0L,4L,1L,2L,0L,3L,0L,0L,0L,6L,1L,3L,3L,0L,1L,0L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136566Inst : IEnumerable<long>
{
public static readonly long[] Value=A136566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136566.Bytes);
public long this[int i]=>Value[i];

public static A136566Inst Instance=new A136566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136567
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,0L,0L,1L,1L,2L,1L,2L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,2L,1L,0L,1L,2L,2L,0L,1L,2L,1L,2L,0L,2L,1L,2L,0L,2L,0L,0L,1L,1L,1L,0L,2L,1L,0L,0L,1L,2L,0L,0L,1L,2L,1L,0L,2L,2L,0L,0L,1L,2L,1L,0L,1L,1L,0L,0L,0L,2L,1L,1L,0L,2L,0L,0L,0L,2L,1L,2L,2L,0L,1L,0L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136567Inst : IEnumerable<long>
{
public static readonly long[] Value=A136567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136567.Bytes);
public long this[int i]=>Value[i];

public static A136567Inst Instance=new A136567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136600
{
public static readonly long[] Value={ 1L,2L,-1L,4L,-4L,1L,6L,-11L,6L,-1L,5L,-20L,21L,-8L,1L,4L,-34L,56L,-36L,10L,-1L,3L,-52L,125L,-120L,55L,-12L,1L,2L,-73L,246L,-329L,220L,-78L,14L,-1L,1L,-96L,440L,-784L,714L,-364L,105L,-16L,1L,0L,-120L,730L,-1679L,1992L,-1364L,560L,-136L,18L,-1L,-1L,-144L,1140L,-3304L,4949L,-4356L,2379L,-816L,171L,-20L,1L,-2L,-167L,1694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136600Inst : IEnumerable<long>
{
public static readonly long[] Value=A136600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136600.Bytes);
public long this[int i]=>Value[i];

public static A136600Inst Instance=new A136600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136601
{
public static readonly long[] Value={ 211L,219L,221L,227L,229L,233L,235L,239L,241L,247L,277L,284L,286L,287L,300L,302L,310L,377L,388L,390L,395L,397L,400L,403L,404L,406L,413L,469L,485L,487L,493L,494L,499L,505L,507L,508L,512L,518L,526L,559L,575L,593L,598L,607L,608L,611L,613L,616L,632L,635L,665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136601Inst : IEnumerable<long>
{
public static readonly long[] Value=A136601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136601.Bytes);
public long this[int i]=>Value[i];

public static A136601Inst Instance=new A136601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136602
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136602Inst : IEnumerable<long>
{
public static readonly long[] Value=A136602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136602.Bytes);
public long this[int i]=>Value[i];

public static A136602Inst Instance=new A136602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136603
{
public static readonly long[] Value={ 176L,191L,194L,196L,209L,213L,215L,217L,223L,237L,253L,259L,263L,272L,274L,275L,289L,290L,292L,293L,295L,305L,307L,308L,353L,361L,367L,379L,380L,381L,382L,386L,392L,399L,401L,405L,415L,416L,418L,419L,427L,443L,461L,463L,467L,475L,477L,479L,481L,490L,491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136603Inst : IEnumerable<long>
{
public static readonly long[] Value=A136603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136603.Bytes);
public long this[int i]=>Value[i];

public static A136603Inst Instance=new A136603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136604
{
public static readonly long[] Value={ 22L,65L,83L,124L,142L,182L,206L,245L,263L,309L,326L,364L,391L,429L,453L,496L,514L,553L,576L,613L,636L,679L,704L,740L,772L,808L,833L,877L,902L,937L,971L,1002L,1028L,1065L,1089L,1124L,1156L,1188L,1215L,1252L,1283L,1309L,1343L,1377L,1406L,1448L,1475L,1502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136604Inst : IEnumerable<long>
{
public static readonly long[] Value=A136604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136604.Bytes);
public long this[int i]=>Value[i];

public static A136604Inst Instance=new A136604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136605
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,3L,3L,1L,1L,2L,4L,6L,6L,1L,1L,2L,4L,7L,11L,11L,1L,1L,2L,4L,8L,14L,23L,23L,1L,1L,2L,4L,8L,15L,29L,46L,47L,1L,1L,2L,4L,8L,16L,32L,60L,99L,106L,1L,1L,2L,4L,8L,16L,33L,66L,128L,216L,235L,1L,1L,2L,4L,8L,16L,34L,69L,143L,284L,488L,551L,1L,1L,2L,4L,8L,16L,34L,70L,149L,315L,636L,1121L,1301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136605Inst : IEnumerable<long>
{
public static readonly long[] Value=A136605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136605.Bytes);
public long this[int i]=>Value[i];

public static A136605Inst Instance=new A136605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136606
{
public static readonly BigInteger[] Value={ 1L,6L,24L,5040L,72576L,39916800L,95800320L,1307674368000L,4184557977600L,121645100408832000L,2043637686868377600L,BigInteger.Parse("25852016738884976640000"),BigInteger.Parse("238634000666630553600000"),BigInteger.Parse("10888869450418352160768000000") };
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
public class A136606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136606Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136606.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136606.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136606Inst Instance=new A136606Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136607
{
public static readonly long[] Value={ 6945715839196407L,7516596593102961L,8189724646216659L,26180005855432611L,42208580868962781L,51825725877080883L,55031440879786917L,56085374579306709L,59554573006892691L,61107945437155071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136607Inst : IEnumerable<long>
{
public static readonly long[] Value=A136607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136607.Bytes);
public long this[int i]=>Value[i];

public static A136607Inst Instance=new A136607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136608
{
public static readonly long[] Value={ 14392910L,1550244L,2188523L,2029381L,2828486L,1905576L,2901300L,1813327L,3097897L,2169409L,2695559L,1697839L,3767494L,1682771L,2548638L,2503246L,3286048L,1684275L,3093051L,1655317L,3500693L,2374117L,2403536L,1619568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136608Inst : IEnumerable<long>
{
public static readonly long[] Value=A136608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136608.Bytes);
public long this[int i]=>Value[i];

public static A136608Inst Instance=new A136608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136609
{
public static readonly long[] Value={ 0L,0L,76L,14392910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136609Inst : IEnumerable<long>
{
public static readonly long[] Value=A136609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136609.Bytes);
public long this[int i]=>Value[i];

public static A136609Inst Instance=new A136609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136610
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,0L,2L,1L,1L,2L,1L,1L,2L,3L,1L,2L,4L,1L,2L,2L,2L,5L,2L,1L,3L,5L,3L,5L,3L,1L,3L,4L,4L,3L,3L,5L,5L,4L,3L,6L,5L,4L,5L,5L,7L,7L,7L,4L,5L,4L,5L,6L,9L,5L,6L,8L,6L,7L,4L,6L,7L,8L,7L,7L,9L,7L,7L,5L,7L,10L,8L,6L,10L,8L,9L,6L,10L,8L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136610Inst : IEnumerable<long>
{
public static readonly long[] Value=A136610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136610.Bytes);
public long this[int i]=>Value[i];

public static A136610Inst Instance=new A136610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136611
{
public static readonly BigInteger[] Value={ 0L,1L,2L,3L,1024L,6L,56L,9L,100000000000L,106993205379072L,210L,16L,BigInteger.Parse("267198604589286774829171"),20L,462L,552L,BigInteger.Parse("2220446049250313080847263336181640625"),27L };
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
public class A136611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136611Inst Instance=new A136611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136612
{
public static readonly long[] Value={ 3L,6L,4L,8L,4L,8L,8L,6L,12L,6L,8L,8L,8L,10L,8L,12L,6L,8L,10L,6L,12L,12L,10L,10L,8L,4L,8L,16L,8L,20L,6L,16L,4L,16L,8L,10L,12L,10L,8L,16L,4L,14L,4L,16L,14L,16L,14L,8L,8L,6L,16L,8L,16L,12L,8L,12L,6L,8L,14L,16L,14L,16L,8L,16L,10L,24L,8L,14L,8L,12L,12L,14L,10L,12L,12L,10L,16L,14L,10L,20L,4L,16L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136612Inst : IEnumerable<long>
{
public static readonly long[] Value=A136612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136612.Bytes);
public long this[int i]=>Value[i];

public static A136612Inst Instance=new A136612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136613
{
public static readonly long[] Value={ 0L,11L,22L,33L,44L,55L,66L,77L,88L,99L,110L,211L,312L,413L,514L,615L,716L,817L,918L,1019L,220L,321L,422L,523L,624L,725L,826L,927L,1028L,1129L,330L,431L,532L,633L,734L,835L,936L,1037L,1138L,1239L,440L,541L,642L,743L,844L,945L,1046L,1147L,1248L,1349L,550L,651L,752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136613Inst : IEnumerable<long>
{
public static readonly long[] Value=A136613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136613.Bytes);
public long this[int i]=>Value[i];

public static A136613Inst Instance=new A136613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136614
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,2L,4L,6L,8L,10L,12L,14L,16L,18L,11L,4L,6L,8L,10L,12L,14L,16L,18L,11L,13L,6L,8L,10L,12L,14L,16L,18L,11L,13L,15L,8L,10L,12L,14L,16L,18L,11L,13L,15L,17L,10L,12L,14L,16L,18L,11L,13L,15L,17L,19L,12L,14L,16L,18L,11L,13L,15L,17L,19L,21L,14L,16L,18L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136614Inst : IEnumerable<long>
{
public static readonly long[] Value=A136614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136614.Bytes);
public long this[int i]=>Value[i];

public static A136614Inst Instance=new A136614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136615
{
public static readonly long[] Value={ 1L,2L,0L,0L,0L,16L,16L,16L,112L,112L,112L,912L,912L,912L,7280L,7280L,7280L,58256L,58256L,58256L,466032L,466032L,466032L,3728272L,3728272L,3728272L,29826160L,29826160L,29826160L,238609296L,238609296L,238609296L,1908874352L,1908874352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136615Inst : IEnumerable<long>
{
public static readonly long[] Value=A136615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136615.Bytes);
public long this[int i]=>Value[i];

public static A136615Inst Instance=new A136615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136680
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,1L,1L,4L,20L,1L,1L,4L,20L,520L,1L,1L,4L,20L,520L,26440L,1L,1L,4L,20L,520L,26440L,8766080L,1L,1L,4L,20L,520L,26440L,8766080L,6939853440L,1L,1L,4L,20L,520L,26440L,8766080L,6939853440L,41934828744960L,1L,1L,4L,20L,520L,26440L,8766080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136680Inst : IEnumerable<long>
{
public static readonly long[] Value=A136680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136680.Bytes);
public long this[int i]=>Value[i];

public static A136680Inst Instance=new A136680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136681
{
public static readonly long[] Value={ 3L,4L,5L,6L,9L,10L,13L,16L,17L,18L,37L,43L,58L,121L,124L,126L,137L,203L,247L,283L,285L,286L,289L,317L,424L,508L,751L,790L,937L,958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136681Inst : IEnumerable<long>
{
public static readonly long[] Value=A136681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136681.Bytes);
public long this[int i]=>Value[i];

public static A136681Inst Instance=new A136681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136682
{
public static readonly long[] Value={ 2L,3L,5L,8L,23L,41L,47L,48L,49L,95L,125L,203L,209L,284L,323L,395L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136682Inst : IEnumerable<long>
{
public static readonly long[] Value=A136682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136682.Bytes);
public long this[int i]=>Value[i];

public static A136682Inst Instance=new A136682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136683
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,20L,21L,29L,119L,132L,151L,351L,434L,457L,462L,572L,611L,930L,1107L,1157L,1452L,1515L,2838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136683Inst : IEnumerable<long>
{
public static readonly long[] Value=A136683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136683.Bytes);
public long this[int i]=>Value[i];

public static A136683Inst Instance=new A136683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136684
{
public static readonly long[] Value={ 3L,5L,8L,11L,20L,38L,61L,65L,71L,80L,83L,93L,233L,704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136684Inst : IEnumerable<long>
{
public static readonly long[] Value=A136684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136684.Bytes);
public long this[int i]=>Value[i];

public static A136684Inst Instance=new A136684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136685
{
public static readonly long[] Value={ 2L,19L,51L,78L,84L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136685Inst : IEnumerable<long>
{
public static readonly long[] Value=A136685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136685.Bytes);
public long this[int i]=>Value[i];

public static A136685Inst Instance=new A136685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136686
{
public static readonly long[] Value={ 19L,47L,164L,235L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136686Inst : IEnumerable<long>
{
public static readonly long[] Value=A136686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136686.Bytes);
public long this[int i]=>Value[i];

public static A136686Inst Instance=new A136686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136687
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136687Inst : IEnumerable<long>
{
public static readonly long[] Value=A136687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136687.Bytes);
public long this[int i]=>Value[i];

public static A136687Inst Instance=new A136687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136688
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,0L,4L,0L,1L,4L,0L,6L,0L,1L,0L,12L,0L,8L,0L,1L,8L,0L,24L,0L,10L,0L,1L,0L,32L,0L,40L,0L,12L,0L,1L,16L,0L,80L,0L,60L,0L,14L,0L,1L,0L,80L,0L,160L,0L,84L,0L,16L,0L,1L,32L,0L,240L,0L,280L,0L,112L,0L,18L,0L,1L,0L,192L,0L,560L,0L,448L,0L,144L,0L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136688Inst : IEnumerable<long>
{
public static readonly long[] Value=A136688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136688.Bytes);
public long this[int i]=>Value[i];

public static A136688Inst Instance=new A136688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136689
{
public static readonly long[] Value={ 1L,0L,1L,3L,0L,1L,0L,6L,0L,1L,9L,0L,9L,0L,1L,0L,27L,0L,12L,0L,1L,27L,0L,54L,0L,15L,0L,1L,0L,108L,0L,90L,0L,18L,0L,1L,81L,0L,270L,0L,135L,0L,21L,0L,1L,0L,405L,0L,540L,0L,189L,0L,24L,0L,1L,243L,0L,1215L,0L,945L,0L,252L,0L,27L,0L,1L,0L,1458L,0L,2835L,0L,1512L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136689Inst : IEnumerable<long>
{
public static readonly long[] Value=A136689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136689.Bytes);
public long this[int i]=>Value[i];

public static A136689Inst Instance=new A136689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136690
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,1L,2L,2L,1L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,1L,2L,2L,1L,1L,1L,2L,2L,2L,1L,2L,2L,1L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136690Inst : IEnumerable<long>
{
public static readonly long[] Value=A136690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136690.Bytes);
public long this[int i]=>Value[i];

public static A136690Inst Instance=new A136690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136691
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,1L,3L,2L,2L,3L,1L,3L,3L,2L,2L,2L,2L,3L,1L,1L,1L,2L,2L,3L,3L,2L,2L,2L,2L,1L,3L,2L,2L,3L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,3L,1L,3L,3L,2L,2L,2L,2L,3L,1L,2L,2L,3L,1L,3L,3L,2L,2L,2L,2L,3L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,3L,1L,1L,1L,2L,2L,2L,2L,1L,3L,2L,2L,1L,3L,1L,1L,2L,2L,3L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136691Inst : IEnumerable<long>
{
public static readonly long[] Value=A136691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136691.Bytes);
public long this[int i]=>Value[i];

public static A136691Inst Instance=new A136691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136692
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,4L,3L,4L,1L,2L,2L,4L,2L,3L,4L,4L,3L,4L,1L,4L,4L,3L,4L,1L,1L,1L,2L,1L,4L,4L,4L,3L,4L,1L,2L,2L,4L,2L,3L,4L,4L,3L,4L,1L,4L,4L,3L,4L,1L,2L,2L,4L,2L,3L,3L,3L,1L,3L,2L,4L,4L,3L,4L,1L,3L,3L,1L,3L,2L,3L,3L,1L,3L,2L,1L,1L,2L,1L,4L,4L,4L,3L,4L,1L,2L,2L,4L,2L,3L,4L,4L,3L,4L,1L,4L,4L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136692Inst : IEnumerable<long>
{
public static readonly long[] Value=A136692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136692.Bytes);
public long this[int i]=>Value[i];

public static A136692Inst Instance=new A136692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136693
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,2L,2L,4L,4L,4L,2L,4L,4L,2L,2L,2L,4L,2L,2L,4L,2L,2L,4L,4L,4L,2L,4L,4L,2L,4L,4L,2L,2L,2L,4L,4L,4L,2L,4L,4L,2L,2L,2L,4L,2L,2L,4L,2L,2L,4L,4L,4L,2L,2L,2L,4L,2L,2L,4L,4L,4L,2L,2L,2L,4L,2L,2L,4L,4L,4L,2L,4L,4L,2L,4L,4L,2L,2L,2L,4L,4L,4L,2L,4L,4L,2L,2L,2L,4L,4L,4L,2L,4L,4L,2L,2L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136693Inst : IEnumerable<long>
{
public static readonly long[] Value=A136693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136693.Bytes);
public long this[int i]=>Value[i];

public static A136693Inst Instance=new A136693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136694
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,1L,6L,6L,6L,5L,1L,4L,6L,1L,2L,2L,4L,5L,6L,2L,5L,1L,1L,2L,6L,3L,1L,6L,3L,3L,6L,4L,2L,3L,4L,6L,6L,5L,1L,4L,6L,1L,6L,6L,5L,1L,4L,6L,1L,1L,1L,2L,6L,3L,1L,6L,6L,6L,5L,1L,4L,6L,1L,2L,2L,4L,5L,6L,2L,5L,1L,1L,2L,6L,3L,1L,6L,3L,3L,6L,4L,2L,3L,4L,6L,6L,5L,1L,4L,6L,1L,6L,6L,5L,1L,4L,6L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136694Inst : IEnumerable<long>
{
public static readonly long[] Value=A136694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136694.Bytes);
public long this[int i]=>Value[i];

public static A136694Inst Instance=new A136694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136695
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,7L,2L,6L,6L,6L,4L,4L,6L,6L,4L,4L,3L,3L,6L,2L,5L,1L,6L,2L,6L,6L,4L,4L,6L,6L,4L,4L,6L,6L,4L,4L,2L,2L,4L,4L,4L,4L,1L,3L,4L,4L,3L,5L,6L,6L,4L,4L,2L,2L,4L,4L,4L,4L,3L,1L,4L,4L,5L,3L,3L,3L,6L,2L,1L,5L,6L,2L,2L,2L,4L,4L,2L,2L,4L,4L,5L,5L,2L,6L,3L,7L,2L,6L,2L,2L,4L,4L,2L,2L,4L,4L,6L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136695Inst : IEnumerable<long>
{
public static readonly long[] Value=A136695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136695.Bytes);
public long this[int i]=>Value[i];

public static A136695Inst Instance=new A136695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136712
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,10L,2L,2L,2L,2L,2L,2L,2L,13L,10L,3L,3L,3L,3L,3L,3L,14L,14L,10L,4L,4L,4L,4L,4L,15L,15L,15L,10L,5L,5L,5L,4L,15L,15L,15L,15L,9L,5L,5L,5L,16L,16L,16L,16L,16L,9L,6L,6L,17L,17L,17L,17L,17L,17L,9L,7L,18L,18L,18L,18L,18L,18L,18L,8L,19L,19L,19L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136712Inst : IEnumerable<long>
{
public static readonly long[] Value=A136712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136712.Bytes);
public long this[int i]=>Value[i];

public static A136712Inst Instance=new A136712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136713
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,1L,1L,1L,1L,1L,12L,3L,2L,2L,2L,2L,2L,2L,2L,13L,13L,4L,3L,3L,3L,3L,3L,3L,14L,14L,14L,5L,4L,4L,4L,4L,4L,15L,15L,15L,15L,6L,5L,5L,5L,5L,16L,16L,16L,16L,16L,7L,6L,6L,6L,17L,17L,17L,17L,17L,17L,8L,7L,7L,18L,18L,18L,18L,18L,18L,18L,9L,8L,19L,19L,19L,19L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136713Inst : IEnumerable<long>
{
public static readonly long[] Value=A136713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136713.Bytes);
public long this[int i]=>Value[i];

public static A136713Inst Instance=new A136713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136714
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,2L,2L,2L,2L,2L,2L,2L,2L,2L,13L,6L,3L,3L,3L,3L,3L,3L,3L,3L,14L,14L,8L,4L,4L,4L,4L,4L,4L,4L,15L,15L,15L,10L,5L,5L,5L,5L,5L,5L,16L,16L,16L,16L,12L,6L,6L,6L,6L,6L,17L,17L,17L,17L,17L,14L,7L,7L,7L,7L,18L,18L,18L,18L,18L,18L,16L,8L,8L,8L,19L,19L,19L,19L,19L,19L,19L,18L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136714Inst : IEnumerable<long>
{
public static readonly long[] Value=A136714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136714.Bytes);
public long this[int i]=>Value[i];

public static A136714Inst Instance=new A136714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136715
{
public static readonly long[] Value={ 1L,1L,1L,0L,4L,2L,0L,4L,16L,4L,0L,0L,36L,72L,12L,0L,0L,36L,324L,324L,36L,0L,0L,0L,576L,2592L,1728L,144L,0L,0L,0L,576L,9216L,20736L,9216L,576L,0L,0L,0L,0L,14400L,115200L,172800L,57600L,2880L,0L,0L,0L,0L,14400L,360000L,1440000L,1440000L,360000L,14400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136715Inst : IEnumerable<long>
{
public static readonly long[] Value=A136715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136715.Bytes);
public long this[int i]=>Value[i];

public static A136715Inst Instance=new A136715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136716
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,4L,0L,0L,12L,12L,0L,0L,12L,72L,36L,0L,0L,0L,144L,432L,144L,0L,0L,0L,144L,1728L,2592L,576L,0L,0L,0L,0L,2880L,17280L,17280L,2880L,0L,0L,0L,0L,2880L,57600L,172800L,115200L,14400L,0L,0L,0L,0L,0L,86400L,864000L,1728000L,864000L,86400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136716Inst : IEnumerable<long>
{
public static readonly long[] Value=A136716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136716.Bytes);
public long this[int i]=>Value[i];

public static A136716Inst Instance=new A136716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136717
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,4L,0L,0L,12L,12L,0L,0L,0L,72L,48L,0L,0L,0L,72L,456L,192L,0L,0L,0L,0L,960L,3120L,960L,0L,0L,0L,0L,0L,10800L,23760L,5760L,0L,0L,0L,0L,0L,10800L,133920L,183600L,34560L,0L,0L,0L,0L,0L,0L,241920L,1572480L,1572480L,241920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136717Inst : IEnumerable<long>
{
public static readonly long[] Value=A136717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136717.Bytes);
public long this[int i]=>Value[i];

public static A136717Inst Instance=new A136717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136718
{
public static readonly long[] Value={ 1L,2L,2L,4L,12L,12L,72L,48L,72L,456L,192L,960L,3120L,960L,10800L,23760L,5760L,10800L,133920L,183600L,34560L,241920L,1572480L,1572480L,241920L,4233600L,18869760L,14878080L,1935360L,4233600L,84309120L,233331840L,141644160L,15482880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136718Inst : IEnumerable<long>
{
public static readonly long[] Value=A136718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136718.Bytes);
public long this[int i]=>Value[i];

public static A136718Inst Instance=new A136718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136719
{
public static readonly BigInteger[] Value={ 1L,3L,27L,432L,10125L,314928L,12252303L,573308928L,31381059609L,1968300000000L,139234453205859L,10968475320188928L,952427511967417317L,BigInteger.Parse("90388408459919044608"),BigInteger.Parse("9308590679915771484375") };
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
public class A136719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136719.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136719Inst Instance=new A136719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136720
{
public static readonly long[] Value={ 7L,13L,103L,193L,823L,1483L,1873L,2083L,3253L,3463L,5653L,9433L,13003L,15643L,15733L,16063L,18043L,18913L,19423L,21013L,22273L,25303L,31723L,34843L,43783L,51343L,55333L,62983L,67213L,69493L,72223L,77263L,79693L,81043L,82723L,88813L,97843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136720Inst : IEnumerable<long>
{
public static readonly long[] Value=A136720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136720.Bytes);
public long this[int i]=>Value[i];

public static A136720Inst Instance=new A136720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136721
{
public static readonly long[] Value={ 11L,17L,107L,197L,827L,1487L,1877L,2087L,3257L,3467L,5657L,9437L,13007L,15647L,15737L,16067L,18047L,18917L,19427L,21017L,22277L,25307L,31727L,34847L,43787L,51347L,55337L,62987L,67217L,69497L,72227L,77267L,79697L,81047L,82727L,88817L,97847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136721Inst : IEnumerable<long>
{
public static readonly long[] Value=A136721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136721.Bytes);
public long this[int i]=>Value[i];

public static A136721Inst Instance=new A136721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136722
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,48L,336L,3584L,54592L,1422976L,66836480L,5998884352L,1030861378560L,335994532814848L,206175878632321024L,BigInteger.Parse("237596569295651315712"),BigInteger.Parse("514414692643000188272640"),BigInteger.Parse("2096154545790162572944244736"),BigInteger.Parse("16113456361117058761983824232448"),BigInteger.Parse("234269143891823701379016369973493760") };
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
public class A136722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136722.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136722Inst Instance=new A136722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136723
{
public static readonly BigInteger[] Value={ 1L,1L,3L,52L,2850L,393848L,125054832L,88260845008L,137304025714320L,469859118159233792L,BigInteger.Parse("3527181890877230433408"),BigInteger.Parse("57833314494643038031674112"),BigInteger.Parse("2060645597746315164145860149760"),BigInteger.Parse("158727775101107953869596632383822848"),BigInteger.Parse("26301662700662611321804753231934678909952") };
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
public class A136723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136723Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136723.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136723.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136723Inst Instance=new A136723Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136724
{
public static readonly long[] Value={ 12L,20L,24L,28L,36L,40L,44L,48L,52L,56L,60L,68L,72L,76L,80L,84L,88L,92L,96L,100L,104L,108L,112L,116L,120L,124L,132L,136L,140L,144L,148L,152L,156L,160L,164L,168L,172L,176L,180L,184L,188L,192L,196L,200L,204L,208L,212L,216L,220L,224L,228L,232L,236L,240L,244L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136724Inst : IEnumerable<long>
{
public static readonly long[] Value=A136724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136724.Bytes);
public long this[int i]=>Value[i];

public static A136724Inst Instance=new A136724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136725
{
public static readonly long[] Value={ 1L,2L,12L,20L,28L,36L,44L,52L,60L,68L,76L,84L,92L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136725Inst : IEnumerable<long>
{
public static readonly long[] Value=A136725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136725.Bytes);
public long this[int i]=>Value[i];

public static A136725Inst Instance=new A136725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136726
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,17L,73L,407L,2907L,26773L,317954L,4886310L,97485657L,2534891399L,86295825506L,3863685633735L,228686666560004L,17979843031304262L,1888025173840826426L,BigInteger.Parse("266025611085446537560"),BigInteger.Parse("50572458313046091569640") };
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
public class A136726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136726.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136726Inst Instance=new A136726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136727
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,139L,1481L,19443L,303297L,5480219L,112549881L,2589274883L,65957355377L,1842897053099L,56038776055081L,1842278768795923L,65109900167188257L,2461735422517374779L,BigInteger.Parse("99148196540813749081") };
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
public class A136727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136727.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136727Inst Instance=new A136727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136744
{
public static readonly long[] Value={ 5L,1L,3L,2L,4L,10L,52L,81L,205L,2089L,5258L,27053L,86885L,506248L,1999385L,15873555L,35291389L,341118861L,1072734242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136744Inst : IEnumerable<long>
{
public static readonly long[] Value=A136744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136744.Bytes);
public long this[int i]=>Value[i];

public static A136744Inst Instance=new A136744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136745
{
public static readonly long[] Value={ 1L,-1L,0L,1L,-1L,0L,-1L,0L,1L,1L,0L,-2L,0L,-1L,0L,1L,1L,0L,2L,0L,-3L,0L,-1L,0L,1L,-1L,0L,3L,0L,3L,0L,-4L,0L,-1L,0L,1L,-1L,0L,-3L,0L,6L,0L,4L,0L,-5L,0L,-1L,0L,1L,1L,0L,-4L,0L,-6L,0L,10L,0L,5L,0L,-6L,0L,-1L,0L,1L,1L,0L,4L,0L,-10L,0L,-10L,0L,15L,0L,6L,0L,-7L,0L,-1L,0L,1L,-1L,0L,5L,0L,10L,0L,-20L,0L,-15L,0L,21L,0L,7L,0L,-8L,0L,-1L,0L,1L,-1L,0L,-5L,0L,15L,0L,20L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136745Inst : IEnumerable<long>
{
public static readonly long[] Value=A136745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136745.Bytes);
public long this[int i]=>Value[i];

public static A136745Inst Instance=new A136745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136746
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,6L,7L,8L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,37L,38L,38L,39L,39L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136746Inst : IEnumerable<long>
{
public static readonly long[] Value=A136746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136746.Bytes);
public long this[int i]=>Value[i];

public static A136746Inst Instance=new A136746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136747
{
public static readonly long[] Value={ 1L,6L,-27L,-92L,390L,-162L,-64L,-1320L,729L,2340L,-948L,2484L,-5098L,-384L,-10530L,3856L,28386L,4374L,-8620L,-35880L,1728L,-5688L,-15288L,35640L,73975L,-30588L,-19683L,5888L,36510L,-63180L,-276808L,192096L,25596L,170316L,-24960L,-67068L,268526L,-51720L,137646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136747Inst : IEnumerable<long>
{
public static readonly long[] Value=A136747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136747.Bytes);
public long this[int i]=>Value[i];

public static A136747Inst Instance=new A136747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136748
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,0L,-1L,2L,3L,1L,0L,0L,-3L,2L,-2L,0L,-3L,0L,-1L,2L,0L,2L,0L,0L,3L,1L,-2L,1L,-6L,0L,0L,2L,3L,0L,0L,0L,-3L,2L,-2L,2L,0L,0L,-2L,2L,0L,0L,0L,0L,-3L,3L,-1L,0L,-6L,0L,-1L,0L,6L,2L,0L,0L,0L,2L,-2L,2L,-3L,0L,0L,2L,0L,0L,0L,0L,3L,2L,-2L,1L,-6L,0L,-2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136748Inst : IEnumerable<long>
{
public static readonly long[] Value=A136748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136748.Bytes);
public long this[int i]=>Value[i];

public static A136748Inst Instance=new A136748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136749
{
public static readonly BigInteger[] Value={ 1L,2L,8L,88L,2816L,285088L,96376832L,112173964160L,458290670993408L,6667221644498203136L,BigInteger.Parse("349410482551421802119168"),BigInteger.Parse("66605167708510907980664608768"),BigInteger.Parse("46557944823739673536754738305957888"),BigInteger.Parse("120169056821375322042225614651624227643392") };
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
public class A136749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A136749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136749Inst Instance=new A136749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136750
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,17L,35L,74L,155L,329L,692L,1464L,3098L,6553L,13873L,29361L,62165L,131638L,278787L,590357L,1250337L,2648108L,5608735L,11879607L,25161906L,53295451L,112886028L,239108343L,506466366L,1072776347L,2272316123L,4813150684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136750Inst : IEnumerable<long>
{
public static readonly long[] Value=A136750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136750.Bytes);
public long this[int i]=>Value[i];

public static A136750Inst Instance=new A136750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136751
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,36L,104L,310L,943L,2913L,9112L,28805L,91893L,295484L,956671L,3115805L,10200445L,33544983L,110755143L,366976365L,1219814018L,4066305982L,13590864072L,45534416250L,152895704998L,514446539489L,1734239511881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136751Inst : IEnumerable<long>
{
public static readonly long[] Value=A136751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136751.Bytes);
public long this[int i]=>Value[i];

public static A136751Inst Instance=new A136751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136752
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,10L,19L,33L,61L,108L,198L,354L,645L,1159L,2106L,3795L,6874L,12405L,22457L,40560L,73374L,132578L,239782L,433362L,783602L,1416401L,2560953L,4629393L,8369741L,15130440L,27354520L,49451349L,89401972L,161622356L,292191262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136752Inst : IEnumerable<long>
{
public static readonly long[] Value=A136752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136752.Bytes);
public long this[int i]=>Value[i];

public static A136752Inst Instance=new A136752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136753
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,52L,134L,355L,955L,2590L,7052L,19246L,52638L,144368L,397468L,1099720L,3060936L,8577496L,24210808L,68843806L,197176726L,568585576L,1649739332L,4812731846L,14105205846L,41498665884L,122469937048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136753Inst : IEnumerable<long>
{
public static readonly long[] Value=A136753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136753.Bytes);
public long this[int i]=>Value[i];

public static A136753Inst Instance=new A136753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136754
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136754Inst : IEnumerable<long>
{
public static readonly long[] Value=A136754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136754.Bytes);
public long this[int i]=>Value[i];

public static A136754Inst Instance=new A136754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136755
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,1L,2L,3L,1L,2L,3L,1L,3L,1L,3L,1L,3L,1L,1L,2L,1L,3L,2L,1L,3L,2L,1L,1L,3L,2L,1L,1L,1L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,1L,1L,1L,2L,2L,3L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136755Inst : IEnumerable<long>
{
public static readonly long[] Value=A136755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136755.Bytes);
public long this[int i]=>Value[i];

public static A136755Inst Instance=new A136755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136756
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,1L,1L,2L,4L,1L,4L,1L,1L,2L,1L,1L,3L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,1L,1L,2L,3L,4L,1L,2L,3L,1L,2L,4L,1L,2L,1L,1L,3L,1L,3L,1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,4L,2L,1L,2L,1L,4L,2L,1L,3L,2L,1L,3L,2L,1L,4L,2L,1L,1L,3L,2L,1L,1L,3L,2L,1L,1L,4L,2L,2L,1L,1L,4L,3L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136756Inst : IEnumerable<long>
{
public static readonly long[] Value=A136756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136756.Bytes);
public long this[int i]=>Value[i];

public static A136756Inst Instance=new A136756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136757
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,3L,3L,3L,5L,1L,2L,3L,1L,2L,1L,2L,1L,3L,1L,5L,3L,1L,1L,4L,2L,1L,1L,1L,4L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,4L,5L,1L,1L,1L,2L,3L,4L,1L,1L,2L,3L,5L,1L,2L,3L,5L,1L,2L,4L,1L,2L,4L,1L,2L,4L,1L,2L,5L,1L,3L,1L,2L,5L,2L,4L,1L,3L,1L,3L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,3L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136757Inst : IEnumerable<long>
{
public static readonly long[] Value=A136757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136757.Bytes);
public long this[int i]=>Value[i];

public static A136757Inst Instance=new A136757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136758
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,2L,2L,2L,2L,3L,4L,6L,1L,3L,6L,1L,4L,1L,3L,1L,4L,1L,5L,2L,1L,4L,2L,1L,5L,3L,2L,1L,5L,3L,2L,1L,1L,1L,5L,4L,3L,3L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,5L,6L,1L,1L,1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,1L,1L,2L,3L,5L,1L,2L,3L,5L,1L,2L,3L,6L,1L,3L,5L,1L,2L,4L,1L,2L,4L,1L,2L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136758Inst : IEnumerable<long>
{
public static readonly long[] Value=A136758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136758.Bytes);
public long this[int i]=>Value[i];

public static A136758Inst Instance=new A136758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136759
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,1L,1L,1L,1L,1L,1L,2L,3L,5L,1L,2L,4L,1L,2L,6L,2L,5L,1L,5L,2L,6L,2L,1L,3L,1L,6L,3L,1L,6L,3L,1L,1L,4L,2L,1L,1L,5L,3L,2L,1L,1L,7L,5L,3L,2L,2L,1L,1L,1L,1L,7L,6L,5L,5L,4L,4L,4L,4L,3L,3L,4L,4L,4L,4L,5L,5L,6L,6L,7L,1L,1L,1L,1L,2L,2L,3L,4L,5L,7L,1L,1L,2L,2L,4L,5L,7L,1L,2L,2L,4L,6L,1L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136759Inst : IEnumerable<long>
{
public static readonly long[] Value=A136759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136759.Bytes);
public long this[int i]=>Value[i];

public static A136759Inst Instance=new A136759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136808
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,1000L,1001L,1010L,1011L,1100L,1101L,10000L,10001L,10010L,10011L,10100L,10110L,11000L,11001L,11010L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,101000L,101001L,101100L,110000L,110001L,110010L,110100L,1000000L,1000001L,1000010L,1000011L,1000100L,1000101L,1000110L,1001000L,1001010L,1001100L,1010000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136808Inst : IEnumerable<long>
{
public static readonly long[] Value=A136808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136808.Bytes);
public long this[int i]=>Value[i];

public static A136808Inst Instance=new A136808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136809
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,111L,1000L,1001L,1010L,1011L,1100L,1101L,1110L,10000L,10001L,10010L,10011L,10100L,10101L,10110L,10111L,11000L,11001L,11010L,11100L,11101L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,100111L,101000L,101001L,101010L,101011L,101100L,101110L,110000L,110001L,110010L,110100L,110101L,111000L,111001L,111010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136809Inst : IEnumerable<long>
{
public static readonly long[] Value=A136809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136809.Bytes);
public long this[int i]=>Value[i];

public static A136809Inst Instance=new A136809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136810
{
public static readonly long[] Value={ 0L,1L,2L,10L,11L,12L,20L,21L,32L,100L,101L,102L,110L,111L,120L,200L,201L,210L,320L,321L,332L,1000L,1001L,1002L,1010L,1011L,1012L,1020L,1021L,1100L,1101L,1102L,1110L,1111L,1200L,1201L,2000L,2001L,2010L,2011L,2100L,2101L,3200L,3210L,3320L,3332L,10000L,10001L,10002L,10010L,10011L,10012L,10020L,10021L,10100L,10101L,10110L,10111L,10120L,10200L,10210L,11000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136810Inst : IEnumerable<long>
{
public static readonly long[] Value=A136810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136810.Bytes);
public long this[int i]=>Value[i];

public static A136810Inst Instance=new A136810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136811
{
public static readonly long[] Value={ 0L,1L,5L,10L,11L,15L,35L,50L,55L,100L,101L,105L,110L,111L,115L,150L,235L,335L,350L,351L,500L,501L,505L,550L,1000L,1001L,1005L,1010L,1011L,1015L,1050L,1055L,1100L,1101L,1105L,1110L,1150L,1235L,1500L,1501L,2305L,2350L,3211L,3335L,3350L,3500L,3510L,3515L,5000L,5001L,5005L,5010L,5011L,5015L,5035L,5050L,5055L,5500L,5505L,10000L,10001L,10005L,10010L,10011L,10015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136811Inst : IEnumerable<long>
{
public static readonly long[] Value=A136811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136811.Bytes);
public long this[int i]=>Value[i];

public static A136811Inst Instance=new A136811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136812
{
public static readonly long[] Value={ 0L,1L,6L,10L,11L,60L,100L,101L,106L,110L,111L,361L,600L,601L,1000L,1001L,1006L,1010L,1011L,1060L,1100L,1101L,1106L,1110L,1631L,3606L,3610L,6000L,6001L,6010L,6011L,10000L,10001L,10006L,10010L,10011L,10060L,10100L,10101L,10106L,10110L,10111L,10301L,10306L,10600L,11000L,11001L,11006L,11010L,11060L,11100L,11101L,16310L,32111L,36060L,36100L,36361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136812Inst : IEnumerable<long>
{
public static readonly long[] Value=A136812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136812.Bytes);
public long this[int i]=>Value[i];

public static A136812Inst Instance=new A136812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136813
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,111L,1000L,1001L,1010L,1011L,1100L,1101L,1110L,10000L,10001L,10010L,10011L,10100L,10101L,10110L,10111L,11000L,11001L,11010L,11100L,11101L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,100111L,101000L,101001L,101010L,101011L,101100L,101110L,110000L,110001L,110010L,110100L,110101L,111000L,111001L,111010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136813Inst : IEnumerable<long>
{
public static readonly long[] Value=A136813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136813.Bytes);
public long this[int i]=>Value[i];

public static A136813Inst Instance=new A136813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136814
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,111L,1000L,1001L,1010L,1011L,1100L,1101L,1110L,10000L,10001L,10010L,10011L,10100L,10101L,10110L,10111L,11000L,11001L,11010L,11100L,11101L,18111L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,100111L,101000L,101001L,101010L,101011L,101100L,101110L,110000L,110001L,110010L,110100L,110101L,111000L,111001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136814Inst : IEnumerable<long>
{
public static readonly long[] Value=A136814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136814.Bytes);
public long this[int i]=>Value[i];

public static A136814Inst Instance=new A136814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136815
{
public static readonly long[] Value={ 0L,1L,3L,10L,11L,30L,100L,101L,110L,111L,139L,300L,1000L,1001L,1010L,1011L,1100L,1101L,1110L,1390L,3000L,10000L,10001L,10010L,10011L,10100L,10101L,10110L,10111L,10923L,11000L,11001L,11010L,11100L,11101L,13900L,30000L,30203L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,100111L,101000L,101001L,101010L,101011L,101100L,101110L,109139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136815Inst : IEnumerable<long>
{
public static readonly long[] Value=A136815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136815.Bytes);
public long this[int i]=>Value[i];

public static A136815Inst Instance=new A136815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136816
{
public static readonly long[] Value={ 0L,1L,2L,10L,11L,12L,20L,21L,100L,101L,102L,110L,120L,200L,201L,210L,1000L,1001L,1002L,1010L,1011L,1012L,1020L,1021L,1100L,1101L,1102L,1200L,1201L,2000L,2001L,2010L,2011L,2100L,2101L,10000L,10001L,10002L,10010L,10011L,10012L,10020L,10021L,10100L,10110L,10120L,10200L,10210L,11000L,11001L,11002L,11010L,11011L,11020L,12000L,12001L,12010L,20000L,20001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136816Inst : IEnumerable<long>
{
public static readonly long[] Value=A136816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136816.Bytes);
public long this[int i]=>Value[i];

public static A136816Inst Instance=new A136816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136817
{
public static readonly long[] Value={ 0L,1L,2L,5L,10L,11L,12L,15L,20L,21L,45L,50L,100L,101L,102L,105L,110L,112L,120L,145L,150L,155L,200L,201L,205L,210L,211L,450L,500L,501L,502L,505L,1000L,1001L,1002L,1005L,1010L,1011L,1012L,1020L,1021L,1050L,1100L,1101L,1102L,1105L,1120L,1200L,1201L,1205L,1245L,1415L,1450L,1451L,1500L,1550L,2000L,2001L,2005L,2010L,2011L,2050L,2100L,2101L,2110L,2245L,4500L,5000L,5001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136817Inst : IEnumerable<long>
{
public static readonly long[] Value=A136817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136817.Bytes);
public long this[int i]=>Value[i];

public static A136817Inst Instance=new A136817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136818
{
public static readonly long[] Value={ 0L,1L,2L,4L,10L,11L,12L,20L,21L,40L,46L,100L,101L,102L,110L,120L,121L,142L,162L,200L,201L,204L,210L,400L,402L,460L,642L,1000L,1001L,1002L,1010L,1011L,1012L,1020L,1021L,1100L,1101L,1102L,1200L,1201L,1210L,1420L,1620L,2000L,2001L,2004L,2010L,2011L,2040L,2100L,2101L,2462L,4000L,4002L,4020L,4600L,6404L,6420L,6642L,10000L,10001L,10002L,10010L,10011L,10012L,10020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136818Inst : IEnumerable<long>
{
public static readonly long[] Value=A136818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136818.Bytes);
public long this[int i]=>Value[i];

public static A136818Inst Instance=new A136818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136819
{
public static readonly long[] Value={ 0L,1L,2L,10L,11L,12L,20L,21L,100L,101L,102L,110L,120L,200L,201L,210L,421L,1000L,1001L,1002L,1010L,1011L,1012L,1020L,1021L,1071L,1100L,1101L,1102L,1200L,1201L,2000L,2001L,2010L,2011L,2100L,2101L,4210L,10000L,10001L,10002L,10010L,10011L,10012L,10020L,10021L,10100L,10110L,10120L,10200L,10210L,10710L,11000L,11001L,11002L,11010L,11011L,11020L,12000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136819Inst : IEnumerable<long>
{
public static readonly long[] Value=A136819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136819.Bytes);
public long this[int i]=>Value[i];

public static A136819Inst Instance=new A136819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136820
{
public static readonly long[] Value={ 0L,1L,2L,10L,11L,12L,20L,21L,22L,100L,101L,102L,110L,120L,122L,200L,201L,202L,210L,220L,221L,1000L,1001L,1002L,1010L,1011L,1012L,1020L,1021L,1022L,1100L,1101L,1102L,1200L,1201L,1202L,1220L,1422L,1488L,2000L,2001L,2002L,2010L,2011L,2012L,2020L,2021L,2022L,2100L,2101L,2102L,2200L,2201L,2202L,2210L,2848L,4488L,10000L,10001L,10002L,10010L,10011L,10012L,10020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136820Inst : IEnumerable<long>
{
public static readonly long[] Value=A136820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136820.Bytes);
public long this[int i]=>Value[i];

public static A136820Inst Instance=new A136820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136821
{
public static readonly long[] Value={ 0L,1L,2L,10L,11L,12L,20L,21L,49L,100L,101L,102L,110L,120L,149L,200L,201L,210L,212L,490L,499L,1000L,1001L,1002L,1010L,1011L,1012L,1020L,1021L,1049L,1100L,1101L,1102L,1200L,1201L,1411L,1421L,1429L,1490L,2000L,2001L,2010L,2011L,2100L,2101L,2120L,4499L,4900L,4990L,4999L,10000L,10001L,10002L,10010L,10011L,10012L,10020L,10021L,10100L,10110L,10120L,10200L,10210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136821Inst : IEnumerable<long>
{
public static readonly long[] Value=A136821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136821.Bytes);
public long this[int i]=>Value[i];

public static A136821Inst Instance=new A136821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136822
{
public static readonly long[] Value={ 0L,1L,5L,10L,11L,15L,50L,100L,101L,105L,110L,150L,500L,501L,505L,1000L,1001L,1005L,1010L,1011L,1050L,1100L,1101L,1105L,1500L,5000L,5001L,5005L,5010L,5011L,5015L,5050L,10000L,10001L,10005L,10010L,10011L,10050L,10100L,10105L,10110L,10500L,11000L,11001L,11005L,11010L,11050L,11205L,15000L,15005L,50000L,50001L,50005L,50010L,50011L,50015L,50050L,50100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136822Inst : IEnumerable<long>
{
public static readonly long[] Value=A136822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136822.Bytes);
public long this[int i]=>Value[i];

public static A136822Inst Instance=new A136822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136823
{
public static readonly long[] Value={ 0L,1L,5L,10L,11L,15L,16L,25L,50L,51L,100L,101L,105L,110L,125L,150L,160L,225L,250L,255L,500L,501L,505L,510L,511L,515L,516L,1000L,1001L,1005L,1010L,1011L,1025L,1050L,1100L,1101L,1105L,1125L,1225L,1250L,1251L,1265L,1500L,1505L,1600L,2250L,2261L,2500L,2501L,2550L,5000L,5001L,5005L,5010L,5011L,5015L,5016L,5025L,5050L,5051L,5100L,5101L,5105L,5110L,5125L,5150L,5160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136823Inst : IEnumerable<long>
{
public static readonly long[] Value=A136823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136823.Bytes);
public long this[int i]=>Value[i];

public static A136823Inst Instance=new A136823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136856
{
public static readonly long[] Value={ 0L,1L,10L,71L,100L,710L,1000L,1071L,7100L,7451L,10000L,10701L,10710L,70751L,71000L,74510L,75501L,100000L,100501L,107010L,107100L,107451L,707510L,710000L,745100L,745501L,755010L,1000000L,1005010L,1007001L,1070100L,1071000L,1074510L,4140701L,7075100L,7100000L,7100501L,7451000L,7455010L,7550100L,10000000L,10005001L,10005071L,10050100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136856Inst : IEnumerable<long>
{
public static readonly long[] Value=A136856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136856.Bytes);
public long this[int i]=>Value[i];

public static A136856Inst Instance=new A136856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136857
{
public static readonly long[] Value={ 0L,1L,10L,100L,1000L,10000L,10401L,10888L,100000L,100501L,104010L,108880L,1000000L,1004001L,1005010L,1040100L,1088800L,10000000L,10005001L,10040010L,10050100L,10401000L,10414151L,10888000L,100000000L,100040001L,100050010L,100400100L,100501000L,104010000L,104141510L,104888441L,108880000L,1000000000L,1000050001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136857Inst : IEnumerable<long>
{
public static readonly long[] Value=A136857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136857.Bytes);
public long this[int i]=>Value[i];

public static A136857Inst Instance=new A136857Inst();

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