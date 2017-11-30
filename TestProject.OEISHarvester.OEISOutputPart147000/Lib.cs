using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A176305
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,7L,7L,1L,1L,31L,36L,31L,1L,1L,165L,194L,194L,165L,1L,1L,1031L,1194L,1218L,1194L,1031L,1L,1L,7423L,8452L,8610L,8610L,8452L,7423L,1L,1L,60621L,68042L,69066L,69200L,69066L,68042L,60621L,1L,1L,554249L,614868L,622284L,623284L,623284L,622284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176305Inst : IEnumerable<long>
{
public static readonly long[] Value=A176305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176305.Bytes);
public long this[int i]=>Value[i];

public static A176305Inst Instance=new A176305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176306
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,13L,13L,1L,1L,25L,38L,25L,1L,1L,-185L,-160L,-160L,-185L,1L,1L,-779L,-964L,-952L,-964L,-779L,1L,1L,7497L,6718L,6520L,6520L,6718L,7497L,1L,1L,45907L,53404L,52612L,52402L,52612L,53404L,45907L,1L,1L,-524629L,-478722L,-471238L,-472042L,-472042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176306Inst : IEnumerable<long>
{
public static readonly long[] Value=A176306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176306.Bytes);
public long this[int i]=>Value[i];

public static A176306Inst Instance=new A176306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176307
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,-11L,-11L,1L,1L,-23L,-36L,-23L,1L,1L,187L,162L,162L,187L,1L,1L,781L,966L,954L,966L,781L,1L,1L,-7495L,-6716L,-6518L,-6518L,-6716L,-7495L,1L,1L,-45905L,-53402L,-52610L,-52400L,-52610L,-53402L,-45905L,1L,1L,524631L,478724L,471240L,472044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176307Inst : IEnumerable<long>
{
public static readonly long[] Value=A176307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176307.Bytes);
public long this[int i]=>Value[i];

