using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A243082
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,15L,31L,57L,114L,213L,410L,766L,1437L,2659L,4888L,9130L,16406L,29477L,54084L,96353L,170015L,303356L,536877L,932679L,1637383L,2831910L,4919306L,8395627L,14550779L,24673403L,41942730L,70587716L,120128827L,201556909L,336844168L,558644630L,932732821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243082Inst : IEnumerable<long>
{
public static readonly long[] Value=A243082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243082.Bytes);
public long this[int i]=>Value[i];

public static A243082Inst Instance=new A243082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243083
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,31L,63L,120L,240L,459L,897L,1716L,3294L,6258L,11852L,22283L,41647L,78197L,144013L,264485L,489979L,892277L,1612753L,2933983L,5288025L,9454944L,16891074L,30121434L,53179092L,93997401L,164816943L,289313718L,502617530L,877419533L,1514746093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243083Inst : IEnumerable<long>
{
public static readonly long[] Value=A243083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243083.Bytes);
public long this[int i]=>Value[i];

public static A243083Inst Instance=new A243083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243084
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,32L,63L,127L,247L,494L,960L,1892L,3672L,7147L,13798L,26581L,50929L,97196L,184578L,348856L,659351L,1232960L,2297710L,4293741L,7938967L,14597060L,26899716L,49245147L,89549454L,162797168L,294737328L,530981823L,953222139L,1708323110L,3043849193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243084Inst : IEnumerable<long>
{
public static readonly long[] Value=A243084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243084.Bytes);
public long this[int i]=>Value[i];

public static A243084Inst Instance=new A243084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243085
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,32L,64L,127L,255L,502L,1004L,1972L,3908L,7660L,15044L,29361L,57209L,110982L,214648L,413552L,793936L,1518344L,2892496L,5500825L,10392649L,19569158L,36845760L,68891188L,128241332L,238736764L,442162796L,814790985L,1499513369L,2750419066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243085Inst : IEnumerable<long>
{
public static readonly long[] Value=A243085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243085.Bytes);
public long this[int i]=>Value[i];

public static A243085Inst Instance=new A243085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243086
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,32L,64L,128L,255L,511L,1013L,2026L,4007L,7969L,15728L,31081L,61127L,120063L,234991L,458813L,892999L,1733063L,3352924L,6466805L,12432745L,23825009L,45552282L,86701276L,164516870L,311753791L,587855120L,1104493663L,2072926133L,3874661542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243086Inst : IEnumerable<long>
{
public static readonly long[] Value=A243086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243086.Bytes);
public long this[int i]=>Value[i];

public static A243086Inst Instance=new A243086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243087
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,32L,64L,128L,256L,511L,1023L,2036L,4072L,8089L,16123L,31971L,63447L,125464L,247848L,488248L,959954L,1882518L,3682966L,7186687L,13987505L,27151374L,52561888L,101473646L,195352782L,375197136L,718154110L,1370815210L,2611751010L,4957566835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243087Inst : IEnumerable<long>
{
public static readonly long[] Value=A243087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243087.Bytes);
public long this[int i]=>Value[i];

public static A243087Inst Instance=new A243087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243088
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1023L,2047L,4083L,8166L,16266L,32466L,64580L,128522L,255119L,506025L,1001545L,1979285L,3903439L,7683348L,15091124L,29577303L,57838511L,112844632L,219646810L,426513292L,826201797L,1596503761L,3077988342L,5917798459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243088Inst : IEnumerable<long>
{
public static readonly long[] Value=A243088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243088.Bytes);
public long this[int i]=>Value[i];

