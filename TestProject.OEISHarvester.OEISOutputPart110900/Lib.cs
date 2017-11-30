using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A191121
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,11L,14L,19L,20L,23L,27L,31L,32L,41L,43L,55L,56L,59L,68L,75L,79L,80L,91L,92L,95L,107L,122L,123L,127L,128L,163L,164L,167L,171L,176L,203L,219L,223L,224L,235L,236L,239L,271L,272L,275L,284L,299L,315L,319L,320L,363L,365L,367L,368L,379L,380L,383L,427L,487L,488L,491L,500L,507L,511L,512L,527L,608L,651L,655L,656L,667L,668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191121Inst : IEnumerable<long>
{
public static readonly long[] Value=A191121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191121.Bytes);
public long this[int i]=>Value[i];

public static A191121Inst Instance=new A191121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191122
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,11L,14L,16L,20L,23L,32L,41L,44L,47L,56L,59L,64L,68L,80L,92L,95L,122L,128L,131L,140L,164L,167L,176L,188L,191L,203L,224L,236L,239L,256L,272L,275L,284L,320L,365L,368L,380L,383L,392L,419L,488L,491L,500L,512L,524L,527L,560L,563L,572L,608L,656L,668L,671L,704L,707L,716L,752L,764L,767L,812L,815L,824L,851L,896L,944L,956L,959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191122Inst : IEnumerable<long>
{
public static readonly long[] Value=A191122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191122.Bytes);
public long this[int i]=>Value[i];

