using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A081859
{
public static readonly long[] Value={ 3L,5L,8L,7L,20L,12L,9L,28L,11L,16L,33L,48L,13L,36L,39L,20L,65L,15L,60L,44L,17L,24L,88L,51L,85L,19L,52L,119L,57L,28L,104L,95L,21L,84L,133L,60L,140L,32L,105L,23L,120L,69L,96L,115L,68L,25L,160L,36L,161L,75L,136L,207L,27L,204L,76L,175L,180L,40L,225L,135L,29L,152L,252L,189L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081859Inst : IEnumerable<long>
{
public static readonly long[] Value=A081859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081859.Bytes);
public long this[int i]=>Value[i];

public static A081859Inst Instance=new A081859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081860
{
public static readonly long[] Value={ 1L,13L,70L,247L,671L,1547L,3178L,5916L,10317L,17088L,26818L,40703L,60034L,85463L,119288L,163736L,218924L,288933L,377482L,482734L,612535L,772291L,955604L,1177050L,1443522L,1742481L,2097702L,2517368L,2978851L,3519151L,4152486L,4836104L,5625521L,6543616L,7517622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081860Inst : IEnumerable<long>
{
public static readonly long[] Value=A081860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081860.Bytes);
public long this[int i]=>Value[i];

public static A081860Inst Instance=new A081860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081861
{
public static readonly long[] Value={ 0L,1L,5L,14L,31L,55L,91L,146L,204L,285L,400L,506L,655L,850L,1015L,1240L,1552L,1804L,2109L,2562L,2870L,3311L,3971L,4324L,4914L,5730L,6201L,6990L,8000L,8555L,9455L,10846L,11536L,12529L,14192L,14910L,16206L,18371L,19088L,20540L,22990L,23821L,25794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081861Inst : IEnumerable<long>
{
public static readonly long[] Value=A081861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081861.Bytes);
public long this[int i]=>Value[i];

public static A081861Inst Instance=new A081861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081862
{
public static readonly long[] Value={ 0L,13L,465L,4902L,28483L,115995L,373503L,1017498L,2442492L,5320665L,10725680L,20266818L,36330915L,62292490L,102677835L,163765560L,253797216L,382977372L,565070697L,817224746L,1159251630L,1617967923L,2225268903L,3015613812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081862Inst : IEnumerable<long>
{
public static readonly long[] Value=A081862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081862.Bytes);
public long this[int i]=>Value[i];

public static A081862Inst Instance=new A081862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081863
{
public static readonly long[] Value={ 24L,240L,168L,480L,264L,21840L,24L,16320L,3192L,2640L,552L,43680L,24L,6960L,57288L,32640L,24L,15353520L,24L,216480L,7224L,5520L,1128L,1485120L,264L,12720L,3192L,13920L,1416L,454293840L,24L,65280L,258888L,240L,18744L,2241613920L,24L,240L,13272L,7360320L,1992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081863Inst : IEnumerable<long>
{
public static readonly long[] Value=A081863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081863.Bytes);
public long this[int i]=>Value[i];

public static A081863Inst Instance=new A081863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081864
{
public static readonly long[] Value={ 1L,244L,3126L,16808L,59293L,161052L,371294L,762744L,1419858L,2476100L,4101152L,6436344L,9768751L,14408200L,20511150L,28629152L,39296688L,52541808L,69343958L,90595736L,115856202L,147008444L,185349918L,229345008L,282492057L,346445352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081864Inst : IEnumerable<long>
{
public static readonly long[] Value=A081864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081864.Bytes);
public long this[int i]=>Value[i];

public static A081864Inst Instance=new A081864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081865
{
public static readonly long[] Value={ 1L,2188L,78126L,823544L,4785157L,19487172L,62748518L,170939688L,410338674L,893871740L,1801914272L,3404825448L,6103593751L,10465138360L,17249876310L,27512614112L,42637932336L,64340198544L,94931877134L,137293757384L,194754273882L,271818611108L,373845175782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081865Inst : IEnumerable<long>
{
public static readonly long[] Value=A081865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081865.Bytes);
public long this[int i]=>Value[i];

public static A081865Inst Instance=new A081865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081866
{
public static readonly long[] Value={ 1L,19684L,1953126L,40353608L,387440173L,2357947692L,10604499374L,38445332184L,118587876498L,322687697780L,794320419872L,1801152661464L,3814699218751L,7625984925160L,14507145975870L,26439622160672L,46413842369328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081866Inst : IEnumerable<long>
{
public static readonly long[] Value=A081866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081866.Bytes);
public long this[int i]=>Value[i];

public static A081866Inst Instance=new A081866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081867
{
public static readonly long[] Value={ 1L,177148L,48828126L,1977326744L,31381236757L,285311670612L,1792160394038L,8649804864648L,34271896307634L,116490258898220L,350279478046112L,952809757913928L,2384185839843751L,5559091947792280L,12200509765705830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081867Inst : IEnumerable<long>
{
public static readonly long[] Value=A081867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081867.Bytes);
public long this[int i]=>Value[i];

public static A081867Inst Instance=new A081867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081868
{
public static readonly long[] Value={ 1L,2L,3L,10L,11L,28L,29L,36L,37L,38L,39L,82L,83L,90L,91L,92L,93L,108L,109L,110L,111L,118L,119L,244L,245L,252L,253L,254L,255L,270L,271L,272L,273L,280L,281L,324L,325L,326L,327L,334L,335L,352L,353L,360L,361L,362L,363L,730L,731L,738L,739L,740L,741L,756L,757L,758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081868Inst : IEnumerable<long>
{
public static readonly long[] Value=A081868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081868.Bytes);
public long this[int i]=>Value[i];

public static A081868Inst Instance=new A081868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081869
{
public static readonly long[] Value={ 2L,3L,4L,5L,9L,10L,11L,21L,22L,23L,45L,46L,91L,92L,183L,365L,729L,1457L,2913L,5825L,11649L,11650L,23299L,46597L,93193L,186385L,186386L,372771L,745541L,1491081L,2982161L,5964321L,5964322L,11928643L,23857285L,47714569L,95429137L,95429138L,190858275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081869Inst : IEnumerable<long>
{
public static readonly long[] Value=A081869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081869.Bytes);
public long this[int i]=>Value[i];

public static A081869Inst Instance=new A081869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081870
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,10L,11L,12L,25L,26L,27L,28L,29L,30L,31L,63L,64L,65L,66L,67L,135L,136L,137L,275L,276L,277L,278L,279L,280L,281L,282L,283L,567L,568L,569L,570L,571L,1143L,1144L,1145L,1146L,1147L,2295L,2296L,2297L,2298L,2299L,4599L,4600L,4601L,4602L,4603L,9207L,9208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081870Inst : IEnumerable<long>
{
public static readonly long[] Value=A081870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081870.Bytes);
public long this[int i]=>Value[i];

public static A081870Inst Instance=new A081870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081871
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,10L,21L,22L,45L,91L,183L,184L,369L,370L,741L,742L,1485L,1486L,2973L,5947L,11895L,23791L,47583L,95167L,190335L,380671L,761343L,1522687L,3045375L,3045376L,6090753L,12181507L,24363015L,48726031L,97452063L,194904127L,389808255L,779616511L,1559233023L,3118466047L,6236932095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081871Inst : IEnumerable<long>
{
public static readonly long[] Value=A081871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081871.Bytes);
public long this[int i]=>Value[i];

public static A081871Inst Instance=new A081871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081872
{
public static readonly long[] Value={ 4L,12L,15L,24L,21L,35L,40L,45L,60L,63L,56L,55L,84L,77L,80L,99L,72L,112L,91L,117L,144L,143L,105L,140L,132L,180L,165L,120L,176L,195L,153L,168L,220L,187L,156L,221L,171L,255L,208L,264L,209L,260L,247L,252L,285L,312L,231L,323L,240L,308L,273L,224L,364L,253L,357L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081872Inst : IEnumerable<long>
{
public static readonly long[] Value=A081872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081872.Bytes);
public long this[int i]=>Value[i];

public static A081872Inst Instance=new A081872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081873
{
public static readonly long[] Value={ 6L,15L,28L,45L,66L,77L,91L,104L,117L,120L,153L,170L,187L,190L,204L,209L,228L,231L,247L,273L,276L,299L,322L,325L,345L,350L,368L,378L,400L,425L,432L,435L,459L,464L,493L,496L,513L,522L,527L,551L,558L,561L,580L,589L,620L,627L,630L,651L,660L,665L,703L,740L,759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081873Inst : IEnumerable<long>
{
public static readonly long[] Value=A081873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081873.Bytes);
public long this[int i]=>Value[i];

public static A081873Inst Instance=new A081873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081874
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,33L,35L,37L,39L,39L,41L,43L,45L,47L,49L,51L,51L,53L,55L,57L,57L,59L,61L,63L,65L,65L,67L,69L,69L,71L,73L,75L,75L,77L,79L,81L,83L,85L,85L,87L,87L,89L,91L,93L,93L,95L,95L,97L,99L,101L,103L,105L,105L,105L,107L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081874Inst : IEnumerable<long>
{
public static readonly long[] Value=A081874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081874.Bytes);
public long this[int i]=>Value[i];

public static A081874Inst Instance=new A081874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081875
{
public static readonly long[] Value={ 1L,4L,12L,40L,130L,480L,1722L,6480L,24336L,92520L,352726L,1352640L,5200312L,20060040L,77559060L,300546720L,1166803126L,4537592928L,17672631918L,68923357200L,269128940724L,1052049834616L,4116715363822L,16123803207552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081875Inst : IEnumerable<long>
{
public static readonly long[] Value=A081875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081875.Bytes);
public long this[int i]=>Value[i];

public static A081875Inst Instance=new A081875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081876
{
public static readonly long[] Value={ 9L,137L,2120L,3496L,88008L,176451L,25198140L,50366472L,1660042751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081876Inst : IEnumerable<long>
{
public static readonly long[] Value=A081876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081876.Bytes);
public long this[int i]=>Value[i];

public static A081876Inst Instance=new A081876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081877
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,1L,2L,1L,1L,1L,5L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,6L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081877Inst : IEnumerable<long>
{
public static readonly long[] Value=A081877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081877.Bytes);
public long this[int i]=>Value[i];

public static A081877Inst Instance=new A081877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081878
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,2L,1L,5L,8L,4L,2L,1L,6L,3L,7L,10L,5L,8L,4L,2L,1L,8L,4L,2L,1L,9L,10L,5L,8L,4L,2L,1L,10L,5L,8L,4L,2L,1L,11L,14L,7L,10L,5L,8L,4L,2L,1L,12L,6L,3L,13L,16L,8L,4L,2L,1L,14L,7L,10L,5L,8L,4L,2L,1L,15L,16L,8L,4L,2L,1L,16L,8L,4L,2L,1L,17L,20L,10L,5L,8L,4L,2L,1L,18L,9L,10L,5L,8L,4L,2L,1L,19L,22L,11L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081878Inst : IEnumerable<long>
{
public static readonly long[] Value=A081878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081878.Bytes);
public long this[int i]=>Value[i];

public static A081878Inst Instance=new A081878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081879
{
public static readonly long[] Value={ 0L,1L,0L,2L,4L,1L,6L,3L,6L,5L,8L,2L,5L,7L,5L,4L,7L,7L,10L,6L,10L,9L,7L,3L,7L,6L,9L,8L,6L,6L,9L,5L,9L,8L,9L,8L,8L,11L,8L,7L,11L,11L,9L,10L,9L,8L,9L,4L,9L,8L,8L,7L,10L,10L,10L,9L,8L,7L,11L,7L,7L,10L,7L,6L,11L,10L,11L,9L,11L,10L,10L,9L,13L,9L,13L,12L,10L,9L,13L,8L,13L,12L,11L,12L,11L,10L,12L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081879Inst : IEnumerable<long>
{
public static readonly long[] Value=A081879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081879.Bytes);
public long this[int i]=>Value[i];

public static A081879Inst Instance=new A081879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081880
{
public static readonly BigInteger[] Value={ 0L,2L,0L,4L,2L,0L,6L,8L,10L,16L,42L,10L,16L,42L,12L,14L,32L,170L,4816L,3865642L,2490531345360L,16L,42L,18L,20L,66L,22L,80L,1066L,189392L,5978221610L,5956522269711832016L,BigInteger.Parse("5913359591595499145281505571167104042"),BigInteger.Parse("5827970276585748074286667660065476529979312208145367609757859954142122960"),24L,26L };
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
public class A081880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A081880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A081880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A081880Inst Instance=new A081880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081881
{
public static readonly long[] Value={ 1L,2L,4L,10L,26L,69L,186L,504L,1369L,3720L,10111L,27483L,74705L,203068L,551995L,1500477L,4078718L,11087104L,30137872L,81923228L,222690421L,605335323L,1645472007L,4472856655L,12158484965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081881Inst : IEnumerable<long>
{
public static readonly long[] Value=A081881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081881.Bytes);
public long this[int i]=>Value[i];

public static A081881Inst Instance=new A081881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081882
{
public static readonly long[] Value={ 2L,8L,1L,2L,3L,2L,1L,4L,2L,3L,1L,4L,8L,3L,1L,4L,2L,4L,1L,2L,3L,2L,1L,5L,2L,5L,1L,3L,4L,6L,1L,8L,2L,5L,1L,2L,3L,2L,1L,3L,2L,6L,1L,5L,5L,3L,1L,3L,2L,3L,1L,2L,3L,2L,1L,8L,2L,7L,1L,3L,4L,4L,1L,4L,2L,4L,1L,2L,3L,2L,1L,5L,2L,3L,1L,4L,6L,3L,1L,5L,2L,8L,1L,2L,3L,2L,1L,6L,2L,4L,1L,3L,4L,5L,1L,4L,2L,4L,1L,2L,3L,2L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081882Inst : IEnumerable<long>
{
public static readonly long[] Value=A081882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081882.Bytes);
public long this[int i]=>Value[i];

public static A081882Inst Instance=new A081882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081883
{
public static readonly long[] Value={ 5L,9L,21L,37L,46L,49L,53L,69L,85L,101L,113L,117L,121L,133L,137L,149L,165L,174L,177L,181L,197L,213L,217L,229L,241L,245L,261L,265L,277L,293L,302L,305L,309L,313L,325L,341L,357L,369L,373L,389L,393L,405L,421L,430L,433L,437L,441L,453L,469L,485L,497L,501L,517L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081883Inst : IEnumerable<long>
{
public static readonly long[] Value=A081883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081883.Bytes);
public long this[int i]=>Value[i];

public static A081883Inst Instance=new A081883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081884
{
public static readonly long[] Value={ 4L,7L,4L,7L,7L,6L,1L,3L,2L,2L,2L,7L,2L,3L,1L,6L,5L,4L,3L,7L,7L,6L,1L,3L,3L,5L,2L,2L,3L,3L,1L,5L,3L,9L,6L,4L,7L,3L,1L,3L,2L,3L,2L,3L,2L,2L,1L,5L,5L,4L,3L,10L,3L,4L,1L,2L,4L,5L,2L,7L,7L,9L,1L,6L,6L,3L,4L,12L,3L,13L,1L,5L,2L,2L,2L,10L,2L,5L,1L,5L,3L,13L,3L,3L,5L,6L,1L,9L,3L,6L,2L,2L,3L,4L,1L,6L,6L,6L,5L,6L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081884Inst : IEnumerable<long>
{
public static readonly long[] Value=A081884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081884.Bytes);
public long this[int i]=>Value[i];

public static A081884Inst Instance=new A081884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081885
{
public static readonly long[] Value={ 8L,5L,3L,8L,18L,8L,5L,6L,5L,6L,3L,6L,7L,5L,1L,6L,4L,6L,3L,4L,2L,6L,2L,7L,3L,2L,4L,6L,2L,5L,1L,8L,12L,4L,7L,4L,8L,7L,3L,9L,10L,5L,3L,9L,5L,6L,1L,3L,11L,4L,2L,4L,4L,4L,2L,4L,6L,7L,2L,2L,5L,3L,1L,7L,9L,9L,5L,7L,4L,13L,4L,5L,6L,8L,6L,14L,8L,3L,1L,4L,2L,5L,4L,5L,3L,2L,2L,10L,2L,5L,3L,18L,4L,3L,1L,11L,4L,7L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081885Inst : IEnumerable<long>
{
public static readonly long[] Value=A081885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081885.Bytes);
public long this[int i]=>Value[i];

public static A081885Inst Instance=new A081885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081886
{
public static readonly long[] Value={ 1L,5L,26L,77L,522L,669L,5772L,13827L,48610L,55991L,699612L,785633L,11359222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081886Inst : IEnumerable<long>
{
public static readonly long[] Value=A081886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081886.Bytes);
public long this[int i]=>Value[i];

public static A081886Inst Instance=new A081886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081887
{
public static readonly long[] Value={ 1L,2L,4L,10L,12L,16L,28L,30L,52L,88L,96L,126L,130L,136L,138L,148L,150L,250L,256L,262L,268L,270L,292L,970L,976L,982L,990L,996L,1008L,1012L,1018L,1020L,1030L,1032L,1038L,1048L,1050L,1060L,1062L,1372L,1380L,1398L,1408L,1422L,1426L,1428L,1432L,1438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081887Inst : IEnumerable<long>
{
public static readonly long[] Value=A081887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081887.Bytes);
public long this[int i]=>Value[i];

public static A081887Inst Instance=new A081887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081888
{
public static readonly long[] Value={ 1L,3L,4L,6L,22L,118L,191L,362L,842L,2042L,2342L,3622L,16022L,29642L,66602L,110881L,143522L,535802L,5070662L,6252122L,6497402L,10219442L,69069002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081888Inst : IEnumerable<long>
{
public static readonly long[] Value=A081888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081888.Bytes);
public long this[int i]=>Value[i];

public static A081888Inst Instance=new A081888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081889
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,19L,21L,23L,31L,35L,41L,43L,53L,57L,69L,87L,93L,95L,101L,115L,141L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081889Inst : IEnumerable<long>
{
public static readonly long[] Value=A081889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081889.Bytes);
public long this[int i]=>Value[i];

public static A081889Inst Instance=new A081889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081890
{
public static readonly long[] Value={ 1L,3L,7L,33L,643L,11073L,151867L,1816713L,19996963L,208630833L,2099398027L,20597485593L,198424412083L,1885822419393L,17740469253787L,165580566245673L,1535948935336003L,14178113530908753L,130361707324735147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081890Inst : IEnumerable<long>
{
public static readonly long[] Value=A081890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081890.Bytes);
public long this[int i]=>Value[i];

public static A081890Inst Instance=new A081890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081891
{
public static readonly long[] Value={ 1L,4L,14L,64L,830L,14704L,228734L,3136144L,39450110L,468241264L,5338397054L,59140070224L,641540046590L,6850671429424L,72282030453374L,755587489260304L,7840735233590270L,80889167950995184L,830567232465613694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081891Inst : IEnumerable<long>
{
public static readonly long[] Value=A081891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081891.Bytes);
public long this[int i]=>Value[i];

public static A081891Inst Instance=new A081891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081924
{
public static readonly long[] Value={ 1L,5L,27L,159L,1029L,7353L,58095L,506691L,4860297L,51023277L,583097859L,7215769575L,96210083853L,1375803720801L,21012273704151L,341449444105227L,5883436565417745L,107162594556721749L,2057521815411573483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081924Inst : IEnumerable<long>
{
public static readonly long[] Value=A081924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081924.Bytes);
public long this[int i]=>Value[i];

public static A081924Inst Instance=new A081924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081925
{
public static readonly long[] Value={ 8L,12L,16L,20L,20L,24L,28L,28L,32L,36L,36L,40L,44L,44L,48L,48L,52L,52L,56L,60L,60L,60L,64L,68L,68L,72L,76L,76L,80L,84L,84L,84L,88L,88L,92L,92L,96L,96L,100L,100L,104L,104L,108L,108L,112L,116L,116L,120L,120L,120L,124L,124L,128L,132L,132L,132L,136L,136L,140L,140L,140L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081925Inst : IEnumerable<long>
{
public static readonly long[] Value=A081925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081925.Bytes);
public long this[int i]=>Value[i];

public static A081925Inst Instance=new A081925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081926
{
public static readonly long[] Value={ 1L,2L,11L,3L,12L,21L,4L,13L,22L,31L,5L,14L,23L,32L,41L,6L,15L,24L,33L,42L,51L,7L,16L,25L,34L,43L,52L,61L,8L,17L,26L,35L,44L,53L,62L,71L,9L,18L,27L,36L,45L,54L,63L,72L,81L,19L,28L,37L,46L,55L,64L,73L,82L,91L,109L,29L,38L,47L,56L,65L,74L,83L,92L,119L,128L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081926Inst : IEnumerable<long>
{
public static readonly long[] Value=A081926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081926.Bytes);
public long this[int i]=>Value[i];

public static A081926Inst Instance=new A081926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081927
{
public static readonly long[] Value={ 1L,11L,21L,31L,41L,51L,61L,71L,81L,109L,137L,165L,193L,257L,294L,376L,467L,567L,676L,785L,894L,1399L,1778L,1986L,2887L,3869L,4869L,5878L,6887L,7896L,8959L,9968L,18798L,26998L,35999L,45999L,56899L,66989L,76998L,87799L,97889L,178899L,199798L,298988L,398988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081927Inst : IEnumerable<long>
{
public static readonly long[] Value=A081927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081927.Bytes);
public long this[int i]=>Value[i];

public static A081927Inst Instance=new A081927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081928
{
public static readonly long[] Value={ 1L,13L,36L,70L,115L,171L,238L,316L,405L,604L,868L,1197L,1591L,2158L,2844L,3829L,5140L,6939L,9415L,12100L,14994L,18493L,26062L,34650L,49414L,69535L,96534L,129412L,164299L,201195L,240154L,281122L,414036L,584635L,852634L,1212633L,1629532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081928Inst : IEnumerable<long>
{
public static readonly long[] Value=A081928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081928.Bytes);
public long this[int i]=>Value[i];

public static A081928Inst Instance=new A081928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081929
{
public static readonly long[] Value={ 1L,22L,64L,127L,211L,316L,442L,589L,757L,946L,1156L,2467L,3979L,5692L,7606L,9721L,12037L,14554L,17272L,20191L,23311L,26632L,30154L,33877L,37801L,41926L,46252L,50779L,55507L,60436L,65566L,70897L,76429L,82162L,88096L,94231L,100567L,107104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081929Inst : IEnumerable<long>
{
public static readonly long[] Value=A081929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081929.Bytes);
public long this[int i]=>Value[i];

public static A081929Inst Instance=new A081929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081930
{
public static readonly long[] Value={ 0L,11L,22L,101L,111L,121L,1001L,1111L,1221L,1331L,10001L,10101L,10201L,10301L,10401L,100001L,101101L,102201L,103301L,104401L,105501L,1000001L,1001001L,1002001L,1003001L,1004001L,1005001L,1006001L,10000001L,10011001L,10022001L,10033001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081930Inst : IEnumerable<long>
{
public static readonly long[] Value=A081930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081930.Bytes);
public long this[int i]=>Value[i];

public static A081930Inst Instance=new A081930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081931
{
public static readonly long[] Value={ 1L,22L,121L,1331L,10401L,105501L,1006001L,10077001L,100080001L,1000990001L,10001010001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081931Inst : IEnumerable<long>
{
public static readonly long[] Value=A081931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081931.Bytes);
public long this[int i]=>Value[i];

public static A081931Inst Instance=new A081931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081932
{
public static readonly long[] Value={ 1L,33L,333L,4664L,51005L,616506L,7021007L,80308008L,900360009L,10004950010L,110005510011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081932Inst : IEnumerable<long>
{
public static readonly long[] Value=A081932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081932.Bytes);
public long this[int i]=>Value[i];

public static A081932Inst Instance=new A081932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081933
{
public static readonly long[] Value={ 1L,11L,110L,1101L,11011L,110111L,1101110L,11011101L,110111011L,1101110111L,11011101110L,110111011103L,1101110111030L,11011101110301L,110111011103011L,1101110111030111L,11011101110301110L,110111011103011103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081933Inst : IEnumerable<long>
{
public static readonly long[] Value=A081933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081933.Bytes);
public long this[int i]=>Value[i];

public static A081933Inst Instance=new A081933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081934
{
public static readonly long[] Value={ 15L,21L,35L,45L,55L,63L,77L,91L,99L,105L,117L,143L,153L,165L,171L,187L,195L,209L,221L,231L,247L,253L,255L,273L,275L,285L,299L,323L,325L,345L,351L,357L,377L,391L,399L,403L,425L,435L,437L,459L,465L,475L,483L,493L,513L,525L,527L,551L,561L,575L,589L,595L,609L,621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081934Inst : IEnumerable<long>
{
public static readonly long[] Value=A081934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081934.Bytes);
public long this[int i]=>Value[i];

public static A081934Inst Instance=new A081934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081935
{
public static readonly long[] Value={ 4L,12L,24L,40L,56L,60L,72L,80L,84L,112L,120L,132L,140L,144L,156L,168L,176L,180L,208L,220L,224L,240L,252L,260L,264L,272L,288L,304L,308L,312L,340L,352L,360L,364L,380L,396L,408L,416L,420L,420L,440L,456L,460L,468L,476L,480L,520L,528L,532L,544L,552L,572L,572L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081935Inst : IEnumerable<long>
{
public static readonly long[] Value=A081935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081935.Bytes);
public long this[int i]=>Value[i];

public static A081935Inst Instance=new A081935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081936
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,33L,13L,39L,65L,15L,17L,51L,85L,19L,119L,57L,95L,21L,133L,105L,23L,69L,115L,25L,161L,75L,207L,27L,175L,225L,135L,29L,189L,87L,145L,31L,297L,203L,93L,261L,155L,33L,319L,217L,279L,165L,35L,341L,231L,105L,37L,111L,429L,315L,185L,39L,385L,259L,455L,333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081936Inst : IEnumerable<long>
{
public static readonly long[] Value=A081936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081936.Bytes);
public long this[int i]=>Value[i];

public static A081936Inst Instance=new A081936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081937
{
public static readonly long[] Value={ 4L,12L,24L,40L,60L,56L,84L,80L,72L,112L,144L,140L,132L,180L,120L,176L,168L,220L,156L,208L,264L,260L,252L,312L,240L,308L,224L,364L,288L,272L,352L,420L,340L,416L,408L,480L,304L,396L,476L,380L,468L,544L,360L,456L,440L,532L,612L,420L,520L,608L,684L,680L,460L,572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081937Inst : IEnumerable<long>
{
public static readonly long[] Value=A081937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081937.Bytes);
public long this[int i]=>Value[i];

public static A081937Inst Instance=new A081937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081938
{
public static readonly BigInteger[] Value={ 1L,2L,3L,5L,9L,44L,131L,602206L,39293339293L,BigInteger.Parse("98576836066063867589") };
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
public class A081938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081938Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A081938.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A081938.Bytes);
public BigInteger this[int i]=>Value[i];

public static A081938Inst Instance=new A081938Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A081939
{
public static readonly long[] Value={ 2L,4L,6L,8L,22L,33L,44L,55L,66L,77L,88L,99L,111L,141L,171L,222L,232L,242L,252L,262L,272L,282L,292L,404L,414L,424L,434L,444L,454L,464L,474L,484L,494L,585L,595L,616L,626L,636L,646L,656L,666L,676L,686L,696L,717L,747L,777L,828L,838L,848L,858L,868L,878L,888L,898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A081939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A081939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A081939Inst : IEnumerable<long>
{
public static readonly long[] Value=A081939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A081939.Bytes);
public long this[int i]=>Value[i];

public static A081939Inst Instance=new A081939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082052
{
public static readonly long[] Value={ 0L,2L,3L,6L,0L,11L,7L,14L,3L,12L,11L,27L,0L,23L,18L,30L,0L,29L,19L,36L,10L,35L,23L,59L,0L,28L,30L,55L,0L,66L,31L,62L,14L,36L,42L,81L,0L,59L,42L,84L,0L,74L,43L,83L,18L,71L,47L,123L,7L,62L,54L,84L,0L,110L,66L,119L,22L,60L,59L,162L,0L,95L,73L,126L,0L,110L,67L,108L,26L,138L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082052Inst : IEnumerable<long>
{
public static readonly long[] Value=A082052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082052.Bytes);
public long this[int i]=>Value[i];

public static A082052Inst Instance=new A082052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082053
{
public static readonly long[] Value={ 1L,3L,1L,7L,6L,9L,1L,15L,10L,18L,1L,25L,14L,17L,6L,31L,18L,36L,1L,42L,22L,25L,1L,57L,31L,42L,10L,49L,30L,54L,1L,63L,34L,54L,6L,88L,38L,41L,14L,90L,42L,86L,1L,73L,60L,49L,1L,121L,50L,93L,18L,98L,54L,90L,6L,113L,58L,90L,1L,150L,62L,65L,31L,127L,84L,130L,1L,126L,70L,102L,1L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082053Inst : IEnumerable<long>
{
public static readonly long[] Value=A082053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082053.Bytes);
public long this[int i]=>Value[i];

public static A082053Inst Instance=new A082053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082054
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,2L,2L,0L,0L,2L,2L,2L,2L,5L,2L,0L,2L,3L,2L,2L,2L,2L,2L,2L,0L,5L,2L,2L,2L,2L,2L,0L,2L,2L,5L,0L,2L,5L,2L,2L,2L,5L,2L,2L,5L,2L,2L,2L,3L,0L,2L,2L,2L,5L,2L,5L,2L,2L,2L,2L,2L,5L,2L,0L,5L,2L,2L,2L,2L,5L,2L,3L,2L,5L,2L,2L,5L,5L,2L,2L,0L,2L,2L,2L,2L,5L,2L,7L,2L,5L,2L,2L,2L,2L,5L,2L,2L,3L,5L,0L,2L,2L,2L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082054Inst : IEnumerable<long>
{
public static readonly long[] Value=A082054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082054.Bytes);
public long this[int i]=>Value[i];

public static A082054Inst Instance=new A082054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082055
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,6L,2L,1L,2L,3L,2L,2L,2L,2L,2L,2L,1L,6L,2L,2L,2L,2L,2L,1L,2L,2L,6L,1L,2L,6L,2L,2L,2L,6L,2L,2L,6L,2L,2L,2L,3L,1L,2L,2L,2L,6L,2L,6L,2L,2L,2L,2L,2L,6L,2L,1L,6L,2L,2L,2L,2L,6L,2L,3L,2L,6L,2L,2L,6L,6L,2L,2L,1L,2L,2L,2L,2L,6L,2L,10L,2L,6L,2L,2L,2L,2L,6L,2L,2L,3L,6L,1L,2L,2L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082055Inst : IEnumerable<long>
{
public static readonly long[] Value=A082055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082055.Bytes);
public long this[int i]=>Value[i];

public static A082055Inst Instance=new A082055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082056
{
public static readonly long[] Value={ 0L,3L,18L,0L,14L,0L,88L,1800L,116L,196L,9801L,377L,2881L,1189L,711L,989L,3596L,477L,6901L,5203L,8473L,9179L,3956L,7067L,6439L,27709L,41309L,10763L,27117L,20569L,10207L,69091L,4976L,15376L,114953L,18650L,204469L,37225L,16279L,130300L,74450L,10877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082056Inst : IEnumerable<long>
{
public static readonly long[] Value=A082056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082056.Bytes);
public long this[int i]=>Value[i];

public static A082056Inst Instance=new A082056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082057
{
public static readonly long[] Value={ 1L,3L,18L,0L,200L,14L,3364L,0L,0L,88L,9801L,0L,25281L,116L,1800L,0L,36992L,0L,4414201L,0L,196L,2881L,541696L,0L,0L,711L,0L,0L,98942809L,209L,1547536L,0L,19602L,6901L,814088L,0L,49042009L,8473L,1521L,0L,3150464641L,377L,245178368L,0L,0L,6439L,9265217536L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082057Inst : IEnumerable<long>
{
public static readonly long[] Value=A082057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082057.Bytes);
public long this[int i]=>Value[i];

public static A082057Inst Instance=new A082057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082058
{
public static readonly long[] Value={ 26L,5L,1L,2L,13L,3L,18L,4L,23L,8L,26L,5L,31L,6L,35L,36L,38L,7L,42L,8L,197L,47L,48L,9L,53L,54L,56L,31L,60L,10L,63L,11L,216L,51L,69L,71L,73L,12L,76L,34L,79L,13L,82L,14L,86L,88L,89L,15L,93L,35L,96L,36L,98L,16L,100L,102L,103L,37L,107L,17L,110L,18L,257L,38L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082058Inst : IEnumerable<long>
{
public static readonly long[] Value=A082058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082058.Bytes);
public long this[int i]=>Value[i];

public static A082058Inst Instance=new A082058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082059
{
public static readonly long[] Value={ 1L,1021L,1201L,2011L,7687L,7867L,8677L,10211L,10271L,10321L,12011L,12041L,12071L,12101L,12301L,12343L,12401L,12433L,12601L,14323L,16787L,17021L,20011L,20101L,20161L,20411L,20611L,21001L,21011L,21031L,21061L,21101L,21401L,21433L,21601L,21701L,22343L,22433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082059Inst : IEnumerable<long>
{
public static readonly long[] Value=A082059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082059.Bytes);
public long this[int i]=>Value[i];

public static A082059Inst Instance=new A082059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082060
{
public static readonly long[] Value={ 1L,21L,63L,101L,233L,291L,502L,677L,1021L,1031L,1051L,1061L,1091L,1201L,1226L,1301L,1601L,1801L,1901L,2011L,2201L,2333L,2383L,2393L,2518L,2633L,2677L,2700L,2767L,2817L,2833L,2991L,3011L,3023L,3122L,3203L,3253L,3323L,3623L,3677L,3767L,3823L,3923L,3989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082060Inst : IEnumerable<long>
{
public static readonly long[] Value=A082060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082060.Bytes);
public long this[int i]=>Value[i];

public static A082060Inst Instance=new A082060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082061
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,3L,2L,1L,2L,5L,2L,3L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,3L,2L,1L,3L,1L,2L,3L,2L,1L,2L,7L,5L,1L,2L,1L,3L,5L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,5L,2L,1L,3L,1L,2L,3L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,3L,2L,1L,2L,1L,7L,3L,5L,1L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082061Inst : IEnumerable<long>
{
public static readonly long[] Value=A082061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082061.Bytes);
public long this[int i]=>Value[i];

public static A082061Inst Instance=new A082061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082062
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,7L,1L,3L,1L,1L,3L,2L,1L,1L,1L,2L,1L,5L,1L,3L,1L,2L,3L,2L,1L,2L,1L,1L,3L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,1L,3L,1L,2L,3L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,7L,1L,2L,3L,2L,1L,3L,7L,2L,1L,2L,5L,3L,1L,1L,3L,1L,1L,3L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082062Inst : IEnumerable<long>
{
public static readonly long[] Value=A082062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082062.Bytes);
public long this[int i]=>Value[i];

public static A082062Inst Instance=new A082062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082063
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,5L,1L,3L,1L,2L,5L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,7L,1L,5L,1L,1L,1L,2L,5L,3L,1L,2L,1L,5L,1L,2L,1L,2L,1L,2L,1L,2L,1L,5L,1L,2L,1L,2L,1L,2L,1L,2L,1L,5L,1L,2L,7L,1L,13L,2L,1L,2L,1L,5L,1L,1L,1L,2L,5L,2L,1L,2L,1L,2L,1L,2L,1L,7L,5L,2L,1L,2L,1L,5L,1L,2L,1L,2L,1L,3L,1L,1L,1L,1L,1L,2L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082063Inst : IEnumerable<long>
{
public static readonly long[] Value=A082063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082063.Bytes);
public long this[int i]=>Value[i];

public static A082063Inst Instance=new A082063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082064
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,3L,2L,1L,2L,3L,2L,2L,2L,2L,2L,2L,1L,3L,2L,2L,2L,2L,2L,1L,2L,2L,3L,1L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,1L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,2L,3L,2L,1L,3L,2L,2L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,3L,2L,2L,1L,2L,2L,2L,2L,3L,2L,5L,2L,3L,2L,2L,2L,2L,3L,2L,2L,3L,3L,1L,2L,2L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082064Inst : IEnumerable<long>
{
public static readonly long[] Value=A082064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082064.Bytes);
public long this[int i]=>Value[i];

public static A082064Inst Instance=new A082064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082065
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,5L,2L,2L,1L,2L,2L,3L,2L,2L,2L,1L,5L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,5L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,5L,2L,1L,2L,5L,2L,2L,2L,2L,2L,1L,2L,2L,5L,3L,5L,2L,2L,2L,1L,5L,2L,3L,2L,2L,2L,5L,2L,2L,2L,2L,5L,2L,2L,2L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082065Inst : IEnumerable<long>
{
public static readonly long[] Value=A082065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082065.Bytes);
public long this[int i]=>Value[i];

public static A082065Inst Instance=new A082065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082066
{
public static readonly long[] Value={ 1L,1L,2L,7L,2L,2L,2L,5L,13L,2L,2L,7L,2L,2L,2L,31L,2L,13L,2L,7L,2L,2L,2L,5L,31L,2L,5L,7L,2L,2L,2L,7L,2L,2L,2L,13L,2L,5L,2L,5L,2L,2L,2L,7L,13L,2L,2L,31L,19L,31L,2L,7L,2L,5L,2L,5L,5L,5L,2L,7L,2L,2L,13L,127L,2L,2L,2L,7L,2L,2L,2L,13L,2L,2L,31L,7L,2L,2L,2L,31L,11L,2L,2L,7L,2L,2L,5L,5L,2L,13L,2L,7L,2L,2L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082066Inst : IEnumerable<long>
{
public static readonly long[] Value=A082066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082066.Bytes);
public long this[int i]=>Value[i];

public static A082066Inst Instance=new A082066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082067
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,5L,2L,3L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,7L,2L,1L,2L,1L,2L,5L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,5L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082067Inst : IEnumerable<long>
{
public static readonly long[] Value=A082067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082067.Bytes);
public long this[int i]=>Value[i];

public static A082067Inst Instance=new A082067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082084
{
public static readonly long[] Value={ 0L,2L,5L,5L,5L,19L,5L,7L,7L,11L,13L,13L,23L,13L,19L,101L,61L,5L,19L,5L,11L,5L,5L,7L,23L,7L,5L,7L,283L,293L,5L,5L,7L,367L,379L,389L,23L,7L,463L,5L,13L,11L,29L,5L,23L,7L,7L,19L,5L,5L,5L,5L,61L,7L,73L,47L,857L,7L,947L,5L,29L,7L,13L,5L,5L,19L,137L,7L,5L,7L,11L,23L,353L,53L,11L,1471L,1489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082084Inst : IEnumerable<long>
{
public static readonly long[] Value=A082084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082084.Bytes);
public long this[int i]=>Value[i];

public static A082084Inst Instance=new A082084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082085
{
public static readonly BigInteger[] Value={ 2L,5L,16L,37L,11L,23L,31L,67L,25L,193L,7L,7L,19L,19L,5939L,27L,13L,11L,11L,503L,15889L,37L,11L,4651L,BigInteger.Parse("52960025378359863409578953"),8L,13L,11L,25L,79L,19L,25L,56707367L,7L,103L,23L,9L,61L };
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
public class A082085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A082085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A082085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A082085Inst Instance=new A082085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082086
{
public static readonly long[] Value={ 2L,5L,5L,5L,13L,23L,61L,19L,5L,283L,5L,23L,13L,29L,7L,61L,947L,29L,137L,11L,353L,23L,199L,5L,47L,2381L,5L,103L,359L,13L,5L,5L,7L,5L,47L,19L,577L,7L,5L,29L,5L,5L,5L,41L,11L,23L,239L,7L,11L,5L,11L,5L,23L,11821L,31L,5L,5L,13669L,7L,193L,5L,991L,89L,7L,13L,18199L,131L,113L,20849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082086Inst : IEnumerable<long>
{
public static readonly long[] Value=A082086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082086.Bytes);
public long this[int i]=>Value[i];

public static A082086Inst Instance=new A082086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082087
{
public static readonly long[] Value={ 2L,5L,5L,7L,7L,17L,17L,17L,17L,3L,3L,41L,41L,41L,41L,31L,31L,5L,5L,5L,5L,7L,7L,7L,7L,7L,7L,5L,5L,7L,7L,7L,7L,7L,7L,197L,197L,197L,197L,2L,2L,281L,281L,281L,281L,43L,43L,43L,43L,43L,43L,7L,7L,7L,7L,7L,7L,5L,5L,5L,5L,5L,5L,5L,5L,73L,73L,73L,73L,2L,2L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,13L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082087Inst : IEnumerable<long>
{
public static readonly long[] Value=A082087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082087.Bytes);
public long this[int i]=>Value[i];

public static A082087Inst Instance=new A082087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082088
{
public static readonly long[] Value={ 2L,5L,7L,17L,3L,41L,31L,5L,7L,5L,7L,197L,2L,281L,43L,7L,5L,5L,73L,2L,7L,7L,13L,5L,7L,5L,3L,7L,13L,3L,7L,7L,7L,7L,571L,7L,7L,5L,7L,7L,5L,7L,5L,7L,2L,7L,19L,3L,3L,67L,5L,2L,71L,43L,7L,71L,239L,7L,7L,7699L,2L,5L,313L,8893L,2L,3L,199L,5L,5L,2L,5L,2L,3L,7L,6361L,3L,97L,5L,19L,97L,7L,2593L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082088Inst : IEnumerable<long>
{
public static readonly long[] Value=A082088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082088.Bytes);
public long this[int i]=>Value[i];

public static A082088Inst Instance=new A082088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082089
{
public static readonly long[] Value={ 1L,3L,4L,7L,2L,13L,11L,3L,4L,3L,4L,45L,1L,60L,14L,4L,3L,3L,21L,1L,4L,4L,6L,3L,4L,3L,2L,4L,6L,2L,4L,4L,4L,4L,105L,4L,4L,3L,4L,4L,3L,4L,3L,4L,1L,4L,8L,2L,2L,19L,3L,1L,20L,14L,4L,20L,52L,4L,4L,977L,1L,3L,65L,1108L,1L,2L,46L,3L,3L,1L,3L,1L,2L,4L,829L,2L,25L,3L,8L,25L,4L,378L,3L,3L,29L,3L,6L,8L,1L,1L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082089Inst : IEnumerable<long>
{
public static readonly long[] Value=A082089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082089.Bytes);
public long this[int i]=>Value[i];

public static A082089Inst Instance=new A082089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082090
{
public static readonly long[] Value={ 2L,3L,4L,4L,5L,5L,5L,5L,5L,5L,6L,5L,6L,6L,6L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,6L,7L,6L,6L,6L,7L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,6L,7L,6L,6L,6L,6L,6L,7L,6L,7L,6L,7L,6L,7L,7L,6L,6L,6L,6L,7L,6L,6L,7L,7L,6L,6L,7L,6L,6L,7L,6L,6L,7L,7L,6L,7L,6L,7L,6L,6L,6L,7L,6L,7L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082090Inst : IEnumerable<long>
{
public static readonly long[] Value=A082090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082090.Bytes);
public long this[int i]=>Value[i];

public static A082090Inst Instance=new A082090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082091
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,3L,2L,2L,2L,4L,2L,3L,2L,3L,2L,2L,2L,3L,3L,2L,3L,3L,2L,2L,2L,3L,2L,2L,2L,4L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,4L,3L,3L,2L,3L,2L,3L,2L,3L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,2L,4L,4L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,3L,4L,2L,2L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082091Inst : IEnumerable<long>
{
public static readonly long[] Value=A082091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082091.Bytes);
public long this[int i]=>Value[i];

public static A082091Inst Instance=new A082091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082092
{
public static readonly long[] Value={ 6L,10L,14L,15L,20L,21L,22L,24L,26L,27L,28L,30L,33L,34L,35L,38L,39L,40L,42L,44L,45L,46L,49L,51L,54L,55L,56L,57L,58L,60L,62L,63L,65L,66L,68L,69L,70L,74L,76L,77L,78L,82L,85L,86L,87L,88L,91L,92L,93L,94L,95L,96L,99L,102L,104L,105L,106L,108L,110L,111L,114L,115L,116L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082092Inst : IEnumerable<long>
{
public static readonly long[] Value=A082092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082092.Bytes);
public long this[int i]=>Value[i];

public static A082092Inst Instance=new A082092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082093
{
public static readonly long[] Value={ 5L,13L,19L,32L,73L,89L,140L,199L,294L,468L,1072L,1072L,1072L,2161L,2976L,32805L,32806L,65732L,65732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082093Inst : IEnumerable<long>
{
public static readonly long[] Value=A082093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082093.Bytes);
public long this[int i]=>Value[i];

public static A082093Inst Instance=new A082093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082094
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,15L,50L,235L,1498L,12592L,135431L,1806803L,29135476L,555971158L,12336554787L,313733168860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082094Inst : IEnumerable<long>
{
public static readonly long[] Value=A082094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082094.Bytes);
public long this[int i]=>Value[i];

public static A082094Inst Instance=new A082094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082095
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,15L,25L,56L,113L,293L,679L,2036L,5389L,18447L,54920L,211347L,697252L,2974827L,10741681L,50245401L,196570892L,998427899L,4197026430L,22963115248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082095Inst : IEnumerable<long>
{
public static readonly long[] Value=A082095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082095.Bytes);
public long this[int i]=>Value[i];

public static A082095Inst Instance=new A082095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082096
{
public static readonly long[] Value={ 1L,1L,3L,7L,29L,151L,1069L,9887L,115891L,1666421L,28700933L,580669933L,13578126713L,362075579539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082096Inst : IEnumerable<long>
{
public static readonly long[] Value=A082096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082096.Bytes);
public long this[int i]=>Value[i];

public static A082096Inst Instance=new A082096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082097
{
public static readonly long[] Value={ 1L,1L,1L,5L,7L,8L,11L,10L,13L,12L,17L,14L,17L,16L,20L,22L,21L,22L,23L,22L,25L,25L,26L,28L,31L,28L,33L,32L,35L,34L,35L,36L,42L,42L,43L,38L,41L,40L,47L,42L,49L,45L,49L,47L,47L,48L,57L,52L,55L,54L,59L,54L,61L,56L,63L,62L,61L,60L,71L,62L,65L,66L,71L,66L,73L,68L,73L,70L,77L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082097Inst : IEnumerable<long>
{
public static readonly long[] Value=A082097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082097.Bytes);
public long this[int i]=>Value[i];

public static A082097Inst Instance=new A082097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082098
{
public static readonly long[] Value={ 7L,359L,199L,1831L,887L,2179L,2971L,5591L,9551L,33247L,15683L,106543L,25471L,153191L,43331L,288583L,372539L,360091L,873787L,542603L,637939L,544279L,1291691L,860143L,1313467L,1388483L,2238823L,2637799L,6695747L,1895359L,6752623L,3851459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082098Inst : IEnumerable<long>
{
public static readonly long[] Value=A082098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082098.Bytes);
public long this[int i]=>Value[i];

public static A082098Inst Instance=new A082098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082099
{
public static readonly long[] Value={ 13L,89L,509L,1933L,1637L,1669L,5953L,27701L,12853L,19333L,36389L,28229L,19609L,82073L,102701L,89689L,134513L,31397L,212701L,815729L,461717L,1155733L,927869L,360653L,396733L,3422813L,3279841L,370261L,5845193L,6085441L,6808273L,9810653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082099Inst : IEnumerable<long>
{
public static readonly long[] Value=A082099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082099.Bytes);
public long this[int i]=>Value[i];

public static A082099Inst Instance=new A082099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082308
{
public static readonly long[] Value={ 1L,5L,25L,127L,657L,3449L,18281L,97395L,519841L,2773741L,14776377L,78538343L,416367665L,2201517153L,11610231433L,61078202971L,320570884929L,1678897264085L,8775159682649L,45780628812879L,238431945108433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082308Inst : IEnumerable<long>
{
public static readonly long[] Value=A082308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082308.Bytes);
public long this[int i]=>Value[i];

public static A082308Inst Instance=new A082308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082309
{
public static readonly long[] Value={ 1L,6L,36L,218L,1336L,8280L,51776L,325792L,2057856L,13023104L,82456576L,521826816L,3298727936L,20822038528L,131210919936L,825373859840L,5182772248576L,32487861092352L,203308891897856L,1270289732337664L,7924975155019776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082309Inst : IEnumerable<long>
{
public static readonly long[] Value=A082309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082309.Bytes);
public long this[int i]=>Value[i];

public static A082309Inst Instance=new A082309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082310
{
public static readonly long[] Value={ 0L,1L,7L,57L,455L,3641L,29127L,233017L,1864135L,14913081L,119304647L,954437177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082310Inst : IEnumerable<long>
{
public static readonly long[] Value=A082310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082310.Bytes);
public long this[int i]=>Value[i];

public static A082310Inst Instance=new A082310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082311
{
public static readonly long[] Value={ 1L,5L,43L,341L,2731L,21845L,174763L,1398101L,11184811L,89478485L,715827883L,5726623061L,45812984491L,366503875925L,2932031007403L,23456248059221L,187649984473771L,1501199875790165L,12009599006321323L,96076792050570581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082311Inst : IEnumerable<long>
{
public static readonly long[] Value=A082311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082311.Bytes);
public long this[int i]=>Value[i];

public static A082311Inst Instance=new A082311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082312
{
public static readonly long[] Value={ 1L,4L,5L,14L,11L,14L,12L,15L,32L,36L,32L,30L,41L,65L,42L,41L,53L,45L,75L,76L,69L,63L,99L,98L,60L,112L,99L,84L,94L,130L,132L,103L,87L,140L,172L,175L,144L,190L,171L,140L,200L,145L,203L,190L,155L,168L,202L,210L,144L,157L,254L,185L,189L,306L,201L,323L,303L,229L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082312Inst : IEnumerable<long>
{
public static readonly long[] Value=A082312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082312.Bytes);
public long this[int i]=>Value[i];

public static A082312Inst Instance=new A082312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082313
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,6L,7L,5L,9L,21L,14L,18L,13L,11L,22L,16L,17L,12L,19L,20L,10L,15L,23L,58L,37L,49L,35L,28L,62L,42L,46L,32L,51L,55L,27L,41L,25L,59L,39L,50L,36L,30L,63L,44L,45L,31L,53L,54L,26L,40L,33L,64L,47L,48L,34L,56L,57L,24L,38L,60L,61L,29L,43L,52L,65L,170L,107L,142L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082313Inst : IEnumerable<long>
{
public static readonly long[] Value=A082313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082313.Bytes);
public long this[int i]=>Value[i];

public static A082313Inst Instance=new A082313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082314
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,6L,9L,11L,10L,12L,13L,21L,22L,20L,17L,18L,19L,16L,14L,15L,23L,28L,25L,30L,33L,24L,29L,26L,31L,34L,27L,32L,35L,36L,58L,62L,59L,63L,64L,57L,61L,54L,45L,48L,55L,46L,49L,50L,56L,60L,53L,44L,47L,51L,42L,37L,39L,52L,43L,38L,40L,41L,65L,79L,70L,84L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082314Inst : IEnumerable<long>
{
public static readonly long[] Value=A082314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082314.Bytes);
public long this[int i]=>Value[i];

public static A082314Inst Instance=new A082314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082315
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,7L,5L,9L,11L,14L,16L,19L,21L,22L,18L,17L,20L,13L,12L,10L,15L,23L,25L,28L,30L,33L,37L,39L,42L,44L,47L,51L,53L,56L,60L,58L,59L,62L,63L,64L,49L,50L,46L,45L,48L,55L,54L,57L,61L,35L,36L,32L,31L,34L,27L,26L,24L,29L,41L,40L,38L,43L,52L,65L,67L,70L,72L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082315Inst : IEnumerable<long>
{
public static readonly long[] Value=A082315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082315.Bytes);
public long this[int i]=>Value[i];

public static A082315Inst Instance=new A082315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082316
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,5L,7L,6L,9L,21L,10L,20L,19L,11L,22L,12L,17L,16L,13L,18L,14L,15L,23L,58L,24L,57L,56L,25L,59L,26L,54L,53L,27L,55L,51L,52L,28L,62L,29L,61L,60L,30L,63L,31L,45L,44L,32L,46L,42L,43L,33L,64L,34L,48L,47L,35L,49L,37L,38L,36L,50L,39L,40L,41L,65L,170L,66L,169L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082316Inst : IEnumerable<long>
{
public static readonly long[] Value=A082316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082316.Bytes);
public long this[int i]=>Value[i];

public static A082316Inst Instance=new A082316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082317
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,5L,6L,4L,8L,17L,20L,12L,10L,15L,16L,19L,11L,9L,14L,22L,21L,18L,13L,45L,48L,54L,57L,61L,31L,34L,26L,24L,29L,40L,38L,43L,52L,44L,47L,53L,56L,60L,30L,33L,25L,23L,28L,39L,37L,42L,51L,63L,64L,59L,58L,62L,50L,49L,46L,55L,36L,35L,32L,27L,41L,129L,132L,138L,141L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082317Inst : IEnumerable<long>
{
public static readonly long[] Value=A082317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082317.Bytes);
public long this[int i]=>Value[i];

public static A082317Inst Instance=new A082317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082318
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,5L,6L,4L,8L,17L,12L,16L,11L,22L,18L,13L,14L,9L,21L,15L,10L,20L,19L,45L,31L,44L,30L,63L,46L,32L,42L,28L,62L,43L,29L,61L,60L,48L,34L,47L,33L,64L,49L,35L,37L,23L,58L,38L,24L,57L,56L,50L,36L,39L,25L,59L,40L,26L,54L,53L,41L,27L,55L,51L,52L,129L,87L,128L,86L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082318Inst : IEnumerable<long>
{
public static readonly long[] Value=A082318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082318.Bytes);
public long this[int i]=>Value[i];

public static A082318Inst Instance=new A082318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082319
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,5L,7L,6L,9L,14L,21L,18L,13L,10L,15L,20L,17L,12L,19L,16L,11L,22L,23L,28L,37L,42L,51L,58L,62L,49L,46L,55L,35L,32L,27L,41L,24L,29L,38L,43L,52L,57L,61L,48L,45L,54L,34L,31L,26L,40L,56L,60L,47L,44L,53L,33L,30L,25L,39L,64L,63L,59L,50L,36L,65L,70L,79L,84L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082319Inst : IEnumerable<long>
{
public static readonly long[] Value=A082319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082319.Bytes);
public long this[int i]=>Value[i];

public static A082319Inst Instance=new A082319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082320
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,7L,5L,9L,14L,21L,18L,13L,10L,15L,20L,17L,12L,19L,16L,11L,22L,23L,37L,58L,49L,35L,24L,38L,57L,48L,34L,56L,47L,33L,64L,25L,39L,59L,50L,36L,26L,40L,54L,45L,31L,53L,44L,30L,63L,27L,41L,55L,46L,32L,51L,42L,28L,62L,52L,43L,29L,61L,60L,65L,107L,170L,142L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082320Inst : IEnumerable<long>
{
public static readonly long[] Value=A082320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082320.Bytes);
public long this[int i]=>Value[i];

public static A082320Inst Instance=new A082320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082321
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,8L,4L,5L,17L,12L,16L,11L,22L,18L,13L,14L,9L,21L,15L,10L,20L,19L,45L,54L,31L,26L,40L,44L,53L,30L,25L,39L,63L,59L,50L,36L,46L,55L,32L,27L,41L,42L,51L,28L,23L,37L,62L,58L,49L,35L,43L,52L,29L,24L,38L,61L,57L,48L,34L,60L,56L,47L,33L,64L,129L,138L,157L,166L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082321Inst : IEnumerable<long>
{
public static readonly long[] Value=A082321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082321.Bytes);
public long this[int i]=>Value[i];

public static A082321Inst Instance=new A082321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082322
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,4L,6L,17L,20L,12L,10L,15L,16L,19L,11L,9L,14L,22L,21L,18L,13L,45L,54L,31L,26L,40L,44L,53L,30L,25L,39L,63L,59L,50L,36L,46L,55L,32L,27L,41L,42L,51L,28L,23L,37L,62L,58L,49L,35L,43L,52L,29L,24L,38L,61L,57L,48L,34L,60L,56L,47L,33L,64L,129L,157L,87L,73L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082322Inst : IEnumerable<long>
{
public static readonly long[] Value=A082322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082322.Bytes);
public long this[int i]=>Value[i];

public static A082322Inst Instance=new A082322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082323
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,21L,10L,20L,19L,11L,22L,12L,17L,16L,13L,18L,14L,15L,23L,37L,58L,49L,35L,24L,38L,57L,48L,34L,56L,47L,33L,64L,25L,39L,59L,50L,36L,26L,40L,54L,45L,31L,53L,44L,30L,63L,27L,41L,55L,46L,32L,51L,42L,28L,62L,52L,43L,29L,61L,60L,65L,79L,107L,121L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082323Inst : IEnumerable<long>
{
public static readonly long[] Value=A082323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082323.Bytes);
public long this[int i]=>Value[i];

public static A082323Inst Instance=new A082323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082372
{
public static readonly long[] Value={ 3L,17L,23L,31L,53L,67L,71L,79L,83L,97L,107L,109L,113L,127L,131L,137L,149L,151L,157L,167L,173L,179L,197L,199L,227L,239L,251L,263L,293L,311L,317L,337L,347L,349L,401L,409L,419L,421L,431L,439L,457L,467L,503L,521L,557L,563L,593L,601L,619L,641L,643L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082372Inst : IEnumerable<long>
{
public static readonly long[] Value=A082372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082372.Bytes);
public long this[int i]=>Value[i];

public static A082372Inst Instance=new A082372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082373
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,19L,23L,29L,23L,29L,31L,37L,31L,37L,41L,43L,53L,59L,61L,67L,67L,71L,73L,79L,71L,73L,79L,83L,79L,83L,89L,97L,83L,89L,97L,101L,97L,101L,103L,107L,107L,109L,113L,127L,109L,113L,127L,131L,113L,127L,131L,137L,127L,131L,137L,139L,131L,137L,139L,149L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082373Inst : IEnumerable<long>
{
public static readonly long[] Value=A082373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082373.Bytes);
public long this[int i]=>Value[i];

public static A082373Inst Instance=new A082373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A082374
{
public static readonly long[] Value={ 2L,6L,16L,17L,18L,20L,21L,25L,29L,31L,33L,35L,36L,41L,45L,52L,53L,59L,61L,62L,64L,65L,77L,79L,81L,83L,84L,85L,88L,90L,91L,94L,95L,96L,100L,101L,102L,103L,104L,106L,110L,114L,116L,117L,119L,122L,132L,136L,137L,139L,147L,152L,154L,155L,156L,157L,158L,164L,167L,172L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A082374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A082374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A082374Inst : IEnumerable<long>
{
public static readonly long[] Value=A082374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A082374.Bytes);
public long this[int i]=>Value[i];

public static A082374Inst Instance=new A082374Inst();

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