public static A243088Inst Instance=new A243088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243089
{
public static readonly long[] Value={ 25L,325L,1825L,4525L,4825L,10225L,12025L,16725L,20425L,30025L,35425L,58825L,177025L,216525L,265525L,352225L,526825L,611425L,675925L,710425L,717025L,746425L,772525L,784225L,834025L,877825L,1125825L,1126225L,1439425L,1491025L,1579225L,1935025L,1973425L,2176525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243089Inst : IEnumerable<long>
{
public static readonly long[] Value=A243089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243089.Bytes);
public long this[int i]=>Value[i];

public static A243089Inst Instance=new A243089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243090
{
public static readonly long[] Value={ 9L,45L,63L,117L,153L,585L,2169L,4005L,9945L,13833L,17865L,27261L,33201L,36873L,40833L,57681L,69345L,69921L,95085L,140985L,155961L,161721L,171405L,186201L,189441L,192465L,203841L,240471L,242451L,244413L,316881L,321201L,406341L,481041L,482769L,488709L,501921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243090Inst : IEnumerable<long>
{
public static readonly long[] Value=A243090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243090.Bytes);
public long this[int i]=>Value[i];

public static A243090Inst Instance=new A243090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243091
{
public static readonly long[] Value={ 1L,6L,5L,6L,9L,29L,25L,29L,41L,61L,24L,56L,25L,69L,44L,21L,81L,64L,49L,36L,25L,316L,201L,104L,336L,281L,244L,225L,224L,241L,276L,36L,49L,64L,81L,344L,100L,249L,44L,69L,96L,209L,436L,56L,89L,369L,225L,61L,400L,284L,176L,84L,441L,361L,76L,225L,169L,76L,564L,536L,84L,504L,500L,504L,516L,536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243091Inst : IEnumerable<long>
{
public static readonly long[] Value=A243091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243091.Bytes);
public long this[int i]=>Value[i];

public static A243091Inst Instance=new A243091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243092
{
public static readonly long[] Value={ 25L,7L,43L,913L,12L,859L,29L,5184L,261L,648L,7649L,167L,31L,8877L,625L,6375L,28L,5193L,683L,5379L,97L,6981L,8328L,389L,15456L,2144L,44L,7496L,791L,48625L,4432L,768L,75L,3000L,937L,52264L,3248L,9017L,304L,96L,73281L,875L,8976L,10944L,6533L,656L,4552L,26809L,3039L,653L,2000L,68024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243092Inst : IEnumerable<long>
{
public static readonly long[] Value=A243092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243092.Bytes);
public long this[int i]=>Value[i];

public static A243092Inst Instance=new A243092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243093
{
public static readonly long[] Value={ 6L,5L,6L,9L,12L,25L,29L,41L,61L,24L,56L,25L,31L,44L,21L,81L,28L,49L,36L,25L,87L,201L,104L,336L,281L,244L,44L,224L,241L,276L,36L,49L,64L,81L,344L,100L,249L,44L,69L,96L,209L,436L,56L,89L,369L,225L,61L,400L,284L,176L,84L,441L,361L,76L,225L,169L,76L,564L,319L,84L,504L,500L,504L,516L,536L,564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243093Inst : IEnumerable<long>
{
public static readonly long[] Value=A243093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243093.Bytes);
public long this[int i]=>Value[i];

public static A243093Inst Instance=new A243093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243094
{
public static readonly long[] Value={ 1L,2L,5L,8L,19L,44L,92L,201L,444L,965L,2104L,4602L,10045L,21924L,47879L,104540L,228236L,498337L,1088072L,2375657L,5186976L,11325186L,24727205L,53988976L,117878715L,257374492L,561947340L,1226946953L,2678896484L,5849059949L,12770744632L,27883440986L,60880261949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243094Inst : IEnumerable<long>
{
public static readonly long[] Value=A243094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243094.Bytes);
public long this[int i]=>Value[i];

public static A243094Inst Instance=new A243094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243095
{
public static readonly long[] Value={ 3L,3L,3L,1L,7L,3L,7L,1L,3L,3L,9L,1L,33L,7L,9L,1L,43L,17L,27L,1L,9L,3L,7L,1L,55L,47L,285L,1L,27L,3L,39L,1L,43L,117L,163L,1L,63L,255L,15L,1L,87L,3L,43L,1L,187L,77L,37L,1L,105L,45L,25L,1L,99L,305L,79L,1L,3L,27L,903L,1L,127L,293L,255L,1L,27L,27L,435L,1L,207L,143L,127L,1L,117L,295L,1159L,1L,477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243095Inst : IEnumerable<long>
{
public static readonly long[] Value=A243095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243095.Bytes);
public long this[int i]=>Value[i];

public static A243095Inst Instance=new A243095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243096
{
public static readonly long[] Value={ 17L,59L,179L,821L,1019L,1301L,1619L,2141L,2339L,3257L,3299L,3461L,4217L,4259L,4337L,4421L,5417L,5501L,5657L,5741L,6659L,6701L,7457L,8819L,8861L,9341L,10139L,10457L,10859L,10937L,11057L,11699L,11939L,12377L,12821L,13337L,13901L,15137L,15581L,15737L,16979L,17417L,17579L,18059L,19139L,19541L,19697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243096Inst : IEnumerable<long>
{
public static readonly long[] Value=A243096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243096.Bytes);
public long this[int i]=>Value[i];

public static A243096Inst Instance=new A243096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243097
{
public static readonly long[] Value={ 18L,18L,27L,27L,36L,36L,45L,45L,36L,54L,36L,54L,36L,63L,36L,63L,36L,54L,72L,36L,54L,72L,36L,54L,81L,36L,54L,81L,36L,54L,54L,72L,90L,36L,54L,54L,72L,90L,36L,63L,54L,72L,99L,36L,63L,54L,72L,99L,36L,54L,72L,54L,72L,72L,90L,108L,36L,54L,72L,54L,72L,72L,90L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243097Inst : IEnumerable<long>
{
public static readonly long[] Value=A243097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243097.Bytes);
public long this[int i]=>Value[i];

public static A243097Inst Instance=new A243097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243098
{
public static readonly long[] Value={ 1L,0L,1L,0L,3L,1L,0L,16L,6L,2L,0L,125L,51L,24L,6L,0L,1296L,560L,300L,120L,24L,0L,16807L,7575L,4360L,2160L,720L,120L,0L,262144L,122052L,73710L,41160L,17640L,5040L,720L,0L,4782969L,2285353L,1430016L,861420L,430080L,161280L,40320L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243098Inst : IEnumerable<long>
{
public static readonly long[] Value=A243098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243098.Bytes);
public long this[int i]=>Value[i];

public static A243098Inst Instance=new A243098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243099
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,3L,3L,7L,6L,13L,10L,21L,15L,31L,21L,43L,28L,57L,36L,73L,45L,91L,55L,111L,66L,133L,78L,157L,91L,183L,105L,211L,120L,241L,136L,273L,153L,307L,171L,343L,190L,381L,210L,421L,231L,463L,253L,507L,276L,553L,300L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243099Inst : IEnumerable<long>
{
public static readonly long[] Value=A243099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243099.Bytes);
public long this[int i]=>Value[i];

public static A243099Inst Instance=new A243099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243100
{
public static readonly BigInteger[] Value={ 3L,7L,19L,179L,543607L,129136067L,94143168179L,11920928949924493L,BigInteger.Parse("36472996377170722403"),BigInteger.Parse("61159026180004467059"),BigInteger.Parse("1341068619659378429383"),BigInteger.Parse("10301051460877537453973547005699"),BigInteger.Parse("710542735760100185871124061615149"),BigInteger.Parse("17763568394002504646778106434649157") };
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
public class A243100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243100Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243100.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243100.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243100Inst Instance=new A243100Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243101
{
public static readonly long[] Value={ -1L,2L,37L,324L,2403L,16582L,109961L,711176L,4521607L,28394442L,176648877L,1090974156L,6698429931L,40930511502L,249105886737L,1510954029072L,9138180665871L,55128765109906L,331851698655797L,1993747216968788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243101Inst : IEnumerable<long>
{
public static readonly long[] Value=A243101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243101.Bytes);
public long this[int i]=>Value[i];

public static A243101Inst Instance=new A243101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243102
{
public static readonly long[] Value={ 239L,326L,364L,497L,563L,598L,613L,637L,695L,819L,1239L,1326L,1364L,1497L,1563L,1598L,1613L,1637L,1695L,1819L,2139L,2313L,2356L,2369L,2419L,2594L,2639L,2791L,3126L,3213L,3235L,3238L,3259L,3354L,3365L,3561L,4219L,4346L,4353L,4395L,4559L,4569L,4592L,4595L,4719L,4953L,4967L,5129L,5233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243102Inst : IEnumerable<long>
{
public static readonly long[] Value=A243102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243102.Bytes);
public long this[int i]=>Value[i];

public static A243102Inst Instance=new A243102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243103
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,144L,7L,64L,27L,3200L,11L,124416L,13L,6272L,2025L,1024L,17L,35831808L,19L,1024000L,3969L,247808L,23L,859963392L,125L,346112L,729L,2809856L,29L,261213880320000000L,31L,32768L,264627L,18939904L,30625L,26748301344768L,37L,23658496L,369603L,32768000000L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243103Inst : IEnumerable<long>
{
public static readonly long[] Value=A243103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243103.Bytes);
public long this[int i]=>Value[i];

public static A243103Inst Instance=new A243103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243104
{
public static readonly long[] Value={ 945L,1575L,2205L,2835L,3465L,4095L,4725L,6435L,6615L,6825L,7245L,7425L,7875L,8085L,8505L,8925L,9135L,9555L,9765L,10395L,11655L,12285L,12915L,13545L,14805L,15015L,16065L,16695L,17955L,18585L,19215L,19635L,19845L,20475L,21105L,21735L,22275L,22365L,22995L,23205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243104Inst : IEnumerable<long>
{
public static readonly long[] Value=A243104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243104.Bytes);
public long this[int i]=>Value[i];

public static A243104Inst Instance=new A243104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243105
{
public static readonly BigInteger[] Value={ 28L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,BigInteger.Parse("298702188259102685572182"),0L,0L,0L,0L,BigInteger.Parse("1343764184037862976125525799963820"),0L,0L,0L,0L,0L,BigInteger.Parse("899099147941632652542743156466630723477224554496"),0L,0L,BigInteger.Parse("89963063825649646755150759614762027655562252125282") };
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
public class A243105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243105Inst Instance=new A243105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243106
{
public static readonly long[] Value={ 10L,-90L,-1090L,8910L,-91090L,908910L,-9091090L,90908910L,1090908910L,11090908910L,-88909091090L,911090908910L,-9088909091090L,90911090908910L,1090911090908910L,11090911090908910L,-88909088909091090L,911090911090908910L,-9088909088909091090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243106Inst : IEnumerable<long>
{
public static readonly long[] Value=A243106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243106.Bytes);
public long this[int i]=>Value[i];

public static A243106Inst Instance=new A243106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243107
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,13L,41L,226L,1072L,9059L,58123L,657766L,5268836L,73980787L,707506879L,11823958238L,131277234376L,2542107619081L,32122718085497L,706963537444114L,10015472595953908L,246853433179370621L,3874536631479770761L,BigInteger.Parse("105709617658879558402") };
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
public class A243107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243107Inst Instance=new A243107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243108
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,6L,1L,0L,2L,1L,0L,7L,3L,3L,4L,8L,0L,9L,2L,0L,5L,6L,2L,1L,9L,9L,1L,5L,8L,2L,1L,0L,7L,8L,1L,1L,7L,6L,7L,4L,4L,6L,0L,8L,0L,6L,1L,0L,2L,5L,6L,8L,0L,7L,3L,3L,9L,4L,4L,5L,4L,4L,5L,6L,7L,4L,4L,1L,1L,5L,3L,9L,9L,6L,2L,9L,1L,6L,1L,7L,4L,0L,1L,9L,7L,8L,4L,4L,8L,1L,8L,7L,6L,8L,3L,3L,1L,3L,3L,5L,6L,2L,6L,4L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243108Inst : IEnumerable<long>
{
public static readonly long[] Value=A243108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243108.Bytes);
public long this[int i]=>Value[i];

public static A243108Inst Instance=new A243108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243109
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,3L,5L,7L,4L,6L,9L,7L,10L,11L,13L,15L,8L,12L,17L,14L,18L,19L,21L,15L,20L,22L,25L,23L,26L,27L,29L,31L,16L,24L,33L,28L,34L,35L,37L,30L,36L,38L,41L,39L,42L,43L,45L,31L,40L,44L,49L,46L,50L,51L,53L,47L,52L,54L,57L,55L,58L,59L,61L,63L,32L,48L,65L,56L,66L,67L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243109Inst : IEnumerable<long>
{
public static readonly long[] Value=A243109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243109.Bytes);
public long this[int i]=>Value[i];

public static A243109Inst Instance=new A243109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243110
{
public static readonly long[] Value={ 3L,11L,37L,101L,239L,271L,1933L,3191L,3541L,4093L,4649L,9091L,21649L,52579L,123551L,210631L,238681L,329401L,333667L,513239L,909091L,2071723L,2906161L,5882353L,10838689L,35121409L,52986961L,70541929L,83251631L,99990001L,121499449L,247629013L,265371653L,1052788969L,1056689261L,1058313049L,5363222357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243110Inst : IEnumerable<long>
{
public static readonly long[] Value=A243110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243110.Bytes);
public long this[int i]=>Value[i];

public static A243110Inst Instance=new A243110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243111
{
public static readonly long[] Value={ 1L,0L,1L,3L,4L,2L,4L,2L,5L,7L,5L,8L,4L,2L,8L,2L,7L,5L,11L,7L,5L,12L,8L,2L,8L,4L,2L,13L,11L,7L,9L,5L,16L,14L,4L,2L,14L,8L,4L,17L,11L,9L,19L,17L,13L,11L,20L,8L,4L,2L,20L,14L,12L,2L,19L,13L,7L,5L,23L,19L,17L,7L,18L,14L,12L,8L,20L,14L,4L,2L,25L,19L,11L,5L,27L,23L,17L,9L,5L,26L,16L,14L,4L,2L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243111Inst : IEnumerable<long>
{
public static readonly long[] Value=A243111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243111.Bytes);
public long this[int i]=>Value[i];

public static A243111Inst Instance=new A243111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243112
{
public static readonly long[] Value={ 0L,2L,4L,8L,12L,20L,24L,40L,48L,56L,88L,104L,112L,176L,208L,224L,240L,368L,432L,464L,480L,736L,864L,928L,960L,992L,1504L,1760L,1888L,1952L,1984L,3008L,3520L,3776L,3904L,3968L,4032L,6080L,7104L,7616L,7872L,8000L,8064L,12160L,14208L,15232L,15744L,16000L,16128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243112Inst : IEnumerable<long>
{
public static readonly long[] Value=A243112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243112.Bytes);
public long this[int i]=>Value[i];

public static A243112Inst Instance=new A243112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243113
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,2L,3L,3L,3L,3L,2L,2L,2L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,3L,3L,3L,3L,3L,3L,4L,4L,5L,3L,3L,3L,3L,3L,3L,4L,4L,5L,4L,3L,3L,3L,4L,4L,4L,4L,5L,4L,3L,4L,4L,3L,4L,4L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243113Inst : IEnumerable<long>
{
public static readonly long[] Value=A243113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243113.Bytes);
public long this[int i]=>Value[i];

public static A243113Inst Instance=new A243113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243114
{
public static readonly BigInteger[] Value={ 5L,162287L,13055867207L,BigInteger.Parse("1719070799748422589190392551"),BigInteger.Parse("174588755932389037098918153698589675008087"),BigInteger.Parse("307180606913594390117978657628360735703373091543821695941623353827100004182413811352186951") };
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
public class A243114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243114Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243114.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243114.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243114Inst Instance=new A243114Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243115
{
public static readonly long[] Value={ 3L,7L,11L,15L,23L,27L,31L,39L,47L,59L,63L,71L,79L,91L,95L,103L,111L,123L,127L,155L,159L,167L,175L,191L,199L,207L,219L,223L,231L,239L,251L,255L,283L,287L,303L,319L,327L,347L,359L,367L,383L,411L,415L,423L,447L,463L,479L,487L,495L,507L,511L,539L,543L,559L,575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243115Inst : IEnumerable<long>
{
public static readonly long[] Value=A243115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243115.Bytes);
public long this[int i]=>Value[i];

public static A243115Inst Instance=new A243115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243116
{
public static readonly BigInteger[] Value={ 1L,4L,28L,220L,1816L,15424L,133456L,1169872L,10354528L,92331904L,828204928L,7464652672L,67547774464L,613295870464L,5584367987968L,50974595472640L,466307503244800L,4273832891668480L,39237007284226048L,360768875975526400L,3321625537178669056L,BigInteger.Parse("30619908430235828224"),BigInteger.Parse("282578914501599305728") };
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
public class A243116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243116Inst Instance=new A243116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243117
{
public static readonly long[] Value={ 0L,1L,3L,6L,8L,12L,13L,14L,15L,18L,20L,24L,28L,30L,31L,32L,36L,38L,39L,40L,42L,44L,48L,54L,56L,57L,60L,62L,63L,68L,72L,74L,78L,80L,84L,90L,91L,93L,96L,98L,102L,104L,108L,110L,112L,114L,120L,121L,124L,126L,127L,128L,132L,133L,138L,140L,144L,150L,152L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243117Inst : IEnumerable<long>
{
public static readonly long[] Value=A243117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243117.Bytes);
public long this[int i]=>Value[i];

public static A243117Inst Instance=new A243117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243118
{
public static readonly long[] Value={ 2L,4L,5L,7L,9L,10L,11L,16L,17L,19L,21L,22L,23L,25L,26L,27L,29L,33L,34L,35L,37L,41L,43L,45L,46L,47L,49L,50L,51L,52L,53L,55L,58L,59L,61L,64L,65L,66L,67L,69L,70L,71L,73L,75L,76L,77L,79L,81L,82L,83L,85L,86L,87L,88L,89L,92L,94L,95L,97L,99L,100L,101L,103L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243118Inst : IEnumerable<long>
{
public static readonly long[] Value=A243118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243118.Bytes);
public long this[int i]=>Value[i];

public static A243118Inst Instance=new A243118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243119
{
public static readonly long[] Value={ 1L,0L,4L,6L,10L,21L,40L,87L,121L,219L,421L,690L,1159L,1782L,3304L,5190L,8212L,12897L,22084L,33255L,53617L,82539L,124849L,206172L,313339L,472056L,714976L,1077996L,1682806L,2502645L,3804460L,5674305L,8340535L,12245241L,18851899L,27570366L,40385431L,59314572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243119Inst : IEnumerable<long>
{
public static readonly long[] Value=A243119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243119.Bytes);
public long this[int i]=>Value[i];

public static A243119Inst Instance=new A243119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243120
{
public static readonly long[] Value={ 1L,0L,4L,5L,18L,34L,59L,132L,272L,519L,966L,1746L,3487L,5986L,10570L,19701L,34444L,59250L,101155L,180588L,302788L,515205L,841042L,1449392L,2420163L,3959442L,6472636L,10656987L,17332640L,28234296L,45337971L,72306544L,117761744L,185704091L,295918788L,466574348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243120Inst : IEnumerable<long>
{
public static readonly long[] Value=A243120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243120.Bytes);
public long this[int i]=>Value[i];

public static A243120Inst Instance=new A243120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243121
{
public static readonly long[] Value={ 1L,0L,5L,5L,21L,40L,100L,210L,396L,870L,1790L,3510L,6681L,13100L,25320L,47835L,87126L,166195L,299375L,542595L,991036L,1775935L,3145270L,5487805L,9852046L,17092310L,29561070L,50696690L,88015196L,150446590L,256066280L,428469220L,727919426L,1224816005L,2043828145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243121Inst : IEnumerable<long>
{
public static readonly long[] Value=A243121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243121.Bytes);
public long this[int i]=>Value[i];

public static A243121Inst Instance=new A243121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243122
{
public static readonly long[] Value={ 1L,0L,6L,6L,27L,49L,131L,279L,635L,1370L,2722L,5877L,12170L,24113L,47660L,94470L,186623L,355400L,680074L,1296600L,2456115L,4535638L,8495447L,15570655L,28505689L,52054671L,94229227L,169184891L,301060621L,540575365L,956101463L,1682865787L,2936425870L,5167830927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243122Inst : IEnumerable<long>
{
public static readonly long[] Value=A243122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243122.Bytes);
public long this[int i]=>Value[i];

public static A243122Inst Instance=new A243122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243123
{
public static readonly long[] Value={ 1L,0L,7L,7L,35L,63L,176L,378L,889L,1946L,4298L,9282L,18999L,40565L,84371L,169372L,340683L,684957L,1359758L,2650942L,5142116L,10008642L,19123713L,36370362L,68799767L,129920385L,241668105L,450604609L,830903577L,1529103100L,2800280316L,5100363926L,9233845628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243123Inst : IEnumerable<long>
{
public static readonly long[] Value=A243123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243123.Bytes);
public long this[int i]=>Value[i];

public static A243123Inst Instance=new A243123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243124
{
public static readonly long[] Value={ 1L,0L,8L,8L,44L,80L,236L,513L,1246L,2780L,6280L,13786L,30070L,64696L,134585L,285384L,594786L,1207084L,2453682L,4972098L,9946044L,19646041L,38691878L,75939596L,147425468L,283809162L,546291230L,1042095956L,1977521091L,3730060870L,7022446786L,13104269980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243124Inst : IEnumerable<long>
{
public static readonly long[] Value=A243124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243124.Bytes);
public long this[int i]=>Value[i];

public static A243124Inst Instance=new A243124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243125
{
public static readonly long[] Value={ 1L,0L,9L,9L,54L,99L,309L,684L,1720L,3918L,9081L,20343L,45261L,99063L,214719L,460428L,965980L,2040096L,4255851L,8706522L,17810088L,36275538L,73017027L,145692324L,289702678L,573412764L,1124242476L,2191850439L,4259718588L,8229423030L,15785908575L,30199934205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243125Inst : IEnumerable<long>
{
public static readonly long[] Value=A243125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243125.Bytes);
public long this[int i]=>Value[i];

public static A243125Inst Instance=new A243125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243126
{
public static readonly long[] Value={ 1L,0L,10L,10L,65L,120L,395L,890L,2320L,5401L,12857L,29435L,66955L,149455L,330042L,719882L,1554760L,3326365L,7009606L,14772370L,30835912L,63443345L,130298990L,266321547L,538824877L,1082905293L,2168501310L,4319287751L,8538816117L,16795672263L,32926171923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243126Inst : IEnumerable<long>
{
public static readonly long[] Value=A243126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243126.Bytes);
public long this[int i]=>Value[i];

public static A243126Inst Instance=new A243126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243127
{
public static readonly long[] Value={ 1L,0L,11L,11L,77L,143L,495L,1133L,3058L,7271L,17777L,41591L,96767L,220473L,496661L,1103619L,2425929L,5276623L,11370986L,24294028L,51316156L,108047687L,225688551L,466237332L,960231624L,1967794950L,3997987950L,8077762209L,16258984885L,32550495175L,64759902032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243127Inst : IEnumerable<long>
{
public static readonly long[] Value=A243127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243127.Bytes);
public long this[int i]=>Value[i];

public static A243127Inst Instance=new A243127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243128
{
public static readonly long[] Value={ 3L,15L,21L,33L,35L,39L,51L,57L,69L,87L,93L,105L,111L,123L,129L,141L,159L,165L,177L,183L,195L,201L,213L,219L,231L,237L,249L,255L,267L,273L,285L,291L,303L,309L,321L,327L,339L,345L,357L,381L,385L,393L,399L,411L,417L,429L,435L,447L,453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243128Inst : IEnumerable<long>
{
public static readonly long[] Value=A243128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243128.Bytes);
public long this[int i]=>Value[i];

public static A243128Inst Instance=new A243128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243129
{
public static readonly long[] Value={ 1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,4L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L,4L,3L,4L,3L,3L,3L,3L,3L,3L,3L,4L,3L,4L,3L,4L,4L,3L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,3L,3L,7L,3L,3L,4L,3L,3L,4L,3L,4L,3L,4L,3L,7L,3L,3L,4L,4L,3L,4L,3L,4L,3L,3L,3L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243129Inst : IEnumerable<long>
{
public static readonly long[] Value=A243129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243129.Bytes);
public long this[int i]=>Value[i];

public static A243129Inst Instance=new A243129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243130
{
public static readonly long[] Value={ -1L,11L,564719L,46611179L,929944511L,9127651499L,58130412911L,276182038859L,1061324394239L,3472236254411L,10011386405999L,26069206375211L,62418042417599L,139296285729899L,292810020137711L,584605483663499L,1116034330278911L,2048348816684939L,3630829342034159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243130Inst : IEnumerable<long>
{
public static readonly long[] Value=A243130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243130.Bytes);
public long this[int i]=>Value[i];

public static A243130Inst Instance=new A243130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243131
{
public static readonly long[] Value={ 0L,1L,362L,3363L,15124L,47525L,120126L,262087L,514088L,930249L,1580050L,2550251L,3946812L,5896813L,8550374L,12082575L,16695376L,22619537L,30116538L,39480499L,51040100L,65160501L,82245262L,102738263L,127125624L,155937625L,189750626L,229188987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243131Inst : IEnumerable<long>
{
public static readonly long[] Value=A243131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243131.Bytes);
public long this[int i]=>Value[i];

public static A243131Inst Instance=new A243131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243132
{
public static readonly long[] Value={ -1L,1L,1351L,19601L,119071L,470449L,1431431L,3650401L,8193151L,16692641L,31521799L,55989361L,94558751L,153090001L,239104711L,362074049L,533729791L,768398401L,1083358151L,1499219281L,2040327199L,2735188721L,3616921351L,4723725601L,6099380351L,7793761249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243132Inst : IEnumerable<long>
{
public static readonly long[] Value=A243132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243132.Bytes);
public long this[int i]=>Value[i];

public static A243132Inst Instance=new A243132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243133
{
public static readonly long[] Value={ 0L,1L,5042L,114243L,937444L,4656965L,17057046L,50843527L,130576328L,299537289L,628855930L,1229215691L,2265463212L,3974443213L,6686381534L,10850138895L,17062657936L,26102926097L,38970776898L,56930852179L,81562047860L,114812765781L,159062294182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243133Inst : IEnumerable<long>
{
public static readonly long[] Value=A243133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243133.Bytes);
public long this[int i]=>Value[i];

public static A243133Inst Instance=new A243133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243134
{
public static readonly long[] Value={ 1L,1L,18817L,665857L,7380481L,46099201L,203253121L,708158977L,2081028097L,5374978561L,12545596801L,26986755841L,54276558337L,103182433537L,186979578241L,325142092801L,545471324161L,886731088897L,1401864610177L,2161873163521L,3260441587201L,4819400974081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243134Inst : IEnumerable<long>
{
public static readonly long[] Value=A243134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243134.Bytes);
public long this[int i]=>Value[i];

public static A243134Inst Instance=new A243134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243135
{
public static readonly long[] Value={ 0L,1L,70226L,3880899L,58106404L,456335045L,2421980406L,9863382151L,33165873224L,96450076809L,250283080090L,592479412811L,1300371936876L,2678768828749L,5228741809214L,9743412645135L,17438019715216L,30122754096401L,50428155189474L,82094249361619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243135Inst : IEnumerable<long>
{
public static readonly long[] Value=A243135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243135.Bytes);
public long this[int i]=>Value[i];

public static A243135Inst Instance=new A243135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243136
{
public static readonly long[] Value={ -1L,1L,262087L,22619537L,457470751L,4517251249L,28860511751L,137379191137L,528572943487L,1730726404001L,4993116004999L,13007560326001L,31154649926687L,69544807113937L,146217791079751L,291977237261249L,557471159562751L,1023286908188737L,1814011722210887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243136Inst : IEnumerable<long>
{
public static readonly long[] Value=A243136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243136.Bytes);
public long this[int i]=>Value[i];

public static A243136Inst Instance=new A243136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243137
{
public static readonly long[] Value={ 17L,23L,41L,43L,59L,61L,89L,113L,163L,179L,181L,239L,241L,257L,317L,379L,419L,421L,439L,499L,521L,523L,631L,733L,881L,883L,953L,1031L,1033L,1123L,1187L,1277L,1279L,1451L,1453L,1481L,1483L,1637L,1709L,1877L,1879L,1913L,2069L,2141L,2143L,2213L,2521L,2579L,2609L,2729L,2731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243137Inst : IEnumerable<long>
{
public static readonly long[] Value=A243137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243137.Bytes);
public long this[int i]=>Value[i];

public static A243137Inst Instance=new A243137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243138
{
public static readonly long[] Value={ 13L,29L,47L,67L,89L,113L,139L,167L,197L,229L,263L,299L,337L,377L,419L,463L,509L,557L,607L,659L,713L,769L,827L,887L,949L,1013L,1079L,1147L,1217L,1289L,1363L,1439L,1517L,1597L,1679L,1763L,1849L,1937L,2027L,2119L,2213L,2309L,2407L,2507L,2609L,2713L,2819L,2927L,3037L,3149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243138Inst : IEnumerable<long>
{
public static readonly long[] Value=A243138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243138.Bytes);
public long this[int i]=>Value[i];

public static A243138Inst Instance=new A243138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243139
{
public static readonly BigInteger[] Value={ 6L,11L,37L,135L,2059L,8205L,131089L,524307L,8388631L,536870941L,2147483679L,137438953509L,2199023255593L,8796093022251L,140737488355375L,9007199254741045L,576460752303423547L,2305843009213694013L,BigInteger.Parse("147573952589676412995"),BigInteger.Parse("2361183241434822606919") };
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
public class A243139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A243139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A243139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A243139Inst Instance=new A243139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243140
{
public static readonly long[] Value={ 22L,26L,38L,55L,62L,88L,95L,102L,104L,108L,116L,122L,126L,138L,162L,174L,202L,206L,218L,234L,258L,410L,414L,430L,442L,474L,586L,826L,922L,1318L,1342L,1366L,1474L,1586L,1826L,1922L,1958L,2318L,2366L,2582L,2742L,3174L,3258L,3498L,4362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243140Inst : IEnumerable<long>
{
public static readonly long[] Value=A243140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243140.Bytes);
public long this[int i]=>Value[i];

public static A243140Inst Instance=new A243140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243141
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,3L,1L,3L,10L,19L,22L,7L,1L,4L,22L,75L,170L,204L,115L,18L,1L,5L,41L,218L,816L,1891L,2635L,1909L,628L,58L,3L,7L,72L,542L,2947L,10846L,26695L,41770L,39218L,19905L,4776L,437L,13L,8L,116L,1178L,8765L,46068L,171700L,444117L,776276L,876012L,601078L,229941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243141Inst : IEnumerable<long>
{
public static readonly long[] Value=A243141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243141.Bytes);
public long this[int i]=>Value[i];

public static A243141Inst Instance=new A243141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243142
{
public static readonly long[] Value={ 0L,3L,19L,75L,218L,542L,1178L,2350L,4340L,7585L,12605L,20153L,31094L,46620L,68068L,97212L,136008L,186975L,252855L,337095L,443410L,576378L,740894L,942890L,1188668L,1485757L,1842113L,2267125L,2770670L,3364280L,4060040L,4871928L,5814544L,6904635L,8159643L,9599427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243142Inst : IEnumerable<long>
{
public static readonly long[] Value=A243142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243142.Bytes);
public long this[int i]=>Value[i];

public static A243142Inst Instance=new A243142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243143
{
public static readonly long[] Value={ 1L,22L,170L,816L,2947L,8765L,22703L,52823L,113042L,225817L,426299L,766905L,1324282L,2206478L,3563770L,5599258L,8584775L,12875840L,18934040L,27347390L,38860741L,54402707L,75125825L,102441321L,138070912L,184090795L,242997153L,317760863L,411908932L,529591532L,675681764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243143Inst : IEnumerable<long>
{
public static readonly long[] Value=A243143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243143.Bytes);
public long this[int i]=>Value[i];

public static A243143Inst Instance=new A243143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243144
{
public static readonly long[] Value={ 0L,7L,204L,1891L,10846L,46068L,159830L,477033L,1268614L,3075291L,6911894L,14580293L,29145928L,55620816L,101945063L,180327134L,309087474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243144Inst : IEnumerable<long>
{
public static readonly long[] Value=A243144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243144.Bytes);
public long this[int i]=>Value[i];

public static A243144Inst Instance=new A243144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243145
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,1L,4L,3L,2L,1L,6L,1L,4L,3L,2L,1L,6L,1L,12L,3L,16L,1L,6L,7L,4L,15L,2L,1L,12L,1L,6L,9L,8L,3L,6L,1L,4L,3L,2L,1L,30L,1L,4L,3L,8L,1L,6L,5L,10L,3L,10L,1L,6L,5L,4L,15L,2L,1L,42L,1L,6L,21L,4L,3L,6L,1L,4L,15L,2L,1L,30L,1L,6L,33L,8L,25L,6L,1L,10L,3L,16L,1L,24L,5L,4L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243145Inst : IEnumerable<long>
{
public static readonly long[] Value=A243145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243145.Bytes);
public long this[int i]=>Value[i];

public static A243145Inst Instance=new A243145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243146
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,1L,4L,3L,10L,1L,6L,1L,4L,165L,2L,1L,252L,1L,210L,3L,16L,1L,6L,35L,4L,15L,2L,1L,2040L,1L,6L,69L,8L,75L,12L,1L,4L,393L,50L,1L,660L,1L,18L,135L,14L,1L,42L,5L,220L,3L,16L,1L,30L,365L,4L,51L,2L,1L,420L,1L,426L,21L,8L,0L,6L,1L,70L,351L,1340L,1L,30L,1L,28L,525L,98L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243146Inst : IEnumerable<long>
{
public static readonly long[] Value=A243146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243146.Bytes);
public long this[int i]=>Value[i];

public static A243146Inst Instance=new A243146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243147
{
public static readonly long[] Value={ 1L,1L,2L,1L,24L,1L,54L,69L,2L,1L,3100L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243147Inst : IEnumerable<long>
{
public static readonly long[] Value=A243147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243147.Bytes);
public long this[int i]=>Value[i];

public static A243147Inst Instance=new A243147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243148
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243148Inst : IEnumerable<long>
{
public static readonly long[] Value=A243148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243148.Bytes);
public long this[int i]=>Value[i];

public static A243148Inst Instance=new A243148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243149
{
public static readonly long[] Value={ 1L,1L,0L,0L,4L,3L,4L,0L,11L,31L,70L,177L,242L,382L,482L,874L,1655L,4440L,10696L,24390L,49867L,95850L,172980L,289229L,492233L,811753L,1468084L,2813206L,5929361L,12780690L,27858421L,59275097L,122326098L,243179349L,467856049L,873044584L,1588187110L,2842593612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243149Inst : IEnumerable<long>
{
public static readonly long[] Value=A243149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243149.Bytes);
public long this[int i]=>Value[i];

public static A243149Inst Instance=new A243149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243150
{
public static readonly long[] Value={ 1L,7L,28L,106L,391L,992L,1178L,7255L,15975L,67143L,333212L,333212L,1641257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243150Inst : IEnumerable<long>
{
public static readonly long[] Value=A243150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243150.Bytes);
public long this[int i]=>Value[i];

public static A243150Inst Instance=new A243150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243151
{
public static readonly long[] Value={ 1L,11L,36L,34L,99L,258L,391L,163L,341L,951L,867L,1692L,1114L,793L,4792L,3019L,1935L,5469L,6398L,6152L,8906L,1987L,15815L,19603L,16292L,26216L,32113L,19718L,24354L,45903L,15776L,42202L,34572L,44411L,46911L,67972L,39291L,52299L,30499L,28383L,38001L,89782L,95017L,55954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243151Inst : IEnumerable<long>
{
public static readonly long[] Value=A243151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243151.Bytes);
public long this[int i]=>Value[i];

public static A243151Inst Instance=new A243151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243152
{
public static readonly long[] Value={ 1L,1L,6L,3L,9L,4L,1L,1L,6L,0L,8L,5L,4L,8L,7L,1L,4L,1L,6L,0L,6L,3L,8L,9L,3L,4L,9L,6L,7L,6L,7L,4L,6L,0L,3L,9L,6L,0L,9L,5L,1L,3L,1L,6L,2L,7L,7L,9L,4L,8L,9L,2L,7L,7L,7L,9L,9L,4L,9L,9L,1L,0L,9L,5L,9L,5L,5L,6L,4L,3L,2L,6L,3L,7L,4L,7L,2L,0L,1L,2L,8L,1L,9L,6L,9L,9L,1L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243152Inst : IEnumerable<long>
{
public static readonly long[] Value=A243152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243152.Bytes);
public long this[int i]=>Value[i];

public static A243152Inst Instance=new A243152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243153
{
public static readonly long[] Value={ 11L,17L,23L,29L,37L,41L,47L,53L,59L,67L,71L,79L,83L,89L,101L,107L,113L,127L,131L,137L,149L,157L,163L,167L,173L,179L,191L,197L,227L,233L,239L,251L,257L,263L,269L,277L,281L,293L,307L,311L,317L,331L,337L,347L,353L,359L,373L,379L,383L,389L,401L,419L,431L,439L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243153Inst : IEnumerable<long>
{
public static readonly long[] Value=A243153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243153.Bytes);
public long this[int i]=>Value[i];

public static A243153Inst Instance=new A243153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243154
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,2L,0L,4L,0L,7L,0L,4L,0L,0L,4L,11L,0L,2L,0L,4L,7L,7L,0L,12L,4L,0L,0L,2L,9L,0L,0L,2L,0L,6L,2L,1L,4L,10L,0L,13L,4L,0L,4L,10L,4L,0L,0L,2L,8L,0L,0L,5L,6L,0L,30L,20L,16L,4L,11L,7L,0L,5L,13L,0L,11L,18L,0L,2L,18L,5L,0L,1L,4L,5L,10L,4L,7L,4L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243154Inst : IEnumerable<long>
{
public static readonly long[] Value=A243154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243154.Bytes);
public long this[int i]=>Value[i];

public static A243154Inst Instance=new A243154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243155
{
public static readonly long[] Value={ 3L,97L,367L,397L,409L,457L,487L,499L,691L,709L,727L,751L,769L,919L,937L,991L,1117L,1171L,1201L,1381L,1447L,1531L,1567L,1579L,1741L,1831L,1987L,2011L,2161L,2221L,2251L,2281L,2467L,2539L,2617L,2671L,2707L,2749L,2851L,2887L,2917L,3019L,3049L,3217L,3229L,3457L,3499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243155Inst : IEnumerable<long>
{
public static readonly long[] Value=A243155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243155.Bytes);
public long this[int i]=>Value[i];

public static A243155Inst Instance=new A243155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243156
{
public static readonly long[] Value={ 1L,1L,3L,9L,28L,92L,319L,1154L,4302L,16382L,63391L,248499L,984867L,3940121L,15891386L,64545971L,263783729L,1083883910L,4475194635L,18557356409L,77251869363L,322723617687L,1352518263334L,5684939482522L,23959266771808L,101226312702475L,428650606083144L,1818991203750774L,7734098181837847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243156Inst : IEnumerable<long>
{
public static readonly long[] Value=A243156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243156.Bytes);
public long this[int i]=>Value[i];

public static A243156Inst Instance=new A243156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243157
{
public static readonly long[] Value={ 1L,0L,0L,-1L,-1L,-1L,2L,6L,11L,5L,-21L,-78L,-124L,-53L,335L,1096L,1727L,441L,-5545L,-17196L,-25596L,-2251L,97822L,284072L,399346L,-44721L,-1782873L,-4876069L,-6411063L,2201418L,33297536L,85893931L,104783903L,-64745927L,-632601621L,-1541899544L,-1727700472L,1642436289L,12171894474L,28062518974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243157Inst : IEnumerable<long>
{
public static readonly long[] Value=A243157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243157.Bytes);
public long this[int i]=>Value[i];

public static A243157Inst Instance=new A243157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243158
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,5L,1L,3L,4L,4L,3L,5L,2L,6L,13L,5L,6L,1L,9L,28L,8L,2L,10L,8L,5L,8L,3L,3L,31L,2L,2L,9L,6L,1L,3L,6L,2L,5L,4L,1L,10L,3L,7L,3L,6L,7L,4L,4L,1L,14L,1L,1L,4L,4L,18L,1L,8L,1L,3L,10L,3L,1L,6L,1L,7L,2L,26L,19L,6L,2L,8L,30L,23L,6L,19L,5L,1L,1L,12L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243158Inst : IEnumerable<long>
{
public static readonly long[] Value=A243158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243158.Bytes);
public long this[int i]=>Value[i];

public static A243158Inst Instance=new A243158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243159
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,2L,5L,11L,6L,28L,39L,57L,96L,163L,324L,486L,967L,1493L,2915L,5083L,9343L,16836L,31877L,55587L,105785L,189879L,357614L,664588L,1257356L,2254304L,4303412L,8113964L,15259583L,28364673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243159Inst : IEnumerable<long>
{
public static readonly long[] Value=A243159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243159.Bytes);
public long this[int i]=>Value[i];

public static A243159Inst Instance=new A243159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243160
{
public static readonly long[] Value={ 3L,2L,2L,2L,0L,2L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,7L,0L,2L,0L,0L,0L,0L,0L,16L,0L,0L,0L,61L,0L,2L,0L,0L,0L,6L,0L,0L,0L,0L,0L,10L,0L,0L,0L,0L,0L,6L,0L,2L,0L,0L,0L,0L,0L,5L,0L,0L,0L,46L,0L,18L,0L,0L,0L,0L,0L,2L,0L,0L,0L,49L,0L,0L,0L,0L,0L,16L,0L,0L,0L,0L,0L,0L,0L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243160Inst : IEnumerable<long>
{
public static readonly long[] Value=A243160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243160.Bytes);
public long this[int i]=>Value[i];

public static A243160Inst Instance=new A243160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243161
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,13L,61L,133L,449L,1825L,11497L,29905L,121529L,613121L,3192553L,26963653L,76748369L,367110269L,2101537105L,13742608029L,90490605353L,966603833657L,2899027074937L,15202727310033L,102739122225929L,738145449190921L,6064931145859705L,47996143247509851L,637518525737986877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243161Inst : IEnumerable<long>
{
public static readonly long[] Value=A243161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243161.Bytes);
public long this[int i]=>Value[i];

public static A243161Inst Instance=new A243161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243162
{
public static readonly long[] Value={ 1L,3L,13L,21L,37L,39L,91L,1443L,3367L,9901L,157737L,333667L,999001L,3075403L,9226209L,14287143L,33336667L,99990001L,1171182883L,1224848037L,1286294191L,1397863441L,1428557143L,1469179621L,1535254357L,1568996211L,1753536967L,1792076241L,1839599913L,1891910811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243162Inst : IEnumerable<long>
{
public static readonly long[] Value=A243162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243162.Bytes);
public long this[int i]=>Value[i];

public static A243162Inst Instance=new A243162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243163
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,0L,0L,7L,12L,0L,0L,4L,45L,55L,0L,0L,0L,55L,286L,273L,0L,0L,0L,22L,546L,1820L,1428L,0L,0L,0L,0L,455L,4760L,11628L,7752L,0L,0L,0L,0L,140L,6120L,38760L,74613L,43263L,0L,0L,0L,0L,0L,3876L,67830L,302841L,480700L,246675L,0L,0L,0L,0L,0L,969L,65835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243163Inst : IEnumerable<long>
{
public static readonly long[] Value=A243163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243163.Bytes);
public long this[int i]=>Value[i];

public static A243163Inst Instance=new A243163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243164
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,2L,1L,2L,2L,3L,3L,3L,2L,3L,4L,2L,2L,4L,3L,3L,5L,3L,5L,5L,6L,2L,5L,5L,4L,4L,2L,4L,6L,7L,6L,7L,2L,7L,4L,7L,4L,4L,6L,7L,3L,7L,7L,3L,7L,7L,9L,7L,6L,5L,6L,6L,7L,7L,9L,4L,9L,8L,2L,10L,7L,9L,11L,5L,6L,5L,9L,11L,8L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243164Inst : IEnumerable<long>
{
public static readonly long[] Value=A243164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243164.Bytes);
public long this[int i]=>Value[i];

public static A243164Inst Instance=new A243164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243165
{
public static readonly long[] Value={ 0L,2L,3L,5L,8L,12L,13L,18L,20L,27L,30L,32L,37L,43L,45L,48L,50L,52L,53L,62L,67L,72L,75L,78L,80L,82L,83L,93L,98L,107L,108L,117L,120L,123L,125L,128L,130L,142L,147L,148L,155L,157L,158L,162L,163L,172L,173L,178L,180L,192L,195L,197L,200L,205L,208L,212L,213L,222L,227L,237L,242L,243L,245L,248L,258L,267L,268L,270L,277L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243165Inst : IEnumerable<long>
{
public static readonly long[] Value=A243165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243165.Bytes);
public long this[int i]=>Value[i];

public static A243165Inst Instance=new A243165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243166
{
public static readonly long[] Value={ 0L,1L,4L,5L,9L,14L,16L,20L,22L,25L,36L,37L,38L,45L,49L,53L,56L,64L,70L,77L,80L,81L,86L,88L,89L,97L,100L,110L,113L,121L,125L,126L,133L,137L,144L,148L,152L,157L,158L,166L,169L,180L,181L,185L,190L,196L,198L,209L,212L,214L,224L,225L,229L,245L,254L,256L,257L,262L,265L,269L,278L,280L,289L,301L,302L,308L,313L,317L,320L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243166Inst : IEnumerable<long>
{
public static readonly long[] Value=A243166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243166.Bytes);
public long this[int i]=>Value[i];

public static A243166Inst Instance=new A243166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243167
{
public static readonly long[] Value={ 0L,2L,7L,8L,10L,11L,18L,19L,28L,32L,35L,40L,43L,44L,50L,55L,63L,72L,74L,76L,79L,83L,90L,95L,98L,99L,106L,107L,112L,127L,128L,131L,139L,140L,151L,154L,160L,162L,167L,171L,172L,175L,176L,178L,194L,200L,211L,215L,220L,226L,227L,239L,242L,250L,252L,259L,263L,266L,271L,274L,275L,283L,288L,296L,304L,307L,314L,315L,316L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243167Inst : IEnumerable<long>
{
public static readonly long[] Value=A243167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243167.Bytes);
public long this[int i]=>Value[i];

public static A243167Inst Instance=new A243167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243168
{
public static readonly long[] Value={ 0L,1L,4L,9L,13L,16L,24L,25L,33L,36L,37L,49L,52L,61L,64L,69L,73L,81L,88L,96L,97L,100L,109L,117L,121L,132L,141L,144L,148L,157L,169L,177L,181L,184L,193L,196L,208L,213L,216L,225L,229L,241L,244L,249L,253L,256L,276L,277L,289L,292L,297L,312L,313L,321L,324L,325L,333L,337L,349L,352L,361L,373L,376L,384L,388L,393L,397L,400L,409L,421L,429L,433L,436L,441L,457L,468L,472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243168Inst : IEnumerable<long>
{
public static readonly long[] Value=A243168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243168.Bytes);
public long this[int i]=>Value[i];

public static A243168Inst Instance=new A243168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243169
{
public static readonly long[] Value={ 0L,3L,8L,11L,12L,23L,27L,32L,39L,44L,47L,48L,59L,71L,72L,75L,83L,92L,99L,104L,107L,108L,111L,128L,131L,143L,147L,156L,167L,176L,179L,183L,188L,191L,192L,200L,207L,219L,227L,236L,239L,243L,251L,263L,264L,275L,284L,288L,291L,296L,299L,300L,311L,327L,332L,347L,351L,359L,363L,368L,383L,392L,396L,407L,416L,419L,423L,428L,431L,432L,443L,444L,467L,471L,479L,488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243169Inst : IEnumerable<long>
{
public static readonly long[] Value=A243169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243169.Bytes);
public long this[int i]=>Value[i];

public static A243169Inst Instance=new A243169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243170
{
public static readonly long[] Value={ 0L,1L,4L,9L,10L,14L,16L,25L,26L,29L,35L,36L,40L,49L,56L,61L,64L,65L,74L,79L,81L,90L,91L,94L,100L,101L,104L,116L,121L,126L,131L,134L,139L,140L,144L,146L,160L,166L,169L,179L,181L,185L,191L,194L,196L,199L,211L,224L,225L,234L,235L,244L,250L,251L,256L,259L,260L,261L,269L,274L,289L,290L,296L,311L,315L,316L,324L,326L,329L,334L,335L,350L,360L,361L,364L,365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243170Inst : IEnumerable<long>
{
public static readonly long[] Value=A243170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243170.Bytes);
public long this[int i]=>Value[i];

public static A243170Inst Instance=new A243170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243171
{
public static readonly long[] Value={ 0L,2L,5L,7L,8L,13L,18L,20L,28L,32L,37L,45L,47L,50L,52L,58L,63L,67L,70L,72L,73L,80L,83L,97L,98L,112L,117L,122L,125L,128L,130L,137L,145L,148L,158L,162L,163L,167L,175L,180L,182L,188L,193L,197L,200L,202L,203L,208L,223L,227L,232L,242L,245L,252L,262L,268L,278L,280L,288L,292L,293L,305L,317L,320L,325L,332L,333L,338L,343L,353L,358L,362L,370L,377L,382L,383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243171Inst : IEnumerable<long>
{
public static readonly long[] Value=A243171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243171.Bytes);
public long this[int i]=>Value[i];

public static A243171Inst Instance=new A243171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243172
{
public static readonly long[] Value={ 0L,1L,4L,7L,9L,15L,16L,25L,28L,36L,37L,43L,49L,51L,60L,63L,64L,67L,79L,81L,85L,100L,105L,109L,112L,121L,123L,127L,135L,141L,144L,148L,151L,163L,169L,172L,175L,177L,193L,196L,204L,205L,211L,225L,235L,240L,249L,252L,256L,259L,267L,268L,277L,289L,295L,301L,303L,316L,324L,331L,333L,337L,340L,343L,357L,361L,373L,375L,379L,387L,393L,400L,415L,420L,421L,436L,441L,445L,448L,457L,459L,463L,469L,484L,487L,492L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243172Inst : IEnumerable<long>
{
public static readonly long[] Value=A243172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243172.Bytes);
public long this[int i]=>Value[i];

public static A243172Inst Instance=new A243172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243173
{
public static readonly long[] Value={ 0L,1L,4L,9L,15L,16L,19L,24L,25L,31L,36L,40L,49L,51L,60L,61L,64L,69L,76L,79L,81L,85L,96L,100L,109L,115L,121L,124L,135L,136L,139L,141L,144L,151L,159L,160L,169L,171L,181L,184L,196L,199L,204L,211L,216L,225L,229L,235L,240L,241L,244L,249L,256L,265L,271L,276L,279L,285L,289L,304L,316L,321L,324L,331L,339L,340L,349L,360L,361L,375L,376L,379L,384L,391L,400L,409L,411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243173Inst : IEnumerable<long>
{
public static readonly long[] Value=A243173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243173.Bytes);
public long this[int i]=>Value[i];

public static A243173Inst Instance=new A243173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243174
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,19L,25L,31L,36L,45L,49L,55L,61L,64L,76L,79L,81L,99L,100L,109L,121L,124L,139L,144L,145L,151L,169L,171L,180L,181L,196L,199L,205L,211L,220L,225L,229L,241L,244L,256L,261L,271L,279L,289L,295L,304L,316L,319L,324L,331L,349L,355L,361L,369L,379L,396L,400L,405L,409L,421L,436L,439L,441L,445L,451L,475L,484L,495L,496L,499L,505L,529L,531L,541L,549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243174Inst : IEnumerable<long>
{
public static readonly long[] Value=A243174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243174.Bytes);
public long this[int i]=>Value[i];

public static A243174Inst Instance=new A243174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243175
{
public static readonly long[] Value={ 0L,1L,4L,7L,9L,13L,16L,19L,25L,27L,28L,31L,36L,37L,43L,49L,52L,61L,63L,64L,67L,73L,76L,79L,81L,91L,97L,100L,103L,108L,109L,112L,117L,121L,124L,127L,133L,139L,144L,148L,151L,157L,163L,169L,171L,172L,175L,181L,189L,193L,196L,199L,208L,211L,217L,223L,225L,229L,241L,243L,244L,247L,252L,256L,259L,268L,271L,277L,279L,283L,289L,292L,301L,304L,307L,313L,316L,324L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243175Inst : IEnumerable<long>
{
public static readonly long[] Value=A243175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243175.Bytes);
public long this[int i]=>Value[i];

public static A243175Inst Instance=new A243175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243176
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,10L,14L,16L,20L,25L,28L,31L,32L,35L,36L,38L,40L,47L,49L,50L,56L,64L,67L,70L,72L,76L,80L,81L,82L,90L,95L,98L,100L,112L,118L,121L,124L,125L,126L,128L,131L,133L,140L,142L,144L,149L,152L,160L,164L,169L,173L,175L,180L,188L,190L,194L,196L,200L,202L,205L,206L,214L,218L,224L,225L,226L,227L,236L,245L,248L,250L,252L,256L,266L,268L,279L,280L,283L,284L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243176Inst : IEnumerable<long>
{
public static readonly long[] Value=A243176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243176.Bytes);
public long this[int i]=>Value[i];

public static A243176Inst Instance=new A243176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243177
{
public static readonly long[] Value={ 0L,3L,4L,8L,11L,12L,16L,19L,24L,27L,32L,36L,43L,44L,48L,51L,59L,64L,67L,68L,72L,75L,76L,83L,88L,96L,99L,100L,107L,108L,123L,128L,131L,132L,136L,139L,144L,147L,152L,163L,164L,171L,172L,176L,179L,187L,192L,196L,200L,204L,211L,216L,219L,227L,228L,236L,243L,251L,256L,264L,267L,268L,272L,275L,283L,288L,291L,292L,300L,304L,307L,323L,324L,328L,331L,332L,339L,344L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243177Inst : IEnumerable<long>
{
public static readonly long[] Value=A243177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243177.Bytes);
public long this[int i]=>Value[i];

public static A243177Inst Instance=new A243177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243178
{
public static readonly long[] Value={ 0L,1L,4L,9L,11L,15L,16L,21L,25L,29L,35L,36L,39L,44L,49L,51L,60L,64L,65L,71L,79L,81L,84L,85L,91L,99L,100L,109L,116L,119L,121L,135L,140L,141L,144L,149L,151L,156L,165L,169L,176L,179L,189L,191L,196L,204L,211L,219L,221L,225L,231L,235L,239L,240L,249L,256L,260L,261L,275L,281L,284L,289L,291L,309L,315L,316L,319L,324L,329L,331L,336L,340L,351L,359L,361L,364L,365L,375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243178Inst : IEnumerable<long>
{
public static readonly long[] Value=A243178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243178.Bytes);
public long this[int i]=>Value[i];

public static A243178Inst Instance=new A243178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243179
{
public static readonly long[] Value={ 0L,3L,5L,7L,12L,13L,17L,20L,27L,28L,33L,45L,47L,48L,52L,55L,63L,68L,73L,75L,77L,80L,83L,87L,97L,103L,105L,108L,112L,117L,125L,132L,143L,145L,147L,153L,157L,167L,173L,175L,180L,187L,188L,192L,195L,203L,208L,213L,220L,223L,227L,237L,243L,245L,252L,255L,257L,272L,273L,283L,292L,293L,297L,300L,307L,308L,313L,320L,325L,327L,332L,343L,348L,353L,355L,357L,363L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243179Inst : IEnumerable<long>
{
public static readonly long[] Value=A243179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243179.Bytes);
public long this[int i]=>Value[i];

public static A243179Inst Instance=new A243179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243180
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,16L,22L,25L,26L,32L,34L,36L,44L,46L,49L,52L,58L,61L,62L,64L,67L,68L,72L,81L,88L,92L,100L,104L,113L,116L,118L,121L,124L,128L,136L,143L,144L,146L,157L,158L,169L,176L,178L,184L,187L,193L,196L,197L,198L,200L,208L,221L,225L,227L,232L,234L,236L,241L,242L,244L,248L,253L,256L,257L,268L,272L,274L,278L,286L,288L,289L,292L,299L,306L,316L,319L,324L,338L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243180Inst : IEnumerable<long>
{
public static readonly long[] Value=A243180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243180.Bytes);
public long this[int i]=>Value[i];

public static A243180Inst Instance=new A243180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A243181
{
public static readonly long[] Value={ 0L,2L,4L,8L,11L,13L,16L,17L,18L,22L,23L,26L,29L,31L,32L,34L,36L,44L,46L,50L,52L,58L,59L,62L,64L,68L,72L,73L,79L,88L,89L,92L,98L,99L,100L,104L,116L,117L,118L,121L,122L,124L,128L,134L,136L,137L,139L,143L,144L,146L,153L,158L,162L,169L,173L,176L,178L,184L,187L,196L,198L,199L,200L,207L,208L,211L,221L,223L,226L,232L,234L,236L,239L,242L,244L,248L,253L,256L,261L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A243181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A243181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A243181Inst : IEnumerable<long>
{
public static readonly long[] Value=A243181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A243181.Bytes);
public long this[int i]=>Value[i];

public static A243181Inst Instance=new A243181Inst();

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