using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A079032
{
public static readonly BigInteger[] Value={ 2L,22L,15L,15L,42L,22L,30L,176L,133230930L,2436L,8118264L,231L,413766180933342362L,31185L,118114304L,31185L,31185L,31185L,670448123060170L,BigInteger.Parse("426088638015652413417"),BigInteger.Parse("1973678121921532286407950000"),133230930L };
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
public class A079032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079032Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A079032.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A079032.Bytes);
public BigInteger this[int i]=>Value[i];

public static A079032Inst Instance=new A079032Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079031
{
public static readonly long[] Value={ 2L,8L,7L,7L,10L,8L,9L,15L,97L,26L,75L,16L,356L,39L,96L,39L,39L,39L,264L,470L,776L,97L,711L,249L,765L,4458L,334L,699L,1084L,18911L,7150L,1447L,4604L,1399L,446L,36041L,5836L,3504L,1449L,4359L,6034L,688L,60818L,4514L,90825L,34641L,36852L,77173L,11100L,2564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079031Inst : IEnumerable<long>
{
public static readonly long[] Value=A079031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079031.Bytes);
public long this[int i]=>Value[i];

public static A079031Inst Instance=new A079031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079030
{
public static readonly long[] Value={ 1L,5L,11L,14L,47L,26L,71L,41L,59L,74L,167L,89L,191L,101L,131L,146L,383L,236L,311L,194L,251L,269L,647L,299L,479L,314L,419L,341L,887L,461L,719L,446L,659L,614L,1031L,626L,1487L,1199L,1019L,689L,1151L,794L,1847L,854L,971L,941L,3023L,1106L,1511L,1109L,1091L,1256L,2711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079030Inst : IEnumerable<long>
{
public static readonly long[] Value=A079030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079030.Bytes);
public long this[int i]=>Value[i];

public static A079030Inst Instance=new A079030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079029
{
public static readonly long[] Value={ 5L,11L,47L,71L,167L,191L,383L,311L,647L,887L,719L,1487L,1151L,1847L,3023L,2711L,2399L,3863L,3719L,5471L,2999L,4391L,3911L,6311L,5519L,5879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079029Inst : IEnumerable<long>
{
public static readonly long[] Value=A079029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079029.Bytes);
public long this[int i]=>Value[i];

public static A079029Inst Instance=new A079029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079028
{
public static readonly long[] Value={ 1L,5L,24L,112L,512L,2304L,10240L,45056L,196608L,851968L,3670016L,15728640L,67108864L,285212672L,1207959552L,5100273664L,21474836480L,90194313216L,377957122048L,1580547964928L,6597069766656L,27487790694400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079028Inst : IEnumerable<long>
{
public static readonly long[] Value=A079028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079028.Bytes);
public long this[int i]=>Value[i];

public static A079028Inst Instance=new A079028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079011
{
public static readonly long[] Value={ 5L,397L,503L,1823L,1627L,8317L,5939L,94153L,68539L,83117L,444187L,542299L,428873L,1179649L,955511L,1625027L,2541289L,1290683L,19856363L,12183757L,5412091L,23374859L,27248701L,38235013L,21369059L,34718041L,84118081L,59859131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079011Inst : IEnumerable<long>
{
public static readonly long[] Value=A079011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079011.Bytes);
public long this[int i]=>Value[i];

public static A079011Inst Instance=new A079011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079010
{
public static readonly long[] Value={ 6L,14L,14L,8L,8L,14L,18L,14L,18L,8L,24L,8L,8L,8L,18L,44L,24L,38L,18L,30L,14L,14L,8L,14L,18L,8L,8L,8L,30L,8L,38L,18L,14L,14L,66L,36L,26L,30L,30L,8L,18L,14L,8L,50L,18L,18L,14L,8L,66L,26L,14L,44L,38L,54L,18L,18L,38L,30L,8L,30L,14L,24L,26L,8L,26L,14L,8L,8L,60L,26L,18L,78L,14L,8L,38L,30L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079010Inst : IEnumerable<long>
{
public static readonly long[] Value=A079010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079010.Bytes);
public long this[int i]=>Value[i];

public static A079010Inst Instance=new A079010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079009
{
public static readonly long[] Value={ 1L,2L,11L,37L,149L,1359L,14130L,175327L,1218073L,108387730L,14305141265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079009Inst : IEnumerable<long>
{
public static readonly long[] Value=A079009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079009.Bytes);
public long this[int i]=>Value[i];

public static A079009Inst Instance=new A079009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079008
{
public static readonly long[] Value={ 1L,2L,5L,11L,11L,17L,17L,37L,46L,46L,112L,112L,123L,149L,149L,149L,257L,257L,257L,257L,257L,257L,257L,261L,658L,658L,685L,741L,741L,1359L,1359L,1359L,1359L,1359L,1359L,1359L,1359L,1359L,1359L,1359L,1359L,1359L,1359L,1359L,1359L,4097L,4097L,4097L,4097L,4097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079008Inst : IEnumerable<long>
{
public static readonly long[] Value=A079008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079008.Bytes);
public long this[int i]=>Value[i];

public static A079008Inst Instance=new A079008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079007
{
public static readonly long[] Value={ 2L,2L,2L,17L,83L,113L,491L,1367L,1801L,5869L,15919L,34883L,70639L,70657L,214867L,214867L,2515871L,3952733L,13010143L,30220163L,60155567L,69931991L,203674907L,1092101119L,1363592621L,1363592677L,2124140323L,23024158649L,30282104173L,30282104173L,196948778371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079007Inst : IEnumerable<long>
{
public static readonly long[] Value=A079007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079007.Bytes);
public long this[int i]=>Value[i];

public static A079007Inst Instance=new A079007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079006
{
public static readonly long[] Value={ 1L,-2L,5L,-10L,18L,-32L,55L,-90L,144L,-226L,346L,-522L,777L,-1138L,1648L,-2362L,3348L,-4704L,6554L,-9056L,12425L,-16932L,22922L,-30848L,41282L,-54946L,72768L,-95914L,125842L,-164402L,213901L,-277204L,357904L,-460448L,590330L,-754368L,960948L,-1220370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079006Inst : IEnumerable<long>
{
public static readonly long[] Value=A079006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079006.Bytes);
public long this[int i]=>Value[i];

public static A079006Inst Instance=new A079006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079005
{
public static readonly long[] Value={ 1L,2L,2L,6L,12L,5L,24L,72L,60L,15L,120L,480L,600L,300L,52L,720L,3600L,6000L,4500L,1560L,203L,5040L,30240L,63000L,63000L,32760L,8526L,877L,40320L,282240L,705600L,882000L,611520L,238728L,49112L,4140L,362880L,2903040L,8467200L,12700800L,11007360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079005Inst : IEnumerable<long>
{
public static readonly long[] Value=A079005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079005.Bytes);
public long this[int i]=>Value[i];

public static A079005Inst Instance=new A079005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079004
{
public static readonly long[] Value={ 7L,10L,10L,34L,106L,322L,970L,2914L,8746L,26242L,78730L,236194L,708586L,2125762L,6377290L,19131874L,57395626L,172186882L,516560650L,1549681954L,4649045866L,13947137602L,41841412810L,125524238434L,376572715306L,1129718145922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079004Inst : IEnumerable<long>
{
public static readonly long[] Value=A079004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079004.Bytes);
public long this[int i]=>Value[i];

public static A079004Inst Instance=new A079004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079003
{
public static readonly long[] Value={ 3L,6L,14L,38L,110L,326L,974L,2918L,8750L,26246L,78734L,236198L,708590L,2125766L,6377294L,19131878L,57395630L,172186886L,516560654L,1549681958L,4649045870L,13947137606L,41841412814L,125524238438L,376572715310L,1129718145926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079003Inst : IEnumerable<long>
{
public static readonly long[] Value=A079003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079003.Bytes);
public long this[int i]=>Value[i];

public static A079003Inst Instance=new A079003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079002
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,14L,15L,20L,25L,27L,30L,35L,45L,50L,70L,75L,81L,100L,125L,135L,150L,175L,225L,243L,250L,350L,375L,405L,500L,625L,675L,729L,750L,875L,1125L,1215L,1250L,1750L,1875L,2025L,2187L,2500L,3125L,3375L,3645L,3750L,4375L,5625L,6075L,6250L,6561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079002Inst : IEnumerable<long>
{
public static readonly long[] Value=A079002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079002.Bytes);
public long this[int i]=>Value[i];

public static A079002Inst Instance=new A079002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079001
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079001Inst : IEnumerable<long>
{
public static readonly long[] Value=A079001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079001.Bytes);
public long this[int i]=>Value[i];

public static A079001Inst Instance=new A079001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A079000
{
public static readonly long[] Value={ 1L,4L,6L,7L,8L,9L,11L,13L,15L,16L,17L,18L,19L,20L,21L,23L,25L,27L,29L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,95L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A079000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A079000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A079000Inst : IEnumerable<long>
{
public static readonly long[] Value=A079000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A079000.Bytes);
public long this[int i]=>Value[i];

public static A079000Inst Instance=new A079000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078999
{
public static readonly ulong[] Value={ 1L,14L,156L,1622L,16347L,161970L,1588176L,15465222L,149866020L,1447117432L,13935821924L,133921143546L,1284811863298L,12309517103724L,117803253946752L,1126336913303526L,10760609522499660L,102733711144434216L,980250448431562864L,9348504508099893272UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078999Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A078999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078999.Bytes);
public ulong this[int i]=>Value[i];

public static A078999Inst Instance=new A078999Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078998
{
public static readonly BigInteger[] Value={ 1L,11L,111L,1111L,11111L,111111L,1111111L,11111111L,111111111L,12222222121L,1222222212101L,122222221210101L,12222222121010101L,1222222212101010101L,BigInteger.Parse("122222221210101010101"),BigInteger.Parse("12222222121010101010101") };
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
public class A078998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078998Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078998.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078998.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078998Inst Instance=new A078998Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078997
{
public static readonly long[] Value={ -1L,-1L,1L,1L,2L,-1L,-2L,1L,1L,3L,-5L,3L,-1L,1L,4L,2L,-8L,-5L,8L,2L,-4L,1L,1L,5L,5L,-10L,-15L,11L,15L,-10L,-5L,5L,-1L,1L,6L,9L,-10L,-30L,6L,41L,-6L,-30L,10L,9L,-6L,1L,1L,7L,14L,-7L,-49L,-14L,77L,29L,-77L,-14L,49L,-7L,-14L,7L,-1L,1L,8L,20L,-70L,-56L,112L,120L,-125L,-120L,112L,56L,-70L,20L,-8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078997Inst : IEnumerable<long>
{
public static readonly long[] Value=A078997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078997.Bytes);
public long this[int i]=>Value[i];

public static A078997Inst Instance=new A078997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078996
{
public static readonly long[] Value={ -1L,-1L,1L,1L,2L,-1L,-2L,1L,1L,3L,0L,-5L,0L,3L,-1L,1L,4L,2L,-8L,-5L,8L,2L,-4L,1L,1L,5L,5L,-10L,-15L,11L,15L,-10L,-5L,5L,-1L,1L,6L,9L,-10L,-30L,6L,41L,-6L,-30L,10L,9L,-6L,1L,1L,7L,14L,-7L,-49L,-14L,77L,29L,-77L,-14L,49L,-7L,-14L,7L,-1L,1L,8L,20L,0L,-70L,-56L,112L,120L,-125L,-120L,112L,56L,-70L,0L,20L,-8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078996Inst : IEnumerable<long>
{
public static readonly long[] Value=A078996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078996.Bytes);
public long this[int i]=>Value[i];

public static A078996Inst Instance=new A078996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078995
{
public static readonly BigInteger[] Value={ 1L,8L,72L,664L,6184L,57888L,543544L,5113872L,48180456L,454396000L,4288773152L,40503496536L,382701222296L,3617396099936L,34203591636048L,323492394385824L,3060238763412072L,28955508198895584L,274018698082833760L,2593539713410178528L,BigInteger.Parse("24550565251665845664") };
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
public class A078995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078995Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078995.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078995.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078995Inst Instance=new A078995Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078994
{
public static readonly BigInteger[] Value={ 1L,1L,1L,-2L,-24L,-138L,-500L,1200L,56256L,904912L,11937696L,144543360L,1639736320L,16965191808L,141946949376L,376837224448L,-23412830208000L,-860170849536000L,-22132932250013696L,-501053473607319552L,BigInteger.Parse("-10543220910009286656"),BigInteger.Parse("-208356118642682839040") };
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
public class A078994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078994Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078994.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078994.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078994Inst Instance=new A078994Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078993
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,5L,8L,28L,24L,108L,66L,357L,176L,1088L,464L,3160L,1218L,8901L,3192L,24564L,8360L,66836L,21890L,180037L,57312L,481464L,150048L,1280736L,392834L,3393509L,1028456L,8965324L,2692536L,23633532L,7049154L,62197413L,18454928L,163482992L,48315632L,429300136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078993Inst : IEnumerable<long>
{
public static readonly long[] Value=A078993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078993.Bytes);
public long this[int i]=>Value[i];

public static A078993Inst Instance=new A078993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078992
{
public static readonly long[] Value={ 1L,1L,1L,-2L,-6L,-2L,6L,36L,24L,12L,-24L,-240L,-240L,-240L,-72L,120L,1800L,2400L,3600L,2160L,600L,-720L,-15120L,-25200L,-50400L,-45360L,-25200L,-5760L,5040L,141120L,282240L,705600L,846720L,705600L,322560L,65520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078992Inst : IEnumerable<long>
{
public static readonly long[] Value=A078992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078992.Bytes);
public long this[int i]=>Value[i];

public static A078992Inst Instance=new A078992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078991
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,-2L,0L,-6L,-2L,6L,0L,36L,24L,12L,-24L,0L,-240L,-240L,-240L,-72L,120L,0L,1800L,2400L,3600L,2160L,600L,-720L,0L,-15120L,-25200L,-50400L,-45360L,-25200L,-5760L,5040L,0L,141120L,282240L,705600L,846720L,705600L,322560L,65520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078991Inst : IEnumerable<long>
{
public static readonly long[] Value=A078991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078991.Bytes);
public long this[int i]=>Value[i];

public static A078991Inst Instance=new A078991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078990
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,4L,10L,16L,22L,1L,6L,21L,52L,105L,158L,211L,1L,8L,36L,116L,301L,644L,1198L,1752L,2306L,1L,10L,55L,216L,678L,1784L,4088L,8144L,14506L,20868L,27230L,1L,12L,78L,360L,1320L,4064L,10896L,25872L,55354L,105704L,183284L,260864L,338444L,1L,14L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078990Inst : IEnumerable<long>
{
public static readonly long[] Value=A078990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078990.Bytes);
public long this[int i]=>Value[i];

public static A078990Inst Instance=new A078990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078989
{
public static readonly BigInteger[] Value={ 1L,67L,4421L,291719L,19249033L,1270144459L,83810285261L,5530208682767L,364909962777361L,24078527334623059L,1588817894122344533L,BigInteger.Parse("104837902484740116119"),BigInteger.Parse("6917712746098725319321"),BigInteger.Parse("456464203340031130959067") };
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
public class A078989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078989Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078989.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078989.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078989Inst Instance=new A078989Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078988
{
public static readonly BigInteger[] Value={ 1L,65L,4289L,283009L,18674305L,1232221121L,81307919681L,5365090477825L,354014663616769L,23359602708228929L,1541379764079492545L,BigInteger.Parse("101707704826538279041"),BigInteger.Parse("6711167138787446924161"),BigInteger.Parse("442835323455144958715585"),BigInteger.Parse("29220420180900779828304449"),BigInteger.Parse("1928104896615996323709378049") };
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
public class A078988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078988Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078988.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078988.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078988Inst Instance=new A078988Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078987
{
public static readonly BigInteger[] Value={ 1L,38L,1443L,54796L,2080805L,79015794L,3000519367L,113940720152L,4326746846409L,164302439443390L,6239165952002411L,236924003736648228L,8996872976040630253L,BigInteger.Parse("341644249085807301386"),BigInteger.Parse("12973484592284636822415"),BigInteger.Parse("492650770257730391950384"),BigInteger.Parse("18707755785201470257292177") };
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
public class A078987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078987Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078987.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078987.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078987Inst Instance=new A078987Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078986
{
public static readonly BigInteger[] Value={ 1L,19L,721L,27379L,1039681L,39480499L,1499219281L,56930852179L,2161873163521L,82094249361619L,3117419602578001L,118379850648602419L,4495316905044313921L,BigInteger.Parse("170703662541035326579"),BigInteger.Parse("6482243859654298096081"),BigInteger.Parse("246154563004322292324499"),BigInteger.Parse("9347391150304592810234881"),BigInteger.Parse("354954709148570204496600979"),BigInteger.Parse("13478931556495363178060602321") };
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
public class A078986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078986Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078986.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078986.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078986Inst Instance=new A078986Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078985
{
public static readonly long[] Value={ 1L,4L,5L,94L,99L,193L,292L,1361L,1653L,16238L,147795L,311828L,459623L,771451L,1231074L,3233599L,23866267L,27099866L,50966133L,383862797L,4273456900L,4657319697L,8930776597L,13588096294L,49695065479L,63283161773L,429394036117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078985Inst : IEnumerable<long>
{
public static readonly long[] Value=A078985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078985.Bytes);
public long this[int i]=>Value[i];

public static A078985Inst Instance=new A078985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078984
{
public static readonly long[] Value={ 1L,5L,6L,113L,119L,232L,351L,1636L,1987L,19519L,177658L,374835L,552493L,927328L,1479821L,3886970L,28688611L,32575581L,61264192L,461424925L,5136938367L,5598363292L,10735301659L,16333664951L,59736296512L,76069961463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078984Inst : IEnumerable<long>
{
public static readonly long[] Value=A078984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078984.Bytes);
public long this[int i]=>Value[i];

public static A078984Inst Instance=new A078984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078983
{
public static readonly long[] Value={ 1L,2L,3L,17L,54L,179L,412L,591L,12823L,13414L,26237L,39651L,184841L,409333L,594174L,28929685L,2054601809L,14411142348L,16465744157L,30876886505L,294357722702L,325234609207L,944826941116L,1270061550323L,14915503994669L,16185565544992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078983Inst : IEnumerable<long>
{
public static readonly long[] Value=A078983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078983.Bytes);
public long this[int i]=>Value[i];

public static A078983Inst Instance=new A078983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078982
{
public static readonly long[] Value={ 1L,1L,2L,11L,35L,116L,267L,383L,8310L,8693L,17003L,25696L,119787L,265270L,385057L,18748006L,1331493483L,9339202387L,10670695870L,20009898257L,190759780183L,210769678440L,612299137063L,823068815503L,9666056107596L,10489124923099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078982Inst : IEnumerable<long>
{
public static readonly long[] Value=A078982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078982.Bytes);
public long this[int i]=>Value[i];

public static A078982Inst Instance=new A078982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078981
{
public static readonly long[] Value={ 1L,5L,6L,17L,40L,97L,137L,371L,2734L,14041L,16775L,30816L,47591L,125998L,299587L,5818151L,6117738L,18053627L,24171365L,187253182L,211424547L,398677729L,3799524108L,4198201837L,16394129619L,20592331456L,36986461075L,94565253606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078981Inst : IEnumerable<long>
{
public static readonly long[] Value=A078981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078981.Bytes);
public long this[int i]=>Value[i];

public static A078981Inst Instance=new A078981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078980
{
public static readonly long[] Value={ 1L,6L,7L,20L,47L,114L,161L,436L,3213L,16501L,19714L,36215L,55929L,148073L,352075L,6837498L,7189573L,21216644L,28406217L,220060163L,248466380L,468526543L,4465205267L,4933731810L,19266400697L,24200132507L,43466533204L,111133198915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078980Inst : IEnumerable<long>
{
public static readonly long[] Value=A078980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078980.Bytes);
public long this[int i]=>Value[i];

public static A078980Inst Instance=new A078980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078899
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,3L,3L,2L,1L,4L,1L,2L,3L,4L,1L,5L,1L,4L,3L,2L,1L,6L,5L,2L,7L,4L,1L,6L,1L,5L,3L,2L,5L,8L,1L,2L,3L,7L,1L,6L,1L,4L,8L,2L,1L,9L,7L,9L,3L,4L,1L,10L,5L,8L,3L,2L,1L,10L,1L,2L,9L,6L,5L,6L,1L,4L,3L,10L,1L,11L,1L,2L,11L,4L,7L,6L,1L,12L,12L,2L,1L,11L,5L,2L,3L,8L,1L,13L,7L,4L,3L,2L,5L,13L,1L,12L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078899Inst : IEnumerable<long>
{
public static readonly long[] Value=A078899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078899.Bytes);
public long this[int i]=>Value[i];

public static A078899Inst Instance=new A078899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078898
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,3L,1L,4L,2L,5L,1L,6L,1L,7L,3L,8L,1L,9L,1L,10L,4L,11L,1L,12L,2L,13L,5L,14L,1L,15L,1L,16L,6L,17L,3L,18L,1L,19L,7L,20L,1L,21L,1L,22L,8L,23L,1L,24L,2L,25L,9L,26L,1L,27L,4L,28L,10L,29L,1L,30L,1L,31L,11L,32L,5L,33L,1L,34L,12L,35L,1L,36L,1L,37L,13L,38L,3L,39L,1L,40L,14L,41L,1L,42L,6L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078898Inst : IEnumerable<long>
{
public static readonly long[] Value=A078898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078898.Bytes);
public long this[int i]=>Value[i];

public static A078898Inst Instance=new A078898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078897
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,2L,1L,7L,4L,2L,1L,5L,1L,2L,3L,15L,1L,8L,1L,4L,3L,2L,1L,10L,6L,2L,13L,4L,1L,7L,1L,31L,3L,2L,5L,17L,1L,2L,3L,9L,1L,6L,1L,4L,10L,2L,1L,22L,8L,12L,3L,4L,1L,26L,5L,9L,3L,2L,1L,14L,1L,2L,10L,63L,5L,6L,1L,4L,3L,11L,1L,34L,1L,2L,18L,4L,7L,6L,1L,19L,40L,2L,1L,13L,5L,2L,3L,8L,1L,21L,7L,4L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078897Inst : IEnumerable<long>
{
public static readonly long[] Value=A078897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078897.Bytes);
public long this[int i]=>Value[i];

public static A078897Inst Instance=new A078897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078896
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,4L,1L,7L,4L,8L,1L,10L,1L,11L,6L,15L,1L,16L,1L,18L,9L,19L,1L,22L,6L,23L,13L,25L,1L,26L,1L,31L,15L,32L,8L,34L,1L,35L,18L,38L,1L,39L,1L,41L,21L,42L,1L,46L,8L,47L,23L,49L,1L,50L,13L,53L,27L,54L,1L,56L,1L,57L,30L,63L,15L,64L,1L,66L,32L,67L,1L,70L,1L,71L,35L,73L,12L,74L,1L,78L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078896Inst : IEnumerable<long>
{
public static readonly long[] Value=A078896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078896.Bytes);
public long this[int i]=>Value[i];

public static A078896Inst Instance=new A078896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078895
{
public static readonly long[] Value={ 8L,44L,66L,88L,99L,242L,252L,343L,363L,404L,444L,484L,606L,616L,666L,808L,848L,888L,909L,999L,1331L,2112L,2222L,2442L,2662L,2772L,2882L,3333L,3663L,3773L,3993L,4004L,4224L,4444L,4664L,4884L,5445L,5555L,6006L,6336L,6666L,6776L,6886L,6996L,7777L,8008L,8448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078895Inst : IEnumerable<long>
{
public static readonly long[] Value=A078895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078895.Bytes);
public long this[int i]=>Value[i];

public static A078895Inst Instance=new A078895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078894
{
public static readonly long[] Value={ 2L,5L,11L,17L,23L,41L,47L,59L,67L,83L,97L,103L,137L,149L,157L,167L,191L,197L,211L,241L,257L,277L,307L,313L,331L,347L,379L,389L,401L,431L,449L,461L,487L,499L,523L,563L,571L,587L,599L,631L,643L,653L,677L,691L,709L,751L,761L,823L,853L,859L,883L,907L,937L,967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078894Inst : IEnumerable<long>
{
public static readonly long[] Value=A078894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078894.Bytes);
public long this[int i]=>Value[i];

public static A078894Inst Instance=new A078894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078893
{
public static readonly long[] Value={ 8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,24L,25L,26L,27L,28L,30L,33L,35L,36L,38L,39L,42L,44L,45L,49L,50L,51L,52L,54L,56L,62L,64L,65L,66L,68L,69L,70L,72L,77L,78L,80L,81L,84L,86L,90L,91L,92L,93L,95L,96L,98L,99L,102L,104L,105L,111L,112L,117L,120L,121L,122L,123L,124L,129L,130L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078893Inst : IEnumerable<long>
{
public static readonly long[] Value=A078893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078893.Bytes);
public long this[int i]=>Value[i];

public static A078893Inst Instance=new A078893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078892
{
public static readonly long[] Value={ 5L,7L,8L,9L,10L,12L,13L,14L,15L,16L,18L,19L,20L,21L,24L,25L,26L,27L,28L,30L,31L,33L,35L,36L,38L,39L,42L,43L,44L,45L,49L,50L,51L,52L,54L,56L,61L,62L,64L,65L,66L,68L,69L,70L,72L,73L,77L,78L,80L,81L,84L,86L,90L,91L,92L,93L,95L,96L,98L,99L,102L,103L,104L,105L,109L,111L,112L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078892Inst : IEnumerable<long>
{
public static readonly long[] Value=A078892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078892.Bytes);
public long this[int i]=>Value[i];

public static A078892Inst Instance=new A078892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078891
{
public static readonly BigInteger[] Value={ 1L,31L,631L,10631L,1510631L,211510631L,28211510631L,3628211510631L,453628211510631L,55453628211510631L,6655453628211510631L,BigInteger.Parse("786655453628211510631"),BigInteger.Parse("91786655453628211510631") };
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
public class A078891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078891Inst Instance=new A078891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078890
{
public static readonly long[] Value={ 1L,2L,3L,6L,0L,9L,2L,2L,9L,1L,4L,4L,3L,0L,6L,3L,2L,7L,7L,8L,2L,1L,5L,8L,4L,9L,2L,8L,3L,3L,5L,6L,9L,7L,0L,4L,6L,5L,6L,6L,0L,9L,2L,6L,6L,3L,8L,0L,4L,9L,7L,8L,5L,8L,7L,5L,7L,7L,2L,3L,5L,4L,0L,9L,7L,6L,6L,4L,9L,0L,8L,4L,9L,6L,6L,3L,5L,6L,6L,9L,6L,1L,8L,5L,4L,9L,1L,8L,1L,9L,3L,3L,4L,7L,3L,5L,4L,4L,2L,0L,0L,1L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078890Inst : IEnumerable<long>
{
public static readonly long[] Value=A078890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078890.Bytes);
public long this[int i]=>Value[i];

public static A078890Inst Instance=new A078890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078889
{
public static readonly long[] Value={ 1L,4L,0L,8L,6L,9L,2L,0L,0L,2L,2L,9L,6L,4L,8L,3L,2L,8L,1L,0L,4L,3L,0L,3L,8L,0L,0L,5L,1L,3L,5L,5L,1L,1L,3L,0L,1L,0L,4L,8L,7L,4L,0L,7L,9L,5L,1L,1L,5L,8L,7L,6L,5L,7L,0L,4L,4L,6L,8L,3L,8L,8L,8L,8L,6L,5L,8L,8L,4L,5L,4L,8L,1L,8L,9L,4L,4L,7L,2L,5L,6L,1L,1L,6L,1L,0L,1L,2L,3L,4L,0L,7L,1L,1L,8L,4L,1L,1L,0L,4L,5L,5L,5L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078889Inst : IEnumerable<long>
{
public static readonly long[] Value=A078889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078889.Bytes);
public long this[int i]=>Value[i];

public static A078889Inst Instance=new A078889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078888
{
public static readonly long[] Value={ 1L,6L,3L,6L,8L,1L,9L,7L,2L,7L,1L,6L,8L,6L,8L,0L,1L,7L,9L,1L,1L,7L,2L,9L,7L,2L,5L,8L,9L,3L,9L,0L,9L,2L,0L,0L,6L,0L,5L,2L,4L,4L,8L,5L,4L,1L,5L,9L,3L,3L,6L,8L,2L,5L,3L,2L,7L,8L,6L,2L,2L,1L,0L,3L,5L,9L,7L,2L,5L,1L,1L,8L,5L,9L,2L,9L,2L,3L,5L,7L,5L,0L,2L,5L,1L,1L,7L,3L,9L,7L,8L,4L,0L,1L,2L,7L,2L,9L,4L,3L,8L,1L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078888Inst : IEnumerable<long>
{
public static readonly long[] Value=A078888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078888.Bytes);
public long this[int i]=>Value[i];

public static A078888Inst Instance=new A078888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078887
{
public static readonly long[] Value={ 1L,9L,5L,2L,1L,6L,6L,4L,4L,7L,5L,7L,2L,5L,1L,2L,8L,4L,9L,2L,5L,1L,0L,5L,1L,0L,6L,3L,5L,1L,5L,2L,1L,9L,4L,8L,4L,3L,2L,2L,4L,3L,4L,6L,8L,9L,9L,3L,2L,0L,3L,7L,2L,9L,8L,0L,7L,9L,2L,3L,1L,7L,4L,2L,6L,7L,3L,0L,3L,5L,8L,8L,3L,7L,2L,1L,2L,7L,6L,9L,0L,9L,0L,0L,4L,8L,7L,8L,5L,6L,1L,4L,9L,1L,6L,2L,4L,4L,6L,3L,1L,3L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078887Inst : IEnumerable<long>
{
public static readonly long[] Value=A078887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078887.Bytes);
public long this[int i]=>Value[i];

public static A078887Inst Instance=new A078887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078886
{
public static readonly long[] Value={ 2L,4L,1L,6L,0L,2L,5L,6L,0L,0L,0L,6L,5L,5L,3L,6L,0L,0L,0L,0L,0L,0L,4L,2L,9L,4L,9L,6L,7L,2L,9L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,8L,4L,4L,6L,7L,4L,4L,0L,7L,3L,7L,0L,9L,5L,5L,1L,6L,1L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,4L,0L,2L,8L,2L,3L,6L,6L,9L,2L,0L,9L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078886Inst : IEnumerable<long>
{
public static readonly long[] Value=A078886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078886.Bytes);
public long this[int i]=>Value[i];

public static A078886Inst Instance=new A078886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078885
{
public static readonly long[] Value={ 4L,5L,6L,9L,4L,2L,5L,6L,2L,4L,7L,7L,6L,3L,9L,6L,6L,1L,1L,1L,5L,4L,9L,1L,8L,2L,6L,1L,6L,6L,9L,0L,3L,0L,3L,7L,9L,8L,9L,9L,4L,2L,5L,9L,9L,7L,1L,3L,8L,3L,1L,1L,9L,2L,0L,9L,1L,0L,5L,6L,8L,7L,4L,3L,0L,9L,9L,8L,2L,4L,1L,8L,2L,9L,9L,6L,9L,0L,0L,2L,9L,5L,1L,8L,8L,2L,5L,1L,5L,2L,6L,6L,8L,0L,6L,8L,7L,7L,5L,3L,3L,4L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078885Inst : IEnumerable<long>
{
public static readonly long[] Value=A078885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078885.Bytes);
public long this[int i]=>Value[i];

public static A078885Inst Instance=new A078885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078884
{
public static readonly long[] Value={ 5L,7L,13L,19L,73L,109L,193L,433L,1153L,2593L,139969L,472393L,786433L,995329L,57395629L,63700993L,169869313L,4076863489L,10871635969L,2348273369089L,56358560858113L,79164837199873L,84537841287169L,150289495621633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078884Inst : IEnumerable<long>
{
public static readonly long[] Value=A078884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078884.Bytes);
public long this[int i]=>Value[i];

public static A078884Inst Instance=new A078884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078835
{
public static readonly long[] Value={ 7L,12L,13L,28L,24L,39L,32L,42L,72L,54L,56L,96L,78L,93L,120L,168L,127L,96L,195L,140L,121L,132L,128L,156L,216L,192L,280L,152L,360L,176L,204L,288L,403L,372L,288L,378L,288L,324L,372L,546L,384L,508L,336L,468L,252L,256L,403L,560L,384L,420L,744L,504L,384L,588L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078835Inst : IEnumerable<long>
{
public static readonly long[] Value=A078835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078835.Bytes);
public long this[int i]=>Value[i];

public static A078835Inst Instance=new A078835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078834
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,1L,5L,11L,3L,13L,7L,3L,2L,17L,2L,19L,5L,1L,11L,23L,3L,1L,13L,3L,7L,29L,3L,31L,2L,1L,17L,1L,2L,37L,19L,3L,5L,41L,2L,43L,11L,5L,23L,47L,3L,1L,2L,3L,13L,53L,3L,11L,7L,3L,29L,59L,3L,61L,31L,7L,2L,1L,2L,67L,17L,1L,2L,71L,2L,73L,37L,5L,19L,1L,3L,79L,5L,1L,41L,83L,2L,5L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078834Inst : IEnumerable<long>
{
public static readonly long[] Value=A078834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078834.Bytes);
public long this[int i]=>Value[i];

public static A078834Inst Instance=new A078834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078833
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,2L,5L,11L,3L,13L,7L,7L,2L,17L,2L,19L,5L,5L,11L,23L,3L,3L,13L,13L,7L,29L,7L,31L,2L,2L,17L,17L,2L,37L,19L,19L,5L,41L,5L,43L,11L,13L,23L,47L,3L,17L,3L,19L,13L,53L,13L,23L,7L,7L,29L,59L,7L,61L,31L,31L,2L,2L,2L,67L,17L,17L,17L,71L,2L,73L,37L,37L,19L,19L,19L,79L,5L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078833Inst : IEnumerable<long>
{
public static readonly long[] Value=A078833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078833.Bytes);
public long this[int i]=>Value[i];

public static A078833Inst Instance=new A078833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078832
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078832Inst : IEnumerable<long>
{
public static readonly long[] Value=A078832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078832.Bytes);
public long this[int i]=>Value[i];

public static A078832Inst Instance=new A078832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078831
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,9L,11L,12L,13L,16L,17L,19L,24L,25L,32L,33L,35L,48L,49L,64L,65L,67L,96L,97L,128L,129L,131L,192L,193L,256L,257L,259L,384L,385L,512L,513L,515L,768L,769L,1024L,1025L,1027L,1536L,1537L,2048L,2049L,2051L,3072L,3073L,4096L,4097L,4099L,6144L,6145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078831Inst : IEnumerable<long>
{
public static readonly long[] Value=A078831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078831.Bytes);
public long this[int i]=>Value[i];

public static A078831Inst Instance=new A078831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078830
{
public static readonly long[] Value={ 2L,3L,4L,8L,9L,16L,32L,33L,64L,65L,128L,129L,256L,512L,513L,1024L,1025L,2048L,2049L,4096L,4097L,8192L,8193L,16384L,16385L,32768L,32769L,65536L,131072L,131073L,262144L,262145L,524288L,524289L,1048576L,1048577L,2097152L,2097153L,4194304L,4194305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078830Inst : IEnumerable<long>
{
public static readonly long[] Value=A078830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078830.Bytes);
public long this[int i]=>Value[i];

public static A078830Inst Instance=new A078830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078829
{
public static readonly long[] Value={ 2L,3L,4L,8L,9L,16L,18L,32L,33L,36L,64L,65L,66L,72L,128L,129L,130L,132L,144L,256L,258L,260L,264L,265L,288L,289L,512L,513L,516L,520L,528L,530L,576L,578L,1024L,1025L,1026L,1032L,1040L,1056L,1057L,1060L,1152L,1156L,2048L,2049L,2050L,2052L,2064L,2080L,2112L,2114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078829Inst : IEnumerable<long>
{
public static readonly long[] Value=A078829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078829.Bytes);
public long this[int i]=>Value[i];

public static A078829Inst Instance=new A078829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078828
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,10L,6L,63L,2L,2L,20L,330L,6L,390L,126L,1323L,2L,34L,4L,114L,20L,100L,660L,159390L,6L,6L,780L,12870L,126L,237510L,2646L,861273L,2L,2L,68L,102L,4L,740L,228L,2394L,20L,820L,200L,141900L,660L,42900L,318780L,157317930L,6L,102L,12L,342L,780L,206700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078828Inst : IEnumerable<long>
{
public static readonly long[] Value=A078828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078828.Bytes);
public long this[int i]=>Value[i];

public static A078828Inst Instance=new A078828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078827
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,2L,3L,1L,1L,3L,4L,2L,4L,4L,5L,1L,2L,2L,3L,3L,4L,5L,7L,2L,2L,5L,6L,4L,7L,6L,8L,1L,1L,3L,3L,2L,4L,4L,5L,3L,4L,5L,7L,5L,7L,8L,10L,2L,3L,3L,4L,5L,7L,7L,9L,4L,4L,8L,10L,6L,10L,9L,11L,1L,1L,2L,3L,3L,4L,4L,6L,2L,3L,5L,6L,4L,6L,6L,8L,3L,4L,5L,7L,5L,6L,8L,10L,5L,6L,8L,9L,8L,11L,11L,13L,2L,3L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078827Inst : IEnumerable<long>
{
public static readonly long[] Value=A078827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078827.Bytes);
public long this[int i]=>Value[i];

public static A078827Inst Instance=new A078827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078826
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,2L,2L,1L,1L,2L,4L,2L,4L,3L,2L,1L,2L,1L,3L,2L,2L,4L,6L,2L,2L,4L,5L,3L,6L,3L,3L,1L,1L,2L,3L,1L,3L,3L,4L,2L,3L,2L,5L,4L,5L,6L,7L,2L,3L,2L,3L,4L,5L,5L,7L,3L,3L,6L,8L,3L,7L,4L,3L,1L,1L,1L,3L,2L,3L,3L,5L,1L,2L,3L,5L,3L,5L,4L,5L,2L,3L,3L,6L,2L,2L,5L,7L,4L,5L,5L,5L,6L,8L,7L,8L,2L,3L,3L,3L,2L,5L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078826Inst : IEnumerable<long>
{
public static readonly long[] Value=A078826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078826.Bytes);
public long this[int i]=>Value[i];

public static A078826Inst Instance=new A078826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078825
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,17L,17L,11L,15L,37L,18L,62L,37L,62L,62L,26L,31L,77L,69L,130L,69L,120L,120L,186L,77L,130L,120L,186L,130L,186L,186L,57L,63L,157L,141L,266L,70L,249L,249L,382L,141L,249L,81L,371L,249L,189L,371L,501L,157L,266L,249L,382L,249L,371L,189L,501L,266L,382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078825Inst : IEnumerable<long>
{
public static readonly long[] Value=A078825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078825.Bytes);
public long this[int i]=>Value[i];

public static A078825Inst Instance=new A078825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078824
{
public static readonly long[] Value={ 1L,1L,3L,2L,4L,6L,6L,3L,5L,8L,5L,10L,8L,10L,10L,4L,6L,10L,9L,13L,9L,12L,12L,15L,10L,13L,12L,15L,13L,15L,15L,5L,7L,12L,11L,16L,7L,16L,16L,19L,11L,16L,7L,19L,16L,12L,19L,21L,12L,16L,16L,19L,16L,19L,12L,21L,16L,19L,19L,21L,19L,21L,21L,6L,8L,14L,13L,19L,12L,19L,19L,23L,12L,17L,16L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078824Inst : IEnumerable<long>
{
public static readonly long[] Value=A078824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078824.Bytes);
public long this[int i]=>Value[i];

public static A078824Inst Instance=new A078824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078823
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,8L,12L,11L,15L,16L,18L,22L,28L,30L,33L,26L,31L,32L,34L,38L,42L,39L,50L,52L,60L,62L,66L,68L,77L,80L,78L,57L,63L,64L,66L,70L,70L,76L,82L,84L,90L,92L,81L,96L,110L,108L,118L,114L,124L,126L,130L,132L,142L,140L,144L,153L,165L,168L,174L,177L,182L,186L,171L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078823Inst : IEnumerable<long>
{
public static readonly long[] Value=A078823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078823.Bytes);
public long this[int i]=>Value[i];

public static A078823Inst Instance=new A078823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078822
{
public static readonly long[] Value={ 1L,1L,3L,2L,4L,4L,5L,3L,5L,5L,5L,6L,7L,7L,7L,4L,6L,6L,6L,7L,7L,6L,8L,8L,9L,9L,9L,9L,10L,10L,9L,5L,7L,7L,7L,8L,7L,8L,9L,9L,9L,9L,7L,9L,11L,10L,11L,10L,11L,11L,11L,11L,12L,11L,11L,12L,13L,13L,13L,13L,13L,13L,11L,6L,8L,8L,8L,9L,8L,9L,10L,10L,9L,8L,10L,11L,11L,12L,12L,11L,11L,11L,11L,12L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078822Inst : IEnumerable<long>
{
public static readonly long[] Value=A078822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078822.Bytes);
public long this[int i]=>Value[i];

public static A078822Inst Instance=new A078822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078821
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,0L,1L,1L,1L,1L,0L,2L,2L,2L,0L,1L,2L,2L,2L,2L,1L,0L,2L,4L,4L,4L,2L,0L,1L,3L,4L,5L,5L,4L,3L,1L,0L,2L,6L,8L,10L,8L,6L,2L,0L,1L,4L,7L,10L,12L,12L,10L,7L,4L,1L,0L,2L,8L,14L,20L,22L,20L,14L,8L,2L,0L,1L,5L,11L,18L,25L,29L,29L,25L,18L,11L,5L,1L,0L,2L,10L,22L,36L,48L,52L,48L,36L,22L,10L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078821Inst : IEnumerable<long>
{
public static readonly long[] Value=A078821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078821.Bytes);
public long this[int i]=>Value[i];

public static A078821Inst Instance=new A078821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078820
{
public static readonly long[] Value={ 5L,24L,100L,400L,1575L,6160L,24024L,93600L,364650L,1421200L,5542680L,21633248L,84504875L,330372000L,1292646000L,5061729600L,19835652870L,77786874000L,305254551000L,1198665468000L,4709756401350L,18516070880736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078820Inst : IEnumerable<long>
{
public static readonly long[] Value=A078820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078820.Bytes);
public long this[int i]=>Value[i];

public static A078820Inst Instance=new A078820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078691
{
public static readonly long[] Value={ 1L,2L,54L,96L,98L,216L,288L,350L,512L,1176L,2166L,2178L,2904L,3174L,3872L,4056L,5046L,5618L,7350L,9248L,11094L,12150L,12482L,15000L,15138L,15842L,16038L,16200L,16810L,16928L,17496L,18490L,21600L,22898L,25088L,27378L,29400L,31974L,33800L,35000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078691Inst : IEnumerable<long>
{
public static readonly long[] Value=A078691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078691.Bytes);
public long this[int i]=>Value[i];

public static A078691Inst Instance=new A078691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078690
{
public static readonly long[] Value={ 1L,2L,30L,12L,1L,1L,17L,90L,27L,1L,1L,32L,150L,42L,1L,1L,47L,210L,57L,1L,1L,62L,270L,72L,1L,1L,77L,330L,87L,1L,1L,92L,390L,102L,1L,1L,107L,450L,117L,1L,1L,122L,510L,132L,1L,1L,137L,570L,147L,1L,1L,152L,630L,162L,1L,1L,167L,690L,177L,1L,1L,182L,750L,192L,1L,1L,197L,810L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078690Inst : IEnumerable<long>
{
public static readonly long[] Value=A078690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078690.Bytes);
public long this[int i]=>Value[i];

public static A078690Inst Instance=new A078690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078689
{
public static readonly long[] Value={ 1L,2L,1L,1L,8L,1L,1L,14L,1L,1L,20L,1L,1L,26L,1L,1L,32L,1L,1L,38L,1L,1L,44L,1L,1L,50L,1L,1L,56L,1L,1L,62L,1L,1L,68L,1L,1L,74L,1L,1L,80L,1L,1L,86L,1L,1L,92L,1L,1L,98L,1L,1L,104L,1L,1L,110L,1L,1L,116L,1L,1L,122L,1L,1L,128L,1L,1L,134L,1L,1L,140L,1L,1L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078689Inst : IEnumerable<long>
{
public static readonly long[] Value=A078689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078689.Bytes);
public long this[int i]=>Value[i];

public static A078689Inst Instance=new A078689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078688
{
public static readonly long[] Value={ 1L,3L,1L,1L,11L,1L,1L,19L,1L,1L,27L,1L,1L,35L,1L,1L,43L,1L,1L,51L,1L,1L,59L,1L,1L,67L,1L,1L,75L,1L,1L,83L,1L,1L,91L,1L,1L,99L,1L,1L,107L,1L,1L,115L,1L,1L,123L,1L,1L,131L,1L,1L,139L,1L,1L,147L,1L,1L,155L,1L,1L,163L,1L,1L,171L,1L,1L,179L,1L,1L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078688Inst : IEnumerable<long>
{
public static readonly long[] Value=A078688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078688.Bytes);
public long this[int i]=>Value[i];

public static A078688Inst Instance=new A078688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078687
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,1L,3L,2L,1L,2L,2L,1L,2L,2L,1L,1L,3L,2L,2L,2L,2L,3L,1L,1L,2L,2L,2L,2L,2L,0L,3L,1L,4L,0L,2L,2L,1L,3L,2L,1L,4L,1L,1L,2L,4L,2L,1L,3L,3L,1L,1L,3L,0L,2L,2L,1L,3L,2L,1L,2L,3L,1L,1L,2L,2L,0L,0L,2L,2L,3L,1L,2L,0L,2L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,3L,0L,1L,3L,2L,1L,1L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078687Inst : IEnumerable<long>
{
public static readonly long[] Value=A078687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078687.Bytes);
public long this[int i]=>Value[i];

public static A078687Inst Instance=new A078687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078686
{
public static readonly long[] Value={ 5L,31L,67L,89L,101L,283L,503L,1039L,1129L,2069L,3457L,5641L,45763L,71483L,86599L,112921L,161411L,210173L,211007L,232741L,245269L,479029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078686Inst : IEnumerable<long>
{
public static readonly long[] Value=A078686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078686.Bytes);
public long this[int i]=>Value[i];

public static A078686Inst Instance=new A078686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078685
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,3L,1L,3L,7L,3L,1L,5L,9L,11L,15L,11L,5L,3L,3L,7L,9L,15L,19L,25L,31L,27L,25L,21L,19L,15L,1L,3L,9L,11L,21L,23L,29L,35L,39L,45L,51L,53L,63L,63L,59L,57L,45L,33L,29L,27L,23L,17L,15L,5L,1L,7L,13L,15L,21L,25L,27L,37L,51L,55L,57L,61L,75L,81L,91L,93L,97L,103L,111L,117L,123L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078685Inst : IEnumerable<long>
{
public static readonly long[] Value=A078685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078685.Bytes);
public long this[int i]=>Value[i];

public static A078685Inst Instance=new A078685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078684
{
public static readonly BigInteger[] Value={ 1L,1L,3L,9L,81L,729L,19683L,531441L,43046721L,3486784401L,847288609443L,205891132094649L,150094635296999121L,BigInteger.Parse("109418989131512359209"),BigInteger.Parse("239299329230617529590083"),BigInteger.Parse("523347633027360537213511521"),BigInteger.Parse("3433683820292512484657849089281"),BigInteger.Parse("22528399544939174411840147874772641") };
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
public class A078684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078684Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078684.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078684.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078684Inst Instance=new A078684Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078683
{
public static readonly long[] Value={ 3L,5L,7L,17L,11L,13L,29L,17L,19L,41L,23L,97L,53L,29L,31L,257L,137L,37L,1217L,41L,43L,89L,47L,97L,101L,53L,109L,113L,59L,61L,7937L,257L,67L,137L,71L,73L,149L,1217L,79L,641L,83L,337L,173L,89L,181L,11777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078683Inst : IEnumerable<long>
{
public static readonly long[] Value=A078683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078683.Bytes);
public long this[int i]=>Value[i];

public static A078683Inst Instance=new A078683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078682
{
public static readonly BigInteger[] Value={ 2L,3L,5L,9094059599L,41L,9094059599L,11L,41L,9094059599L,23L,17L,41L,99390677L,9094059599L,23L,BigInteger.Parse("542705556759647203359434240657"),59L,41L,29L,99390677L,9094059599L,113L,53L,BigInteger.Parse("542705556759647203359434240657"),16323879599L,59L,41L };
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
public class A078682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A078682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078682Inst Instance=new A078682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078681
{
public static readonly long[] Value={ 1L,1L,1L,53L,5L,52L,1L,4L,51L,2L,1L,3L,39L,50L,1L,162L,3L,2L,1L,38L,49L,4L,2L,161L,50L,2L,1L,52L,4L,37L,1L,48L,3L,13L,1L,160L,9L,49L,1L,8L,42L,51L,18L,3L,36L,8L,1L,47L,3L,2L,12L,35L,27L,159L,1L,8L,48L,2L,1L,7L,4L,41L,50L,16L,17L,2L,1L,35L,7L,13L,1L,46L,11L,2L,1L,3L,11L,34L,2L,26L,158L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078681Inst : IEnumerable<long>
{
public static readonly long[] Value=A078681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078681.Bytes);
public long this[int i]=>Value[i];

public static A078681Inst Instance=new A078681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078680
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,3L,2L,1L,1L,4L,3L,1L,6L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,1L,8L,3L,1L,2L,1L,1L,2L,5L,1L,4L,1L,3L,2L,1L,2L,8L,583L,1L,2L,1L,1L,6L,1L,1L,4L,1L,2L,2L,5L,2L,4L,7L,1L,2L,1L,5L,2L,1L,1L,2L,3L,3L,2L,1L,1L,4L,3L,1L,2L,3L,1L,10L,1L,2L,4L,1L,2L,2L,1L,1L,8L,7L,2L,582L,1L,1L,2L,1L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078680Inst : IEnumerable<long>
{
public static readonly long[] Value=A078680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078680.Bytes);
public long this[int i]=>Value[i];

public static A078680Inst Instance=new A078680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078679
{
public static readonly long[] Value={ 1L,1L,3L,7L,17L,43L,111L,291L,771L,2059L,5533L,14943L,40523L,110271L,300949L,823417L,2257877L,6203239L,17071779L,47054475L,129872499L,358896927L,992907525L,2749737663L,7622185263L,21146597511L,58714466733L,163142652877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078679Inst : IEnumerable<long>
{
public static readonly long[] Value=A078679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078679.Bytes);
public long this[int i]=>Value[i];

public static A078679Inst Instance=new A078679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078678
{
public static readonly long[] Value={ 1L,2L,4L,8L,18L,42L,100L,242L,592L,1460L,3624L,9042L,22656L,56970L,143688L,363348L,920886L,2338566L,5949148L,15157874L,38674978L,98803052L,252701484L,646990518L,1658066668L,4252908542L,10917422860L,28046438252L,72099983802L,185469011130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078678Inst : IEnumerable<long>
{
public static readonly long[] Value=A078678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078678.Bytes);
public long this[int i]=>Value[i];

public static A078678Inst Instance=new A078678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078677
{
public static readonly long[] Value={ 1L,3L,6L,5L,8L,9L,13L,9L,12L,13L,17L,15L,19L,20L,20L,17L,20L,21L,25L,23L,27L,28L,28L,27L,31L,32L,32L,34L,34L,35L,39L,33L,36L,37L,41L,39L,43L,44L,44L,43L,47L,48L,48L,50L,50L,51L,55L,51L,55L,56L,56L,58L,58L,59L,63L,62L,62L,63L,67L,65L,69L,70L,72L,65L,68L,69L,73L,71L,75L,76L,76L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078677Inst : IEnumerable<long>
{
public static readonly long[] Value=A078677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078677.Bytes);
public long this[int i]=>Value[i];

public static A078677Inst Instance=new A078677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078676
{
public static readonly long[] Value={ 1L,2L,7L,43L,350L,3547L,43011L,607042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078676Inst : IEnumerable<long>
{
public static readonly long[] Value=A078676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078676.Bytes);
public long this[int i]=>Value[i];

public static A078676Inst Instance=new A078676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078659
{
public static readonly long[] Value={ 1L,0L,-1L,0L,0L,-1L,-1L,1L,1L,-1L,0L,1L,0L,-1L,0L,2L,1L,-1L,0L,1L,0L,-2L,0L,2L,0L,-2L,0L,1L,-1L,-2L,0L,3L,1L,-3L,0L,2L,-1L,-4L,1L,4L,-1L,-3L,1L,2L,-1L,-4L,2L,5L,0L,-4L,1L,4L,-2L,-5L,3L,5L,-1L,-5L,2L,4L,-2L,-6L,3L,8L,-1L,-8L,3L,6L,-4L,-9L,5L,8L,-3L,-9L,4L,7L,-5L,-11L,7L,11L,-4L,-12L,7L,9L,-7L,-13L,9L,12L,-6L,-14L,9L,10L,-8L,-16L,13L,15L,-8L,-17L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078659Inst : IEnumerable<long>
{
public static readonly long[] Value=A078659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078659.Bytes);
public long this[int i]=>Value[i];

public static A078659Inst Instance=new A078659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078658
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,4L,2L,6L,4L,9L,6L,13L,10L,19L,15L,28L,24L,41L,36L,59L,55L,85L,81L,121L,119L,171L,172L,240L,247L,335L,348L,464L,490L,639L,681L,874L,941L,1190L,1289L,1610L,1756L,2168L,2375L,2904L,3197L,3873L,4276L,5141L,5693L,6796L,7541L,8945L,9946L,11730L,13058L,15322L,17078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078658Inst : IEnumerable<long>
{
public static readonly long[] Value=A078658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078658.Bytes);
public long this[int i]=>Value[i];

public static A078658Inst Instance=new A078658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078657
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,3L,1L,5L,3L,8L,5L,12L,9L,18L,14L,27L,23L,40L,35L,58L,54L,84L,80L,120L,118L,170L,171L,239L,246L,334L,347L,463L,489L,638L,680L,873L,940L,1189L,1288L,1609L,1755L,2167L,2374L,2903L,3196L,3872L,4275L,5140L,5692L,6795L,7540L,8944L,9945L,11729L,13057L,15321L,17077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078657Inst : IEnumerable<long>
{
public static readonly long[] Value=A078657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078657.Bytes);
public long this[int i]=>Value[i];

public static A078657Inst Instance=new A078657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078656
{
public static readonly long[] Value={ 31L,127L,179L,283L,353L,547L,739L,877L,1087L,1153L,1297L,1523L,1597L,1741L,1823L,2063L,2221L,2749L,2909L,3001L,3259L,3517L,3733L,3911L,4153L,4421L,4663L,4759L,4943L,5189L,5281L,5701L,5801L,6229L,6311L,6841L,7109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078656Inst : IEnumerable<long>
{
public static readonly long[] Value=A078656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078656.Bytes);
public long this[int i]=>Value[i];

public static A078656Inst Instance=new A078656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078655
{
public static readonly long[] Value={ 17L,41L,67L,127L,157L,191L,283L,331L,367L,401L,509L,563L,599L,709L,797L,877L,919L,967L,1087L,1171L,1217L,1297L,1409L,1447L,1523L,1741L,1787L,1847L,2027L,2081L,2221L,2269L,2351L,2477L,2549L,2609L,2719L,2803L,2909L,3019L,3067L,3229L,3299L,3469L,3559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078655Inst : IEnumerable<long>
{
public static readonly long[] Value=A078655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078655.Bytes);
public long this[int i]=>Value[i];

public static A078655Inst Instance=new A078655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078654
{
public static readonly long[] Value={ 5L,17L,31L,67L,83L,127L,191L,211L,277L,331L,353L,401L,431L,563L,587L,709L,739L,797L,877L,967L,991L,1063L,1153L,1217L,1297L,1409L,1433L,1499L,1597L,1669L,1741L,1847L,2027L,2063L,2221L,2341L,2417L,2477L,2609L,2647L,2897L,3001L,3067L,3109L,3299L,3319L,3407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078654Inst : IEnumerable<long>
{
public static readonly long[] Value=A078654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078654.Bytes);
public long this[int i]=>Value[i];

public static A078654Inst Instance=new A078654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078653
{
public static readonly long[] Value={ 11L,41L,59L,109L,157L,179L,241L,283L,367L,461L,509L,547L,599L,617L,773L,859L,919L,1031L,1087L,1171L,1201L,1447L,1471L,1523L,1621L,1723L,1787L,1823L,1913L,2081L,2099L,2269L,2351L,2381L,2549L,2683L,2719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078653Inst : IEnumerable<long>
{
public static readonly long[] Value=A078653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078653.Bytes);
public long this[int i]=>Value[i];

public static A078653Inst Instance=new A078653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078652
{
public static readonly long[] Value={ 1L,2L,4L,5L,13L,17L,25L,29L,43L,47L,61L,67L,81L,83L,101L,103L,107L,109L,125L,127L,143L,149L,165L,167L,191L,193L,215L,223L,230L,233L,243L,251L,260L,263L,279L,281L,308L,311L,324L,331L,340L,347L,361L,367L,387L,389L,425L,431L,444L,449L,473L,479L,507L,509L,533L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078652Inst : IEnumerable<long>
{
public static readonly long[] Value=A078652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078652.Bytes);
public long this[int i]=>Value[i];

public static A078652Inst Instance=new A078652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078651
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,17L,23L,27L,31L,33L,40L,42L,46L,50L,59L,61L,68L,70L,77L,81L,85L,87L,97L,101L,105L,111L,118L,120L,128L,130L,141L,145L,149L,153L,165L,167L,171L,175L,185L,187L,195L,197L,204L,211L,215L,217L,231L,235L,242L,246L,253L,255L,265L,269L,279L,283L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078651Inst : IEnumerable<long>
{
public static readonly long[] Value=A078651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078651.Bytes);
public long this[int i]=>Value[i];

public static A078651Inst Instance=new A078651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078650
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078650Inst : IEnumerable<long>
{
public static readonly long[] Value=A078650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078650.Bytes);
public long this[int i]=>Value[i];

public static A078650Inst Instance=new A078650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078649
{
public static readonly long[] Value={ 2L,4L,8L,11L,13L,16L,18L,22L,26L,28L,31L,35L,38L,40L,44L,48L,51L,53L,56L,58L,62L,65L,67L,70L,74L,78L,80L,83L,85L,89L,92L,94L,97L,99L,103L,107L,110L,112L,115L,119L,121L,124L,126L,130L,133L,135L,138L,140L,144L,148L,150L,153L,157L,160L,162L,165L,167L,171L,175L,178L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078649Inst : IEnumerable<long>
{
public static readonly long[] Value=A078649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078649.Bytes);
public long this[int i]=>Value[i];

public static A078649Inst Instance=new A078649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078648
{
public static readonly long[] Value={ 5L,18L,24L,36L,48L,60L,78L,84L,90L,114L,144L,120L,168L,180L,234L,246L,288L,240L,210L,324L,300L,360L,474L,330L,528L,576L,390L,462L,480L,420L,570L,510L,672L,792L,756L,876L,714L,798L,690L,1038L,630L,1008L,930L,780L,960L,870L,924L,900L,1134L,1434L,840L,990L,1302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078648Inst : IEnumerable<long>
{
public static readonly long[] Value=A078648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078648.Bytes);
public long this[int i]=>Value[i];

public static A078648Inst Instance=new A078648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078647
{
public static readonly long[] Value={ 4L,22L,34L,58L,94L,112L,142L,170L,220L,274L,286L,340L,280L,364L,460L,622L,520L,490L,610L,650L,670L,890L,920L,700L,850L,770L,1000L,1250L,1160L,910L,1520L,1190L,1120L,1400L,1450L,1670L,1570L,1660L,1630L,1330L,1610L,1870L,2002L,2260L,2060L,1540L,1750L,1960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078647Inst : IEnumerable<long>
{
public static readonly long[] Value=A078647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078647.Bytes);
public long this[int i]=>Value[i];

public static A078647Inst Instance=new A078647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078646
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,2L,0L,0L,1L,2L,0L,2L,0L,0L,1L,1L,0L,3L,0L,0L,0L,2L,0L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,3L,0L,3L,0L,0L,1L,2L,0L,4L,0L,0L,1L,2L,0L,4L,0L,0L,0L,2L,0L,4L,0L,0L,1L,4L,0L,4L,0L,0L,0L,4L,0L,4L,0L,0L,1L,4L,0L,4L,0L,0L,1L,3L,0L,5L,0L,0L,0L,3L,0L,5L,0L,0L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078646Inst : IEnumerable<long>
{
public static readonly long[] Value=A078646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078646.Bytes);
public long this[int i]=>Value[i];

public static A078646Inst Instance=new A078646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078645
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,11L,13L,17L,19L,23L,25L,29L,33L,35L,37L,39L,41L,43L,49L,53L,57L,65L,67L,69L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078645Inst : IEnumerable<long>
{
public static readonly long[] Value=A078645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078645.Bytes);
public long this[int i]=>Value[i];

public static A078645Inst Instance=new A078645Inst();

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