public static A176307Inst Instance=new A176307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176308
{
public static readonly long[] Value={ 6L,42L,66L,78L,102L,114L,138L,186L,210L,222L,258L,282L,318L,330L,354L,366L,390L,402L,438L,462L,498L,510L,534L,546L,642L,678L,690L,714L,762L,786L,798L,858L,870L,894L,906L,942L,966L,978L,1002L,1038L,1086L,1110L,1122L,1218L,1230L,1254L,1266L,1290L,1302L,1338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176308Inst : IEnumerable<long>
{
public static readonly long[] Value=A176308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176308.Bytes);
public long this[int i]=>Value[i];

public static A176308Inst Instance=new A176308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176309
{
public static readonly long[] Value={ 49L,50L,68L,99L,116L,117L,124L,125L,128L,175L,176L,243L,244L,245L,275L,276L,315L,316L,324L,325L,343L,344L,351L,360L,361L,423L,424L,425L,459L,460L,472L,475L,476L,549L,604L,605L,700L,704L,716L,724L,725L,775L,776L,832L,833L,844L,845L,846L,847L,848L,867L,868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176309Inst : IEnumerable<long>
{
public static readonly long[] Value=A176309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176309.Bytes);
public long this[int i]=>Value[i];

public static A176309Inst Instance=new A176309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176310
{
public static readonly long[] Value={ 1L,3L,12L,47L,157L,531L,1741L,5459L,16814L,51286L,152506L,447622L,1300571L,3721897L,10551143L,29663448L,82494469L,227701487L,624113377L,1697228926L,4586879327L,12323255188L,32904418872L,87395198231L,230972180615L,607363842960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176310Inst : IEnumerable<long>
{
public static readonly long[] Value=A176310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176310.Bytes);
public long this[int i]=>Value[i];

public static A176310Inst Instance=new A176310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176311
{
public static readonly long[] Value={ 3L,15L,60L,127L,378L,1020L,2040L,4095L,13299L,24570L,49140L,131068L,229362L,524280L,1572840L,2097151L,4718574L,13631475L,20971500L,50331642L,134217696L,201326580L,402653160L,1073741820L,2080374753L,3758096370L,10737418200L,17179869176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176311Inst : IEnumerable<long>
{
public static readonly long[] Value=A176311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176311.Bytes);
public long this[int i]=>Value[i];

public static A176311Inst Instance=new A176311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176312
{
public static readonly long[] Value={ 4L,46L,74L,94L,106L,134L,158L,166L,178L,194L,226L,254L,262L,314L,326L,334L,346L,422L,446L,466L,502L,514L,526L,529L,554L,586L,614L,634L,662L,674L,706L,718L,734L,746L,758L,766L,778L,794L,802L,818L,851L,878L,886L,898L,914L,934L,958L,974L,982L,998L,1006L,1018L,1081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176312Inst : IEnumerable<long>
{
public static readonly long[] Value=A176312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176312.Bytes);
public long this[int i]=>Value[i];

public static A176312Inst Instance=new A176312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176313
{
public static readonly long[] Value={ 135L,296L,343L,375L,999L,1160L,1431L,1592L,1624L,2295L,2375L,2456L,2727L,2888L,3429L,3591L,3624L,3752L,3992L,4023L,4184L,4887L,4913L,5048L,5144L,5319L,5480L,5831L,6183L,6344L,6375L,6615L,6776L,6858L,6859L,7479L,7624L,7640L,7749L,7911L,8072L,8375L,8775L,8936L,9125L,9207L,9368L,9624L,10071L,10232L,10375L,10503L,10632L,10664L,10984L,11124L,11319L,11367L,11528L,11624L,11799L,11960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176313Inst : IEnumerable<long>
{
public static readonly long[] Value=A176313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176313.Bytes);
public long this[int i]=>Value[i];

public static A176313Inst Instance=new A176313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176314
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,3L,0L,2L,2L,1L,1L,4L,2L,5L,2L,2L,3L,6L,0L,3L,5L,6L,4L,8L,2L,6L,4L,5L,7L,6L,1L,6L,9L,11L,5L,10L,4L,9L,8L,5L,8L,13L,3L,8L,7L,10L,10L,16L,11L,12L,5L,8L,12L,18L,4L,10L,14L,10L,10L,12L,8L,15L,16L,20L,13L,20L,4L,11L,16L,15L,16L,16L,12L,19L,7L,11L,17L,25L,11L,14L,20L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176314Inst : IEnumerable<long>
{
public static readonly long[] Value=A176314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176314.Bytes);
public long this[int i]=>Value[i];

public static A176314Inst Instance=new A176314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176315
{
public static readonly BigInteger[] Value={ 1L,3L,13L,165L,7901L,1383853L,879285501L,2047199658621L,17660268902020093L,BigInteger.Parse("569790880105867285245"),BigInteger.Parse("69280640454268889757533693") };
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
public class A176315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176315Inst Instance=new A176315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176316
{
public static readonly long[] Value={ 2L,3L,11L,29L,47L,59L,71L,83L,101L,131L,149L,167L,227L,257L,317L,347L,359L,383L,389L,479L,503L,563L,569L,587L,593L,683L,773L,839L,857L,881L,947L,983L,1019L,1091L,1109L,1187L,1193L,1229L,1259L,1319L,1361L,1499L,1583L,1613L,1637L,1697L,1733L,1823L,1913L,1931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176316Inst : IEnumerable<long>
{
public static readonly long[] Value=A176316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176316.Bytes);
public long this[int i]=>Value[i];

public static A176316Inst Instance=new A176316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176317
{
public static readonly long[] Value={ 5L,4L,5L,8L,0L,3L,9L,8L,9L,1L,5L,4L,9L,8L,0L,8L,0L,2L,1L,2L,8L,3L,6L,6L,4L,1L,4L,5L,7L,8L,0L,8L,0L,8L,5L,2L,4L,2L,0L,7L,7L,5L,0L,6L,1L,5L,3L,9L,7L,1L,7L,0L,1L,6L,1L,4L,3L,9L,8L,5L,9L,8L,3L,4L,5L,7L,1L,4L,1L,1L,2L,2L,9L,5L,5L,2L,8L,2L,6L,5L,1L,8L,3L,8L,2L,8L,7L,6L,2L,6L,3L,5L,9L,1L,5L,5L,4L,5L,8L,9L,0L,4L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176317Inst : IEnumerable<long>
{
public static readonly long[] Value=A176317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176317.Bytes);
public long this[int i]=>Value[i];

public static A176317Inst Instance=new A176317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176318
{
public static readonly long[] Value={ 5L,3L,1L,3L,6L,5L,7L,1L,6L,9L,3L,5L,5L,6L,8L,8L,6L,9L,7L,1L,8L,6L,1L,4L,8L,2L,3L,4L,9L,2L,0L,3L,5L,1L,6L,6L,4L,8L,0L,8L,0L,7L,9L,5L,2L,6L,2L,7L,0L,8L,0L,8L,9L,9L,2L,1L,0L,8L,3L,0L,0L,6L,2L,1L,3L,2L,2L,0L,9L,9L,3L,5L,8L,3L,8L,2L,9L,6L,8L,0L,3L,7L,7L,6L,0L,7L,0L,9L,4L,9L,5L,7L,3L,1L,7L,2L,6L,4L,7L,3L,4L,5L,5L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176318Inst : IEnumerable<long>
{
public static readonly long[] Value=A176318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176318.Bytes);
public long this[int i]=>Value[i];

public static A176318Inst Instance=new A176318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176319
{
public static readonly long[] Value={ 5L,2L,3L,8L,6L,1L,2L,7L,8L,7L,5L,2L,5L,8L,3L,0L,5L,6L,7L,2L,8L,4L,8L,4L,8L,9L,1L,4L,0L,0L,4L,0L,1L,0L,6L,6L,9L,7L,6L,3L,7L,2L,3L,4L,7L,4L,9L,8L,9L,9L,1L,6L,2L,7L,1L,1L,3L,4L,4L,7L,2L,2L,4L,8L,6L,6L,2L,4L,6L,6L,3L,8L,5L,6L,1L,3L,6L,1L,3L,6L,6L,9L,0L,0L,4L,2L,9L,2L,1L,8L,0L,8L,1L,9L,3L,5L,3L,1L,2L,8L,8L,2L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176319Inst : IEnumerable<long>
{
public static readonly long[] Value=A176319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176319.Bytes);
public long this[int i]=>Value[i];

public static A176319Inst Instance=new A176319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176320
{
public static readonly long[] Value={ 5L,1L,6L,1L,4L,5L,3L,2L,3L,7L,1L,1L,1L,8L,8L,5L,3L,3L,3L,1L,7L,8L,3L,7L,4L,1L,9L,6L,1L,6L,3L,4L,3L,5L,6L,4L,0L,2L,6L,1L,2L,2L,4L,9L,5L,0L,7L,2L,9L,2L,3L,7L,7L,7L,8L,8L,7L,2L,8L,0L,6L,2L,7L,4L,3L,4L,3L,7L,3L,2L,4L,2L,0L,9L,7L,9L,3L,9L,0L,4L,8L,7L,1L,4L,1L,0L,9L,3L,7L,1L,8L,5L,7L,0L,9L,7L,3L,1L,9L,8L,9L,5L,9L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176320Inst : IEnumerable<long>
{
public static readonly long[] Value=A176320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176320.Bytes);
public long this[int i]=>Value[i];

public static A176320Inst Instance=new A176320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176321
{
public static readonly long[] Value={ 5L,1L,3L,8L,9L,9L,3L,3L,1L,4L,5L,5L,8L,7L,3L,7L,9L,9L,9L,4L,0L,2L,5L,4L,3L,6L,8L,5L,6L,9L,9L,7L,9L,5L,8L,6L,1L,1L,7L,9L,7L,1L,2L,4L,4L,4L,5L,1L,2L,2L,5L,4L,1L,9L,6L,1L,7L,0L,7L,6L,0L,1L,3L,4L,8L,9L,2L,3L,3L,2L,9L,0L,4L,8L,0L,3L,6L,8L,5L,3L,3L,5L,8L,6L,3L,5L,9L,3L,1L,4L,7L,1L,8L,1L,7L,6L,0L,9L,2L,1L,7L,0L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176321Inst : IEnumerable<long>
{
public static readonly long[] Value=A176321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176321.Bytes);
public long this[int i]=>Value[i];

public static A176321Inst Instance=new A176321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176322
{
public static readonly long[] Value={ 3L,6L,9L,4L,5L,9L,0L,6L,4L,0L,3L,8L,2L,2L,3L,3L,1L,9L,9L,1L,6L,3L,5L,6L,1L,1L,5L,9L,9L,7L,9L,7L,1L,4L,2L,0L,5L,6L,5L,1L,5L,9L,7L,4L,2L,2L,3L,1L,7L,1L,5L,5L,8L,7L,4L,6L,3L,9L,0L,6L,4L,1L,8L,8L,8L,4L,9L,2L,6L,6L,0L,6L,6L,7L,2L,5L,1L,5L,9L,4L,7L,0L,2L,0L,9L,0L,3L,0L,4L,0L,6L,0L,5L,4L,4L,6L,5L,2L,9L,0L,3L,8L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176322Inst : IEnumerable<long>
{
public static readonly long[] Value=A176322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176322.Bytes);
public long this[int i]=>Value[i];

public static A176322Inst Instance=new A176322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176323
{
public static readonly long[] Value={ 5L,1L,2L,2L,0L,2L,2L,1L,2L,0L,4L,2L,5L,3L,7L,8L,8L,6L,7L,4L,7L,8L,6L,3L,3L,7L,8L,4L,1L,9L,9L,8L,4L,3L,9L,9L,6L,1L,8L,8L,1L,7L,9L,6L,4L,4L,2L,0L,3L,7L,5L,9L,9L,6L,2L,1L,8L,9L,3L,8L,9L,4L,0L,8L,9L,5L,0L,0L,1L,4L,8L,1L,3L,7L,5L,2L,7L,5L,1L,7L,2L,8L,5L,4L,8L,4L,6L,3L,2L,2L,2L,3L,3L,2L,9L,8L,6L,0L,4L,4L,5L,0L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176323Inst : IEnumerable<long>
{
public static readonly long[] Value=A176323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176323.Bytes);
public long this[int i]=>Value[i];

public static A176323Inst Instance=new A176323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176324
{
public static readonly long[] Value={ 5L,1L,0L,8L,7L,4L,5L,9L,7L,3L,7L,4L,9L,7L,5L,4L,6L,4L,5L,8L,1L,0L,7L,0L,2L,6L,1L,3L,5L,1L,9L,8L,2L,2L,2L,7L,4L,6L,8L,0L,7L,2L,1L,4L,1L,9L,5L,4L,6L,7L,8L,0L,0L,1L,1L,6L,4L,9L,3L,8L,0L,1L,1L,9L,6L,4L,5L,6L,0L,7L,7L,4L,6L,5L,7L,7L,4L,3L,9L,0L,4L,9L,3L,1L,6L,8L,1L,6L,8L,0L,9L,7L,7L,5L,2L,4L,5L,9L,8L,7L,4L,6L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176324Inst : IEnumerable<long>
{
public static readonly long[] Value=A176324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176324.Bytes);
public long this[int i]=>Value[i];

public static A176324Inst Instance=new A176324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176325
{
public static readonly long[] Value={ 5L,0L,9L,8L,0L,7L,6L,2L,1L,1L,3L,5L,3L,3L,1L,5L,9L,4L,0L,2L,9L,1L,1L,6L,9L,5L,1L,2L,2L,5L,8L,8L,0L,8L,5L,5L,0L,4L,1L,4L,2L,0L,7L,8L,8L,0L,7L,1L,5L,5L,7L,0L,9L,4L,2L,0L,8L,3L,7L,1L,0L,4L,6L,9L,1L,7L,7L,8L,9L,9L,5L,2L,5L,3L,6L,3L,2L,0L,0L,0L,5L,5L,6L,2L,1L,7L,1L,9L,2L,8L,0L,1L,3L,5L,8L,7L,2L,8L,6L,3L,5L,1L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176325Inst : IEnumerable<long>
{
public static readonly long[] Value=A176325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176325.Bytes);
public long this[int i]=>Value[i];

public static A176325Inst Instance=new A176325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176326
{
public static readonly long[] Value={ 7L,9L,11L,6L,11L,8L,5L,13L,5L,4L,15L,2L,3L,17L,-1L,2L,19L,-4L,1L,21L,-7L,0L,23L,-10L,-1L,25L,-13L,-2L,27L,-16L,-3L,29L,-19L,-4L,31L,-22L,-5L,33L,-25L,-6L,35L,-28L,-7L,37L,-31L,-8L,39L,-34L,-9L,41L,-37L,-10L,43L,-40L,-11L,45L,-43L,-12L,47L,-46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176326Inst : IEnumerable<long>
{
public static readonly long[] Value=A176326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176326.Bytes);
public long this[int i]=>Value[i];

public static A176326Inst Instance=new A176326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176327
{
public static readonly BigInteger[] Value={ 1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,5L,0L,-691L,0L,7L,0L,-3617L,0L,43867L,0L,-174611L,0L,854513L,0L,-236364091L,0L,8553103L,0L,-23749461029L,0L,8615841276005L,0L,-7709321041217L,0L,2577687858367L,0L,BigInteger.Parse("-26315271553053477373"),0L,2929993913841559L,0L,BigInteger.Parse("-261082718496449122051") };
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
public class A176327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176327Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176327.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176327.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176327Inst Instance=new A176327Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176328
{
public static readonly long[] Value={ 1L,-1L,7L,-3L,59L,-5L,127L,-7L,119L,-9L,335L,-11L,15689L,-13L,49L,-15L,463L,-17L,51049L,-19L,-171311L,-21L,856031L,-23L,-236331331L,-25L,8553181L,-27L,-23749448849L,-29L,8615841490835L,-31L,-7709321033057L,-33L,2577687858469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176328Inst : IEnumerable<long>
{
public static readonly long[] Value=A176328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176328.Bytes);
public long this[int i]=>Value[i];

public static A176328Inst Instance=new A176328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176329
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176329Inst : IEnumerable<long>
{
public static readonly long[] Value=A176329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176329.Bytes);
public long this[int i]=>Value[i];

public static A176329Inst Instance=new A176329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176330
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176330Inst : IEnumerable<long>
{
public static readonly long[] Value=A176330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176330.Bytes);
public long this[int i]=>Value[i];

public static A176330Inst Instance=new A176330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176331
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,7L,1L,1L,13L,28L,13L,1L,1L,21L,79L,79L,21L,1L,1L,31L,181L,315L,181L,31L,1L,1L,43L,361L,971L,971L,361L,43L,1L,1L,57L,652L,2511L,3876L,2511L,652L,57L,1L,1L,73L,1093L,5713L,12606L,12606L,5713L,1093L,73L,1L,1L,91L,1729L,11789L,35246L,50358L,35246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176331Inst : IEnumerable<long>
{
public static readonly long[] Value=A176331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176331.Bytes);
public long this[int i]=>Value[i];

public static A176331Inst Instance=new A176331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176332
{
public static readonly long[] Value={ 1L,2L,5L,16L,56L,202L,741L,2752L,10318L,38972L,148070L,565280L,2166646L,8332378L,32136205L,124249856L,481433286L,1868972828L,7267804550L,28304698336L,110383060776L,431000853028L,1684754608210L,6592277745536L,25818887839956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176332Inst : IEnumerable<long>
{
public static readonly long[] Value=A176332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176332.Bytes);
public long this[int i]=>Value[i];

public static A176332Inst Instance=new A176332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176333
{
public static readonly long[] Value={ 1L,1L,-5L,-29L,-71L,-23L,547L,2395L,4657L,-2927L,-53621L,-188141L,-269975L,613369L,4883251L,14012683L,12101473L,-77708255L,-419746277L,-979610813L,-140726759L,8253590281L,34280901955L,62841295291L,-57162936431L,-794223403343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176333Inst : IEnumerable<long>
{
public static readonly long[] Value=A176333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176333.Bytes);
public long this[int i]=>Value[i];

public static A176333Inst Instance=new A176333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176334
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,51L,124L,305L,755L,1879L,4698L,11792L,29694L,74984L,189811L,481498L,1223713L,3115200L,7942134L,20275362L,51823246L,132604193L,339644739L,870745187L,2234208932L,5737129623L,14742751524L,37909928908L,97543380598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176334Inst : IEnumerable<long>
{
public static readonly long[] Value=A176334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176334.Bytes);
public long this[int i]=>Value[i];

public static A176334Inst Instance=new A176334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176335
{
public static readonly long[] Value={ 1L,3L,28L,315L,3876L,50358L,678112L,9365499L,131809060L,1882294128L,27193657008L,396600597198L,5829739893264L,86262567856650L,1283677784658528L,19196304797150715L,288295493121264420L,4346056823245242420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176335Inst : IEnumerable<long>
{
public static readonly long[] Value=A176335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176335.Bytes);
public long this[int i]=>Value[i];

public static A176335Inst Instance=new A176335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176336
{
public static readonly long[] Value={ 1L,2L,5L,12L,33L,64L,237L,364L,1309L,2912L,7989L,10036L,80757L,88948L,226889L,732996L,2313981L,2445052L,19491205L,20015492L,114457609L,188499788L,270028737L,278417344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176336Inst : IEnumerable<long>
{
public static readonly long[] Value=A176336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176336.Bytes);
public long this[int i]=>Value[i];

public static A176336Inst Instance=new A176336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176337
{
public static readonly BigInteger[] Value={ 0L,1L,-2L,15L,-224L,6945L,-437534L,55566819L,-14169538844L,7240634349285L,-7407168939318554L,15162474818785080039UL,BigInteger.Parse("-62090334382924902759704"),BigInteger.Parse("508581928930537878504735465"),BigInteger.Parse("-8332097741669002063543081123094") };
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
public class A176337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176337.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176337Inst Instance=new A176337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176338
{
public static readonly BigInteger[] Value={ 0L,1L,-7L,183L,-14639L,3542639L,-2579041191L,5637784043527L,-36983863325537119L,BigInteger.Parse("727916397973221576159"),BigInteger.Parse("-42982007467522787629036631"),BigInteger.Parse("7614090694841791737333323035127"),BigInteger.Parse("-4046432358866721800888421193787892879") };
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
public class A176338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176338Inst Instance=new A176338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176339
{
public static readonly long[] Value={ 1L,1L,1L,1L,-3L,1L,1L,17L,17L,1L,1L,-239L,-219L,-239L,1L,1L,7169L,6933L,6933L,7169L,1L,1L,-444479L,-437307L,-437563L,-437307L,-444479L,1L,1L,56004353L,55559877L,55567029L,55567029L,55559877L,56004353L,1L,1L,-14225105663L,-14169101307L,-14169545803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176339Inst : IEnumerable<long>
{
public static readonly long[] Value=A176339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176339.Bytes);
public long this[int i]=>Value[i];

public static A176339Inst Instance=new A176339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176340
{
public static readonly long[] Value={ 1L,1L,1L,1L,-8L,1L,1L,190L,190L,1L,1L,-14822L,-14624L,-14822L,1L,1L,3557278L,3542464L,3542464L,3557278L,1L,1L,-2582583830L,-2579026544L,-2579041556L,-2579026544L,-2582583830L,1L,1L,5640363084718L,5637780500896L,5637784057984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176340Inst : IEnumerable<long>
{
public static readonly long[] Value=A176340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176340.Bytes);
public long this[int i]=>Value[i];

public static A176340Inst Instance=new A176340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176341
{
public static readonly long[] Value={ 32L,1L,6L,0L,2L,4L,7L,13L,11L,5L,49L,94L,148L,110L,1L,3L,40L,95L,424L,37L,53L,93L,135L,16L,292L,89L,6L,28L,33L,186L,64L,0L,15L,24L,86L,9L,285L,46L,17L,43L,70L,2L,92L,23L,59L,60L,19L,119L,87L,57L,31L,48L,172L,8L,191L,130L,210L,404L,10L,4L,127L,219L,20L,312L,22L,7L,117L,98L,605L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176341Inst : IEnumerable<long>
{
public static readonly long[] Value=A176341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176341.Bytes);
public long this[int i]=>Value[i];

public static A176341Inst Instance=new A176341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176342
{
public static readonly long[] Value={ 1L,1L,2L,4L,2L,6L,4L,4L,10L,4L,12L,6L,8L,16L,6L,18L,8L,12L,10L,22L,12L,18L,12L,28L,30L,16L,20L,16L,24L,36L,18L,24L,40L,42L,20L,24L,22L,46L,16L,20L,32L,24L,52L,40L,36L,28L,58L,16L,60L,30L,36L,48L,66L,32L,44L,70L,24L,72L,36L,40L,36L,60L,78L,32L,40L,82L,24L,64L,42L,56L,88L,24L,72L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176342Inst : IEnumerable<long>
{
public static readonly long[] Value=A176342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176342.Bytes);
public long this[int i]=>Value[i];

public static A176342Inst Instance=new A176342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176343
{
public static readonly BigInteger[] Value={ 0L,1L,2L,5L,16L,81L,649L,8438L,177199L,6024767L,331362186L,29491234555L,4246737775921L,989489901789594L,373037692974676939L,BigInteger.Parse("227552992714552932791"),BigInteger.Parse("224594803809263744664718"),BigInteger.Parse("358677901683394200229554647") };
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
public class A176343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176343Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176343.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176343.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176343Inst Instance=new A176343Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176344
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,11L,13L,11L,1L,1L,65L,75L,75L,65L,1L,1L,568L,632L,640L,632L,568L,1L,1L,7789L,8356L,8418L,8418L,8356L,7789L,1L,1L,168761L,176549L,177114L,177168L,177114L,176549L,168761L,1L,1L,5847568L,6016328L,6024114L,6024671L,6024671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176344Inst : IEnumerable<long>
{
public static readonly long[] Value=A176344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176344.Bytes);
public long this[int i]=>Value[i];

public static A176344Inst Instance=new A176344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176345
{
public static readonly long[] Value={ 1L,3L,5L,6L,9L,15L,13L,12L,15L,27L,21L,30L,25L,39L,45L,24L,33L,45L,37L,54L,65L,63L,45L,60L,45L,75L,45L,78L,57L,135L,61L,48L,105L,99L,117L,90L,73L,111L,125L,108L,81L,195L,85L,126L,135L,135L,93L,120L,91L,135L,165L,150L,105L,135L,189L,156L,185L,171L,117L,270L,121L,183L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176345Inst : IEnumerable<long>
{
public static readonly long[] Value=A176345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176345.Bytes);
public long this[int i]=>Value[i];

public static A176345Inst Instance=new A176345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176346
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,2L,2L,1L,1L,3L,5L,3L,1L,1L,2L,3L,3L,2L,1L,1L,3L,4L,7L,4L,3L,1L,1L,2L,5L,4L,4L,5L,2L,1L,1L,3L,3L,5L,9L,5L,3L,3L,1L,1L,2L,4L,6L,5L,5L,6L,4L,2L,1L,1L,3L,5L,7L,6L,11L,6L,7L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176346Inst : IEnumerable<long>
{
public static readonly long[] Value=A176346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176346.Bytes);
public long this[int i]=>Value[i];

public static A176346Inst Instance=new A176346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176347
{
public static readonly long[] Value={ 0L,1L,3L,3L,5L,7L,11L,9L,15L,11L,19L,15L,23L,17L,23L,21L,35L,31L,39L,35L,27L,29L,47L,43L,35L,59L,39L,63L,41L,55L,71L,59L,45L,71L,51L,71L,87L,57L,95L,99L,59L,79L,83L,107L,65L,91L,69L,119L,111L,71L,119L,77L,103L,131L,81L,143L,115L,87L,119L,143L,159L,95L,131L,99L,167L,159L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176347Inst : IEnumerable<long>
{
public static readonly long[] Value=A176347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176347.Bytes);
public long this[int i]=>Value[i];

public static A176347Inst Instance=new A176347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176348
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,6L,6L,1L,1L,12L,30L,12L,1L,1L,10L,30L,30L,10L,1L,1L,18L,60L,140L,60L,18L,1L,1L,14L,105L,140L,140L,105L,14L,1L,1L,24L,84L,280L,630L,280L,84L,24L,1L,1L,18L,144L,504L,630L,630L,504L,144L,18L,1L,1L,30L,225L,840L,1260L,2772L,1260L,840L,225L,30L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176348Inst : IEnumerable<long>
{
public static readonly long[] Value=A176348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176348.Bytes);
public long this[int i]=>Value[i];

public static A176348Inst Instance=new A176348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176349
{
public static readonly BigInteger[] Value={ 1L,31L,28861L,24988748491L,BigInteger.Parse("18733126534418632060921"),BigInteger.Parse("10527900892636182836790613691868303334293108151"),BigInteger.Parse("3325100916155092061227521396285672007717003791068669733032713344074584207918598201019772272181") };
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
public class A176349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176349Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176349.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176349.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176349Inst Instance=new A176349Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176350
{
public static readonly long[] Value={ 6858L,22625L,28375L,40472L,48248L,49624L,58374L,59750L,94471L,102248L,103624L,107702L,112374L,122823L,129623L,133623L,136214L,136375L,153063L,164295L,187623L,190375L,197910L,199624L,210248L,211624L,220374L,221750L,238248L,246616L,260874L,264248L,275750L,280231L,298375L,300806L,312471L,329623L,336824L,346086L,349623L,352375L,356375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176350Inst : IEnumerable<long>
{
public static readonly long[] Value=A176350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176350.Bytes);
public long this[int i]=>Value[i];

public static A176350Inst Instance=new A176350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176351
{
public static readonly long[] Value={ 4L,180L,320L,5480L,12096L,17720L,82780L,1175232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176351Inst : IEnumerable<long>
{
public static readonly long[] Value=A176351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176351.Bytes);
public long this[int i]=>Value[i];

public static A176351Inst Instance=new A176351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176352
{
public static readonly long[] Value={ 1L,2L,6L,3L,12L,4L,20L,5L,30L,45L,9L,15L,10L,25L,175L,70L,42L,7L,56L,8L,28L,21L,49L,14L,126L,168L,210L,90L,72L,16L,160L,60L,50L,225L,270L,27L,297L,33L,88L,11L,132L,231L,165L,264L,24L,54L,63L,36L,120L,75L,105L,189L,84L,462L,396L,108L,1404L,117L,65L,910L,273L,1001L,182L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176352Inst : IEnumerable<long>
{
public static readonly long[] Value=A176352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176352.Bytes);
public long this[int i]=>Value[i];

public static A176352Inst Instance=new A176352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176353
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,3L,3L,3L,1L,1L,3L,3L,3L,3L,1L,1L,3L,4L,4L,4L,3L,1L,1L,3L,4L,5L,5L,4L,3L,1L,1L,3L,4L,5L,5L,5L,4L,3L,1L,1L,3L,5L,6L,6L,6L,6L,5L,3L,1L,1L,3L,5L,6L,6L,7L,6L,6L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176353Inst : IEnumerable<long>
{
public static readonly long[] Value=A176353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176353.Bytes);
public long this[int i]=>Value[i];

public static A176353Inst Instance=new A176353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176354
{
public static readonly long[] Value={ 1L,1L,3L,9L,17L,46L,153L,338L,935L,3067L,7182L,20064L,64819L,156968L,441084L,1408612L,3488489L,9840608L,31145791L,78388512L,221722954L,696757333L,1775204952L,5031253931L,15718503073L,40435757688L,114779701466L,356852697226L,925209496348L,2629513384131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176354Inst : IEnumerable<long>
{
public static readonly long[] Value=A176354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176354.Bytes);
public long this[int i]=>Value[i];

public static A176354Inst Instance=new A176354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176355
{
public static readonly long[] Value={ 6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176355Inst : IEnumerable<long>
{
public static readonly long[] Value=A176355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176355.Bytes);
public long this[int i]=>Value[i];

public static A176355Inst Instance=new A176355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176356
{
public static readonly long[] Value={ 1L,2L,5L,10L,11L,20L,50L,100L,101L,110L,115L,118L,121L,125L,152L,158L,181L,185L,188L,200L,500L,1000L,1010L,1012L,1018L,1022L,1028L,1051L,1081L,1082L,1085L,1100L,1102L,1105L,1108L,1115L,1118L,1121L,1150L,1180L,1181L,1201L,1202L,1210L,1211L,1225L,1250L,1255L,1282L,1285L,1501L,1502L,1520L,1522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176356Inst : IEnumerable<long>
{
public static readonly long[] Value=A176356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176356.Bytes);
public long this[int i]=>Value[i];

public static A176356Inst Instance=new A176356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176357
{
public static readonly long[] Value={ 1L,127L,4054L,37210L,134325L,776241L,1313848L,5536128L,7280823L,28243653L,32246894L,74873810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176357Inst : IEnumerable<long>
{
public static readonly long[] Value=A176357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176357.Bytes);
public long this[int i]=>Value[i];

public static A176357Inst Instance=new A176357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176358
{
public static readonly long[] Value={ 5L,19L,46L,87L,131L,196L,272L,362L,471L,596L,735L,887L,1042L,1211L,1397L,1586L,1789L,1997L,2206L,2425L,2652L,2882L,3119L,3384L,3659L,3957L,4264L,4575L,4889L,5210L,5534L,5863L,6207L,6584L,6997L,7416L,7844L,8278L,8717L,9158L,9607L,10065L,10524L,10991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176358Inst : IEnumerable<long>
{
public static readonly long[] Value=A176358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176358.Bytes);
public long this[int i]=>Value[i];

public static A176358Inst Instance=new A176358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176359
{
public static readonly long[] Value={ 27000L,74088L,189000L,287496L,297000L,343000L,351000L,370440L,459000L,474552L,513000L,621000L,783000L,814968L,837000L,963144L,999000L,1029000L,1061208L,1107000L,1157625L,1161000L,1259496L,1269000L,1323000L,1331000L,1407672L,1431000L,1437480L,1481544L,1593000L,1647000L,1704024L,1809000L,1852200L,1917000L,1971000L,2012472L,2079000L,2133000L,2148552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176359Inst : IEnumerable<long>
{
public static readonly long[] Value=A176359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176359.Bytes);
public long this[int i]=>Value[i];

public static A176359Inst Instance=new A176359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176360
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,1L,2L,2L,3L,4L,4L,1L,1L,2L,3L,3L,4L,1L,1L,2L,3L,3L,4L,4L,1L,2L,2L,3L,4L,4L,1L,2L,2L,3L,3L,4L,1L,1L,2L,3L,3L,4L,1L,1L,2L,2L,3L,4L,4L,1L,2L,2L,3L,4L,4L,1L,1L,2L,3L,3L,4L,1L,1L,2L,3L,3L,4L,4L,1L,2L,2L,3L,4L,4L,1L,2L,2L,3L,3L,4L,1L,1L,2L,3L,3L,4L,1L,1L,2L,2L,3L,4L,4L,1L,2L,2L,3L,4L,4L,1L,1L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176360Inst : IEnumerable<long>
{
public static readonly long[] Value=A176360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176360.Bytes);
public long this[int i]=>Value[i];

public static A176360Inst Instance=new A176360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176361
{
public static readonly long[] Value={ 1L,1L,4L,13L,33L,97L,273L,709L,1866L,5120L,13036L,33582L,87333L,219269L,555681L,1413270L,3488571L,8687949L,21624643L,52958400L,130132799L,319007916L,773803200L,1877699413L,4549855097L,10950145994L,26310132088L,63155284600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176361Inst : IEnumerable<long>
{
public static readonly long[] Value=A176361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176361.Bytes);
public long this[int i]=>Value[i];

public static A176361Inst Instance=new A176361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176362
{
public static readonly long[] Value={ 1L,7L,28L,63L,186L,508L,1016L,2047L,6643L,12282L,24564L,65532L,114674L,262136L,786408L,1048575L,2359278L,6815731L,10485740L,25165818L,67108832L,100663284L,201326568L,536870908L,1040187361L,1879048178L,5368709080L,8589934584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176362Inst : IEnumerable<long>
{
public static readonly long[] Value=A176362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176362.Bytes);
public long this[int i]=>Value[i];

public static A176362Inst Instance=new A176362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176363
{
public static readonly long[] Value={ 1L,2L,3L,7L,11L,12L,17L,18L,19L,24L,27L,28L,29L,30L,36L,37L,42L,43L,44L,45L,47L,48L,54L,56L,61L,63L,64L,66L,67L,68L,71L,72L,75L,78L,79L,80L,83L,89L,90L,92L,97L,98L,100L,101L,102L,104L,105L,107L,108L,110L,112L,114L,116L,117L,120L,125L,126L,131L,132L,135L,137L,144L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176363Inst : IEnumerable<long>
{
public static readonly long[] Value=A176363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176363.Bytes);
public long this[int i]=>Value[i];

public static A176363Inst Instance=new A176363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176364
{
public static readonly BigInteger[] Value={ 0L,226153980L,798920165762330040L,BigInteger.Parse("2822295814832482312327709940"),BigInteger.Parse("9970149719303180503641083029374964080"),BigInteger.Parse("35220930741174421456911021812718768924061809900") };
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
public class A176364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176364Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176364.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176364.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176364Inst Instance=new A176364Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176365
{
public static readonly BigInteger[] Value={ 1L,1L,11L,151L,15619L,655177L,27085381L,2330931341L,12157712239L,37307713155613L,339781108897078469L,BigInteger.Parse("75489558096433522049"),BigInteger.Parse("11482547005345338463969"),BigInteger.Parse("3607856726470666022715979"),BigInteger.Parse("18497593486903125823791655511"),BigInteger.Parse("520679973964725199436393399689") };
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
public class A176365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176365Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176365.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176365Inst Instance=new A176365Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176366
{
public static readonly BigInteger[] Value={ 2L,3L,40L,630L,72576L,3326400L,148262400L,13621608000L,75277762560L,243290200817664L,2322315553259520000L,BigInteger.Parse("538583682060103680000"),BigInteger.Parse("85226428809510912000000"),BigInteger.Parse("27777728189842735104000000"),BigInteger.Parse("147362699895661699242393600000"),BigInteger.Parse("4282728465717668134232064000000") };
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
public class A176366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176366Inst Instance=new A176366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176367
{
public static readonly BigInteger[] Value={ 0L,8L,1008L,127000L,16000992L,2015997992L,253999746000L,32001951998008L,4031991952003008L,507998984000381000L,BigInteger.Parse("64003839992096002992"),BigInteger.Parse("8063975840020095995992"),BigInteger.Parse("1015996952002539999492000") };
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
public class A176367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176367Inst Instance=new A176367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176368
{
public static readonly BigInteger[] Value={ 1L,129L,33281L,8586369L,2215249921L,571525893249L,147451465208321L,38041906497853569L,9814664424981012481UL,BigInteger.Parse("2532145379738603366529"),BigInteger.Parse("653283693308134687552001"),BigInteger.Parse("168544660728119010785049729") };
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
public class A176368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176368Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176368.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176368Inst Instance=new A176368Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176369
{
public static readonly BigInteger[] Value={ 0L,16L,4128L,1065008L,274767936L,70889062480L,18289103351904L,4718517775728752L,1217359297034666112L,BigInteger.Parse("314073980117168128144"),BigInteger.Parse("81029869510932342395040"),BigInteger.Parse("20905392259840427169792176") };
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
public class A176369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176369Inst Instance=new A176369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176370
{
public static readonly BigInteger[] Value={ 1L,65L,8449L,1098305L,142771201L,18559157825L,2412547746049L,313612647828545L,40767231669964801L,5299426504447595585L,BigInteger.Parse("688884678346517461249"),BigInteger.Parse("89549708758542822366785"),BigInteger.Parse("11640773253932220390220801") };
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
public class A176370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176370Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176370.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176370Inst Instance=new A176370Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176371
{
public static readonly long[] Value={ 31L,41L,71L,83L,281L,311L,431L,479L,733L,751L,797L,2011L,2857L,3163L,4373L,4397L,4943L,7541L,7577L,7583L,9413L,9491L,20533L,20731L,20771L,24151L,24547L,24767L,26249L,28979L,31121L,41201L,41609L,43321L,43391L,43753L,45641L,49459L,49463L,49811L,49891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176371Inst : IEnumerable<long>
{
public static readonly long[] Value=A176371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176371.Bytes);
public long this[int i]=>Value[i];

public static A176371Inst Instance=new A176371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176372
{
public static readonly BigInteger[] Value={ 0L,8L,1040L,135192L,17573920L,2284474408L,296964099120L,38603048411192L,5018099329355840L,652314309767848008L,BigInteger.Parse("84795842170490885200"),BigInteger.Parse("11022807167854047227992"),BigInteger.Parse("1432880135978855648753760") };
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
public class A176372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176372Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176372.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176372.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176372Inst Instance=new A176372Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176373
{
public static readonly BigInteger[] Value={ 1L,48842L,4771081927L,466058366908226L,BigInteger.Parse("45526445508292066657"),BigInteger.Parse("4447205302565943872414162"),BigInteger.Parse("434420802730325215724612934151"),BigInteger.Parse("42435961689461883070277145987192122"),BigInteger.Parse("4145314481238973783106627512888262311297") };
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
public class A176373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176373Inst Instance=new A176373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176374
{
public static readonly BigInteger[] Value={ 0L,5967L,582880428L,56938091722785L,5561940551265649512L,BigInteger.Parse("543312600752895615207423"),BigInteger.Parse("53072948086383914724656258820"),BigInteger.Parse("5184377860327013725210426371365457"),BigInteger.Parse("506430766855111060647071374935807042768") };
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
public class A176374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176374Inst Instance=new A176374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176375
{
public static readonly BigInteger[] Value={ 1L,7775L,120901249L,1880014414175L,29234224019520001L,BigInteger.Parse("454592181623521601375"),BigInteger.Parse("7068908395011536881861249"),BigInteger.Parse("109921525087837216889420820575"),BigInteger.Parse("1709279708046960327618956878080001") };
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
public class A176375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176375Inst Instance=new A176375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176376
{
public static readonly BigInteger[] Value={ 0L,936L,14554800L,226327139064L,3519386997890400L,BigInteger.Parse("54726467590868580936"),BigInteger.Parse("850996567518619435664400"),BigInteger.Parse("13232996570188064633712839064") };
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
public class A176376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176376Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176376.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176376.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176376Inst Instance=new A176376Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176377
{
public static readonly BigInteger[] Value={ 1L,251L,126001L,63252251L,31752504001L,15939693756251L,8001694513134001L,4016834705899512251L,BigInteger.Parse("2016443020667042016001"),BigInteger.Parse("1012250379540149192520251"),BigInteger.Parse("508147674086134227603150001"),BigInteger.Parse("255089120140859842107588780251") };
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
public class A176377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176377.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176377Inst Instance=new A176377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176378
{
public static readonly BigInteger[] Value={ 0L,30L,15060L,7560090L,3795150120L,1905157800150L,956385420525180L,480103575945840210L,BigInteger.Parse("241011038739391260240"),BigInteger.Parse("120987061343598466800270"),BigInteger.Parse("60735263783447690942475300"),BigInteger.Parse("30488981432229397254655800330") };
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
public class A176378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176378.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176378Inst Instance=new A176378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176379
{
public static readonly long[] Value={ 2L,7L,2L,31L,2L,7L,11L,7L,19L,5L,5L,19L,2L,13L,13L,61L,11L,17L,61L,5L,5L,7L,139L,5L,19L,2L,103L,29L,7L,2L,109L,7L,59L,31L,41L,5L,5L,127L,13L,31L,5L,109L,2L,7L,41L,11L,2L,7L,101L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176379Inst : IEnumerable<long>
{
public static readonly long[] Value=A176379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176379.Bytes);
public long this[int i]=>Value[i];

public static A176379Inst Instance=new A176379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176380
{
public static readonly BigInteger[] Value={ 1L,3480L,24220799L,168576757560L,1173294208396801L,8166127521864977400L,BigInteger.Parse("56836246378886034307199"),BigInteger.Parse("395580266630919276913127640"),BigInteger.Parse("2753238598914951788429334067201") };
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
public class A176380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176380.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176380Inst Instance=new A176380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176381
{
public static readonly BigInteger[] Value={ 0L,413L,2874480L,20006380387L,139244404619040L,969141036142138013L,BigInteger.Parse("6745221472304875951440"),BigInteger.Parse("46946740478100900479884387"),BigInteger.Parse("326749306982360795035119382080") };
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
public class A176381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176381.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176381Inst Instance=new A176381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176382
{
public static readonly BigInteger[] Value={ 1L,2281249L,10408194000001L,BigInteger.Parse("47487364308614281249"),BigInteger.Parse("216661004683313632776000001"),BigInteger.Parse("988515400545561595548925838281249"),BigInteger.Parse("4510099537958107027564099725673746000001") };
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
public class A176382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176382Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176382.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176382.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176382Inst Instance=new A176382Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176383
{
public static readonly long[] Value={ 2L,2L,3L,8L,3L,8L,3L,5L,16L,9L,5L,16L,9L,5L,7L,128L,9L,5L,7L,128L,81L,5L,7L,256L,81L,25L,7L,256L,81L,25L,7L,11L,1024L,243L,25L,7L,11L,1024L,243L,25L,7L,11L,13L,2048L,243L,25L,49L,11L,13L,2048L,729L,125L,49L,11L,13L,32768L,729L,125L,49L,11L,13L,32768L,729L,125L,49L,11L,13L,17L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176383Inst : IEnumerable<long>
{
public static readonly long[] Value=A176383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176383.Bytes);
public long this[int i]=>Value[i];

public static A176383Inst Instance=new A176383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176384
{
public static readonly BigInteger[] Value={ 0L,267000L,1218186966000L,5557975596000801000L,BigInteger.Parse("25358252540801244373932000"),BigInteger.Parse("115696976500895037877980001335000"),BigInteger.Parse("527867223891355250275667198886560898000") };
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
public class A176384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176384.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176384Inst Instance=new A176384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176385
{
public static readonly long[] Value={ 4L,2L,6L,56L,32L,97L,6L,95L,176L,4L,32L,309L,68L,68L,194L,616L,175L,96L,1540L,4L,816L,14L,1540L,95L,840L,32L,5L,437L,50L,10336L,95L,5L,995L,976L,175L,14L,40L,570L,1976L,995L,1400L,294L,1994L,176L,544L,507L,328L,392L,77L,11020L,18905L,18050L,9995L,779L,4L,805L,669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176385Inst : IEnumerable<long>
{
public static readonly long[] Value=A176385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176385.Bytes);
public long this[int i]=>Value[i];

public static A176385Inst Instance=new A176385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176386
{
public static readonly BigInteger[] Value={ 1L,3699L,27365201L,202447753299L,1497708451540801L,11080046922051092499UL,BigInteger.Parse("81970185631625530766801"),BigInteger.Parse("606415422222718754561701299"),BigInteger.Parse("4486261211633487714621935443201") };
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
public class A176386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176386Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176386.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176386.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176386Inst Instance=new A176386Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176387
{
public static readonly BigInteger[] Value={ 0L,430L,3181140L,23534073290L,174105071018280L,1288029291859162150L,BigInteger.Parse("9528840527069010567420"),BigInteger.Parse("70494360931227248318611010"),BigInteger.Parse("521517272640378655992073684560") };
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
public class A176387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176387Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176387.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176387.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176387Inst Instance=new A176387Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176388
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,3L,5L,3L,1L,1L,11L,21L,21L,11L,1L,1L,6L,13L,16L,13L,6L,1L,1L,34L,76L,106L,106L,76L,34L,1L,1L,15L,33L,50L,56L,50L,33L,15L,1L,1L,112L,258L,402L,493L,493L,402L,258L,112L,1L,1L,40L,91L,146L,188L,204L,188L,146L,91L,40L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176388Inst : IEnumerable<long>
{
public static readonly long[] Value=A176388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176388.Bytes);
public long this[int i]=>Value[i];

public static A176388Inst Instance=new A176388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176389
{
public static readonly long[] Value={ 2L,2L,2L,1L,0L,1L,4L,-12L,-12L,4L,791L,0L,-120L,0L,791L,6L,16260L,-280L,-280L,16260L,6L,-41312053L,0L,364560L,0L,364560L,0L,-41312053L,8L,-3163111000L,-5544L,7035000L,7035000L,-5544L,-3163111000L,8L,383801047294219L,0L,-343384323744L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176389Inst : IEnumerable<long>
{
public static readonly long[] Value=A176389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176389.Bytes);
public long this[int i]=>Value[i];

public static A176389Inst Instance=new A176389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176390
{
public static readonly long[] Value={ 1L,1L,1L,1L,16L,1L,1L,273L,273L,1L,1L,4856L,6246L,4856L,1L,1L,95065L,134785L,134785L,95065L,1L,1L,2073408L,3094575L,3410240L,3094575L,2073408L,1L,1L,50255905L,77413889L,89782273L,89782273L,77413889L,50255905L,1L,1L,1345053808L,2116602172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176390Inst : IEnumerable<long>
{
public static readonly long[] Value=A176390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176390.Bytes);
public long this[int i]=>Value[i];

public static A176390Inst Instance=new A176390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176391
{
public static readonly long[] Value={ 1L,2L,12L,1396L,5147608L,14289569180818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176391Inst : IEnumerable<long>
{
public static readonly long[] Value=A176391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176391.Bytes);
public long this[int i]=>Value[i];

public static A176391Inst Instance=new A176391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176392
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,55L,55L,1L,1L,561L,609L,561L,1L,1L,7151L,7705L,7705L,7151L,1L,1L,109873L,117017L,117523L,117017L,109873L,1L,1L,1979503L,2089369L,2096465L,2096465L,2089369L,1979503L,1L,1L,40949569L,42929065L,43038883L,43045473L,43038883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176392Inst : IEnumerable<long>
{
public static readonly long[] Value=A176392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176392.Bytes);
public long this[int i]=>Value[i];

public static A176392Inst Instance=new A176392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176393
{
public static readonly long[] Value={ 1L,3L,9L,13L,17L,19L,21L,25L,29L,31L,33L,37L,41L,43L,45L,49L,51L,53L,55L,57L,61L,65L,67L,69L,71L,73L,77L,79L,81L,85L,89L,91L,93L,97L,99L,101L,103L,105L,109L,111L,113L,115L,117L,121L,125L,127L,129L,131L,133L,137L,139L,141L,145L,149L,151L,153L,155L,157L,161L,163L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176393Inst : IEnumerable<long>
{
public static readonly long[] Value=A176393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176393.Bytes);
public long this[int i]=>Value[i];

public static A176393Inst Instance=new A176393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176394
{
public static readonly long[] Value={ 6L,4L,6L,4L,1L,0L,1L,6L,1L,5L,1L,3L,7L,7L,5L,4L,5L,8L,7L,0L,5L,4L,8L,9L,2L,6L,8L,3L,0L,1L,1L,7L,4L,4L,7L,3L,3L,8L,8L,5L,6L,1L,0L,5L,0L,7L,6L,2L,0L,7L,6L,1L,2L,5L,6L,1L,1L,1L,6L,1L,3L,9L,5L,8L,9L,0L,3L,8L,6L,6L,0L,3L,3L,8L,1L,7L,6L,0L,0L,0L,7L,4L,1L,6L,2L,2L,9L,2L,3L,7L,3L,5L,1L,4L,4L,9L,7L,1L,5L,1L,3L,5L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176394Inst : IEnumerable<long>
{
public static readonly long[] Value=A176394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176394.Bytes);
public long this[int i]=>Value[i];

public static A176394Inst Instance=new A176394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176395
{
public static readonly long[] Value={ 6L,3L,1L,6L,6L,2L,4L,7L,9L,0L,3L,5L,5L,3L,9L,9L,8L,4L,9L,1L,1L,4L,9L,3L,2L,7L,3L,6L,6L,7L,0L,6L,8L,6L,6L,8L,3L,9L,2L,7L,0L,8L,8L,5L,4L,5L,5L,8L,9L,3L,5L,3L,5L,9L,7L,0L,5L,8L,6L,8L,2L,1L,4L,6L,1L,1L,6L,4L,8L,4L,6L,4L,2L,6L,0L,9L,0L,4L,3L,8L,4L,6L,7L,0L,8L,8L,4L,3L,3L,9L,9L,1L,2L,8L,2L,9L,0L,6L,5L,0L,9L,0L,7L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176395Inst : IEnumerable<long>
{
public static readonly long[] Value=A176395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176395.Bytes);
public long this[int i]=>Value[i];

public static A176395Inst Instance=new A176395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176396
{
public static readonly long[] Value={ 6L,2L,4L,0L,3L,7L,0L,3L,4L,9L,2L,0L,3L,9L,3L,0L,1L,1L,5L,4L,8L,2L,9L,8L,3L,7L,1L,8L,0L,4L,3L,9L,9L,8L,3L,2L,8L,8L,5L,2L,6L,0L,2L,1L,5L,3L,5L,2L,9L,1L,7L,3L,2L,7L,4L,8L,5L,5L,6L,7L,7L,1L,9L,8L,9L,0L,4L,8L,0L,8L,6L,8L,8L,9L,2L,2L,0L,2L,2L,1L,8L,5L,7L,0L,0L,1L,8L,0L,4L,5L,3L,3L,0L,2L,8L,0L,5L,1L,1L,7L,8L,3L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176396Inst : IEnumerable<long>
{
public static readonly long[] Value=A176396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176396.Bytes);
public long this[int i]=>Value[i];

public static A176396Inst Instance=new A176396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176397
{
public static readonly long[] Value={ 6L,1L,9L,3L,7L,4L,3L,8L,8L,4L,5L,3L,4L,2L,6L,2L,3L,9L,9L,8L,1L,4L,0L,4L,9L,0L,3L,5L,3L,9L,6L,1L,2L,2L,7L,6L,8L,3L,1L,3L,4L,6L,9L,9L,4L,0L,8L,7L,5L,0L,8L,5L,3L,3L,4L,6L,4L,7L,3L,6L,7L,5L,2L,9L,2L,1L,2L,4L,7L,8L,9L,0L,5L,1L,7L,5L,2L,6L,8L,5L,8L,4L,5L,6L,9L,3L,1L,2L,4L,6L,2L,2L,8L,5L,1L,6L,7L,8L,3L,8L,7L,5L,1L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176397Inst : IEnumerable<long>
{
public static readonly long[] Value=A176397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176397.Bytes);
public long this[int i]=>Value[i];

public static A176397Inst Instance=new A176397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176398
{
public static readonly long[] Value={ 6L,1L,6L,2L,2L,7L,7L,6L,6L,0L,1L,6L,8L,3L,7L,9L,3L,3L,1L,9L,9L,8L,8L,9L,3L,5L,4L,4L,4L,3L,2L,7L,1L,8L,5L,3L,3L,7L,1L,9L,5L,5L,5L,1L,3L,9L,3L,2L,5L,2L,1L,6L,8L,2L,6L,8L,5L,7L,5L,0L,4L,8L,5L,2L,7L,9L,2L,5L,9L,4L,4L,3L,8L,6L,3L,9L,2L,3L,8L,2L,2L,1L,3L,4L,4L,2L,4L,8L,1L,0L,8L,3L,7L,9L,3L,0L,0L,2L,9L,5L,1L,8L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176398Inst : IEnumerable<long>
{
public static readonly long[] Value=A176398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176398.Bytes);
public long this[int i]=>Value[i];

public static A176398Inst Instance=new A176398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176399
{
public static readonly long[] Value={ 6L,1L,3L,9L,6L,0L,8L,7L,1L,0L,8L,3L,3L,7L,0L,1L,5L,0L,9L,6L,0L,0L,2L,3L,3L,6L,9L,4L,4L,1L,3L,6L,5L,0L,1L,3L,0L,9L,3L,0L,8L,4L,6L,5L,3L,8L,5L,9L,9L,9L,0L,2L,3L,6L,5L,9L,7L,1L,1L,5L,5L,4L,2L,6L,8L,7L,7L,4L,2L,1L,2L,3L,5L,8L,0L,2L,9L,7L,4L,4L,4L,0L,1L,0L,0L,8L,7L,3L,8L,2L,4L,8L,8L,1L,1L,0L,3L,4L,6L,5L,4L,7L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176399Inst : IEnumerable<long>
{
public static readonly long[] Value=A176399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176399.Bytes);
public long this[int i]=>Value[i];

public static A176399Inst Instance=new A176399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176400
{
public static readonly long[] Value={ 2L,1L,9L,7L,7L,2L,6L,0L,9L,7L,5L,8L,3L,5L,9L,1L,0L,5L,6L,7L,2L,0L,1L,6L,3L,5L,8L,6L,0L,8L,9L,5L,5L,5L,0L,9L,1L,6L,5L,1L,5L,9L,2L,5L,7L,7L,0L,1L,9L,9L,3L,1L,6L,5L,6L,1L,7L,9L,8L,0L,8L,7L,9L,8L,8L,1L,4L,1L,9L,4L,8L,6L,5L,0L,6L,2L,0L,8L,2L,1L,0L,8L,0L,7L,0L,6L,1L,1L,6L,7L,7L,4L,1L,6L,7L,7L,2L,4L,2L,5L,8L,3L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176400Inst : IEnumerable<long>
{
public static readonly long[] Value=A176400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176400.Bytes);
public long this[int i]=>Value[i];

public static A176400Inst Instance=new A176400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176401
{
public static readonly long[] Value={ 6L,1L,2L,2L,4L,9L,8L,9L,9L,9L,1L,9L,9L,1L,9L,9L,1L,0L,2L,9L,2L,3L,4L,4L,6L,5L,6L,0L,4L,6L,9L,8L,9L,7L,2L,3L,0L,5L,3L,6L,4L,7L,9L,9L,8L,8L,9L,9L,5L,8L,2L,8L,1L,5L,4L,2L,2L,6L,4L,8L,5L,9L,6L,5L,3L,0L,4L,8L,0L,5L,6L,0L,0L,2L,9L,1L,7L,5L,7L,2L,5L,0L,3L,1L,6L,6L,6L,8L,0L,5L,6L,1L,1L,0L,6L,7L,0L,2L,9L,3L,5L,5L,3L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176401Inst : IEnumerable<long>
{
public static readonly long[] Value=A176401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176401.Bytes);
public long this[int i]=>Value[i];

public static A176401Inst Instance=new A176401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176402
{
public static readonly long[] Value={ 6L,1L,0L,9L,1L,2L,6L,3L,5L,1L,0L,2L,9L,6L,0L,5L,0L,1L,5L,1L,8L,4L,8L,2L,5L,1L,8L,0L,7L,7L,3L,5L,1L,8L,9L,9L,4L,4L,2L,5L,4L,1L,3L,5L,6L,4L,7L,3L,0L,5L,5L,1L,5L,5L,7L,0L,1L,8L,7L,3L,2L,4L,3L,2L,8L,1L,5L,5L,9L,4L,8L,4L,9L,6L,0L,2L,4L,1L,6L,5L,5L,9L,4L,7L,1L,4L,0L,6L,8L,5L,4L,3L,0L,3L,9L,6L,0L,6L,7L,2L,0L,0L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176402Inst : IEnumerable<long>
{
public static readonly long[] Value=A176402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176402.Bytes);
public long this[int i]=>Value[i];

public static A176402Inst Instance=new A176402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176403
{
public static readonly long[] Value={ 6L,0L,9L,8L,3L,8L,6L,6L,7L,6L,9L,6L,5L,9L,3L,3L,5L,0L,8L,1L,4L,3L,4L,1L,2L,3L,1L,9L,8L,2L,5L,9L,1L,9L,6L,8L,8L,6L,6L,6L,3L,3L,7L,3L,6L,4L,2L,3L,3L,2L,7L,2L,6L,6L,1L,2L,7L,0L,0L,5L,9L,0L,1L,2L,8L,9L,0L,7L,8L,6L,4L,7L,3L,5L,4L,9L,5L,8L,3L,2L,2L,6L,8L,1L,5L,4L,2L,9L,9L,0L,1L,4L,8L,6L,9L,3L,8L,8L,1L,4L,3L,3L,3L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176403Inst : IEnumerable<long>
{
public static readonly long[] Value=A176403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176403.Bytes);
public long this[int i]=>Value[i];

public static A176403Inst Instance=new A176403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176404
{
public static readonly long[] Value={ 9L,15L,25L,33L,39L,49L,55L,57L,65L,87L,95L,111L,119L,121L,129L,143L,145L,159L,161L,169L,177L,183L,185L,201L,209L,215L,217L,247L,249L,265L,287L,289L,295L,303L,305L,319L,321L,327L,329L,335L,361L,377L,391L,393L,407L,415L,417L,447L,471L,473L,481L,489L,497L,505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176404Inst : IEnumerable<long>
{
public static readonly long[] Value=A176404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176404.Bytes);
public long this[int i]=>Value[i];

public static A176404Inst Instance=new A176404Inst();

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