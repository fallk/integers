using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A177905
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,26L,42L,52L,68L,78L,84L,114L,156L,186L,204L,222L,228L,372L,444L,546L,798L,876L,884L,1092L,1218L,1252L,1302L,1378L,1428L,1482L,1554L,1596L,1806L,2418L,2436L,2604L,2652L,2756L,2886L,2964L,3108L,3534L,3606L,3612L,3756L,3876L,4134L,4218L,4836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177905Inst : IEnumerable<long>
{
public static readonly long[] Value=A177905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177905.Bytes);
public long this[int i]=>Value[i];

public static A177905Inst Instance=new A177905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177906
{
public static readonly long[] Value={ 1L,5L,1555L,9673655L,24181805L,90993505L,200928005L,28298980055L,36850702555L,62488609555L,141377087255L,150435008905L,367279622065L,2256331679135L,7521049172905L,18802586659555L,24599612913355L,54706615318945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177906Inst : IEnumerable<long>
{
public static readonly long[] Value=A177906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177906.Bytes);
public long this[int i]=>Value[i];

public static A177906Inst Instance=new A177906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177907
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,20L,24L,30L,40L,50L,57L,60L,68L,78L,100L,110L,111L,114L,120L,136L,150L,156L,200L,204L,220L,222L,228L,258L,300L,312L,330L,340L,390L,408L,440L,444L,456L,516L,550L,570L,600L,660L,680L,780L,820L,876L,888L,930L,1010L,1020L,1032L,1086L,1100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177907Inst : IEnumerable<long>
{
public static readonly long[] Value=A177907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177907.Bytes);
public long this[int i]=>Value[i];

public static A177907Inst Instance=new A177907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177908
{
public static readonly long[] Value={ 1L,7L,889L,2359L,299593L,2033143L,13549249L,42931441L,100170217L,188097287L,233727361L,310935751L,685169191L,1515836567L,3606045247L,4566096913L,5452293007L,6620620783L,12721617559L,13162910047L,24088984969L,29683374847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177908Inst : IEnumerable<long>
{
public static readonly long[] Value=A177908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177908.Bytes);
public long this[int i]=>Value[i];

public static A177908Inst Instance=new A177908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177909
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,20L,40L,68L,82L,110L,136L,164L,220L,328L,340L,410L,440L,610L,680L,772L,820L,1010L,1210L,1220L,1510L,1544L,1640L,2020L,2420L,2440L,2530L,2788L,3020L,3740L,3860L,4040L,4510L,4840L,5060L,5576L,6040L,6710L,6806L,7004L,7370L,7480L,7720L,8020L,9020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177909Inst : IEnumerable<long>
{
public static readonly long[] Value=A177909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177909.Bytes);
public long this[int i]=>Value[i];

public static A177909Inst Instance=new A177909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177910
{
public static readonly long[] Value={ 9L,3L,3L,7L,1L,6L,6L,3L,5L,8L,1L,4L,9L,1L,4L,0L,1L,1L,7L,5L,1L,4L,0L,5L,3L,0L,9L,1L,8L,0L,3L,1L,6L,6L,6L,5L,6L,7L,9L,0L,8L,2L,0L,1L,8L,8L,0L,7L,8L,7L,2L,9L,4L,3L,6L,6L,9L,2L,6L,2L,7L,4L,0L,3L,2L,4L,1L,6L,1L,0L,7L,2L,0L,0L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177910Inst : IEnumerable<long>
{
public static readonly long[] Value=A177910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177910.Bytes);
public long this[int i]=>Value[i];

public static A177910Inst Instance=new A177910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177911
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,10L,12L,20L,30L,42L,60L,68L,78L,84L,114L,122L,156L,204L,210L,222L,228L,244L,340L,366L,390L,420L,444L,546L,570L,610L,732L,780L,798L,820L,876L,930L,1010L,1020L,1092L,1110L,1140L,1164L,1218L,1220L,1428L,1482L,1554L,1596L,1806L,1830L,1860L,2020L,2220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177911Inst : IEnumerable<long>
{
public static readonly long[] Value=A177911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177911.Bytes);
public long this[int i]=>Value[i];

public static A177911Inst Instance=new A177911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177912
{
public static readonly long[] Value={ 1L,11L,253L,11891L,77209L,768361L,1775807L,17666737L,36112967L,61488361L,83462929L,154261943L,173185331L,591303757L,830336639L,971656873L,2936791979L,4139054953L,5393125859L,8139710557L,8142849781L,45667873031L,53653880269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177912Inst : IEnumerable<long>
{
public static readonly long[] Value=A177912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177912.Bytes);
public long this[int i]=>Value[i];

public static A177912Inst Instance=new A177912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177913
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,10L,12L,14L,20L,28L,30L,34L,42L,60L,68L,70L,84L,102L,110L,114L,140L,170L,183L,204L,210L,220L,222L,228L,238L,330L,340L,366L,406L,420L,444L,476L,510L,570L,660L,714L,732L,770L,798L,812L,820L,876L,930L,942L,1010L,1020L,1110L,1140L,1190L,1218L,1428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177913Inst : IEnumerable<long>
{
public static readonly long[] Value=A177913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177913.Bytes);
public long this[int i]=>Value[i];

public static A177913Inst Instance=new A177913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177914
{
public static readonly long[] Value={ 1L,13L,2041L,8801L,1381757L,24355253L,249302027L,464754407L,2681233451L,16488506281L,16772956369L,39665616523L,72966441899L,168777472279L,388885239223L,420953651807L,2974921088191L,3487599163841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177914Inst : IEnumerable<long>
{
public static readonly long[] Value=A177914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177914.Bytes);
public long this[int i]=>Value[i];

public static A177914Inst Instance=new A177914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177915
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,14L,16L,28L,56L,68L,112L,136L,226L,272L,406L,452L,476L,812L,904L,952L,1582L,1624L,1808L,1904L,2056L,2758L,3164L,3248L,4112L,5516L,5956L,6328L,7684L,9316L,11032L,11912L,12656L,13804L,14392L,15368L,18632L,21512L,22064L,23824L,23954L,25144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177915Inst : IEnumerable<long>
{
public static readonly long[] Value=A177915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177915.Bytes);
public long this[int i]=>Value[i];

public static A177915Inst Instance=new A177915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177916
{
public static readonly long[] Value={ 1L,3L,5L,15L,21L,39L,55L,57L,105L,111L,155L,165L,195L,205L,219L,273L,285L,327L,399L,465L,505L,555L,609L,615L,741L,777L,903L,915L,1095L,1155L,1255L,1265L,1365L,1443L,1515L,1533L,1635L,1705L,1995L,2067L,2109L,2145L,2255L,2265L,2289L,2373L,2667L,2715L,2847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177916Inst : IEnumerable<long>
{
public static readonly long[] Value=A177916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177916.Bytes);
public long this[int i]=>Value[i];

public static A177916Inst Instance=new A177916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177917
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,16L,18L,20L,24L,30L,36L,40L,42L,48L,58L,60L,72L,78L,80L,84L,90L,110L,114L,116L,120L,126L,144L,156L,168L,174L,180L,210L,220L,222L,228L,232L,234L,240L,252L,290L,312L,330L,336L,342L,348L,360L,390L,420L,440L,444L,456L,464L,468L,504L,522L,546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177917Inst : IEnumerable<long>
{
public static readonly long[] Value=A177917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177917.Bytes);
public long this[int i]=>Value[i];

public static A177917Inst Instance=new A177917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177918
{
public static readonly long[] Value={ 1L,17L,343927L,1414961L,28626075991L,610559655569L,5417488064959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177918Inst : IEnumerable<long>
{
public static readonly long[] Value=A177918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177918.Bytes);
public long this[int i]=>Value[i];

public static A177918Inst Instance=new A177918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177919
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,10L,12L,18L,20L,30L,36L,42L,60L,68L,78L,84L,90L,110L,126L,156L,180L,204L,210L,220L,222L,234L,252L,294L,330L,340L,362L,381L,390L,420L,438L,444L,468L,546L,588L,612L,630L,654L,660L,666L,724L,762L,780L,820L,876L,882L,930L,990L,1010L,1014L,1020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177919Inst : IEnumerable<long>
{
public static readonly long[] Value=A177919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177919.Bytes);
public long this[int i]=>Value[i];

public static A177919Inst Instance=new A177919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177920
{
public static readonly long[] Value={ 1L,19L,7805561L,1432001198261L,3661225986659L,58130944174609L,187470481770989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177920Inst : IEnumerable<long>
{
public static readonly long[] Value=A177920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177920.Bytes);
public long this[int i]=>Value[i];

public static A177920Inst Instance=new A177920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177921
{
public static readonly long[] Value={ 1L,1L,2L,4L,12L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177921Inst : IEnumerable<long>
{
public static readonly long[] Value=A177921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177921.Bytes);
public long this[int i]=>Value[i];

public static A177921Inst Instance=new A177921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177922
{
public static readonly long[] Value={ 0L,2L,3L,5L,7L,9L,9L,11L,16L,18L,18L,18L,22L,28L,30L,30L,25L,29L,36L,43L,45L,45L,39L,39L,45L,53L,61L,63L,63L,56L,49L,55L,64L,73L,82L,84L,84L,76L,68L,68L,76L,86L,96L,106L,108L,99L,90L,81L,89L,100L,111L,122L,133L,135L,135L,125L,115L,105L,105L,115L,127L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177922Inst : IEnumerable<long>
{
public static readonly long[] Value=A177922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177922.Bytes);
public long this[int i]=>Value[i];

public static A177922Inst Instance=new A177922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177923
{
public static readonly long[] Value={ 19L,13L,37L,23L,73L,19L,23L,23L,13L,59L,19L,13L,13L,5L,31L,7L,43L,3L,53L,11L,67L,131L,19L,31L,181L,11L,223L,83L,317L,89L,163L,569L,821L,1553L,109L,191L,109L,409L,709L,409L,509L,1627L,509L,23L,127L,659L,809L,29L,499L,191L,719L,1409L,773L,967L,67L,139L,23L,229L,23L,11L,263L,11L,19L,293L,19L,331L,643L,331L,29L,59L,419L,13L,491L,71L,23L,13L,107L,13L,19L,139L,19L,59L,31L,109L,199L,113L,421L,733L,181L,89L,59L,47L,13L,17L,11L,41L,23L,5L,23L,17L,5L,5L,3L,13L,7L,23L,43L,73L,139L,17L,229L,11L,257L,71L,113L,7L,191L,311L,509L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177923Inst : IEnumerable<long>
{
public static readonly long[] Value=A177923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177923.Bytes);
public long this[int i]=>Value[i];

public static A177923Inst Instance=new A177923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177924
{
public static readonly long[] Value={ 1L,4L,3L,3L,0L,2L,5L,0L,3L,4L,1L,1L,5L,2L,2L,3L,6L,6L,5L,9L,6L,0L,6L,1L,1L,9L,5L,3L,4L,6L,6L,7L,8L,7L,4L,7L,3L,1L,1L,5L,6L,4L,8L,9L,9L,1L,4L,1L,0L,3L,8L,9L,4L,9L,4L,8L,8L,5L,4L,9L,3L,5L,1L,7L,6L,7L,4L,0L,2L,9L,5L,0L,7L,6L,3L,9L,3L,6L,2L,7L,6L,0L,8L,7L,3L,5L,1L,8L,6L,9L,4L,3L,6L,9L,8L,2L,6L,4L,4L,1L,4L,6L,5L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177924Inst : IEnumerable<long>
{
public static readonly long[] Value=A177924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177924.Bytes);
public long this[int i]=>Value[i];

public static A177924Inst Instance=new A177924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177925
{
public static readonly long[] Value={ 5L,2L,2L,4L,9L,4L,0L,1L,9L,1L,0L,4L,5L,2L,5L,2L,5L,2L,9L,3L,7L,9L,4L,2L,6L,9L,3L,9L,4L,1L,4L,0L,0L,9L,8L,4L,9L,4L,4L,7L,6L,3L,4L,3L,5L,1L,8L,9L,8L,1L,8L,1L,1L,7L,1L,3L,5L,8L,7L,6L,3L,6L,9L,8L,9L,7L,4L,5L,6L,5L,2L,4L,2L,7L,8L,0L,4L,3L,1L,4L,6L,0L,8L,9L,1L,7L,0L,4L,6L,8L,8L,4L,7L,1L,0L,2L,8L,0L,7L,2L,2L,0L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177925Inst : IEnumerable<long>
{
public static readonly long[] Value=A177925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177925.Bytes);
public long this[int i]=>Value[i];

public static A177925Inst Instance=new A177925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177926
{
public static readonly BigInteger[] Value={ 1L,4L,576L,518400L,13168189440000L,229442532802560000L,BigInteger.Parse("437763136697395052544000000"),BigInteger.Parse("40990389067797283140009984000000"),BigInteger.Parse("1263377636044591724886240423994982400000000"),BigInteger.Parse("92956902680071188234494975268405495542386262016000000000000") };
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
public class A177926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177926.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177926Inst Instance=new A177926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177927
{
public static readonly long[] Value={ 4L,9L,10L,22L,24L,25L,27L,34L,42L,46L,55L,58L,60L,72L,78L,81L,82L,85L,94L,105L,106L,114L,115L,118L,121L,126L,128L,132L,142L,145L,150L,166L,178L,180L,186L,187L,192L,195L,202L,204L,205L,214L,216L,222L,224L,226L,231L,234L,235L,243L,253L,256L,258L,262L,265L,274L,276L,285L,289L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177927Inst : IEnumerable<long>
{
public static readonly long[] Value=A177927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177927.Bytes);
public long this[int i]=>Value[i];

public static A177927Inst Instance=new A177927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177928
{
public static readonly long[] Value={ 1L,2L,3L,9L,27L,33L,66L,99L,123L,246L,271L,333L,351L,407L,429L,462L,481L,518L,546L,567L,666L,693L,702L,715L,777L,814L,819L,924L,936L,999L,1434L,2151L,2868L,3333L,4521L,4818L,6666L,7227L,7373L,7535L,8631L,9042L,9999L,33333L,53658L,54546L,66666L,80487L,81819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177928Inst : IEnumerable<long>
{
public static readonly long[] Value=A177928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177928.Bytes);
public long this[int i]=>Value[i];

public static A177928Inst Instance=new A177928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177929
{
public static readonly long[] Value={ 4L,6L,10L,12L,22L,24L,28L,30L,58L,60L,118L,120L,126L,130L,132L,138L,274L,276L,280L,282L,562L,564L,568L,570L,1138L,1140L,1146L,1150L,1152L,2302L,2304L,2308L,2310L,4618L,4620L,4650L,9298L,9300L,9316L,9318L,9324L,9328L,9330L,9336L,9340L,9342L,18682L,18684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177929Inst : IEnumerable<long>
{
public static readonly long[] Value=A177929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177929.Bytes);
public long this[int i]=>Value[i];

public static A177929Inst Instance=new A177929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177930
{
public static readonly long[] Value={ 3L,5L,3L,11L,3L,5L,3L,29L,3L,59L,3L,7L,5L,3L,7L,137L,3L,5L,3L,281L,3L,5L,3L,569L,3L,7L,5L,3L,1151L,3L,5L,3L,2309L,3L,31L,4649L,3L,17L,3L,7L,5L,3L,7L,5L,3L,9341L,3L,5L,3L,11L,3L,59L,3L,29L,3L,19L,7L,5L,3L,7L,19L,5L,3L,7L,109L,5L,3L,61L,7L,79L,5L,3L,13L,5L,3L,19139L,3L,101L,3L,7L,13L,11L,3L,71L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177930Inst : IEnumerable<long>
{
public static readonly long[] Value=A177930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177930.Bytes);
public long this[int i]=>Value[i];

public static A177930Inst Instance=new A177930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177931
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,16L,20L,24L,29L,33L,36L,46L,76L,99L,108L,132L,179L,213L,217L,251L,286L,397L,431L,439L,445L,471L,535L,658L,677L,702L,780L,889L,1227L,1296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177931Inst : IEnumerable<long>
{
public static readonly long[] Value=A177931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177931.Bytes);
public long this[int i]=>Value[i];

public static A177931Inst Instance=new A177931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177932
{
public static readonly long[] Value={ 3L,5L,11L,29L,59L,137L,281L,569L,1151L,2309L,4649L,9341L,19139L,38711L,77489L,155381L,311681L,624047L,1248101L,2497421L,4998941L,10002437L,20005289L,40010609L,80021309L,160043909L,320090921L,640196267L,1280392739L,2560793201L,5121618767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177932Inst : IEnumerable<long>
{
public static readonly long[] Value=A177932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177932.Bytes);
public long this[int i]=>Value[i];

public static A177932Inst Instance=new A177932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177933
{
public static readonly long[] Value={ 1L,4L,3L,3L,1L,2L,7L,4L,2L,6L,7L,2L,2L,2L,9L,1L,1L,3L,0L,6L,9L,3L,4L,5L,3L,5L,5L,4L,9L,7L,5L,2L,3L,5L,5L,5L,7L,3L,6L,9L,3L,4L,0L,0L,8L,4L,0L,6L,9L,9L,9L,7L,1L,4L,6L,6L,5L,9L,6L,4L,6L,7L,0L,3L,1L,7L,6L,1L,3L,7L,8L,0L,1L,6L,6L,3L,2L,3L,6L,8L,1L,2L,3L,2L,5L,7L,5L,9L,2L,8L,7L,6L,3L,6L,4L,5L,9L,6L,2L,1L,6L,8L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177933Inst : IEnumerable<long>
{
public static readonly long[] Value=A177933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177933.Bytes);
public long this[int i]=>Value[i];

public static A177933Inst Instance=new A177933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177934
{
public static readonly long[] Value={ 2L,6L,6L,8L,6L,5L,0L,6L,6L,6L,6L,6L,6L,5L,8L,3L,3L,9L,5L,2L,8L,7L,2L,3L,9L,6L,2L,5L,7L,5L,1L,6L,2L,6L,1L,3L,0L,0L,5L,2L,1L,5L,9L,5L,9L,8L,0L,8L,1L,3L,7L,4L,6L,5L,9L,5L,8L,9L,9L,4L,3L,9L,9L,1L,5L,9L,0L,9L,6L,5L,3L,5L,0L,6L,7L,8L,3L,5L,1L,1L,4L,2L,0L,4L,4L,2L,3L,3L,6L,9L,1L,0L,8L,2L,1L,4L,5L,3L,0L,0L,8L,4L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177934Inst : IEnumerable<long>
{
public static readonly long[] Value=A177934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177934.Bytes);
public long this[int i]=>Value[i];

public static A177934Inst Instance=new A177934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177935
{
public static readonly long[] Value={ 1L,0L,3L,4L,4L,0L,8L,0L,4L,3L,2L,7L,8L,8L,6L,0L,0L,4L,6L,9L,7L,3L,8L,5L,9L,9L,4L,4L,2L,6L,2L,6L,9L,9L,7L,3L,6L,8L,3L,0L,2L,0L,2L,2L,3L,7L,4L,9L,7L,1L,6L,8L,7L,9L,4L,5L,6L,7L,7L,1L,1L,5L,3L,5L,7L,6L,0L,0L,5L,9L,0L,0L,3L,7L,4L,1L,9L,3L,7L,0L,8L,7L,9L,5L,1L,7L,9L,5L,2L,5L,5L,0L,3L,2L,8L,5L,3L,2L,7L,4L,8L,4L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177935Inst : IEnumerable<long>
{
public static readonly long[] Value=A177935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177935.Bytes);
public long this[int i]=>Value[i];

public static A177935Inst Instance=new A177935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177936
{
public static readonly long[] Value={ 1L,3L,3L,7L,9L,0L,8L,8L,1L,6L,0L,2L,5L,9L,6L,5L,2L,0L,1L,5L,0L,2L,6L,8L,8L,1L,3L,5L,4L,7L,8L,6L,3L,0L,7L,0L,5L,7L,9L,8L,1L,4L,0L,4L,6L,2L,9L,1L,7L,5L,3L,2L,8L,8L,5L,1L,3L,2L,1L,1L,2L,4L,8L,6L,3L,3L,7L,7L,6L,1L,3L,6L,0L,2L,8L,9L,6L,2L,3L,9L,5L,0L,7L,8L,3L,6L,0L,1L,3L,8L,1L,7L,6L,1L,7L,4L,4L,4L,2L,8L,4L,9L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177936Inst : IEnumerable<long>
{
public static readonly long[] Value=A177936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177936.Bytes);
public long this[int i]=>Value[i];

public static A177936Inst Instance=new A177936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177937
{
public static readonly long[] Value={ 1L,3L,3L,3L,8L,2L,9L,0L,7L,4L,5L,0L,6L,9L,2L,4L,9L,6L,8L,9L,1L,2L,1L,0L,6L,3L,0L,3L,3L,1L,9L,8L,8L,8L,5L,1L,8L,9L,1L,0L,0L,3L,1L,0L,9L,4L,8L,1L,6L,2L,9L,7L,9L,1L,9L,0L,5L,0L,2L,3L,7L,1L,8L,7L,8L,3L,7L,6L,2L,9L,4L,1L,3L,8L,2L,9L,0L,1L,1L,5L,6L,2L,8L,3L,3L,4L,5L,0L,1L,1L,1L,8L,4L,3L,2L,9L,4L,2L,9L,9L,6L,7L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177937Inst : IEnumerable<long>
{
public static readonly long[] Value=A177937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177937.Bytes);
public long this[int i]=>Value[i];

public static A177937Inst Instance=new A177937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177938
{
public static readonly long[] Value={ 1L,1L,1L,6L,5L,1L,60L,47L,12L,1L,840L,638L,179L,22L,1L,15120L,11274L,3325L,485L,35L,1L,332640L,245004L,74524L,11985L,1075L,51L,1L,8648640L,6314664L,1961470L,336049L,34300L,2086L,70L,1L,259459200L,188204400L,59354028L,10630508L,1182769L,83720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177938Inst : IEnumerable<long>
{
public static readonly long[] Value=A177938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177938.Bytes);
public long this[int i]=>Value[i];

public static A177938Inst Instance=new A177938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177939
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,30L,30L,1L,1L,336L,3024L,336L,1L,1L,5040L,665280L,665280L,5040L,1L,1L,95040L,259459200L,4151347200L,259459200L,95040L,1L,1L,2162160L,158789030400L,60339831552000L,60339831552000L,158789030400L,2162160L,1L,1L,57657600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177939Inst : IEnumerable<long>
{
public static readonly long[] Value=A177939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177939.Bytes);
public long this[int i]=>Value[i];

public static A177939Inst Instance=new A177939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177940
{
public static readonly long[] Value={ 2L,1L,3L,4L,8L,3L,1L,4L,6L,0L,6L,7L,4L,1L,5L,7L,3L,0L,3L,3L,7L,0L,7L,8L,6L,5L,1L,6L,8L,5L,3L,9L,3L,2L,5L,8L,4L,2L,6L,9L,6L,6L,2L,9L,2L,1L,3L,4L,8L,3L,1L,4L,6L,0L,6L,7L,4L,1L,5L,7L,3L,0L,3L,3L,7L,0L,7L,8L,6L,5L,1L,6L,8L,5L,3L,9L,3L,2L,5L,8L,4L,2L,6L,9L,6L,6L,2L,9L,2L,1L,3L,4L,8L,3L,1L,4L,6L,0L,6L,7L,4L,1L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177940Inst : IEnumerable<long>
{
public static readonly long[] Value=A177940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177940.Bytes);
public long this[int i]=>Value[i];

public static A177940Inst Instance=new A177940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177941
{
public static readonly long[] Value={ 5L,7L,9L,15L,27L,31L,33L,37L,39L,75L,81L,159L,165L,327L,331L,333L,337L,339L,349L,351L,699L,715L,717L,721L,723L,727L,729L,745L,747L,751L,753L,757L,759L,1515L,1531L,1533L,1537L,1539L,1561L,1563L,1567L,1569L,3135L,3147L,3151L,3153L,3157L,3159L,3165L,6327L,6331L,6333L,6337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177941Inst : IEnumerable<long>
{
public static readonly long[] Value=A177941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177941.Bytes);
public long this[int i]=>Value[i];

public static A177941Inst Instance=new A177941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177942
{
public static readonly long[] Value={ 3L,3L,7L,13L,5L,3L,5L,3L,37L,7L,79L,7L,163L,5L,3L,5L,3L,11L,3L,349L,17L,3L,5L,3L,5L,3L,17L,3L,5L,3L,5L,3L,757L,17L,3L,5L,3L,23L,3L,5L,3L,1567L,13L,5L,3L,5L,3L,7L,3163L,5L,3L,5L,3L,17L,3L,5L,3L,5L,3L,23L,3L,5L,3L,37L,7L,17L,3L,7L,23L,3L,13L,7L,5L,3L,5L,3L,7L,11L,3L,5L,3L,5L,3L,6547L,7L,13099L,7L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177942Inst : IEnumerable<long>
{
public static readonly long[] Value=A177942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177942.Bytes);
public long this[int i]=>Value[i];

public static A177942Inst Instance=new A177942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177943
{
public static readonly long[] Value={ 1L,3L,4L,9L,11L,13L,20L,33L,42L,49L,84L,86L,107L,109L,123L,128L,191L,295L,296L,318L,330L,337L,396L,453L,481L,616L,663L,771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177943Inst : IEnumerable<long>
{
public static readonly long[] Value=A177943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177943.Bytes);
public long this[int i]=>Value[i];

public static A177943Inst Instance=new A177943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177944
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,9L,9L,1L,1L,16L,26L,16L,1L,1L,25L,55L,55L,25L,1L,1L,36L,99L,134L,99L,36L,1L,1L,49L,161L,273L,273L,161L,49L,1L,1L,64L,244L,496L,622L,496L,244L,64L,1L,1L,81L,351L,831L,1251L,1251L,831L,351L,81L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177944Inst : IEnumerable<long>
{
public static readonly long[] Value=A177944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177944.Bytes);
public long this[int i]=>Value[i];

public static A177944Inst Instance=new A177944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177945
{
public static readonly long[] Value={ 3L,7L,13L,37L,79L,163L,349L,757L,1567L,3163L,6547L,13099L,26497L,52999L,106273L,212557L,426889L,855427L,1710853L,3421903L,6845869L,13691767L,27385087L,54771007L,109542907L,219096259L,438203677L,876417229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177945Inst : IEnumerable<long>
{
public static readonly long[] Value=A177945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177945.Bytes);
public long this[int i]=>Value[i];

public static A177945Inst Instance=new A177945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177946
{
public static readonly BigInteger[] Value={ 2L,3L,20L,210L,332640L,8648640L,70572902400L,3016991577600L,71241227785728000L,BigInteger.Parse("2436552577639909048320000"),BigInteger.Parse("205999445200465037721600000"),BigInteger.Parse("28734252852655074735274328064000000"),BigInteger.Parse("5372155913332392772506888374845440000000") };
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
public class A177946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177946Inst Instance=new A177946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177947
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,8L,8L,1L,1L,13L,22L,13L,1L,1L,19L,45L,45L,19L,1L,1L,26L,79L,110L,79L,26L,1L,1L,34L,126L,224L,224L,126L,34L,1L,1L,43L,188L,406L,518L,406L,188L,43L,1L,1L,53L,267L,678L,1050L,1050L,678L,267L,53L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177947Inst : IEnumerable<long>
{
public static readonly long[] Value=A177947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177947.Bytes);
public long this[int i]=>Value[i];

public static A177947Inst Instance=new A177947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177948
{
public static readonly long[] Value={ 1L,10L,14L,25L,104L,116L,124L,136L,145L,149L,151L,157L,161L,167L,173L,184L,188L,190L,205L,224L,245L,251L,266L,268L,272L,280L,287L,289L,310L,1006L,1024L,1036L,1060L,1070L,1124L,1150L,1216L,1220L,1240L,1244L,1250L,1286L,1306L,1310L,1336L,1366L,1376L,1406L,1417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177948Inst : IEnumerable<long>
{
public static readonly long[] Value=A177948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177948.Bytes);
public long this[int i]=>Value[i];

public static A177948Inst Instance=new A177948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177949
{
public static readonly long[] Value={ 15684L,15685L,15686L,15687L,15688L,15689L,15690L,15691L,15692L,15693L,15694L,15695L,15696L,15697L,15698L,15699L,15700L,15701L,15702L,15703L,15704L,15705L,15706L,15707L,15708L,15709L,15710L,15711L,15712L,15713L,15714L,15715L,15716L,15717L,15718L,15719L,15720L,15721L,15722L,15723L,15724L,15725L,15726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177949Inst : IEnumerable<long>
{
public static readonly long[] Value=A177949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177949.Bytes);
public long this[int i]=>Value[i];

public static A177949Inst Instance=new A177949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177950
{
public static readonly long[] Value={ 1L,2L,3L,9L,11L,22L,26L,33L,48L,66L,87L,99L,101L,111L,117L,121L,202L,212L,216L,264L,273L,288L,297L,307L,333L,484L,513L,528L,666L,783L,819L,836L,999L,1001L,1111L,1323L,1331L,1452L,1474L,1602L,2002L,2178L,2285L,2622L,2636L,3333L,4884L,4961L,6666L,7161L,7575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177950Inst : IEnumerable<long>
{
public static readonly long[] Value=A177950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177950.Bytes);
public long this[int i]=>Value[i];

public static A177950Inst Instance=new A177950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177951
{
public static readonly long[] Value={ 4L,1L,3L,2L,8L,7L,7L,4L,4L,9L,3L,6L,6L,29L,10L,5L,5L,5L,8L,8L,8L,8L,28L,28L,7L,7L,7L,7L,30L,30L,30L,4L,13L,13L,27L,27L,9L,9L,9L,9L,9L,9L,9L,19L,11L,11L,11L,11L,11L,11L,6L,6L,6L,6L,26L,26L,6L,6L,31L,23L,31L,15L,15L,29L,15L,29L,29L,29L,15L,15L,10L,10L,10L,10L,10L,10L,10L,10L,10L,21L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177951Inst : IEnumerable<long>
{
public static readonly long[] Value=A177951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177951.Bytes);
public long this[int i]=>Value[i];

public static A177951Inst Instance=new A177951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177952
{
public static readonly long[] Value={ 0L,0L,7L,13L,86L,293L,1212L,4699L,17380L,60623L,203799L,664953L,2135649L,6800449L,21572602L,68311990L,216144075L,683666674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177952Inst : IEnumerable<long>
{
public static readonly long[] Value=A177952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177952.Bytes);
public long this[int i]=>Value[i];

public static A177952Inst Instance=new A177952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177953
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,8L,3L,4L,1L,16L,4L,11L,4L,1L,32L,5L,26L,10L,6L,1L,64L,6L,57L,20L,22L,6L,128L,7L,120L,35L,64L,21L,8L,1L,256L,8L,247L,56L,163L,56L,37L,8L,1L,512L,9L,502L,84L,382L,126L,130L,36L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177953Inst : IEnumerable<long>
{
public static readonly long[] Value=A177953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177953.Bytes);
public long this[int i]=>Value[i];

public static A177953Inst Instance=new A177953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177954
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,3L,5L,4L,1L,3L,6L,7L,4L,1L,4L,11L,17L,14L,6L,1L,4L,12L,22L,24L,16L,6L,1L,5L,19L,43L,59L,51L,27L,8L,1L,5L,20L,50L,80L,86L,62L,29L,8L,1L,6L,19L,86L,164L,212L,188L,113L,44L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177954Inst : IEnumerable<long>
{
public static readonly long[] Value=A177954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177954.Bytes);
public long this[int i]=>Value[i];

public static A177954Inst Instance=new A177954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177955
{
public static readonly long[] Value={ 3L,10L,18L,33L,57L,83L,114L,149L,197L,260L,340L,439L,559L,683L,810L,953L,1121L,1316L,1531L,1755L,1997L,2252L,2540L,2863L,3205L,3565L,3964L,4404L,4887L,5398L,5926L,6501L,7125L,7800L,8528L,9311L,10151L,11050L,12010L,13009L,14032L,15120L,16275L,17499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177955Inst : IEnumerable<long>
{
public static readonly long[] Value=A177955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177955.Bytes);
public long this[int i]=>Value[i];

public static A177955Inst Instance=new A177955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177956
{
public static readonly long[] Value={ 2L,2L,4L,60L,28L,2L,234L,2L,10L,186L,32L,8L,22L,6L,76L,330L,78L,62L,462L,88L,1416L,1440L,150L,40L,308L,144L,260L,42L,492L,2320L,132L,328L,838L,696L,736L,234L,56L,2786L,172L,382L,4872L,128L,4752L,7292L,826L,1856L,3960L,1124L,424L,612L,2052L,430L,1104L,280L,78L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177956Inst : IEnumerable<long>
{
public static readonly long[] Value=A177956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177956.Bytes);
public long this[int i]=>Value[i];

public static A177956Inst Instance=new A177956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177957
{
public static readonly long[] Value={ 1L,5L,6L,5L,6L,9L,6L,8L,0L,7L,8L,5L,7L,8L,3L,4L,1L,1L,1L,9L,8L,4L,3L,1L,4L,9L,9L,3L,4L,0L,4L,4L,6L,5L,8L,4L,9L,7L,4L,9L,8L,1L,5L,9L,8L,3L,8L,0L,9L,6L,3L,2L,6L,8L,2L,5L,5L,9L,9L,5L,5L,7L,3L,7L,2L,3L,3L,0L,7L,7L,2L,3L,0L,3L,8L,5L,1L,0L,3L,1L,1L,1L,0L,6L,8L,2L,7L,6L,7L,1L,4L,8L,1L,8L,3L,8L,5L,6L,5L,9L,6L,9L,8L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177957Inst : IEnumerable<long>
{
public static readonly long[] Value=A177957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177957.Bytes);
public long this[int i]=>Value[i];

public static A177957Inst Instance=new A177957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177958
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,12L,18L,9L,27L,36L,24L,8L,16L,32L,40L,10L,20L,30L,15L,45L,54L,42L,7L,14L,21L,28L,35L,49L,56L,48L,60L,50L,25L,75L,90L,63L,70L,77L,11L,22L,33L,44L,55L,66L,72L,64L,80L,88L,96L,78L,13L,26L,39L,52L,65L,91L,84L,98L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177958Inst : IEnumerable<long>
{
public static readonly long[] Value=A177958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177958.Bytes);
public long this[int i]=>Value[i];

public static A177958Inst Instance=new A177958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177959
{
public static readonly long[] Value={ 1L,3L,4L,7L,10L,12L,14L,17L,22L,28L,31L,34L,38L,41L,46L,51L,58L,60L,63L,68L,69L,77L,80L,86L,93L,98L,101L,105L,107L,110L,127L,126L,132L,135L,145L,148L,154L,159L,164L,170L,176L,178L,190L,188L,193L,196L,208L,222L,224L,226L,230L,238L,238L,250L,250L,258L,264L,267L,272L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177959Inst : IEnumerable<long>
{
public static readonly long[] Value=A177959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177959.Bytes);
public long this[int i]=>Value[i];

public static A177959Inst Instance=new A177959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177960
{
public static readonly long[] Value={ 3L,5L,17L,51L,257L,1285L,3855L,13107L,65537L,196611L,983055L,1114129L,5570645L,16711935L,50529027L,84215045L,858993459L,4294967297L,21474836485L,219043332147L,365072220245L,1103806595329L,3311419785987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177960Inst : IEnumerable<long>
{
public static readonly long[] Value=A177960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177960.Bytes);
public long this[int i]=>Value[i];

public static A177960Inst Instance=new A177960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177961
{
public static readonly long[] Value={ 2L,4L,6L,5L,7L,12L,8L,10L,18L,11L,13L,14L,4L,16L,30L,17L,4L,21L,20L,22L,42L,23L,25L,27L,5L,28L,29L,4L,31L,60L,32L,4L,36L,35L,37L,72L,38L,5L,43L,41L,43L,44L,4L,46L,48L,5L,4L,51L,50L,52L,102L,53L,55L,108L,56L,58L,59L,4L,5L,9L,7L,4L,66L,65L,67L,69L,5L,70L,138L,71L,7L,8L,4L,76L,150L,77L,4L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177961Inst : IEnumerable<long>
{
public static readonly long[] Value=A177961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177961.Bytes);
public long this[int i]=>Value[i];

public static A177961Inst Instance=new A177961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177962
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,3L,2L,2L,1L,3L,3L,2L,2L,4L,1L,2L,1L,3L,6L,1L,2L,2L,2L,6L,2L,2L,4L,6L,3L,3L,2L,5L,1L,3L,2L,3L,4L,2L,4L,2L,2L,12L,2L,3L,1L,2L,6L,3L,2L,6L,10L,2L,3L,3L,2L,6L,5L,1L,2L,12L,2L,2L,2L,4L,12L,2L,3L,2L,2L,2L,6L,3L,3L,6L,6L,4L,6L,2L,10L,6L,2L,5L,6L,2L,3L,3L,2L,2L,20L,1L,2L,2L,3L,1L,12L,1L,2L,6L,12L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177962Inst : IEnumerable<long>
{
public static readonly long[] Value=A177962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177962.Bytes);
public long this[int i]=>Value[i];

public static A177962Inst Instance=new A177962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177963
{
public static readonly BigInteger[] Value={ 1L,4L,576L,1625702400L,13168189440000L,BigInteger.Parse("7600054456551997440000"),BigInteger.Parse("437763136697395052544000000"),BigInteger.Parse("5919012181389927685417441689600000000"),BigInteger.Parse("162644002617632464507038883409628607021056000000000000") };
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
public class A177963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177963Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177963.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177963Inst Instance=new A177963Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177964
{
public static readonly long[] Value={ 2L,13L,17L,28L,32L,43L,47L,58L,62L,73L,77L,88L,92L,103L,107L,118L,122L,133L,137L,148L,152L,163L,167L,178L,182L,193L,197L,208L,212L,223L,227L,238L,242L,253L,257L,268L,272L,283L,287L,298L,302L,313L,317L,328L,332L,343L,347L,358L,362L,373L,377L,388L,392L,403L,407L,418L,422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177964Inst : IEnumerable<long>
{
public static readonly long[] Value=A177964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177964.Bytes);
public long this[int i]=>Value[i];

public static A177964Inst Instance=new A177964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177965
{
public static readonly long[] Value={ 1L,4L,7L,10L,16L,19L,22L,31L,34L,37L,40L,49L,52L,55L,64L,70L,76L,79L,82L,91L,97L,100L,106L,112L,115L,121L,136L,139L,142L,154L,157L,166L,169L,175L,184L,187L,190L,199L,205L,211L,217L,220L,229L,232L,244L,250L,262L,271L,274L,286L,289L,301L,304L,307L,310L,316L,322L,331L,337L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177965Inst : IEnumerable<long>
{
public static readonly long[] Value=A177965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177965.Bytes);
public long this[int i]=>Value[i];

public static A177965Inst Instance=new A177965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177966
{
public static readonly long[] Value={ 2L,5L,8L,11L,12L,14L,20L,23L,26L,27L,29L,35L,41L,42L,44L,50L,53L,56L,57L,65L,68L,74L,83L,86L,87L,89L,95L,98L,113L,116L,117L,119L,125L,128L,131L,132L,134L,140L,146L,147L,155L,158L,173L,176L,177L,179L,191L,192L,194L,200L,209L,215L,221L,222L,224L,230L,233L,239L,245L,251L,252L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177966Inst : IEnumerable<long>
{
public static readonly long[] Value=A177966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177966.Bytes);
public long this[int i]=>Value[i];

public static A177966Inst Instance=new A177966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177967
{
public static readonly long[] Value={ 2L,3L,5L,8L,11L,19L,34L,46L,53L,95L,103L,179L,251L,299L,503L,743L,1006L,1319L,1439L,2878L,3359L,3959L,6619L,5387L,10774L,5879L,11758L,17747L,24373L,40679L,26879L,35279L,61739L,23399L,46798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177967Inst : IEnumerable<long>
{
public static readonly long[] Value=A177967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177967.Bytes);
public long this[int i]=>Value[i];

public static A177967Inst Instance=new A177967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177968
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,12L,25L,29L,39L,61L,65L,115L,161L,189L,365L,470L,641L,841L,904L,1821L,2158L,2502L,4207L,3462L,6924L,3749L,7498L,11201L,17935L,25964L,17161L,22524L,38972L,14735L,33851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177968Inst : IEnumerable<long>
{
public static readonly long[] Value=A177968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177968.Bytes);
public long this[int i]=>Value[i];

public static A177968Inst Instance=new A177968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177969
{
public static readonly long[] Value={ 0L,7L,2L,1L,1L,4L,20L,8L,3L,2L,1L,1L,3L,10L,70L,1L,2L,6L,1L,16L,1L,2L,2L,5L,1L,1L,5L,4L,1L,1L,7L,4L,1L,1L,1L,4L,3L,1L,1L,9L,2L,4L,8L,2L,10L,3L,2L,4L,3L,8L,6L,4L,2852L,2L,1L,1L,2L,30L,1L,3L,1L,1L,57L,1L,2L,1L,2L,1L,2L,2L,5L,1L,2L,59L,1L,3L,1L,6L,19L,3L,1L,1L,1L,3L,47L,10L,5L,9L,1L,1L,4L,1L,1L,8L,6L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177969Inst : IEnumerable<long>
{
public static readonly long[] Value=A177969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177969.Bytes);
public long this[int i]=>Value[i];

public static A177969Inst Instance=new A177969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177970
{
public static readonly long[] Value={ 1L,1L,1L,1L,26L,1L,1L,99L,99L,1L,1L,244L,622L,244L,1L,1L,485L,2300L,2300L,485L,1L,1L,846L,6423L,12000L,6423L,846L,1L,1L,1351L,15001L,45031L,45031L,15001L,1351L,1L,1L,2024L,30924L,136120L,218774L,136120L,30924L,2024L,1L,1L,2889L,58122L,352698L,831384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177970Inst : IEnumerable<long>
{
public static readonly long[] Value=A177970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177970.Bytes);
public long this[int i]=>Value[i];

public static A177970Inst Instance=new A177970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177971
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,4L,1L,-5L,14L,-8L,1L,-7L,32L,-28L,16L,1L,-9L,62L,-36L,88L,-32L,1L,-11L,112L,104L,448L,-176L,64L,1L,-13L,198L,928L,2976L,240L,480L,-128L,1L,-15L,352L,4316L,20448L,17264L,5632L,-960L,256L,1L,-17L,638L,16500L,126968L,245872L,142752L,11200L,2432L,-512L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177971Inst : IEnumerable<long>
{
public static readonly long[] Value=A177971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177971.Bytes);
public long this[int i]=>Value[i];

public static A177971Inst Instance=new A177971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177972
{
public static readonly long[] Value={ 2L,1L,9L,5L,3L,7L,8L,6L,6L,2L,1L,8L,7L,7L,3L,3L,9L,8L,0L,4L,3L,1L,0L,5L,7L,5L,7L,7L,3L,8L,7L,6L,5L,8L,9L,5L,4L,8L,9L,5L,6L,8L,7L,6L,0L,6L,6L,7L,1L,1L,7L,0L,7L,4L,7L,8L,4L,1L,8L,0L,2L,4L,4L,3L,0L,3L,8L,8L,6L,1L,6L,5L,0L,3L,5L,1L,1L,1L,1L,9L,6L,6L,3L,1L,9L,4L,4L,1L,0L,5L,3L,7L,8L,6L,8L,2L,0L,1L,0L,1L,6L,6L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177972Inst : IEnumerable<long>
{
public static readonly long[] Value=A177972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177972.Bytes);
public long this[int i]=>Value[i];

public static A177972Inst Instance=new A177972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177973
{
public static readonly long[] Value={ 9L,5L,0L,2L,1L,0L,5L,0L,2L,9L,9L,3L,9L,4L,1L,8L,6L,3L,9L,5L,3L,4L,6L,7L,2L,1L,3L,4L,5L,7L,8L,8L,0L,3L,4L,3L,0L,1L,4L,4L,6L,3L,8L,3L,7L,4L,7L,0L,3L,6L,0L,0L,1L,3L,2L,3L,0L,2L,7L,8L,0L,0L,3L,2L,9L,1L,8L,6L,6L,5L,5L,3L,2L,8L,7L,9L,1L,1L,8L,1L,2L,3L,8L,1L,9L,4L,1L,6L,6L,4L,1L,0L,5L,1L,9L,2L,4L,8L,3L,3L,6L,3L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177973Inst : IEnumerable<long>
{
public static readonly long[] Value=A177973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177973.Bytes);
public long this[int i]=>Value[i];

public static A177973Inst Instance=new A177973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177974
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,0L,4L,1L,1L,5L,-40L,-40L,5L,1L,1L,6L,-330L,-480L,-330L,6L,1L,1L,7L,-2478L,-3990L,-3990L,-2478L,7L,1L,1L,8L,-20104L,-33264L,-36960L,-33264L,-20104L,8L,1L,1L,9L,-181368L,-301896L,-344736L,-344736L,-301896L,-181368L,9L,1L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177974Inst : IEnumerable<long>
{
public static readonly long[] Value=A177974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177974.Bytes);
public long this[int i]=>Value[i];

public static A177974Inst Instance=new A177974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177975
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,2L,5L,3L,1L,0L,4L,7L,9L,4L,1L,0L,2L,14L,16L,14L,5L,1L,0L,6L,13L,34L,30L,20L,6L,1L,0L,4L,27L,43L,69L,50L,27L,7L,1L,0L,6L,26L,83L,107L,125L,77L,35L,8L,1L,0L,4L,39L,100L,209L,226L,209L,112L,44L,9L,1L,0L,10L,38L,155L,29L,5L,461L,428L,329L,156L,54L,10L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177975Inst : IEnumerable<long>
{
public static readonly long[] Value=A177975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177975.Bytes);
public long this[int i]=>Value[i];

public static A177975Inst Instance=new A177975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177976
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,3L,1L,1L,6L,8L,4L,1L,1L,10L,15L,13L,5L,1L,1L,12L,29L,29L,19L,6L,1L,1L,18L,42L,63L,49L,26L,7L,1L,1L,22L,69L,106L,118L,76L,34L,8L,1L,1L,28L,95L,189L,225L,201L,111L,43L,9L,1L,1L,32L,134L,289L,434L,427L,320L,155L,53L,10L,1L,1L,42L,172L,444L,729L,888L,748L,484L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177976Inst : IEnumerable<long>
{
public static readonly long[] Value=A177976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177976.Bytes);
public long this[int i]=>Value[i];

public static A177976Inst Instance=new A177976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177977
{
public static readonly long[] Value={ 1L,1L,0L,1L,3L,-2L,1L,6L,5L,-6L,1L,10L,35L,26L,-48L,1L,15L,85L,165L,-26L,-120L,1L,21L,175L,735L,1264L,-36L,-1440L,1L,28L,322L,1960L,5929L,8092L,-1212L,-10080L,1L,36L,546L,4536L,22449L,60564L,57644L,-24816L,-80640L,1L,45L,870L,9450L,63273L,254205L,572480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177977Inst : IEnumerable<long>
{
public static readonly long[] Value=A177977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177977.Bytes);
public long this[int i]=>Value[i];

public static A177977Inst Instance=new A177977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177978
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,1L,-1L,1L,0L,-1L,0L,-1L,1L,0L,1L,1L,0L,-1L,1L,0L,-1L,-1L,0L,0L,-1L,1L,0L,1L,0L,1L,0L,0L,-1L,1L,0L,-1L,1L,-1L,0L,0L,0L,-1L,1L,0L,1L,-1L,0L,1L,0L,0L,0L,-1L,1L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,-1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,-1L,1L,0L,-1L,-1L,-1L,0L,-1L,0L,0L,0L,0L,0L,-1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177978Inst : IEnumerable<long>
{
public static readonly long[] Value=A177978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177978.Bytes);
public long this[int i]=>Value[i];

public static A177978Inst Instance=new A177978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177979
{
public static readonly long[] Value={ 1L,2L,5L,4L,12L,6L,9L,23L,11L,27L,34L,22L,10L,33L,15L,37L,44L,28L,80L,19L,81L,14L,107L,89L,64L,16L,82L,60L,53L,138L,25L,114L,148L,136L,42L,104L,115L,63L,20L,143L,29L,179L,67L,109L,48L,208L,235L,52L,118L,86L,24L,77L,125L,35L,194L,154L,149L,106L,58L,26L,135L,96L,353L,87L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177979Inst : IEnumerable<long>
{
public static readonly long[] Value=A177979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177979.Bytes);
public long this[int i]=>Value[i];

public static A177979Inst Instance=new A177979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177980
{
public static readonly long[] Value={ 2L,3L,3L,5L,3L,7L,5L,3L,3L,11L,7L,13L,5L,3L,3L,17L,3L,19L,11L,7L,7L,23L,13L,3L,5L,3L,3L,29L,3L,31L,17L,3L,3L,11L,19L,37L,11L,7L,7L,41L,7L,43L,23L,13L,13L,47L,3L,3L,5L,3L,3L,53L,3L,3L,29L,3L,3L,59L,31L,61L,17L,3L,3L,11L,3L,67L,11L,19L,19L,71L,37L,73L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177980Inst : IEnumerable<long>
{
public static readonly long[] Value=A177980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177980.Bytes);
public long this[int i]=>Value[i];

public static A177980Inst Instance=new A177980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177981
{
public static readonly long[] Value={ 23L,31L,53L,67L,113L,131L,173L,191L,223L,229L,311L,337L,419L,431L,479L,653L,659L,661L,673L,719L,733L,797L,839L,1289L,1297L,5101L,7103L,10709L,10903L,11113L,11273L,11311L,13709L,13901L,14149L,15101L,15727L,16301L,16703L,17317L,17903L,18119L,18191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177981Inst : IEnumerable<long>
{
public static readonly long[] Value=A177981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177981.Bytes);
public long this[int i]=>Value[i];

public static A177981Inst Instance=new A177981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177982
{
public static readonly long[] Value={ 14L,16L,18L,39L,100L,112L,114L,115L,116L,118L,120L,121L,122L,124L,125L,126L,270L,280L,300L,320L,330L,334L,335L,336L,338L,339L,340L,342L,344L,345L,346L,348L,490L,500L,510L,520L,540L,550L,556L,570L,580L,600L,620L,630L,640L,650L,660L,668L,669L,670L,672L,674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177982Inst : IEnumerable<long>
{
public static readonly long[] Value=A177982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177982.Bytes);
public long this[int i]=>Value[i];

public static A177982Inst Instance=new A177982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177983
{
public static readonly long[] Value={ 3L,5L,4L,9L,8L,7L,15L,11L,10L,21L,4L,13L,17L,17L,16L,18L,20L,4L,39L,23L,22L,45L,5L,25L,30L,4L,28L,32L,32L,31L,33L,35L,4L,69L,38L,37L,40L,41L,5L,81L,4L,43L,47L,5L,46L,6L,50L,4L,99L,53L,52L,105L,56L,55L,111L,4L,58L,6L,7L,5L,8L,65L,4L,129L,5L,67L,72L,71L,70L,75L,4L,7L,77L,77L,76L,78L,80L,4L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177983Inst : IEnumerable<long>
{
public static readonly long[] Value=A177983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177983.Bytes);
public long this[int i]=>Value[i];

public static A177983Inst Instance=new A177983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177984
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,14L,14L,1L,1L,44L,126L,44L,1L,1L,132L,887L,887L,132L,1L,1L,390L,5451L,12076L,5451L,390L,1L,1L,1150L,30984L,131665L,131665L,30984L,1150L,1L,1L,3400L,168076L,1252600L,2353126L,1252600L,168076L,3400L,1L,1L,10088L,885725L,10905407L,34828859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177984Inst : IEnumerable<long>
{
public static readonly long[] Value=A177984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177984.Bytes);
public long this[int i]=>Value[i];

public static A177984Inst Instance=new A177984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177985
{
public static readonly long[] Value={ 1L,1L,-2L,4L,1L,-5L,7L,1L,-8L,10L,-9L,-1L,13L,1L,-14L,1L,16L,-17L,19L,1L,-20L,22L,-20L,-2L,25L,-24L,-1L,28L,1L,-29L,1L,31L,-32L,34L,1L,-35L,2L,36L,-38L,40L,-39L,-1L,43L,-41L,-2L,1L,46L,-47L,49L,1L,-50L,52L,1L,-53L,55L,-54L,-1L,2L,2L,-4L,1L,61L,-62L,64L,-62L,-2L,67L,1L,-68L,4L,-3L,-1L,73L,1L,-74L,1L,76L,-77L,2L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177985Inst : IEnumerable<long>
{
public static readonly long[] Value=A177985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177985.Bytes);
public long this[int i]=>Value[i];

public static A177985Inst Instance=new A177985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177986
{
public static readonly long[] Value={ 1L,3L,4L,8L,9L,15L,16L,19L,20L,24L,25L,28L,33L,35L,36L,40L,48L,49L,51L,63L,64L,65L,68L,73L,80L,81L,84L,99L,100L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177986Inst : IEnumerable<long>
{
public static readonly long[] Value=A177986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177986.Bytes);
public long this[int i]=>Value[i];

public static A177986Inst Instance=new A177986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177987
{
public static readonly long[] Value={ 2L,5L,6L,7L,10L,11L,12L,13L,14L,17L,18L,21L,22L,23L,26L,27L,29L,30L,31L,32L,34L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,50L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,66L,67L,69L,70L,71L,72L,74L,75L,76L,77L,78L,79L,82L,83L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177987Inst : IEnumerable<long>
{
public static readonly long[] Value=A177987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177987.Bytes);
public long this[int i]=>Value[i];

public static A177987Inst Instance=new A177987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177988
{
public static readonly long[] Value={ 1L,7L,12L,15L,16L,17L,31L,32L,45L,49L,56L,60L,65L,71L,72L,77L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177988Inst : IEnumerable<long>
{
public static readonly long[] Value=A177988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177988.Bytes);
public long this[int i]=>Value[i];

public static A177988Inst Instance=new A177988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177989
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,8L,9L,10L,11L,13L,14L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,46L,47L,48L,50L,51L,52L,53L,54L,55L,57L,58L,59L,61L,62L,63L,64L,66L,67L,68L,69L,70L,73L,74L,75L,76L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177989Inst : IEnumerable<long>
{
public static readonly long[] Value=A177989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177989.Bytes);
public long this[int i]=>Value[i];

public static A177989Inst Instance=new A177989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177990
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177990Inst : IEnumerable<long>
{
public static readonly long[] Value=A177990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177990.Bytes);
public long this[int i]=>Value[i];

public static A177990Inst Instance=new A177990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177991
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,4L,1L,3L,1L,2L,1L,1L,1L,4L,1L,3L,1L,2L,1L,1L,1L,1L,5L,1L,4L,1L,3L,1L,2L,1L,1L,1L,5L,1L,4L,1L,3L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177991Inst : IEnumerable<long>
{
public static readonly long[] Value=A177991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177991.Bytes);
public long this[int i]=>Value[i];

public static A177991Inst Instance=new A177991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177992
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,5L,1L,1L,15L,6L,5L,1L,1L,31L,10L,16L,5L,1L,1L,63L,15L,42L,15L,7L,1L,1L,127L,21L,99L,35L,29L,7L,1L,1L,255L,28L,219L,70L,93L,28L,9L,1L,1L,511L,36L,466L,126L,256L,84L,46L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177992Inst : IEnumerable<long>
{
public static readonly long[] Value=A177992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177992.Bytes);
public long this[int i]=>Value[i];

public static A177992Inst Instance=new A177992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177993
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,2L,4L,3L,1L,3L,8L,9L,5L,1L,3L,9L,13L,11L,5L,1L,4L,15L,28L,31L,20L,7L,1L,4L,16L,34L,46L,40L,22L,7L,1L,5L,24L,62L,102L,110L,78L,35L,9L,1L,5L,25L,70L,130L,166L,148L,91L,37L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177993Inst : IEnumerable<long>
{
public static readonly long[] Value=A177993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177993.Bytes);
public long this[int i]=>Value[i];

public static A177993Inst Instance=new A177993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177994
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,3L,1L,2L,1L,1L,1L,4L,1L,3L,1L,2L,1L,1L,4L,1L,3L,1L,2L,1L,1L,1L,5L,1L,4L,1L,3L,1L,2L,1L,1L,5L,1L,4L,1L,3L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177994Inst : IEnumerable<long>
{
public static readonly long[] Value=A177994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177994.Bytes);
public long this[int i]=>Value[i];

public static A177994Inst Instance=new A177994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177995
{
public static readonly long[] Value={ 1L,2L,1L,2L,0L,3L,2L,0L,6L,5L,2L,0L,6L,0L,13L,2L,0L,6L,0L,26L,21L,2L,0L,6L,0L,26L,0L,55L,2L,0L,6L,0L,26L,0L,110L,89L,2L,0L,6L,0L,26L,0L,110L,0L,233L,2L,0L,6L,0L,26L,0L,110L,0L,466L,377L,1L,0L,6L,0L,26L,0L,110L,0L,466L,0L,987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177995Inst : IEnumerable<long>
{
public static readonly long[] Value=A177995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177995.Bytes);
public long this[int i]=>Value[i];

public static A177995Inst Instance=new A177995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177996
{
public static readonly BigInteger[] Value={ 41L,29L,23L,79L,354689L,BigInteger.Parse("1961870762757168078553"),47L,40427L,4093L,4441L,2543L,1033L,659L,BigInteger.Parse("181194015068926422899222020415627"),394502321L,22742387L,36583L,569L,14747L,12641L,167L,407987015619859919L,100493L,3679329001L };
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
public class A177996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A177996.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A177996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A177996Inst Instance=new A177996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177997
{
public static readonly long[] Value={ 2L,5L,7L,13L,31L,41L,43L,59L,101L,107L,127L,137L,149L,199L,239L,277L,359L,389L,479L,613L,743L,757L,809L,829L,937L,991L,1031L,1103L,1439L,1487L,1499L,1847L,1877L,2011L,2083L,2179L,2609L,2663L,2711L,2741L,2749L,2857L,2909L,3329L,3559L,3623L,3643L,3697L,3823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177997Inst : IEnumerable<long>
{
public static readonly long[] Value=A177997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177997.Bytes);
public long this[int i]=>Value[i];

public static A177997Inst Instance=new A177997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177998
{
public static readonly long[] Value={ 0L,0L,907L,9007L,90007L,900007L,8000009L,40000003L,700000001L,9000000001L,40000000003L,700000000009L,8000000000009L,70000000000009L,940000000000007L,9000000000000007L,70000000000000003L,200000000000000003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177998Inst : IEnumerable<long>
{
public static readonly long[] Value=A177998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177998.Bytes);
public long this[int i]=>Value[i];

public static A177998Inst Instance=new A177998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A177999
{
public static readonly long[] Value={ 7L,11L,911L,8111L,16111L,911111L,1171111L,71111111L,131111111L,1711111111L,31111111111L,311111111111L,5111111111111L,41111111111111L,111151111111111L,5111111111111111L,11111611111111111L,191111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A177999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A177999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A177999Inst : IEnumerable<long>
{
public static readonly long[] Value=A177999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A177999.Bytes);
public long this[int i]=>Value[i];

public static A177999Inst Instance=new A177999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178000
{
public static readonly long[] Value={ 2L,29L,229L,2221L,22229L,922223L,9222229L,22222223L,222222227L,7222222229L,22222222223L,522222222229L,9222222222229L,22222222222229L,222222222222227L,9222222222222227L,72222222222222221L,222222222222222221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178000Inst : IEnumerable<long>
{
public static readonly long[] Value=A178000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178000.Bytes);
public long this[int i]=>Value[i];

public static A178000Inst Instance=new A178000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178001
{
public static readonly long[] Value={ 3L,83L,733L,7333L,38333L,733333L,3733333L,83333333L,373333333L,3334333333L,38333333333L,383333333333L,3433333333333L,53333333333333L,383333333333333L,3733333333333333L,43333333333333333L,353333333333333333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178001Inst : IEnumerable<long>
{
public static readonly long[] Value=A178001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178001.Bytes);
public long this[int i]=>Value[i];

public static A178001Inst Instance=new A178001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178002
{
public static readonly long[] Value={ 7L,47L,449L,4447L,44449L,444449L,7444441L,74444449L,444444443L,4444444447L,44444444441L,444444444443L,5444444444443L,84444444444449L,494444444444441L,8444444444444443L,74444444444444441L,494444444444444447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178002Inst : IEnumerable<long>
{
public static readonly long[] Value=A178002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178002.Bytes);
public long this[int i]=>Value[i];

public static A178002Inst Instance=new A178002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178003
{
public static readonly long[] Value={ 5L,59L,557L,5557L,75557L,555557L,9555551L,55555559L,855555559L,5555555557L,75555555557L,555555555559L,5555555555551L,59555555555557L,555555555555557L,6555555555555553L,55556555555555557L,555555555555555559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178003Inst : IEnumerable<long>
{
public static readonly long[] Value=A178003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178003.Bytes);
public long this[int i]=>Value[i];

public static A178003Inst Instance=new A178003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178004
{
public static readonly long[] Value={ 0L,67L,661L,6661L,96667L,666667L,9666661L,66666667L,666666667L,6666666661L,66666666667L,669666666661L,6666676666667L,96666666666667L,696666666666661L,6966666666666661L,96666666666666661L,666666666666666661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178004Inst : IEnumerable<long>
{
public static readonly long[] Value=A178004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178004.Bytes);
public long this[int i]=>Value[i];

public static A178004Inst Instance=new A178004Inst();

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