public static A191122Inst Instance=new A191122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191123
{
public static readonly long[] Value={ 1L,2L,5L,9L,14L,21L,26L,37L,41L,57L,62L,77L,85L,105L,110L,122L,149L,165L,170L,185L,229L,230L,249L,254L,309L,314L,329L,341L,365L,421L,441L,446L,489L,494L,509L,554L,597L,661L,681L,686L,689L,741L,746L,761L,917L,921L,926L,941L,986L,997L,1017L,1022L,1094L,1237L,1257L,1262L,1317L,1322L,1337L,1365L,1461L,1466L,1481L,1526L,1661L,1685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191123Inst : IEnumerable<long>
{
public static readonly long[] Value=A191123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191123.Bytes);
public long this[int i]=>Value[i];

public static A191123Inst Instance=new A191123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191124
{
public static readonly long[] Value={ 1L,2L,5L,6L,10L,14L,17L,22L,26L,29L,41L,42L,50L,58L,65L,70L,77L,86L,90L,106L,118L,122L,125L,149L,166L,170L,173L,194L,202L,209L,230L,234L,257L,262L,269L,282L,310L,317L,346L,353L,362L,365L,374L,426L,446L,474L,490L,497L,502L,509L,518L,581L,598L,605L,626L,666L,682L,689L,694L,701L,770L,778L,785L,806L,810L,838L,845L,922L,929L,938L,950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191124Inst : IEnumerable<long>
{
public static readonly long[] Value=A191124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191124.Bytes);
public long this[int i]=>Value[i];

public static A191124Inst Instance=new A191124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191125
{
public static readonly long[] Value={ 1L,2L,5L,7L,11L,14L,20L,23L,31L,32L,41L,47L,59L,68L,83L,92L,95L,122L,127L,131L,140L,167L,176L,191L,203L,239L,248L,275L,284L,335L,365L,371L,380L,383L,392L,419L,491L,500L,511L,527L,563L,572L,608L,671L,707L,716L,743L,767L,815L,824L,851L,959L,995L,1004L,1094L,1103L,1112L,1139L,1148L,1175L,1256L,1343L,1463L,1472L,1487L,1499L,1523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191125Inst : IEnumerable<long>
{
public static readonly long[] Value=A191125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191125.Bytes);
public long this[int i]=>Value[i];

public static A191125Inst Instance=new A191125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191126
{
public static readonly long[] Value={ 1L,3L,9L,27L,33L,81L,99L,105L,129L,243L,297L,315L,321L,387L,393L,417L,513L,729L,891L,945L,963L,969L,1161L,1179L,1185L,1251L,1257L,1281L,1539L,1545L,1569L,1665L,2049L,2187L,2673L,2835L,2889L,2907L,2913L,3483L,3537L,3555L,3561L,3753L,3771L,3777L,3843L,3849L,3873L,4617L,4635L,4641L,4707L,4713L,4737L,4995L,5001L,5025L,5121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191126Inst : IEnumerable<long>
{
public static readonly long[] Value=A191126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191126.Bytes);
public long this[int i]=>Value[i];

public static A191126Inst Instance=new A191126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191127
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,10L,18L,22L,27L,30L,34L,38L,54L,66L,70L,81L,86L,90L,102L,106L,114L,118L,134L,150L,162L,198L,210L,214L,243L,258L,262L,270L,278L,306L,318L,322L,342L,354L,358L,402L,406L,422L,450L,454L,470L,486L,534L,594L,598L,630L,642L,646L,729L,774L,786L,790L,810L,834L,838L,854L,918L,954L,966L,970L,1026L,1030L,1046L,1062L,1074L,1078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191127Inst : IEnumerable<long>
{
public static readonly long[] Value=A191127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191127.Bytes);
public long this[int i]=>Value[i];

public static A191127Inst Instance=new A191127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191128
{
public static readonly long[] Value={ 1L,3L,9L,11L,27L,33L,35L,43L,81L,99L,105L,107L,129L,131L,139L,171L,243L,297L,315L,321L,323L,387L,393L,395L,417L,419L,427L,513L,515L,523L,555L,683L,729L,891L,945L,963L,969L,971L,1161L,1179L,1185L,1187L,1251L,1257L,1259L,1281L,1283L,1291L,1539L,1545L,1547L,1569L,1571L,1579L,1665L,1667L,1675L,1707L,2049L,2051L,2059L,2091L,2187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191128Inst : IEnumerable<long>
{
public static readonly long[] Value=A191128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191128.Bytes);
public long this[int i]=>Value[i];

public static A191128Inst Instance=new A191128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191129
{
public static readonly long[] Value={ 1L,3L,5L,9L,13L,15L,21L,27L,37L,39L,45L,53L,61L,63L,81L,85L,109L,111L,117L,135L,149L,157L,159L,181L,183L,189L,213L,243L,245L,253L,255L,325L,327L,333L,341L,351L,405L,437L,445L,447L,469L,471L,477L,541L,543L,549L,567L,597L,629L,637L,639L,725L,729L,733L,735L,757L,759L,765L,853L,973L,975L,981L,999L,1013L,1021L,1023L,1053L,1215L,1301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191129Inst : IEnumerable<long>
{
public static readonly long[] Value=A191129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191129.Bytes);
public long this[int i]=>Value[i];

public static A191129Inst Instance=new A191129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191130
{
public static readonly long[] Value={ 1L,3L,6L,9L,14L,18L,26L,27L,38L,42L,54L,58L,74L,78L,81L,106L,110L,114L,126L,154L,162L,170L,174L,218L,222L,234L,243L,298L,314L,318L,326L,330L,342L,378L,426L,442L,458L,462L,486L,506L,510L,522L,618L,650L,654L,666L,682L,698L,702L,729L,874L,890L,894L,938L,942L,954L,974L,978L,990L,1026L,1134L,1194L,1258L,1274L,1278L,1306L,1322L,1326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191130Inst : IEnumerable<long>
{
public static readonly long[] Value=A191130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191130.Bytes);
public long this[int i]=>Value[i];

public static A191130Inst Instance=new A191130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191131
{
public static readonly long[] Value={ 1L,3L,7L,9L,15L,21L,27L,31L,39L,45L,63L,81L,87L,93L,111L,117L,127L,135L,159L,183L,189L,243L,255L,261L,279L,327L,333L,351L,375L,381L,405L,447L,471L,477L,511L,543L,549L,567L,639L,729L,735L,759L,765L,783L,837L,975L,981L,999L,1023L,1047L,1053L,1119L,1125L,1143L,1215L,1311L,1335L,1341L,1407L,1413L,1431L,1503L,1527L,1533L,1623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191131Inst : IEnumerable<long>
{
public static readonly long[] Value=A191131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191131.Bytes);
public long this[int i]=>Value[i];

public static A191131Inst Instance=new A191131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191180
{
public static readonly long[] Value={ 1L,3L,9L,11L,27L,33L,35L,43L,57L,81L,99L,105L,107L,129L,131L,139L,171L,185L,243L,297L,315L,321L,323L,387L,393L,395L,417L,419L,427L,513L,515L,523L,555L,569L,683L,697L,729L,891L,945L,963L,969L,971L,1161L,1179L,1185L,1187L,1251L,1257L,1259L,1281L,1283L,1291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191180Inst : IEnumerable<long>
{
public static readonly long[] Value=A191180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191180.Bytes);
public long this[int i]=>Value[i];

public static A191180Inst Instance=new A191180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191181
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,25L,27L,33L,35L,43L,61L,79L,81L,97L,99L,105L,107L,129L,131L,139L,171L,223L,241L,243L,295L,297L,313L,315L,321L,323L,385L,387L,393L,395L,417L,419L,427L,513L,515L,523L,547L,555L,683L,709L,727L,729L,871L,889L,891L,943L,945L,961L,963L,969L,971L,1159L,1161L,1177L,1179L,1185L,1187L,1249L,1251L,1257L,1259L,1281L,1283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191181Inst : IEnumerable<long>
{
public static readonly long[] Value=A191181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191181.Bytes);
public long this[int i]=>Value[i];

public static A191181Inst Instance=new A191181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191182
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,15L,21L,27L,37L,39L,45L,53L,61L,63L,71L,81L,85L,109L,111L,117L,135L,149L,157L,159L,181L,183L,189L,199L,213L,243L,245L,253L,255L,325L,327L,333L,341L,351L,405L,437L,445L,447L,455L,469L,471L,477L,541L,543L,549L,567L,583L,597L,629L,637L,639L,725L,729L,733L,735L,757L,759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191182Inst : IEnumerable<long>
{
public static readonly long[] Value=A191182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191182.Bytes);
public long this[int i]=>Value[i];

public static A191182Inst Instance=new A191182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191183
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,11L,13L,15L,20L,21L,27L,29L,37L,39L,45L,47L,53L,61L,63L,81L,83L,85L,101L,109L,111L,117L,119L,135L,137L,149L,157L,159L,181L,182L,183L,189L,191L,213L,243L,245L,253L,255L,263L,325L,327L,333L,335L,341L,351L,353L,405L,407L,425L,437L,445L,447L,469L,471L,477L,479L,541L,543L,549L,551L,567L,569L,597L,629L,637L,639L,725L,729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191183Inst : IEnumerable<long>
{
public static readonly long[] Value=A191183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191183.Bytes);
public long this[int i]=>Value[i];

public static A191183Inst Instance=new A191183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191184
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,14L,18L,26L,27L,38L,42L,54L,58L,74L,78L,81L,106L,110L,114L,126L,142L,154L,162L,170L,174L,206L,218L,222L,234L,243L,298L,314L,318L,326L,330L,342L,378L,398L,426L,442L,458L,462L,486L,506L,510L,522L,590L,618L,650L,654L,666L,682L,698L,702L,729L,874L,890L,894L,910L,938L,942L,954L,974L,978L,990L,1026L,1134L,1166L,1194L,1258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191184Inst : IEnumerable<long>
{
public static readonly long[] Value=A191184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191184.Bytes);
public long this[int i]=>Value[i];

public static A191184Inst Instance=new A191184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191185
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,10L,13L,14L,18L,19L,26L,27L,28L,31L,38L,40L,42L,43L,54L,55L,58L,74L,78L,79L,81L,82L,85L,94L,106L,110L,114L,115L,121L,126L,127L,130L,154L,162L,163L,166L,170L,174L,175L,218L,222L,223L,234L,235L,238L,243L,244L,247L,256L,283L,298L,314L,318L,319L,326L,330L,331L,342L,343L,346L,364L,378L,379L,382L,391L,426L,442L,458L,462L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191185Inst : IEnumerable<long>
{
public static readonly long[] Value=A191185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191185.Bytes);
public long this[int i]=>Value[i];

public static A191185Inst Instance=new A191185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191186
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,15L,21L,27L,29L,31L,37L,39L,45L,53L,61L,63L,81L,85L,87L,93L,109L,111L,117L,125L,127L,135L,149L,157L,159L,181L,183L,189L,213L,243L,245L,253L,255L,261L,279L,325L,327L,333L,341L,349L,351L,373L,375L,381L,405L,437L,445L,447L,469L,471L,477L,501L,509L,511L,541L,543L,549L,567L,597L,629L,637L,639L,725L,729L,733L,735L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191186Inst : IEnumerable<long>
{
public static readonly long[] Value=A191186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191186.Bytes);
public long this[int i]=>Value[i];

public static A191186Inst Instance=new A191186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191187
{
public static readonly long[] Value={ 1L,3L,6L,7L,9L,15L,21L,27L,31L,33L,39L,45L,60L,63L,69L,81L,87L,93L,111L,117L,127L,135L,141L,159L,183L,189L,195L,243L,249L,255L,261L,279L,285L,303L,327L,333L,351L,357L,375L,381L,405L,411L,447L,471L,477L,511L,543L,546L,549L,567L,573L,627L,639L,729L,735L,759L,765L,783L,789L,837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191187Inst : IEnumerable<long>
{
public static readonly long[] Value=A191187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191187.Bytes);
public long this[int i]=>Value[i];

public static A191187Inst Instance=new A191187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191188
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191188Inst : IEnumerable<long>
{
public static readonly long[] Value=A191188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191188.Bytes);
public long this[int i]=>Value[i];

public static A191188Inst Instance=new A191188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191189
{
public static readonly long[] Value={ 1L,4L,13L,31L,40L,49L,112L,121L,148L,157L,193L,274L,355L,364L,436L,445L,472L,481L,580L,589L,625L,769L,1003L,1084L,1093L,1327L,1336L,1408L,1417L,1444L,1453L,1732L,1741L,1768L,1777L,1876L,1885L,1921L,2308L,2317L,2353L,2461L,2497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191189Inst : IEnumerable<long>
{
public static readonly long[] Value=A191189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191189.Bytes);
public long this[int i]=>Value[i];

public static A191189Inst Instance=new A191189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191190
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,13L,14L,19L,22L,26L,40L,43L,50L,54L,58L,67L,71L,74L,79L,86L,102L,121L,130L,135L,151L,158L,163L,170L,175L,198L,202L,214L,223L,230L,238L,259L,263L,266L,294L,307L,314L,342L,364L,391L,406L,454L,455L,475L,482L,490L,511L,518L,526L,595L,602L,607L,630L,643L,650L,670L,678L,691L,698L,715L,778L,790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191190Inst : IEnumerable<long>
{
public static readonly long[] Value=A191190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191190.Bytes);
public long this[int i]=>Value[i];

public static A191190Inst Instance=new A191190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191191
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,13L,14L,15L,19L,22L,26L,33L,40L,43L,50L,51L,54L,58L,60L,67L,74L,79L,86L,102L,114L,121L,123L,130L,132L,151L,158L,163L,168L,170L,175L,195L,198L,202L,214L,223L,230L,231L,238L,259L,266L,294L,307L,314L,342L,357L,364L,384L,391L,406L,447L,454L,456L,475L,482L,483L,490L,511L,518L,519L,526L,537L,595L,600L,602L,607L,630L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191191Inst : IEnumerable<long>
{
public static readonly long[] Value=A191191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191191.Bytes);
public long this[int i]=>Value[i];

public static A191191Inst Instance=new A191191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191192
{
public static readonly long[] Value={ 1L,3L,4L,10L,11L,13L,14L,15L,31L,34L,39L,40L,43L,46L,51L,59L,78L,94L,103L,118L,121L,123L,130L,135L,139L,154L,155L,159L,171L,178L,183L,203L,206L,235L,270L,283L,310L,355L,364L,370L,375L,391L,406L,411L,418L,463L,466L,471L,478L,483L,491L,514L,519L,535L,539L,550L,555L,610L,615L,619L,635L,654L,683L,706L,711L,718L,731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191192Inst : IEnumerable<long>
{
public static readonly long[] Value=A191192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191192.Bytes);
public long this[int i]=>Value[i];

public static A191192Inst Instance=new A191192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191193
{
public static readonly long[] Value={ 1L,3L,4L,8L,10L,11L,13L,15L,26L,31L,34L,35L,39L,40L,43L,46L,51L,59L,71L,89L,94L,98L,103L,116L,118L,121L,123L,130L,134L,135L,139L,154L,155L,159L,171L,178L,183L,203L,233L,235L,278L,283L,305L,310L,314L,350L,355L,359L,364L,370L,375L,386L,391L,406L,411L,413L,418L,458L,463L,466L,471L,478L,483L,491L,514L,519L,530L,535L,539L,550L,555L,610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191193Inst : IEnumerable<long>
{
public static readonly long[] Value=A191193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191193.Bytes);
public long this[int i]=>Value[i];

public static A191193Inst Instance=new A191193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191194
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,13L,15L,16L,18L,20L,22L,23L,25L,27L,29L,32L,34L,36L,39L,41L,43L,45L,46L,48L,50L,52L,53L,55L,57L,59L,62L,64L,66L,69L,71L,73L,75L,76L,78L,80L,82L,83L,85L,87L,89L,92L,94L,96L,99L,101L,103L,105L,106L,108L,110L,112L,115L,117L,119L,122L,124L,126L,128L,129L,131L,133L,135L,136L,138L,140L,142L,145L,147L,149L,152L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191194Inst : IEnumerable<long>
{
public static readonly long[] Value=A191194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191194.Bytes);
public long this[int i]=>Value[i];

public static A191194Inst Instance=new A191194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191195
{
public static readonly long[] Value={ 1L,4L,10L,13L,16L,37L,40L,49L,52L,64L,91L,118L,121L,145L,148L,157L,160L,193L,196L,208L,256L,334L,361L,364L,442L,445L,469L,472L,481L,484L,577L,580L,589L,592L,625L,628L,640L,769L,772L,784L,820L,832L,1024L,1063L,1090L,1093L,1306L,1333L,1336L,1414L,1417L,1441L,1444L,1453L,1456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191195Inst : IEnumerable<long>
{
public static readonly long[] Value=A191195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191195.Bytes);
public long this[int i]=>Value[i];

public static A191195Inst Instance=new A191195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191244
{
public static readonly BigInteger[] Value={ 1L,10110L,110100L,1011130L,3234210L,22142230L,123052510L,523053070L,2520607100L,11111111110L,479110292610L,19641010776330L,80101410369310L,210510130141118110L,1212103125891481260L,315281211715711270L,12138214138151315710UL,BigInteger.Parse("56015814091312161590"),BigInteger.Parse("1780471401817161317410"),BigInteger.Parse("6151213981715112481715110") };
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
public class A191244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191244Inst Instance=new A191244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191245
{
public static readonly long[] Value={ 3L,7L,11L,19L,53L,97L,103L,127L,131L,149L,179L,197L,227L,239L,277L,283L,337L,349L,409L,457L,463L,487L,499L,569L,599L,641L,659L,683L,701L,719L,743L,809L,839L,953L,971L,1013L,1019L,1051L,1093L,1201L,1213L,1237L,1291L,1297L,1303L,1321L,1381L,1423L,1543L,1597L,1621L,1747L,1753L,1783L,1801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191245Inst : IEnumerable<long>
{
public static readonly long[] Value=A191245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191245.Bytes);
public long this[int i]=>Value[i];

public static A191245Inst Instance=new A191245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191246
{
public static readonly long[] Value={ 0L,2L,3L,3L,2L,3L,4L,2L,4L,2L,3L,3L,2L,3L,4L,3L,2L,4L,2L,3L,3L,2L,3L,4L,5L,2L,3L,3L,2L,3L,5L,2L,3L,3L,2L,3L,4L,2L,4L,2L,3L,3L,2L,3L,4L,3L,2L,4L,2L,3L,3L,2L,3L,4L,5L,2L,4L,2L,3L,3L,2L,3L,5L,2L,3L,3L,2L,3L,4L,2L,4L,2L,3L,3L,2L,3L,4L,3L,2L,4L,2L,3L,3L,2L,3L,4L,5L,3L,2L,4L,2L,3L,3L,2L,3L,5L,2L,3L,3L,2L,3L,4L,2L,4L,2L,3L,3L,2L,3L,4L,3L,2L,4L,2L,3L,3L,2L,3L,4L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191246Inst : IEnumerable<long>
{
public static readonly long[] Value=A191246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191246.Bytes);
public long this[int i]=>Value[i];

public static A191246Inst Instance=new A191246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191247
{
public static readonly long[] Value={ 0L,1L,2L,0L,2L,1L,3L,1L,0L,1L,3L,0L,3L,1L,2L,3L,2L,0L,2L,3L,0L,3L,2L,1L,4L,1L,2L,4L,2L,1L,0L,1L,2L,0L,2L,1L,4L,1L,0L,1L,4L,0L,4L,1L,2L,4L,2L,0L,2L,4L,0L,4L,2L,1L,3L,1L,4L,1L,3L,4L,3L,1L,0L,1L,3L,0L,3L,1L,4L,1L,0L,1L,4L,0L,4L,1L,3L,4L,3L,0L,3L,4L,0L,4L,3L,1L,2L,3L,2L,4L,2L,3L,4L,3L,2L,0L,2L,3L,0L,3L,2L,4L,2L,0L,2L,4L,0L,4L,2L,3L,4L,3L,0L,3L,4L,0L,4L,3L,2L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191247Inst : IEnumerable<long>
{
public static readonly long[] Value=A191247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191247.Bytes);
public long this[int i]=>Value[i];

public static A191247Inst Instance=new A191247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191248
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,2L,5L,2L,6L,2L,3L,6L,3L,2L,7L,8L,7L,6L,3L,9L,3L,9L,3L,9L,3L,10L,3L,7L,2L,19L,2L,12L,12L,24L,13L,15L,14L,9L,2L,16L,3L,12L,13L,17L,38L,4L,38L,38L,4L,21L,39L,4L,19L,40L,4L,18L,41L,42L,23L,42L,23L,23L,45L,29L,47L,47L,34L,26L,47L,38L,21L,47L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191248Inst : IEnumerable<long>
{
public static readonly long[] Value=A191248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191248.Bytes);
public long this[int i]=>Value[i];

public static A191248Inst Instance=new A191248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191249
{
public static readonly long[] Value={ 2L,12L,4L,432L,72L,8L,61344L,3888L,288L,16L,32866560L,665280L,21600L,960L,32L,68307743232L,407306880L,4328640L,95040L,2880L,64L,561981464819712L,965518299648L,2948037120L,21893760L,362880L,8064L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191249Inst : IEnumerable<long>
{
public static readonly long[] Value=A191249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191249.Bytes);
public long this[int i]=>Value[i];

public static A191249Inst Instance=new A191249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191250
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191250Inst : IEnumerable<long>
{
public static readonly long[] Value=A191250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191250.Bytes);
public long this[int i]=>Value[i];

public static A191250Inst Instance=new A191250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191251
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,27L,29L,31L,33L,35L,37L,39L,40L,42L,44L,46L,48L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,68L,70L,72L,74L,76L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,115L,117L,119L,121L,123L,125L,127L,128L,130L,132L,134L,136L,137L,139L,141L,143L,145L,147L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191251Inst : IEnumerable<long>
{
public static readonly long[] Value=A191251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191251.Bytes);
public long this[int i]=>Value[i];

public static A191251Inst Instance=new A191251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191252
{
public static readonly long[] Value={ 2L,6L,9L,11L,15L,17L,21L,25L,28L,30L,34L,38L,41L,43L,47L,50L,52L,56L,58L,62L,66L,69L,71L,75L,78L,80L,84L,86L,90L,94L,97L,99L,103L,105L,109L,113L,116L,118L,122L,126L,129L,131L,135L,138L,140L,144L,146L,150L,154L,157L,159L,163L,165L,169L,173L,176L,178L,182L,186L,189L,191L,195L,198L,200L,204L,206L,210L,214L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191252Inst : IEnumerable<long>
{
public static readonly long[] Value=A191252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191252.Bytes);
public long this[int i]=>Value[i];

public static A191252Inst Instance=new A191252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191253
{
public static readonly long[] Value={ 4L,13L,19L,23L,32L,36L,45L,54L,60L,64L,73L,82L,88L,92L,101L,107L,111L,120L,124L,133L,142L,148L,152L,161L,167L,171L,180L,184L,193L,202L,208L,212L,221L,225L,234L,243L,249L,253L,262L,271L,277L,281L,290L,296L,300L,309L,313L,322L,331L,337L,341L,350L,354L,363L,372L,378L,382L,391L,400L,406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191253Inst : IEnumerable<long>
{
public static readonly long[] Value=A191253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191253.Bytes);
public long this[int i]=>Value[i];

public static A191253Inst Instance=new A191253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191254
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191254Inst : IEnumerable<long>
{
public static readonly long[] Value=A191254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191254.Bytes);
public long this[int i]=>Value[i];

public static A191254Inst Instance=new A191254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191255
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191255Inst : IEnumerable<long>
{
public static readonly long[] Value=A191255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191255.Bytes);
public long this[int i]=>Value[i];

public static A191255Inst Instance=new A191255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191256
{
public static readonly long[] Value={ 2L,6L,10L,14L,16L,18L,22L,26L,30L,34L,38L,42L,46L,48L,50L,54L,58L,62L,66L,70L,74L,78L,80L,82L,86L,90L,94L,98L,102L,106L,110L,112L,114L,118L,122L,126L,128L,130L,134L,138L,142L,144L,146L,150L,154L,158L,162L,166L,170L,174L,176L,178L,182L,186L,190L,194L,198L,202L,206L,208L,210L,214L,218L,222L,226L,230L,234L,238L,240L,242L,246L,250L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191256Inst : IEnumerable<long>
{
public static readonly long[] Value=A191256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191256.Bytes);
public long this[int i]=>Value[i];

public static A191256Inst Instance=new A191256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191257
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,9L,11L,13L,15L,17L,19L,21L,23L,24L,25L,27L,29L,31L,33L,35L,37L,39L,40L,41L,43L,45L,47L,49L,51L,53L,55L,56L,57L,59L,61L,63L,64L,65L,67L,69L,71L,72L,73L,75L,77L,79L,81L,83L,85L,87L,88L,89L,91L,93L,95L,97L,99L,101L,103L,104L,105L,107L,109L,111L,113L,115L,117L,119L,120L,121L,123L,125L,127L,129L,131L,133L,135L,136L,137L,139L,141L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191257Inst : IEnumerable<long>
{
public static readonly long[] Value=A191257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191257.Bytes);
public long this[int i]=>Value[i];

public static A191257Inst Instance=new A191257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191258
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191258Inst : IEnumerable<long>
{
public static readonly long[] Value=A191258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191258.Bytes);
public long this[int i]=>Value[i];

public static A191258Inst Instance=new A191258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191259
{
public static readonly long[] Value={ 2L,6L,10L,14L,17L,19L,23L,27L,31L,33L,37L,41L,45L,49L,52L,54L,58L,62L,66L,70L,74L,78L,82L,86L,89L,91L,95L,99L,103L,105L,109L,113L,117L,121L,124L,126L,130L,134L,138L,142L,146L,149L,151L,155L,159L,163L,166L,168L,172L,176L,180L,182L,186L,190L,194L,198L,201L,203L,207L,211L,215L,219L,223L,227L,231L,235L,238L,240L,244L,248L,252L,254L,258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191259Inst : IEnumerable<long>
{
public static readonly long[] Value=A191259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191259.Bytes);
public long this[int i]=>Value[i];

public static A191259Inst Instance=new A191259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191308
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,1L,8L,2L,13L,6L,1L,21L,12L,2L,34L,26L,9L,1L,55L,50L,19L,2L,89L,97L,52L,13L,1L,144L,180L,108L,28L,2L,233L,332L,243L,97L,18L,1L,377L,600L,488L,210L,39L,2L,610L,1076L,999L,552L,170L,24L,1L,987L,1908L,1942L,1168L,376L,52L,2L,1597L,3361L,3773L,2663L,1162L,282L,31L,1L,2584L,5878L,7140L,5466L,2543L,630L,67L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191308Inst : IEnumerable<long>
{
public static readonly long[] Value=A191308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191308.Bytes);
public long this[int i]=>Value[i];

public static A191308Inst Instance=new A191308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191309
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,8L,16L,47L,94L,244L,488L,1186L,2372L,5536L,11072L,25147L,50294L,112028L,224056L,491870L,983740L,2135440L,4270880L,9188406L,18376812L,39249768L,78499536L,166656772L,333313544L,704069248L,1408138496L,2961699667L,5923399334L,12412521388L,24825042776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191309Inst : IEnumerable<long>
{
public static readonly long[] Value=A191309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191309.Bytes);
public long this[int i]=>Value[i];

public static A191309Inst Instance=new A191309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191310
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,6L,3L,1L,10L,8L,1L,1L,14L,16L,4L,1L,23L,32L,13L,1L,1L,32L,56L,32L,5L,1L,55L,102L,74L,19L,1L,1L,78L,170L,152L,55L,6L,1L,143L,302L,307L,144L,26L,1L,1L,208L,498L,580L,336L,86L,7L,1L,405L,890L,1102L,748L,251L,34L,1L,1L,602L,1478L,2004L,1564L,652L,126L,8L,1L,1228L,2691L,3714L,3200L,1587L,405L,43L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191310Inst : IEnumerable<long>
{
public static readonly long[] Value=A191310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191310.Bytes);
public long this[int i]=>Value[i];

public static A191310Inst Instance=new A191310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191311
{
public static readonly long[] Value={ 4L,6L,15L,91L,703L,1891L,2701L,11305L,12403L,13981L,18721L,23001L,30889L,38503L,39865L,49141L,68101L,79003L,88561L,88831L,91001L,93961L,104653L,107185L,137149L,146611L,152551L,157641L,176149L,188191L,204001L,218791L,226801L,228241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191311Inst : IEnumerable<long>
{
public static readonly long[] Value=A191311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191311.Bytes);
public long this[int i]=>Value[i];

public static A191311Inst Instance=new A191311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191312
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,2L,1L,2L,1L,0L,3L,2L,2L,2L,1L,0L,6L,3L,4L,2L,4L,1L,0L,10L,6L,6L,4L,4L,4L,1L,0L,20L,10L,12L,6L,8L,4L,9L,1L,0L,35L,20L,20L,12L,12L,8L,9L,9L,1L,0L,70L,35L,40L,20L,24L,12L,18L,9L,23L,1L,0L,126L,70L,70L,40L,40L,24L,27L,18L,23L,23L,1L,0L,252L,126L,140L,70L,80L,40L,54L,27L,46L,23L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191312Inst : IEnumerable<long>
{
public static readonly long[] Value=A191312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191312.Bytes);
public long this[int i]=>Value[i];

public static A191312Inst Instance=new A191312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191313
{
public static readonly long[] Value={ 0L,0L,2L,5L,15L,30L,71L,134L,296L,551L,1188L,2211L,4720L,8815L,18722L,35105L,74307L,139842L,295223L,557366L,1174031L,2222606L,4672473L,8866776L,18607461L,35384676L,74139407L,141248270L,295524297L,563959752L,1178389423L,2252131246L,4700155088L,8995122383L,18751860084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191313Inst : IEnumerable<long>
{
public static readonly long[] Value=A191313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191313.Bytes);
public long this[int i]=>Value[i];

public static A191313Inst Instance=new A191313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191314
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,7L,2L,1L,12L,6L,1L,1L,20L,12L,2L,1L,33L,27L,8L,1L,1L,54L,53L,16L,2L,1L,88L,108L,44L,10L,1L,1L,143L,208L,88L,20L,2L,1L,232L,405L,208L,65L,12L,1L,1L,376L,768L,415L,130L,24L,2L,1L,609L,1459L,908L,350L,90L,14L,1L,1L,986L,2734L,1804L,700L,180L,28L,2L,1L,1596L,5117L,3776L,1700L,544L,119L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191314Inst : IEnumerable<long>
{
public static readonly long[] Value=A191314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191314.Bytes);
public long this[int i]=>Value[i];

public static A191314Inst Instance=new A191314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191315
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,11L,27L,50L,115L,216L,481L,913L,1992L,3809L,8192L,15748L,33512L,64685L,136546L,264422L,554686L,1077055L,2248105L,4375221L,9095238L,17735812L,36745504L,71776633L,148288346L,290092160L,597876033L,1171153370L,2408702852L,4723840544L,9697826974L,19038878297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191315Inst : IEnumerable<long>
{
public static readonly long[] Value=A191315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191315.Bytes);
public long this[int i]=>Value[i];

public static A191315Inst Instance=new A191315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191316
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,1L,8L,2L,14L,5L,1L,23L,10L,2L,40L,23L,6L,1L,67L,44L,13L,2L,117L,92L,35L,7L,1L,198L,174L,72L,16L,2L,346L,350L,170L,49L,8L,1L,590L,654L,345L,106L,19L,2L,1032L,1280L,768L,277L,65L,9L,1L,1769L,2374L,1530L,592L,146L,22L,2L,3096L,4564L,3263L,1436L,417L,83L,10L,1L,5328L,8414L,6417L,3004L,928L,192L,25L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191316Inst : IEnumerable<long>
{
public static readonly long[] Value=A191316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191316.Bytes);
public long this[int i]=>Value[i];

public static A191316Inst Instance=new A191316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191317
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,14L,23L,40L,67L,117L,198L,346L,590L,1032L,1769L,3096L,5328L,9329L,16103L,28205L,48801L,85500L,148216L,259733L,450952L,790387L,1374044L,2408653L,4191814L,7349019L,12801243L,22445281L,39127766L,68611494L,119687036L,209890344L,366348367L,642493426L,1121992447L,1967839835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191317Inst : IEnumerable<long>
{
public static readonly long[] Value=A191317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191317.Bytes);
public long this[int i]=>Value[i];

public static A191317Inst Instance=new A191317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191318
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,2L,1L,4L,5L,1L,5L,10L,4L,1L,6L,16L,12L,1L,7L,24L,30L,8L,1L,8L,33L,56L,28L,1L,9L,44L,98L,84L,16L,1L,10L,56L,152L,179L,64L,1L,11L,70L,228L,358L,224L,32L,1L,12L,85L,320L,618L,536L,144L,1L,13L,102L,440L,1030L,1206L,576L,64L,1L,14L,120L,580L,1580L,2292L,1528L,320L,1L,15L,140L,754L,2370L,4202L,3820L,1440L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191318Inst : IEnumerable<long>
{
public static readonly long[] Value=A191318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191318.Bytes);
public long this[int i]=>Value[i];

public static A191318Inst Instance=new A191318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191319
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,14L,37L,74L,177L,354L,807L,1614L,3579L,7158L,15591L,31182L,67071L,134142L,285861L,571722L,1209641L,2419282L,5089517L,10179034L,21314453L,42628906L,88918353L,177836706L,369734553L,739469106L,1533115953L,3066231906L,6341759073L,12683518146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191319Inst : IEnumerable<long>
{
public static readonly long[] Value=A191319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191319.Bytes);
public long this[int i]=>Value[i];

public static A191319Inst Instance=new A191319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191320
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,4L,2L,4L,6L,9L,10L,1L,9L,23L,3L,23L,36L,11L,23L,77L,25L,1L,65L,118L,65L,4L,65L,249L,131L,17L,197L,380L,298L,48L,1L,197L,808L,566L,140L,5L,626L,1236L,1210L,336L,24L,626L,2665L,2230L,833L,80L,1L,2056L,4094L,4627L,1828L,259L,6L,2056L,8955L,8401L,4155L,711L,32L,6918L,13816L,17192L,8648L,1923L,122L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191320Inst : IEnumerable<long>
{
public static readonly long[] Value=A191320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191320.Bytes);
public long this[int i]=>Value[i];

public static A191320Inst Instance=new A191320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191321
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,9L,14L,20L,27L,47L,74L,109L,153L,262L,415L,622L,894L,1516L,2410L,3653L,5335L,8988L,14323L,21883L,32330L,54213L,86543L,133004L,198229L,331233L,529462L,817432L,1226719L,2044151L,3270870L,5068346L,7648526L,12716872L,20365398L,31651555L,47984938L,79636493L,127621431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191321Inst : IEnumerable<long>
{
public static readonly long[] Value=A191321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191321.Bytes);
public long this[int i]=>Value[i];

public static A191321Inst Instance=new A191321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191322
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,1L,1L,2L,2L,1L,1L,2L,0L,0L,1L,2L,2L,2L,3L,2L,2L,2L,0L,0L,1L,2L,3L,3L,2L,2L,2L,3L,0L,1L,2L,2L,3L,4L,2L,3L,3L,3L,0L,1L,2L,3L,2L,2L,4L,4L,4L,4L,0L,0L,1L,2L,2L,1L,4L,4L,4L,4L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191322Inst : IEnumerable<long>
{
public static readonly long[] Value=A191322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191322.Bytes);
public long this[int i]=>Value[i];

public static A191322Inst Instance=new A191322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191323
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,13L,17L,20L,22L,26L,31L,34L,40L,47L,52L,61L,67L,71L,79L,92L,94L,101L,103L,107L,119L,121L,139L,142L,152L,155L,157L,161L,179L,182L,184L,202L,209L,214L,229L,233L,236L,238L,242L,269L,274L,277L,283L,304L,310L,314L,322L,344L,350L,355L,358L,364L,404L,412L,416L,418L,425L,427L,457L,466L,472L,484L,517L,526L,533L,538L,547L,553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191323Inst : IEnumerable<long>
{
public static readonly long[] Value=A191323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191323.Bytes);
public long this[int i]=>Value[i];

public static A191323Inst Instance=new A191323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191356
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,17L,21L,27L,33L,45L,51L,65L,73L,99L,129L,153L,165L,195L,257L,273L,297L,325L,367L,513L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191356Inst : IEnumerable<long>
{
public static readonly long[] Value=A191356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191356.Bytes);
public long this[int i]=>Value[i];

public static A191356Inst Instance=new A191356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191357
{
public static readonly BigInteger[] Value={ 103L,479L,3673L,55147L,2024063L,243937297L,142915724779L,685893080269745L,BigInteger.Parse("53978528420922581864"),BigInteger.Parse("175329092084368391071206608"),BigInteger.Parse("80227969100540338877503013472650510"),BigInteger.Parse("26469961649988241699181245714190498215773679043") };
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
public class A191357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191357Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191357.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191357.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191357Inst Instance=new A191357Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191358
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,4L,6L,4L,1L,1L,3L,3L,3L,6L,3L,1L,3L,3L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,10L,10L,5L,1L,1L,4L,4L,6L,12L,6L,4L,12L,12L,4L,1L,4L,6L,4L,1L,1L,3L,3L,3L,3L,6L,6L,3L,6L,3L,1L,3L,3L,3L,6L,3L,1L,3L,3L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,15L,20L,15L,6L,1L,1L,5L,5L,10L,20L,10L,10L,30L,30L,10L,5L,20L,30L,20L,5L,1L,5L,10L,10L,5L,1L,1L,4L,4L,4L,6L,12L,12L,6L,12L,6L,4L,12L,12L,12L,24L,12L,4L,12L,12L,4L,1L,4L,4L,6L,12L,6L,4L,12L,12L,4L,1L,4L,6L,4L,1L,1L,3L,3L,3L,3L,3L,6L,6L,6L,3L,6L,6L,3L,6L,3L,1L,3L,3L,3L,3L,6L,6L,3L,6L,3L,1L,3L,3L,3L,6L,3L,1L,3L,3L,1L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,21L,35L,35L,21L,7L,1L,1L,6L,6L,15L,30L,15L,20L,60L,60L,20L,15L,60L,90L,60L,15L,6L,30L,60L,60L,30L,6L,1L,6L,15L,20L,15L,6L,1L,1L,5L,5L,5L,10L,20L,20L,10L,20L,10L,10L,30L,30L,30L,60L,30L,10L,30L,30L,10L,5L,20L,20L,30L,60L,30L,20L,60L,60L,20L,5L,20L,30L,20L,5L,1L,5L,5L,10L,20L,10L,10L,30L,30L,10L,5L,20L,30L,20L,5L,1L,5L,10L,10L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191358Inst : IEnumerable<long>
{
public static readonly long[] Value=A191358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191358.Bytes);
public long this[int i]=>Value[i];

public static A191358Inst Instance=new A191358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191359
{
public static readonly long[] Value={ 2L,6L,1L,1L,8L,8L,2L,4L,9L,2L,6L,4L,0L,0L,7L,2L,5L,4L,2L,8L,8L,4L,9L,2L,7L,0L,1L,3L,5L,2L,7L,1L,6L,5L,0L,5L,5L,0L,7L,2L,4L,0L,9L,6L,2L,7L,5L,2L,4L,0L,1L,0L,8L,0L,6L,3L,3L,4L,9L,7L,9L,3L,4L,4L,0L,7L,1L,5L,7L,4L,0L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191359Inst : IEnumerable<long>
{
public static readonly long[] Value=A191359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191359.Bytes);
public long this[int i]=>Value[i];

public static A191359Inst Instance=new A191359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191360
{
public static readonly long[] Value={ 0L,1L,2L,-1L,3L,-2L,0L,4L,-3L,-1L,1L,-4L,5L,-5L,-2L,0L,-6L,2L,-7L,-3L,6L,-8L,-4L,-1L,-9L,1L,-10L,-5L,3L,-11L,-6L,-2L,-12L,7L,-13L,-7L,-3L,-14L,0L,-15L,-8L,2L,-16L,-9L,-4L,-17L,4L,-18L,-10L,-5L,-19L,-1L,-20L,-11L,8L,-21L,-12L,-6L,-22L,-2L,-23L,-13L,1L,-24L,-14L,-7L,-25L,3L,-26L,-15L,-8L,-27L,-3L,-28L,-16L,5L,-29L,-17L,-9L,-30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191360Inst : IEnumerable<long>
{
public static readonly long[] Value=A191360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191360.Bytes);
public long this[int i]=>Value[i];

public static A191360Inst Instance=new A191360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191361
{
public static readonly long[] Value={ 0L,1L,-1L,-2L,2L,-3L,0L,-4L,-5L,-1L,-6L,-7L,3L,-8L,-2L,-9L,-10L,1L,-11L,-3L,-12L,-13L,-4L,-14L,-15L,0L,-16L,-5L,-17L,-18L,-6L,-19L,-20L,4L,-21L,-7L,-22L,-23L,-1L,-24L,-8L,-25L,-26L,-9L,-27L,-28L,2L,-29L,-10L,-30L,-31L,-2L,-32L,-11L,-33L,-34L,-12L,-35L,-36L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191361Inst : IEnumerable<long>
{
public static readonly long[] Value=A191361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191361.Bytes);
public long this[int i]=>Value[i];

public static A191361Inst Instance=new A191361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191362
{
public static readonly long[] Value={ 0L,-1L,1L,-2L,2L,0L,3L,-3L,4L,1L,5L,-1L,6L,2L,7L,-4L,8L,3L,9L,0L,10L,4L,11L,-2L,12L,5L,13L,1L,14L,6L,15L,-5L,16L,7L,17L,2L,18L,8L,19L,-1L,20L,9L,21L,3L,22L,10L,23L,-3L,24L,11L,25L,4L,26L,12L,27L,0L,28L,13L,29L,5L,30L,14L,31L,-6L,32L,15L,33L,6L,34L,16L,35L,1L,36L,17L,37L,7L,38L,18L,39L,-2L,40L,19L,41L,8L,42L,20L,43L,2L,44L,21L,45L,9L,46L,22L,47L,-4L,48L,23L,49L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191362Inst : IEnumerable<long>
{
public static readonly long[] Value=A191362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191362.Bytes);
public long this[int i]=>Value[i];

public static A191362Inst Instance=new A191362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191363
{
public static readonly long[] Value={ 3L,10L,136L,32896L,2147516416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191363Inst : IEnumerable<long>
{
public static readonly long[] Value=A191363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191363.Bytes);
public long this[int i]=>Value[i];

public static A191363Inst Instance=new A191363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191364
{
public static readonly BigInteger[] Value={ 1L,1L,2L,15L,152L,2190L,39894L,886074L,23187632L,699092136L,23860707480L,909507899520L,38295831424872L,1765316863497720L,88423030108046256L,4782130014839166360L,BigInteger.Parse("277730241327729713280"),BigInteger.Parse("17239188136821392859840") };
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
public class A191364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191364Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191364.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191364.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191364Inst Instance=new A191364Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191365
{
public static readonly BigInteger[] Value={ 1L,1L,4L,18L,102L,695L,5485L,49077L,490308L,5404569L,65106103L,850535477L,11972432846L,180605413001L,2906109200293L,49678357272247L,898988188301320L,17167497793440977L,344991795682802331L,7277230501449340417L,BigInteger.Parse("160765066207998479698") };
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
public class A191365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191365Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191365.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191365Inst Instance=new A191365Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191366
{
public static readonly long[] Value={ 0L,4L,4L,20L,59L,164L,544L,1730L,5471L,17765L,55050L,173906L,546893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191366Inst : IEnumerable<long>
{
public static readonly long[] Value=A191366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191366.Bytes);
public long this[int i]=>Value[i];

public static A191366Inst Instance=new A191366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191367
{
public static readonly long[] Value={ 9L,728L,2457L,189L,189L,126L,91L,9L,1001L,28L,91L,126L,133L,9L,2331L,91L,91L,189L,91L,854L,9L,133L,133L,2457L,217L,28L,9L,126L,217L,468L,133L,189L,3528L,11772L,637L,28L,133L,28L,9L,189L,637L,468L,217L,559L,152L,637L,559L,126L,72L,637L,5256L,9L,793L,28L,793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191367Inst : IEnumerable<long>
{
public static readonly long[] Value=A191367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191367.Bytes);
public long this[int i]=>Value[i];

public static A191367Inst Instance=new A191367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191368
{
public static readonly BigInteger[] Value={ 1L,2L,5L,12L,12L,-120L,-600L,6720L,84672L,-1088640L,-27216000L,399168000L,17337576960L,-286858091520L,-19833061248000L,366148823040000L,37838865512448000L,-771912856453939200L,BigInteger.Parse("-113678565831806976000"),BigInteger.Parse("2541050295063920640000"),BigInteger.Parse("513635665355584192512000") };
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
public class A191368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191368Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191368.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191368Inst Instance=new A191368Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191369
{
public static readonly long[] Value={ 11L,155L,203L,2164L,2228L,2252L,2276L,2348L,2404L,2452L,2468L,2588L,2612L,2636L,2644L,2675L,2708L,2763L,2836L,2891L,2979L,3148L,3179L,3236L,3275L,3283L,3411L,3475L,3716L,3971L,33723L,33755L,34235L,34523L,34539L,34715L,34771L,35315L,35563L,35571L,35787L,36155L,36411L,36507L,36555L,36579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191369Inst : IEnumerable<long>
{
public static readonly long[] Value=A191369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191369.Bytes);
public long this[int i]=>Value[i];

public static A191369Inst Instance=new A191369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191370
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,8L,22L,44L,88L,170L,340L,680L,1366L,2732L,5464L,10922L,21844L,43688L,87382L,174764L,349528L,699050L,1398100L,2796200L,5592406L,11184812L,22369624L,44739242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191370Inst : IEnumerable<long>
{
public static readonly long[] Value=A191370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191370.Bytes);
public long this[int i]=>Value[i];

public static A191370Inst Instance=new A191370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191371
{
public static readonly BigInteger[] Value={ 1L,3L,15L,123L,1635L,35043L,1206915L,66622083L,5884188675L,830476531203L,187106645932035L,67241729173555203L,BigInteger.Parse("38521811621470420995"),BigInteger.Parse("35161184767296890265603"),BigInteger.Parse("51112793797110111859802115"),BigInteger.Parse("118291368253025368001553530883"),BigInteger.Parse("435713124846749574718274002747395"),BigInteger.Parse("2553666761436949125065383836043837443") };
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
public class A191371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191371Inst Instance=new A191371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191628
{
public static readonly long[] Value={ 3L,2L,3L,8L,18L,45L,115L,298L,787L,2108L,5714L,15630L,43089L,119574L,333695L,935798L,2635513L,7450394L,21132026L,60116972L,171481200L,490329056L,1405122072L,4034707664L,11606693280L,33445603004L,96526550442L,278985273840L,807416204292L,2339671955621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191628Inst : IEnumerable<long>
{
public static readonly long[] Value=A191628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191628.Bytes);
public long this[int i]=>Value[i];

public static A191628Inst Instance=new A191628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191629
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,3L,6L,11L,19L,35L,64L,117L,215L,399L,744L,1394L,2621L,4946L,9362L,17772L,33825L,64527L,123361L,236298L,453438L,871543L,1677721L,3234162L,6242685L,12064514L,23342213L,45210182L,87652393L,170097714L,330382099L,642238100L,1249445031L,2432547849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191629Inst : IEnumerable<long>
{
public static readonly long[] Value=A191629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191629.Bytes);
public long this[int i]=>Value[i];

public static A191629Inst Instance=new A191629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191630
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,4L,8L,15L,26L,48L,89L,163L,303L,564L,1057L,1985L,3744L,7084L,13443L,25575L,48770L,93206L,178481L,342392L,657930L,1266204L,2440322L,4709393L,9099506L,17602324L,34087042L,66076419L,128207978L,248983611L,483939977L,941362695L,1832519379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191630Inst : IEnumerable<long>
{
public static readonly long[] Value=A191630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191630.Bytes);
public long this[int i]=>Value[i];

public static A191630Inst Instance=new A191630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191631
{
public static readonly long[] Value={ 2L,1L,1L,2L,3L,5L,9L,17L,30L,53L,97L,178L,327L,606L,1129L,2114L,3971L,7489L,14169L,26886L,51150L,97541L,186413L,356962L,684784L,1315860L,2532409L,4880644L,9418787L,18199013L,35204649L,68174084L,132152839L,256415957L,497967222L,967879954L,1882725390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191631Inst : IEnumerable<long>
{
public static readonly long[] Value=A191631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191631.Bytes);
public long this[int i]=>Value[i];

public static A191631Inst Instance=new A191631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191632
{
public static readonly long[] Value={ 3L,3L,5L,11L,27L,66L,168L,437L,1157L,3107L,8435L,23106L,63772L,177147L,494789L,1388603L,3913338L,11069156L,31412472L,89404728L,255130565L,729792083L,2092070640L,6009139074L,17291604274L,49840506437L,143879197829L,415941680999L,1204041708155L,3489680204994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191632Inst : IEnumerable<long>
{
public static readonly long[] Value=A191632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191632.Bytes);
public long this[int i]=>Value[i];

public static A191632Inst Instance=new A191632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191633
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,5L,8L,15L,27L,48L,89L,163L,303L,565L,1057L,1985L,3744L,7085L,13443L,25575L,48771L,93206L,178481L,342392L,657930L,1266205L,2440322L,4709393L,9099507L,17602325L,34087042L,66076419L,128207979L,248983611L,483939977L,941362695L,1832519379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191633Inst : IEnumerable<long>
{
public static readonly long[] Value=A191633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191633.Bytes);
public long this[int i]=>Value[i];

public static A191633Inst Instance=new A191633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191634
{
public static readonly long[] Value={ 1L,1L,2L,6L,15L,38L,99L,262L,703L,1904L,5210L,14363L,39858L,111231L,311932L,878504L,2483464L,7044008L,20038990L,57160400L,163443018L,468374024L,1344902554L,3868897760L,11148534334L,32175516814L,92995091280L,269138734764L,779890651873L,2262539913128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191634Inst : IEnumerable<long>
{
public static readonly long[] Value=A191634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191634.Bytes);
public long this[int i]=>Value[i];

public static A191634Inst Instance=new A191634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191635
{
public static readonly long[] Value={ 1L,1L,1L,0L,-4L,-10L,14L,196L,440L,-3168L,-27856L,-16192L,1164272L,7585552L,-23621872L,-695464800L,-3191206912L,38919085184L,661218763136L,1320994868224L,-74958266666752L,-932434904045568L,2633042904931328L,193750955482836992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191635Inst : IEnumerable<long>
{
public static readonly long[] Value=A191635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191635.Bytes);
public long this[int i]=>Value[i];

public static A191635Inst Instance=new A191635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191636
{
public static readonly long[] Value={ 3L,5L,12L,36L,113L,372L,1260L,4369L,15420L,55188L,199728L,729444L,2684354L,9942053L,37025580L,138547332L,520602096L,1963413621L,7429132620L,28192605840L,107269427100L,409120605684L,1563749870614L,5988829291716L,22977549119237L,88305875046480L,339894311499660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191636Inst : IEnumerable<long>
{
public static readonly long[] Value=A191636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191636.Bytes);
public long this[int i]=>Value[i];

public static A191636Inst Instance=new A191636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191637
{
public static readonly long[] Value={ 1L,3L,9L,28L,93L,315L,1092L,3855L,13797L,49932L,182361L,671088L,2485513L,9256395L,34636833L,130150524L,490853405L,1857283155L,7048151460L,26817356775L,102280151421L,390937467653L,1497207322929L,5744387279809L,22076468761620L,84973577874915L,327534518354217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191637Inst : IEnumerable<long>
{
public static readonly long[] Value=A191637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191637.Bytes);
public long this[int i]=>Value[i];

public static A191637Inst Instance=new A191637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191638
{
public static readonly long[] Value={ 1L,3L,7L,23L,73L,240L,819L,2849L,10082L,36157L,131071L,479349L,1766022L,6547206L,24403223L,91382282L,343597383L,1296593900L,4908534052L,18635790301L,70936234050L,270649016067L,1034834473200L,3964436291699L,15214863605981L,58488306848967L,225179981368524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191638Inst : IEnumerable<long>
{
public static readonly long[] Value=A191638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191638.Bytes);
public long this[int i]=>Value[i];

public static A191638Inst Instance=new A191638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191639
{
public static readonly long[] Value={ 1L,2L,6L,19L,64L,215L,744L,2621L,9362L,33825L,123361L,453438L,1677721L,6242685L,23342213L,87652393L,330382099L,1249445031L,4739274257L,18024780783L,68719476736L,262569940961L,1005267773966L,3855821598776L,14814472458455L,57007590219879L,219687786700999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191639Inst : IEnumerable<long>
{
public static readonly long[] Value=A191639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191639.Bytes);
public long this[int i]=>Value[i];

public static A191639Inst Instance=new A191639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191640
{
public static readonly long[] Value={ 1L,2L,5L,17L,53L,178L,606L,2114L,7489L,26886L,97541L,356962L,1315860L,4880644L,18199013L,68174084L,256415957L,967879954L,3665038759L,13917868706L,52988512181L,202209034993L,773282903051L,2962894491691L,11372726331743L,43724268226898L,168358864574597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191640Inst : IEnumerable<long>
{
public static readonly long[] Value=A191640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191640.Bytes);
public long this[int i]=>Value[i];

public static A191640Inst Instance=new A191640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191641
{
public static readonly long[] Value={ 1L,1L,5L,15L,48L,163L,565L,1985L,7085L,25575L,93206L,342392L,1266205L,4709393L,17602325L,66076419L,248983611L,941362695L,3569842947L,13574217626L,51741723660L,197665011735L,756653163200L,2901803883615L,11147523830125L,42891425022576L,165269711096165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191641Inst : IEnumerable<long>
{
public static readonly long[] Value=A191641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191641.Bytes);
public long this[int i]=>Value[i];

public static A191641Inst Instance=new A191641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191642
{
public static readonly long[] Value={ 15L,4697L,5548L,14774L,33696L,61072L,111231L,115985L,173819L,563316L,606004L,1751458L,1952544L,3046715L,4397195L,45051907L,653475595L,734915444L,1241384578L,2438767174L,2557084119L,5090226634L,6088149715L,18483120028L,44254634530L,48502484589L,70835215004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191642Inst : IEnumerable<long>
{
public static readonly long[] Value=A191642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191642.Bytes);
public long this[int i]=>Value[i];

public static A191642Inst Instance=new A191642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191643
{
public static readonly long[] Value={ 2L,8L,22L,94L,454L,2430L,14214L,89918L,610182L,4412958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191643Inst : IEnumerable<long>
{
public static readonly long[] Value=A191643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191643.Bytes);
public long this[int i]=>Value[i];

public static A191643Inst Instance=new A191643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191676
{
public static readonly long[] Value={ 14L,33L,39L,60L,64L,84L,95L,110L,138L,150L,155L,174L,189L,217L,248L,258L,259L,272L,315L,324L,360L,368L,390L,399L,405L,410L,430L,473L,504L,530L,539L,564L,584L,624L,663L,670L,732L,754L,770L,819L,852L,854L,869L,885L,897L,915L,1005L,1008L,1024L,1053L,1056L,1065L,1104L,1110L,1120L,1139L,1155L,1248L,1278L,1292L,1360L,1378L,1422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191676Inst : IEnumerable<long>
{
public static readonly long[] Value=A191676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191676.Bytes);
public long this[int i]=>Value[i];

public static A191676Inst Instance=new A191676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191677
{
public static readonly long[] Value={ 1L,4L,8L,12L,16L,20L,24L,28L,32L,35L,36L,40L,44L,48L,52L,55L,56L,60L,64L,68L,72L,76L,77L,80L,84L,88L,92L,95L,96L,100L,104L,108L,112L,115L,116L,119L,120L,124L,128L,132L,136L,140L,143L,144L,148L,152L,155L,156L,160L,161L,164L,168L,172L,176L,180L,184L,187L,188L,192L,196L,200L,203L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191677Inst : IEnumerable<long>
{
public static readonly long[] Value=A191677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191677.Bytes);
public long this[int i]=>Value[i];

public static A191677Inst Instance=new A191677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191678
{
public static readonly long[] Value={ 1L,1L,5L,15L,62L,233L,937L,3729L,15121L,61492L,251942L,1036215L,4279754L,17731181L,73670725L,306823695L,1280574706L,5354602495L,22426876445L,94070238840L,395106054632L,1661489413472L,6994494531010L,29474635716345L,124319047552309L,524797934104312L,2217091297558466L,9373180869094923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191678Inst : IEnumerable<long>
{
public static readonly long[] Value=A191678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191678.Bytes);
public long this[int i]=>Value[i];

public static A191678Inst Instance=new A191678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191679
{
public static readonly long[] Value={ 2211L,2261L,2311L,2463L,2725L,4257L,6125L,6611L,7821L,9841L,9973L,10303L,10499L,10631L,10953L,11987L,12115L,12179L,12243L,12309L,12375L,12637L,12837L,13497L,13695L,14169L,15063L,15395L,16207L,16483L,16821L,17605L,17891L,19017L,20345L,20487L,21135L,22539L,22811L,23219L,23985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191679Inst : IEnumerable<long>
{
public static readonly long[] Value=A191679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191679.Bytes);
public long this[int i]=>Value[i];

public static A191679Inst Instance=new A191679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191680
{
public static readonly long[] Value={ 0L,256L,9841L,131072L,976562L,5038848L,20176803L,67108864L,193710244L,500000000L,1178973845L,2579890176L,5302249686L,10330523392L,19221679687L,34359738368L,59293938248L,99179645184L,161343848889L,256000000000L,397140023290L,603634608896L,900576330731L,1320903770112L,1907348632812L,2714751839488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191680Inst : IEnumerable<long>
{
public static readonly long[] Value=A191680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191680.Bytes);
public long this[int i]=>Value[i];

public static A191680Inst Instance=new A191680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191681
{
public static readonly long[] Value={ 0L,4L,40L,364L,3280L,29524L,265720L,2391484L,21523360L,193710244L,1743392200L,15690529804L,141214768240L,1270932914164L,11438396227480L,102945566047324L,926510094425920L,8338590849833284L,75047317648499560L,675425858836496044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191681Inst : IEnumerable<long>
{
public static readonly long[] Value=A191681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191681.Bytes);
public long this[int i]=>Value[i];

public static A191681Inst Instance=new A191681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191682
{
public static readonly long[] Value={ 2L,4L,4L,6L,6L,6L,6L,8L,8L,8L,8L,8L,8L,8L,8L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191682Inst : IEnumerable<long>
{
public static readonly long[] Value=A191682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191682.Bytes);
public long this[int i]=>Value[i];

public static A191682Inst Instance=new A191682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191683
{
public static readonly long[] Value={ 21L,33L,57L,69L,93L,105L,129L,177L,195L,213L,217L,237L,249L,265L,309L,393L,417L,445L,465L,483L,489L,565L,573L,597L,633L,645L,669L,753L,813L,865L,915L,933L,973L,987L,993L,1057L,1077L,1137L,1149L,1185L,1257L,1285L,1329L,1365L,1389L,1393L,1417L,1437L,1465L,1477L,1497L,1545L,1569L,1689L,1743L,1765L,1857L,1893L,1897L,1945L,1977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191683Inst : IEnumerable<long>
{
public static readonly long[] Value=A191683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191683.Bytes);
public long this[int i]=>Value[i];

public static A191683Inst Instance=new A191683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191684
{
public static readonly long[] Value={ 1L,2L,10L,46L,233L,1196L,6274L,33292L,178378L,962616L,5224965L,28494124L,156000816L,856903772L,4720235840L,26064910068L,144236627991L,799671246842L,4440913771641L,24699098156578L,137553727513369L,766990846033320L,4281404671954689L,23923170440346544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191684Inst : IEnumerable<long>
{
public static readonly long[] Value=A191684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191684.Bytes);
public long this[int i]=>Value[i];

public static A191684Inst Instance=new A191684Inst();

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